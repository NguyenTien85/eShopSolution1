using eShopSolution.App.Catalog.Products;
using eShopSolution.ViewModels.Catalog.ProductImages.Request;
using eShopSolution.ViewModels.Catalog.Products.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.BackendApi.Controllers
{
    //api/products
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("paging")]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetManageProductPagingRequest request)
        {
            var products = await _productService.GetAllPaging(request);
            return Ok(products);
        }

        [HttpGet("{productId}/{languageId}")]
        public async Task<IActionResult> GetById(int productId, string languageId)
        {
            var product = await _productService.GetById(productId, languageId);

            if (product == null)
            {
                return BadRequest($"can not find product Id: {productId}");
            }

            return Ok(product);
        }

        //
        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Create([FromForm] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var productId = await _productService.Create(request);
            if (productId == 0)
            {
                return BadRequest();
            }

            var product = await _productService.GetById(productId, request.LanguageId);

            return CreatedAtAction(nameof(GetById), new { id = productId }, product);
        }

        //
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var affectedResult = await _productService.Update(request);
            if (affectedResult == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        //
        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var affectedResult = await _productService.Delete(productId);
            if (affectedResult == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        //
        [HttpPatch("RevisePrice/{productId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int productId, decimal newPrice)
        {
            var result = await _productService.UpdatePrice(productId, newPrice);
            if (result == false)
            {
                return BadRequest();
            }

            return Ok();
        }

        //
        [HttpPatch("ReviseStock/{productId}/{addedQuantity}")]
        public async Task<IActionResult> UpdateStock(int productId, int addedQuantity)
        {
            var result = await _productService.UpdateStock(productId, addedQuantity);
            if (result == false)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpGet("{productId}/images/{imageId}")]
        public async Task<IActionResult> GetProductImageById(int imageId)
        {
            var productImage = await _productService.GetProductImageById(imageId);

            if (productImage == null)
            {
                return BadRequest($"can not find productImage Id: {imageId}");
            }

            return Ok(productImage);
        }

        //Image
        [HttpPost("{productId}/images")]
        public async Task<IActionResult> CreateImage(int productId, [FromForm] ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var imageId = await _productService.AddImage(productId, request);
            if (imageId == 0)
            {
                return BadRequest();
            }

            var productImageViewModel = await _productService.GetProductImageById(imageId);

            return CreatedAtAction(nameof(GetProductImageById), new { id = imageId }, productImageViewModel);
        }

        //Image
        [HttpPut("{productId}/images/{imageId}")]
        public async Task<IActionResult> UpdateImage(int imageId, [FromForm] ProductImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _productService.UpdateImage(imageId, request);
            if (result == 0)
            {
                return BadRequest();
            }

            return Ok();
        }

        //Image
        [HttpDelete("{productId}/images/{imageId}")]
        public async Task<IActionResult> DeleteImage(int imageId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _productService.RemoveImage(imageId);
            if (result == 0)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}