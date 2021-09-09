using eShopSolution.Data.EF;
using eShopSolution.ViewModels.Utilities.Slides;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.App.Utilities.Slides
{
    public class SlideService : ISlideService
    {
        private readonly eShopDbContext _context;

        public SlideService(eShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<SlideViewModel>> GetAll()
        {
            var slides = await _context.Slides.
                Select(x => new SlideViewModel()
                {
                    Id = x.Id,
                    Description = x.Description,
                    Name = x.Name,
                    Image = x.Image,
                    SortOrder = x.SortOrder,
                    Status = x.Status,
                    Url = x.Url
                })
                .OrderBy(x => x.SortOrder)
                .ToListAsync();
            return slides;
        }
    }
}