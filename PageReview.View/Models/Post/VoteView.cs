using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageReview.View.Models.Post
{
    public class VoteView
    {
        public int Id { get; set; }
        public int Vote { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; }
    }
}
