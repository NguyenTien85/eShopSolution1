using eShopSolution.App.Catalog.Dtos;
using eShopSolution.App.Catalog.Products.Dtos;
using eShopSolution.App.Catalog.Products.Dtos.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.App.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request); 
    }
}
