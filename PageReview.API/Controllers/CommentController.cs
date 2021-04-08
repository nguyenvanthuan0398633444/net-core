using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PageReview.BAL.Interface;
using PageReview.Domain.Request.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageReview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService commentService;

        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }
        [HttpPost, HttpPatch]
        [Route("save")]
        public async Task<OkObjectResult> Save(SaveCommentReq request)
        {
            var result = await commentService.Save(request);
            return Ok(result);
        }
        [HttpPatch("delete/{id}")]
        public async Task<OkObjectResult> Delete(int id)
        {
            var result = await commentService.Delete(id);
            return Ok(result);
        }
        [HttpGet("getsbyProduct/{id}")]
        public async Task<OkObjectResult> GetsByProduct(int id)
        {
            var result = await commentService.GetsComment(id);
            return Ok(result);
        }
        [HttpPost, HttpPatch]
        [Route("saverep")]
        public async Task<OkObjectResult> SaveRep(SaveReplyReq request)
        {
            var result = await commentService.SaveRep(request);
            return Ok(result);
        }
        [HttpGet("getsReply/{productId}/{commentId}")]
        public async Task<OkObjectResult> GetsReply(int productId, int commentId)
        {
            var result = await commentService.GetsReply(productId,commentId);
            return Ok(result);
        }
        [HttpGet("get/{id}")]
        public async Task<OkObjectResult> Get(int id)
        {
            var result = await commentService.Get(id);
            return Ok(result);
        }
    }
}
