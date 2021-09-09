using eShopSolution.ViewModels.Catalog.Categories.Request;
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

        Task<PagedResult<ProductViewModel>> GetPaging(GetManageProductPagingRequest request);

        Task<List<ProductViewModel>> GetFeaturedProducts(string languageId, int take);

        Task<List<ProductViewModel>> GetLatestProducts(string languageId, int take);

        Task<ApiResult<bool>> CategoryAssign(CategoryAssignRequest request);

        Task<ProductViewModel> GetProductById(int id);
    }
}