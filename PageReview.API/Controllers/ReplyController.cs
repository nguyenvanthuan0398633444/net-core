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
    public class ReplyController : ControllerBase
    {
        private readonly IReplyService replyService;

        public ReplyController(IReplyService replyService)
        {
            this.replyService = replyService;
        }
        [HttpPost, HttpPatch]
        [Route("save")]
        public async Task<OkObjectResult> Save(SaveReplyReq request)
        {
            var result = await replyService.Save(request);
            return Ok(result);
        }
        [HttpPatch("delete/{id}")]
        public async Task<OkObjectResult> Delete(int id)
        {
            var result = await replyService.Delete(id);
            return Ok(result);
        }
        [HttpGet("getsReply/{CommentId}/{ProductId}")]
        public async Task<OkObjectResult> GetByReply(int CommentId, int ProductId)
        {
            var result = await replyService.GetsReply(CommentId, ProductId);
            return Ok(result);
        }
    }
}
