using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PageReview.BAL.Interface;
using PageReview.Domain.Request.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageReview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpPost, HttpPatch]
        [Route("save")]
        public async Task<OkObjectResult> Save(SaveProductReq request)
        {
            var result = await productService.Save(request);
            return Ok(result);
        }
        [HttpGet("gets")]
        public async Task<OkObjectResult> Gets()
        {
            var result = await productService.Gets();
            return Ok(result);
        }
        [HttpGet("get/{id}")]
        public async Task<OkObjectResult> Get(int id)
        {
            var result = await productService.Get(id);
            return Ok(result);
        }
        [HttpPatch("delete/{id}")]
        public async Task<OkObjectResult> Delete(int id)
        {
            var result = await productService.Delete(id);
            return Ok(result);
        }
        [HttpGet("getsbycategory/{id}")]
        public async Task<OkObjectResult> GetByCategory(int id)
        {
            var result = await productService.GetsByCategoryId(id);
            return Ok(result);
        }
        [HttpGet("getsbybrand/{id}")]
        public async Task<OkObjectResult> GetByBrand(int id)
        {
            var result = await productService.GetsByBrandId(id);
            return Ok(result);
        }
        [HttpGet("getsbycharacter/{searchword}")]
        public async Task<OkObjectResult> Getsbycharacter(string searchword)
        {
            var result = await productService.GetsByCharacter(searchword);
            return Ok(result);
        }
        [HttpGet("getsbycomment/{muccomment}")]
        public async Task<OkObjectResult> GetsbyComment(int muccomment)
        {
            var result = await productService.GetsByComment(muccomment);
            return Ok(result);
        }
        [HttpGet("getsbyprice/{price}")]
        public async Task<OkObjectResult> GetsbyPrice(double price)
        {
            var result = await productService.GetsByPrice(price);
            return Ok(result);
        }
        [HttpGet("getsbyvote/{mucvote}")]
        public async Task<OkObjectResult> GetsbyVote(int mucvote)
        {
            var result = await productService.GetsByVote(mucvote);
            return Ok(result);
        }
    }
}
