using eShopSolution.ApiIntegration;
using eShopSolution.Utilities.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.AdminApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryApiClient _categoryApiClient;
        private readonly IConfiguration _configuration;

        public CategoryController(IConfiguration configuration, ICategoryApiClient categoryApiClient)
        {
            _configuration = configuration;
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IActionResult> Index()
        {
            //set authenticated user to be able to request backend Api
            var session = HttpContext.Session.GetString("Token");
            var languageId = HttpContext.Session.GetString(SystemConstants.AppSettings.DefaultLanguageId);
            var categories = await _categoryApiClient.GetAll(languageId);
            //ViewBag.Keyword = keyword;

            //var categories = await _productApiClient.GetAllCategory()

            ViewBag.CategoryIds = categories.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.Id.ToString()
            });
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMessage = TempData["result"].ToString();
            }
            return View(categories);
        }
    }
}