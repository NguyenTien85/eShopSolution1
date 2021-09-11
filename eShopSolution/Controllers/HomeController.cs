using eShopSolution.ApiIntegration;
using eShopSolution.Models;
using eShopSolution.Utilities.Constants;
using eShopSolution.WebApp.Models;
using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;

namespace eShopSolution.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISharedCultureLocalizer _loc;
        private readonly ISlideApiClient _slideApiClient;
        private readonly IProductApiClient _productApiClient;

        public HomeController(ILogger<HomeController> logger,
            ISharedCultureLocalizer loc,
            ISlideApiClient slideApiClient,
            IProductApiClient productApiClient)
        {
            _logger = logger;
            _loc = loc;
            _slideApiClient = slideApiClient;
            _productApiClient = productApiClient;
        }

        public async Task<IActionResult> Index()
        {
            //var msg = _loc.GetLocalizedString("Specials Offer");
            var culture = CultureInfo.CurrentCulture.Name;
            var noFeatureProduct = SystemConstants.ProductSettings.FeaturedProductTakeOut;
            var noLatestProduct = SystemConstants.ProductSettings.LatestProductTakeOut;
            var slides = await _slideApiClient.GetAll();
            var featureProduct = await _productApiClient.GetFeaturedProducts(culture, noFeatureProduct);
            var latestProduct = await _productApiClient.GetLatestProducts(culture, noLatestProduct);
            var homeViewModel = new HomeViewModel()
            {
                Slides = slides,
                FeaturedProducts = featureProduct,
                LatestProducts = latestProduct
            };

            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SetCultureCookie(string cltr, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(cltr)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
                );

            return LocalRedirect(returnUrl);
        }
    }
}