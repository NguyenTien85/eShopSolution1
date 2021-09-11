using eShopSolution.ApiIntegration;
using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Catalog.Products.Request;
using eShopSolution.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApiClient _productApiClient;
        private readonly ICategoryApiClient _categoryApiClient;

        public ProductController(IProductApiClient productApiClient, ICategoryApiClient categoryApiClient)
        {
            _productApiClient = productApiClient;
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IActionResult> Detail(int id)
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var product = await _productApiClient.GetProductById(id, languageId);
            var images = await _productApiClient.GetListImages(id);
            var catalog = await _productApiClient.GetCatalogOfProduct(id, languageId);
            var productdetail = new ProductDetailViewModel()
            {
                Product = product,
                ProductImages = images,
                Category = catalog
            };
            return View(productdetail);
        }

        //product
        public async Task<IActionResult> Category(int id, int pageIndex = 1, int pageSize = 6)
        {
            var languageId = CultureInfo.CurrentCulture.Name;
            var productByCategoryRequest = new GetManageProductPagingRequest()
            {
                CategoryId = id,
                LanguageId = languageId,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var products = await _productApiClient.GetAllProductsOfCatalog(productByCategoryRequest);
            var category = await _categoryApiClient.GetById(id, languageId);

            var viewContent = new ProductCategoryViewModel()
            {
                Products = products,
                Category = category
            };
            return View(viewContent);
        }
    }
}