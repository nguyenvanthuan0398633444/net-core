using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PageReview.View.Models;
using PageReview.View.Models.Comment;
using PageReview.View.Ultilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageReview.View.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Comment/GetsByProduct/{ProductId}")]
        public JsonResult GetsByProduct(int ProductId)
        {
            List<CommentView> result = ApiHelper<List<CommentView>>.HttpGetAsync($"Comment/GetsByProduct/{ProductId}");
            return Json(new { result });
        }
        [HttpGet("Comment/Get/{Id}")]
        public JsonResult Get(int Id)
        {
            var result = ApiHelper<CommentView>.HttpGetAsync($"Comment/Get/{Id}");
            return Json(new { result });
        }
        [HttpPost("comment/save")]
        [Authorize]
        public JsonResult Save(SaveComment request)
        {
            var result = ApiHelper<Result>.HttpPostAsync($"Comment/Save", "POST", request);
            return Json(new { data = result });
        }
        [HttpPost("Comment/delete/{id}")]
        [Authorize]
        public IActionResult Delete(int id)
        {
            var result = ApiHelper<Result>.HttpPatchAsync($"Comment/delete/{id}", null);
            return Json(new { data = result });
        }
        [HttpPost("Comment/saveRep")]
        [Authorize]
        public JsonResult SaveRep(SaveComment request)
        {
            var result = ApiHelper<Result>.HttpPostAsync($"Comment/SaveRep", "POST", request);
            return Json(new { data = result });
        }
        [HttpGet("Comment/getsReply/{productId}/{commentId}")]
        public JsonResult GetsReply(int productId, int commentId)
        {
            var result = ApiHelper<List<CommentView>>.HttpGetAsync($"Comment/getsReply/{productId}/{commentId}");
            return Json(new { data = result });
        }
    }
}
