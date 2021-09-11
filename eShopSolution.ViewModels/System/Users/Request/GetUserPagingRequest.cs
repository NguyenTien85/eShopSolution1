using eShopSolution.ViewModels.Common;

namespace eShopSolution.ViewModels.System.Users.Request
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}