using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PageReview.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageReview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllController : ControllerBase
    {
        private readonly IGetAllRepository getAllRepository;

        public GetAllController(IGetAllRepository getAllRepository)
        {
            this.getAllRepository = getAllRepository;
        }
        [HttpGet("getsProductStatus")]
        public async Task<OkObjectResult> GetsProductStatus()
        {
            var result = await getAllRepository.GetsProductStatus();
            return Ok(result);
        }
        [HttpGet("getsImage/{id}")]
        public async Task<OkObjectResult> GetsImage(int id)
        {
            var result = await getAllRepository.GetsGetsImage(id);
            return Ok(result);
        }
        [HttpGet("getProductCommingFirst")]
        public async Task<OkObjectResult> GetProductCommingFirst()
        {
            var result = await getAllRepository.GetProductCommingFirst();
            return Ok(result);
        }
        [HttpGet("gets1ProductComment")]
        public async Task<OkObjectResult> Gets1ProductComment()
        {
            var result = await getAllRepository.Gets1ProductComment();
            return Ok(result);
        }
        [HttpGet("gets1ProductVote")]
        public async Task<OkObjectResult> Gets1ProductVote()
        {
            var result = await getAllRepository.Gets1ProductVote();
            return Ok(result);
        }
        [HttpGet("Gets5GetsExpensive")]
        public async Task<OkObjectResult> Gets5GetsExpensive()
        {
            var result = await getAllRepository.Gets5GetsExpensive();
            return Ok(result);
        }
        [HttpGet("Gets5ProductComment")]
        public async Task<OkObjectResult> Gets5ProductComment()
        {
            var result = await getAllRepository.Gets5ProductComment();
            return Ok(result);
        }
        [HttpGet("Gets5ProductCommingsoon")]
        public async Task<OkObjectResult> Gets5ProductCommingsoon()
        {
            var result = await getAllRepository.Gets5ProductCommingsoon();
            return Ok(result);
        }
        [HttpGet("Gets5Productnew")]
        public async Task<OkObjectResult> Gets5Productnew()
        {
            var result = await getAllRepository.Gets5Productnew();
            return Ok(result);
        }
        [HttpGet("Gets5Productrandom")]
        public async Task<OkObjectResult> Gets5Productrandom()
        {
            var result = await getAllRepository.Gets5Productrandom();
            return Ok(result);
        }
        [HttpGet("Gets5ProductVote")]
        public async Task<OkObjectResult> Gets5ProductVote()
        {
            var result = await getAllRepository.Gets5ProductVote();
            return Ok(result);
        }
        [HttpGet("Gets6ProductsameBrand/{id}")]
        public async Task<OkObjectResult> Gets6ProductsameBrand(int id)
        {
            var result = await getAllRepository.Gets6ProductsameBrand(id);
            return Ok(result);
        }
        [HttpGet("Gets6ProductsameCategory/{id}")]
        public async Task<OkObjectResult> Gets6ProductsameCategory(int id)
        {
            var result = await getAllRepository.Gets6ProductsameCategory(id);
            return Ok(result);
        }
    }
}
