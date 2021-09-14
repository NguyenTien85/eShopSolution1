using eShopSolution.ApiIntegration;
using eShopSolution.Utilities.Constants;
using eShopSolution.ViewModels.Sales;
using eShopSolution.ViewModels.Sales.Request;
using eShopSolution.WebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly IOrderApiClient _orderApiClient;

        public CartController(IProductApiClient productApiClient,
            IOrderApiClient orderApiClient)
        {
            _productApiClient = productApiClient;
            _orderApiClient = orderApiClient;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int productId, string languageId)
        {
            var jCart = HttpContext.Session.GetString(SystemConstants.CartSession);
            var product = await _productApiClient.GetProductById(productId, languageId);
            if (product == null)
            {
                return BadRequest($"not found product with Id: {productId} and LanguageId: {languageId}");
            }
            var cartItem = new CartItemViewModel()
            {
                ProductId = productId,
                Quantity = 1,
                Description = product.Description,
                Name = product.Name,
                ThumbnailImage = product.ThubnailImage,
                Price = product.Price
            };

            if (jCart == null)
            {
                var curCart = new List<CartItemViewModel>();
                curCart.Add(cartItem);
                HttpContext.Session.SetString(SystemConstants.CartSession, JsonConvert.SerializeObject(curCart));
                return Ok(curCart);
            }

            var currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(jCart);

            if (currentCart.Any(x => x.ProductId == productId))
            {
                currentCart.First(x => x.ProductId == productId).Quantity += 1;
            }
            else
            {
                currentCart.Add(cartItem);
            }

            var json = JsonConvert.SerializeObject(currentCart);

            HttpContext.Session.SetString(SystemConstants.CartSession, json);

            return Ok(currentCart);
        }

        [HttpPost]
        public IActionResult UpdateCart(int productId, int quantity, bool isRedirect)
        {
            var jCart = HttpContext.Session.GetString(SystemConstants.CartSession);
            if (jCart == null)
            {
                return BadRequest();
            }

            var currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(jCart);

            if (!currentCart.Any(x => x.ProductId == productId))
            {
                return BadRequest();
            }

            currentCart.First(x => x.ProductId == productId).Quantity = quantity;

            if (isRedirect)
            {
                var curProduct = currentCart.First(x => x.ProductId == productId);
                currentCart.Remove(curProduct);
            }

            var json = JsonConvert.SerializeObject(currentCart);
            HttpContext.Session.SetString(SystemConstants.CartSession, json);

            return Ok(currentCart);
        }

        [HttpGet]
        public IActionResult CheckOut()
        {
            var jCart = HttpContext.Session.GetString(SystemConstants.CartSession);
            var currentCart = new List<CartItemViewModel>();
            if (jCart != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(jCart);
            }
            var checkOut = new CheckOutViewModel()
            {
                CartItems = currentCart
            };
            return View(checkOut);
        }

        [HttpPost]
        public async Task<IActionResult> CheckOut(CheckOutViewModel request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var jCart = HttpContext.Session.GetString(SystemConstants.CartSession);
            var currentCart = new List<CartItemViewModel>();
            if (jCart != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(jCart);
            }
            request.CartItems = currentCart;
            var orderDetails = new List<OrderDetailViewModel>();
            foreach (var item in currentCart)
            {
                orderDetails.Add(new OrderDetailViewModel()
                {
                    Price = item.Price,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity
                });
            }

            var orderRequest = new OrderRequestViewModel()
            {
                OrderDetails = orderDetails,
                ShipAddress = request.ShipAddress,
                ShipEmail = request.ShipEmail,
                ShipName = request.ShipName,
                ShipPhoneNumber = request.ShipPhoneNumber,
                UserName = request.UserName
            };

            var result = await _orderApiClient.CreateOrder(orderRequest);
            if (result.IsSucceeded)
            {
                TempData["SuccessMsg"] = "Create Order success";
            }

            return View(request);
        }

        [HttpGet]
        public IActionResult GetListItems()
        {
            var jCart = HttpContext.Session.GetString(SystemConstants.CartSession);
            var currentCart = new List<CartItemViewModel>();
            if (jCart != null)
            {
                currentCart = JsonConvert.DeserializeObject<List<CartItemViewModel>>(jCart);
            }
            return Ok(currentCart);
        }
    }
}