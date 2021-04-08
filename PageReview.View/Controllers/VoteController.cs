using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PageReview.View.Models;
using PageReview.View.Models.Post;
using PageReview.View.Ultilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageReview.View.Controllers
{
    public class VoteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("GetVote/{ProductId}/{UserId}")]
        public JsonResult GetVote(int ProductId, string UserId)
        {
            var result = ApiHelper<VoteView>.HttpGetAsync($"Vote/GetVote/{ProductId}/{UserId}");
            return Json(new { result });
        }
        [HttpPost("Vote/saveVote")]
        [Authorize]
        public JsonResult SaveVote(VoteView request)
        {
            var result = ApiHelper<Result>.HttpPostAsync($"Vote/Save", "POST", request);
            return Json(new { data = result });
        }
        [HttpPatch("Vote/Delete/{id}")]
        [Authorize]
        public JsonResult SaveVote(int id)
        {
            var result = ApiHelper<Result>.HttpPatchAsync($"Vote/Delete/{id}", null);
            return Json(new { data = result });
        }
    }
}
