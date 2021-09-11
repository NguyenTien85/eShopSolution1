using eShopSolution.App.Common;
using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.Utilities.Exceptions;
using eShopSolution.ViewModels.Catalog.Categories;
using eShopSolution.ViewModels.Catalog.Categories.Request;
using eShopSolution.ViewModels.Catalog.ProductImages;
using eShopSolution.ViewModels.Catalog.ProductImages.Request;
using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Catalog.Products.Request;
using eShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace eShopSolution.App.Catalog.Products
{
    public class ProductService : IProductService
    {
        private readonly eShopDbContext _context;
        private readonly IStorageService _storageService;

        public ProductService(eShopDbContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
        }

        public async Task<int> AddImage(int productId, ProductImageCreateRequest request)
        {
            var productImage = new ProductImage()
            {
                Caption = request.Caption,
                DateCreated = DateTime.Now,
                IsDefault = request.IsDefault,
                ProductId = productId,
                SortOrder = request.SortOrder
            };

            if (request.ImageFile != null)
            {
                productImage.ImagePath = await this.SaveFile(request.ImageFile);
                productImage.FileSize = request.ImageFile.Length;
            };

            _context.ProductImages.Add(productImage);

            await _context.SaveChangesAsync();
            return productImage.Id;
        }

        public async Task AddViewCount(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            product.ViewCount += 1;
            await _context.SaveChangesAsync();
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
                OriginalPrice = request.OriginalPrice,
                Stock = request.Stock,
                ViewCount = 0,
                DateCreated = DateTime.Now,
                IsFeatured = request.IsFeatured,
                ProductTranslations = new List<ProductTranslation>()
            };
            foreach (var lang in _context.Languages)
            {
                if (lang.Id == request.LanguageId)
                {
                    var productTranslation = new ProductTranslation()
                    {
                        Name = request.Name,
                        Description = request.Description,
                        Details = request.Details,
                        SeoDescription = request.SeoDescription,
                        SeoTitle = request.SeoTitle,
                        SeoAlias = request.SeoAlias,
                        LanguageId = request.LanguageId
                    };
                    product.ProductTranslations.Add(productTranslation);
                }
                else
                {
                    var productTranslation = new ProductTranslation()
                    {
                        Name = request.Name,
                        Description = "",
                        Details = "",
                        SeoDescription = "",
                        SeoTitle = "",
                        SeoAlias = "",
                        LanguageId = lang.Id
                    };
                    product.ProductTranslations.Add(productTranslation);
                }
            }

            //Save Image
            if (request.ThumbnailImage != null)
            {
                product.ProductImages = new List<ProductImage>()
                {
                    new ProductImage()
                    {
                        Caption = "Thumbnail Image",
                        DateCreated = DateTime.Now,
                        FileSize = request.ThumbnailImage.Length,
                        ImagePath = await this.SaveFile(request.ThumbnailImage),
                        IsDefault = true,
                        SortOrder=1
                    }
                };
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product.Id;
        }

        public async Task<ApiResult<bool>> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                return new ApiErrorResult<bool>($"Can not find product {productId}");
            }

            var images = _context.ProductImages.Where(x => x.ProductId == productId);
            foreach (var image in images)
            {
                await _storageService.DeleteFileAsync(image.ImagePath);
            }

            _context.Products.Remove(product);

            var result = await _context.SaveChangesAsync();
            if (result == 0)
            {
                return new ApiErrorResult<bool>("fail to delete product");
            }
            return new ApiSuccessResult<bool>();
        }

        public async Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request)
        {
            //1. select
            var query = from p in _context.Products                                             //from  _context.Products as p
                        from pt in _context.ProductTranslations
                            .Where(x => x.ProductId == p.Id && x.LanguageId == request.LanguageId)
                            .DefaultIfEmpty()
                            //on p.Id equals pt.ProductId     //join _context.ProductTranslations as pt on pt.ProductId = p.Id

                        from pic in _context.ProductInCategories                                //left join _context.ProductInCategories as pic on pic.ProductId = pt.ProductId
                            .Where(x => x.ProductId == pt.ProductId)
                            .DefaultIfEmpty()

                        from c in _context.Categories                                           //left join _context.Categories as c on c.Id = pic.CategoryId
                            .Where(x => x.Id == pic.CategoryId)
                            .DefaultIfEmpty()

                        from pi in _context.ProductImages
                        .Where(x => x.Id == p.Id && x.IsDefault)
                        .DefaultIfEmpty()

                        select new { p, pt, pic, pi };

            //2. Filtering
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query.Where(x => x.pt.Name.Contains(request.Keyword));
            }

            if (request.CategoryId != null && request.CategoryId != 0)
            {
                query.Where(x => request.CategoryId == x.pic.CategoryId);
            }

            //3. Paging
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.pt.Name,
                    DateCreated = x.p.DateCreated,
                    Description = x.pt.Description,
                    Details = x.pt.Details,
                    LanguageId = x.pt.LanguageId,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                    SeoAlias = x.pt.SeoAlias,
                    SeoDescription = x.pt.SeoDescription,
                    SeoTitle = x.pt.SeoTitle,
                    Stock = x.p.Stock,
                    ViewCount = x.p.ViewCount,
                    IsFeatured = x.p.IsFeatured,
                    ThubnailImage = x.pi.ImagePath
                })
                .ToListAsync();

            //4. Select and Projection
            var pagedResult = new PagedResult<ProductViewModel>()
            {
                TotalRecords = totalRow,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                Items = data
            };

            return pagedResult;
        }

        public async Task<PagedResult<ProductViewModel>> GetAllProductsOfCatalog(GetManageProductPagingRequest request)
        {
            //1. select
            var query = from p in _context.Products                                             //from  _context.Products as p
                        from pt in _context.ProductTranslations
                            .Where(x => x.ProductId == p.Id && x.LanguageId == request.LanguageId)
                            //on p.Id equals pt.ProductId     //join _context.ProductTranslations as pt on pt.ProductId = p.Id

                        from pic in _context.ProductInCategories                                //left join _context.ProductInCategories as pic on pic.ProductId = pt.ProductId
                            .Where(x => x.ProductId == pt.ProductId && x.CategoryId == request.CategoryId)

                        from c in _context.Categories                                           //left join _context.Categories as c on c.Id = pic.CategoryId
                            .Where(x => x.Id == pic.CategoryId)
                            .DefaultIfEmpty()

                        from pi in _context.ProductImages
                        .Where(x => x.Id == p.Id && x.IsDefault)
                        .DefaultIfEmpty()

                        select new { p, pt, pic, pi };

            //2. Filtering
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query.Where(x => x.pt.Name.Contains(request.Keyword));
            }

            if (request.CategoryId != null && request.CategoryId != 0)
            {
                query.Where(x => request.CategoryId == x.pic.CategoryId);
            }

            //3. Paging
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.pt.Name,
                    DateCreated = x.p.DateCreated,
                    Description = x.pt.Description,
                    Details = x.pt.Details,
                    LanguageId = x.pt.LanguageId,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                    SeoAlias = x.pt.SeoAlias,
                    SeoDescription = x.pt.SeoDescription,
                    SeoTitle = x.pt.SeoTitle,
                    Stock = x.p.Stock,
                    ViewCount = x.p.ViewCount,
                    IsFeatured = x.p.IsFeatured,
                    ThubnailImage = x.pi.ImagePath
                })
                .ToListAsync();

            //4. Select and Projection
            var pagedResult = new PagedResult<ProductViewModel>()
            {
                TotalRecords = totalRow,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                Items = data
            };

            return pagedResult;
        }

        public async Task<ProductViewModel> GetById(int productId, string languageId)
        {
            var product = await _context.Products.FindAsync(productId);
            var productTranslation = await _context.ProductTranslations.FirstOrDefaultAsync(x => x.ProductId == productId && x.LanguageId == languageId);
            if (product == null || productTranslation == null)
            {
                throw new eShopException($"Can not find product {productId} with languageId {languageId}");
            }
            var categories = await (from c in _context.Categories
                                    join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                                    join pic in _context.ProductInCategories on c.Id equals pic.CategoryId
                                    where pic.ProductId == productId && ct.LanguageId == languageId
                                    select ct.Name
                                    ).ToListAsync();

            var productViewModel = new ProductViewModel()
            {
                Id = product.Id,
                LanguageId = productTranslation.LanguageId,
                DateCreated = product.DateCreated,
                Description = productTranslation.Description,
                Details = productTranslation.Details,
                Name = productTranslation.Name,
                OriginalPrice = product.OriginalPrice,
                Price = product.Price,
                SeoAlias = productTranslation.SeoAlias,
                SeoDescription = productTranslation.SeoDescription,
                SeoTitle = productTranslation.SeoTitle,
                Stock = product.Stock,
                ViewCount = product.ViewCount,
                Categories = categories,
                IsFeatured = product.IsFeatured
            };
            return productViewModel;
        }

        public async Task<List<ProductImageViewModel>> GetListImages(int productId)
        {
            return await _context.ProductImages
                .Where(x => x.ProductId == productId)
                .Select(pi => new ProductImageViewModel()
                {
                    Caption = pi.Caption,
                    DateCreated = pi.DateCreated,
                    FileSize = pi.FileSize,
                    Id = pi.Id,
                    IsDefault = pi.IsDefault,
                    ProductId = pi.ProductId,
                    SortOrder = pi.SortOrder,
                    ImagePath = pi.ImagePath
                })
                .ToListAsync();
        }

        public async Task<ProductImageViewModel> GetProductImageById(int imageId)
        {
            var productImage = await _context.ProductImages.FindAsync(imageId);
            if (productImage == null)
            {
                throw new eShopException($"Can not find an image with Id: {imageId}");
            };

            var productImageViewModel = new ProductImageViewModel()
            {
                Caption = productImage.Caption,
                DateCreated = productImage.DateCreated,
                FileSize = productImage.FileSize,
                Id = productImage.Id,
                ImagePath = productImage.ImagePath,
                IsDefault = productImage.IsDefault,
                ProductId = productImage.ProductId,
                SortOrder = productImage.SortOrder
            };
            return productImageViewModel;
        }

        public async Task<int> RemoveImage(int imageId)
        {
            var productImage = await _context.ProductImages.FindAsync(imageId);
            if (productImage == null)
            {
                throw new eShopException($"Can not find an image with Id: {imageId}");
            }
            _context.ProductImages.Remove(productImage);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);
            var productTranslation = await _context.ProductTranslations.FirstOrDefaultAsync(x => x.ProductId == request.Id && x.LanguageId == request.LanguageId);
            if (product == null || productTranslation == null)
            {
                throw new eShopException($"Can not find product with Id: {request.Id}");
            }
            product.IsFeatured = request.IsFeatured;

            productTranslation.Name = request.Name;
            productTranslation.SeoAlias = request.SeoAlias;
            productTranslation.SeoDescription = request.SeoDescription;
            productTranslation.SeoTitle = request.SeoTitle;
            productTranslation.Description = request.Description;
            productTranslation.Details = request.Details;

            //Save Image
            if (request.ThumbnailImage != null)
            {
                var thumbnailImage = await _context.ProductImages.FirstOrDefaultAsync(x => x.IsDefault == false && x.ProductId == request.Id);
                if (thumbnailImage != null)
                {
                    thumbnailImage.FileSize = request.ThumbnailImage.Length;
                    thumbnailImage.ImagePath = await this.SaveFile(request.ThumbnailImage);
                    _context.ProductImages.Update(thumbnailImage);
                }
            };

            return await _context.SaveChangesAsync();
        }

        public async Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request)
        {
            var productImage = await _context.ProductImages.FindAsync(imageId);
            if (productImage == null)
            {
                throw new eShopException($"Can not find an image with Id: {imageId}");
            }

            if (request.ImageFile != null)
            {
                productImage.ImagePath = await this.SaveFile(request.ImageFile);
                productImage.FileSize = request.ImageFile.Length;
            }
            productImage.Caption = request.Caption;
            productImage.IsDefault = request.IsDefault;
            productImage.SortOrder = request.SortOrder;

            _context.ProductImages.Update(productImage);
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                throw new eShopException($"Can not find product with Id: {productId}");
            }
            product.Price = newPrice;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateStock(int productId, int addedQuantity)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                throw new eShopException($"Can not find product with Id: {productId}");
            }
            product.Stock += addedQuantity;
            return await _context.SaveChangesAsync() > 0;
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            var filePath = await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return filePath;
        }

        public async Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request)
        {
            //1. select
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on pt.ProductId equals pic.ProductId
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        where pt.LanguageId == languageId
                        select new { p, pt, pic };

            //2. Filtering

            if (request.CategoryId.HasValue && request.CategoryId.Value > 0)
            {
                query.Where(x => x.pic.CategoryId == request.CategoryId);
            };

            //3. Paging
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.pt.Name,
                    DateCreated = x.p.DateCreated,
                    Description = x.pt.Description,
                    Details = x.pt.Details,
                    LanguageId = x.pt.LanguageId,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                    SeoAlias = x.pt.SeoAlias,
                    SeoDescription = x.pt.SeoDescription,
                    SeoTitle = x.pt.SeoTitle,
                    Stock = x.p.Stock,
                    ViewCount = x.p.ViewCount
                })
                .ToListAsync();

            //4. Select and Projection
            var pagedResult = new PagedResult<ProductViewModel>()
            {
                TotalRecords = totalRow,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize,
                Items = data
            };

            return pagedResult;
        }

        public async Task<ApiResult<bool>> CategoryAssign(CategoryAssignRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);
            if (product == null)
            {
                return new ApiErrorResult<bool>($"product with id {request.Id} not existed");
            }

            foreach (var category in request.Categories)
            {
                var productInCategory = await _context.ProductInCategories
                    .FirstOrDefaultAsync(x => x.ProductId == request.Id && int.Parse(category.Id) == x.CategoryId);
                if (productInCategory != null)
                {
                    if (category.Selected == false)
                    {
                        _context.ProductInCategories.Remove(productInCategory);
                    }
                }
                else
                {
                    if (category.Selected)
                    {
                        await _context.ProductInCategories.AddAsync(new ProductInCategory()
                        {
                            CategoryId = int.Parse(category.Id),
                            ProductId = request.Id
                        });
                    }
                }
            }

            await _context.SaveChangesAsync();
            return new ApiSuccessResult<bool>();
        }

        public async Task<List<ProductViewModel>> GetFeaturedProducts(string languageId, int take)
        {
            //1. select
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on pt.ProductId equals pic.ProductId
                        from pe in _context.ProductImages.Where(x => x.ProductId == p.Id && x.IsDefault)
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        where pt.LanguageId == languageId
                        select new { p, pt, pic, pe };

            var data = await query
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.pt.Name,
                    DateCreated = x.p.DateCreated,
                    Description = x.pt.Description,
                    Details = x.pt.Details,
                    LanguageId = x.pt.LanguageId,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                    SeoAlias = x.pt.SeoAlias,
                    SeoDescription = x.pt.SeoDescription,
                    SeoTitle = x.pt.SeoTitle,
                    Stock = x.p.Stock,
                    ViewCount = x.p.ViewCount,
                    ThubnailImage = x.pe.ImagePath
                })
                .OrderByDescending(x => x.ViewCount)
                .Take(take)
                .ToListAsync();

            return data;
        }

        public async Task<List<ProductViewModel>> GetLatestProducts(string languageId, int take)
        {
            //1. select
            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on pt.ProductId equals pic.ProductId
                        from pe in _context.ProductImages.Where(x => x.ProductId == p.Id && x.IsDefault)
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        where pt.LanguageId == languageId
                        select new { p, pt, pic, pe };

            var data = await query
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.pt.Name,
                    DateCreated = x.p.DateCreated,
                    Description = x.pt.Description,
                    Details = x.pt.Details,
                    LanguageId = x.pt.LanguageId,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                    SeoAlias = x.pt.SeoAlias,
                    SeoDescription = x.pt.SeoDescription,
                    SeoTitle = x.pt.SeoTitle,
                    Stock = x.p.Stock,
                    ViewCount = x.p.ViewCount,
                    ThubnailImage = x.pe.ImagePath
                })
                .OrderByDescending(x => x.DateCreated)
                .Take(take)
                .ToListAsync();

            return data;
        }

        public async Task<CategoryViewModel> GetCatalogOfProduct(int productId, string languageId)
        {
            var query = await (from p in _context.Products
                            .Where(x => x.Id == productId)
                               join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                               join c in _context.Categories on pic.CategoryId equals c.Id
                               join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                               where ct.LanguageId == languageId
                               select new { c, ct }
                        ).FirstOrDefaultAsync();

            var data = new CategoryViewModel()
            {
                Id = query.c.Id,
                IsShowOnHome = query.c.IsShowOnHome,
                LanguageId = languageId,
                Name = query.ct.Name,
                ParentId = query.c.ParentId,
                SeoAlias = query.ct.SeoAlias,
                SeoDescription = query.ct.SeoDescription,
                SeoTitle = query.ct.SeoTitle,
                SortOrder = query.c.SortOrder,
                Status = query.c.Status
            };

            return data;
        }
    }
}