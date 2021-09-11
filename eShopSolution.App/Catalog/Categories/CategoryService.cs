using eShopSolution.Data.EF;
using eShopSolution.Utilities.Exceptions;
using eShopSolution.ViewModels.Catalog.Categories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.App.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly eShopDbContext _context;

        public CategoryService(eShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryViewModel>> GetAll(string languageId)
        {
            //1. select
            var query = from c in _context.Categories
                        join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                        where ct.LanguageId == languageId
                        select new { c, ct };

            var data = await query
                .Select(x => new CategoryViewModel()
                {
                    Id = x.c.Id,
                    IsShowOnHome = x.c.IsShowOnHome,
                    LanguageId = languageId,
                    Name = x.ct.Name,
                    SeoAlias = x.ct.SeoAlias,
                    SeoDescription = x.ct.SeoDescription,
                    SeoTitle = x.ct.SeoTitle,
                    SortOrder = x.c.SortOrder,
                    Status = x.c.Status,
                    ParentId = x.c.ParentId
                })
                .ToListAsync();

            return data;
        }

        public async Task<CategoryViewModel> GetById(int categoryId, string languageId)
        {
            var category = await _context.Categories.FindAsync(categoryId);
            var categoryTranslation = await _context.CategoryTranslations.FirstOrDefaultAsync(x => x.CategoryId == categoryId && x.LanguageId == languageId);
            if (category == null || categoryTranslation == null)
            {
                throw new eShopException($"Can not find category {categoryId} with languageId {languageId}");
            }

            var categoryViewModel = new CategoryViewModel()
            {
                Id = category.Id,
                IsShowOnHome = category.IsShowOnHome,
                LanguageId = categoryTranslation.LanguageId,
                Name = categoryTranslation.Name,
                ParentId = category.ParentId,
                SeoAlias = categoryTranslation.SeoAlias,
                SeoDescription = categoryTranslation.SeoDescription,
                SeoTitle = categoryTranslation.SeoTitle,
                SortOrder = category.SortOrder,
                Status = category.Status
            };
            return categoryViewModel;
        }
    }
}