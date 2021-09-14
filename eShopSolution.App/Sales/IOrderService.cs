using eShopSolution.ViewModels.Sales.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.App.Sales
{
    public interface IOrderService
    {
        Task<int> Create(OrderRequestViewModel request);

        Task<OrderRequestViewModel> GetById(int orderId);
    }
}