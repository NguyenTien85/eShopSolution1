using eShopSolution.App.Catalog.Products;
using eShopSolution.ViewModels.Catalog.Products.Request;
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
    public class ProductController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IManageProductService _manageProductService;
        public ProductController(IPublicProductService publicProductService, IManageProductService manageProductService)
        {
            _publicProductService = publicProductService;
            _manageProductService = manageProductService;
        }

        //-------------------------------------------------------------------------------
        //PublicProductService
        //-------------------------------------------------------------------------------

        //http://localhost:port/api/product
        [HttpGet("{languageId}")]
        public async Task<IActionResult> Get(string languageId)
        {
            var products = await _publicProductService.GetAll(languageId);

            return Ok(products);
        }

        //http://localhost:port/api/product/public-paging
        [HttpGet("public-paging/{languageId}")]
        public async Task<IActionResult> Get([FromQuery] GetPublicProductPagingRequest request)
        {
            var pageResult = await _publicProductService.GetAllByCategoryId(request);

            return Ok(pageResult);
        }

        //-------------------------------------------------------------------------------
        //ManageProductService
        //-------------------------------------------------------------------------------
        
        //http://localhost:port/api/product/1/vn
        [HttpGet("{productId}/{languageId}")]
        public async Task<IActionResult> GetById(int productId, string languageId)
        {
            var product = await _manageProductService.GetById(productId, languageId);

            if(product == null)
            {
                return BadRequest($"can not find product Id: {productId}");
            }

            return Ok(product);
        }

        //
        [HttpPost]
        public async Task<IActionResult> Create([FromForm]ProductCreateRequest request)
        {
            var productId = await _manageProductService.Create(request);
            if (productId == 0)
            {
                return BadRequest();
            }

            var product = await _manageProductService.GetById(productId, request.LanguageId);

            return CreatedAtAction(nameof(GetById), new {id = productId }, product);
        }

        //
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request)
        {
            var affectedResult = await _manageProductService.Update(request);
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
            var affectedResult = await _manageProductService.Delete(productId);
            if (affectedResult == 0)
            {
                return BadRequest();
            }

            return Ok();
        }


        //
        [HttpPut("RevisePrice/{productId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int productId, decimal newPrice)
        {
            var result = await _manageProductService.UpdatePrice(productId, newPrice);
            if (result==false)
            {
                return BadRequest();
            }

            return Ok();
        }

        //
        [HttpPut("ReviseStock/{productId}/{addedQuantity}")]
        public async Task<IActionResult> UpdateStock(int productId, int addedQuantity)
        {
            var result = await _manageProductService.UpdateStock(productId, addedQuantity);
            if (result == false)
            {
                return BadRequest();
            }

            return Ok();
        }
    }
}
