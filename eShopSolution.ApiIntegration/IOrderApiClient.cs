using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.Sales.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ApiIntegration
{
    public interface IOrderApiClient
    {
        Task<ApiResult<bool>> CreateOrder(OrderRequestViewModel request);
    }
}