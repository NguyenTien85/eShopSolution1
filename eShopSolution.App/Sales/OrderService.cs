using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Sales;
using eShopSolution.ViewModels.Sales.Request;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.App.Sales
{
    public class OrderService : IOrderService
    {
        private readonly IConfiguration _config;
        private readonly eShopDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public OrderService(IConfiguration config,
            eShopDbContext context,
            UserManager<AppUser> userManager)
        {
            _config = config;
            _context = context;
            _userManager = userManager;
        }

        public async Task<int> Create(OrderRequestViewModel request)
        {
            var listOfOrder = new List<OrderDetail>();
            foreach (var item in request.OrderDetails)
            {
                var orderDetail = new OrderDetail()
                {
                    Price = item.Price,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                };
                listOfOrder.Add(orderDetail);
            }
            var order = new Order()
            {
                OrderDate = DateTime.Now,
                ShipAddress = request.ShipAddress,
                ShipPhoneNumber = request.ShipPhoneNumber,
                ShipName = request.ShipName,
                ShipEmail = request.ShipEmail,
                Status = Data.Enums.OrderStatus.Confirmed,
                OrderDetails = listOfOrder
            };
            if (request.UserName != null && request.UserName != "")
            {
                var user = await _userManager.FindByNameAsync(request.UserName);
                if (user != null)
                {
                    order.UserId = user.Id;
                }
            }

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            return order.Id;
        }

        public async Task<OrderRequestViewModel> GetById(int orderId)
        {
            var order = await _context.Orders.FindAsync(orderId);
            var user = await _userManager.FindByIdAsync(order.UserId.ToString());
            var orderDetails = await _context.OrderDetails
                .Where(x => x.OrderId == orderId)
                .Select(x => new OrderDetailViewModel()
                {
                    ProductId = x.ProductId,
                    Price = x.Price,
                    Quantity = x.Quantity
                }).ToListAsync();

            var result = new OrderRequestViewModel()
            {
                OrderDetails = orderDetails,
                ShipAddress = order.ShipAddress,
                ShipEmail = order.ShipEmail,
                ShipName = order.ShipName,
                ShipPhoneNumber = order.ShipPhoneNumber,
                UserName = user.UserName
            };
            return result;
        }
    }
}