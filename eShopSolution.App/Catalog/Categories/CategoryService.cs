using eShopSolution.Data.EF;
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
                    Status = x.c.Status
                })
                .ToListAsync();

            return data;
        }
    }
}