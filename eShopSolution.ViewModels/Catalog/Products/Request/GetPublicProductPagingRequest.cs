using eShopSolution.ViewModels.Common;

namespace eShopSolution.ViewModels.Catalog.Products.Request
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}