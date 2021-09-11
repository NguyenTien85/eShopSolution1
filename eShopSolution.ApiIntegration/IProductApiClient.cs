using eShopSolution.ViewModels.Catalog.Categories;
using eShopSolution.ViewModels.Catalog.Categories.Request;
using eShopSolution.ViewModels.Catalog.ProductImages;
using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Catalog.Products.Request;
using eShopSolution.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.ApiIntegration
{
    public interface IProductApiClient
    {
        //Task<ApiResult<ProductViewModel>> GetProductById(Guid id);
        Task<bool> CreateProduct(ProductCreateRequest request);

        Task<bool> UpdateProduct(ProductUpdateRequest request);

        Task<PagedResult<ProductViewModel>> GetPaging(GetManageProductPagingRequest request);

        Task<PagedResult<ProductViewModel>> GetAllProductsOfCatalog(GetManageProductPagingRequest request);

        Task<List<ProductViewModel>> GetFeaturedProducts(string languageId, int take);

        Task<List<ProductViewModel>> GetLatestProducts(string languageId, int take);

        Task<ApiResult<bool>> CategoryAssign(CategoryAssignRequest request);

        Task<ApiResult<bool>> Delete(int productId);

        Task<ProductViewModel> GetProductById(int id, string languageId);

        Task<List<ProductImageViewModel>> GetListImages(int productId);

        Task<CategoryViewModel> GetCatalogOfProduct(int productId, string languageId);
    }
}