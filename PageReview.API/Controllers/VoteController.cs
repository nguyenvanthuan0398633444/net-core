using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PageReview.BAL.Interface;
using PageReview.Domain.Request.Vote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageReview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoteController : ControllerBase
    {
        private readonly IVoteService voteService;

        public VoteController(IVoteService voteService)
        {
            this.voteService = voteService;
        }
        [HttpPost, HttpPatch]
        [Route("save")]
        public async Task<OkObjectResult> Save(SaveVoteReq request)
        {
            var result = await voteService.Save(request);
            return Ok(result);
        }
        [HttpPatch("delete/{id}")]
        public async Task<OkObjectResult> Delete(int id)
        {
            var result = await voteService.Delete(id);
            return Ok(result);
        }
        //[HttpGet("gets/{id}")]
        //public async Task<OkObjectResult> Gets(int id)
        //{
        //    var result = await voteService.Get(id);
        //    return Ok(result);
        //}
        [HttpGet("GetVote/{ProductId}/{UserId}")]
        public async Task<OkObjectResult> GetVote(int ProductId, string UserId)
        {
            var result = await voteService.Get(ProductId, UserId);
            return Ok(result);
        }
    }
}
