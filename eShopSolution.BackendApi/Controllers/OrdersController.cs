using eShopSolution.App.Sales;
using eShopSolution.ViewModels.Sales.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateOrder([FromBody] OrderRequestViewModel request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var orderId = await _orderService.Create(request);
            if (orderId == 0)
            {
                return BadRequest();
            }

            var order = await _orderService.GetById(orderId);

            return Ok(order);
        }
    }
}