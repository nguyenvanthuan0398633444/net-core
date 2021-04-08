using System;
using System.Collections.Generic;
using System.Text;

namespace PageReview.Domain.Response.Vote
{
    public class VoteView
    {
        public int Id { get; set; }
        public int Vote { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; }
    }
}
