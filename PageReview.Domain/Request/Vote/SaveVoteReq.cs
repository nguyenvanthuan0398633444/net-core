using System;
using System.Collections.Generic;
using System.Text;

namespace PageReview.Domain.Request.Vote
{
    public class SaveVoteReq
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Vote { get; set; }
        public string UserId { get; set; }
    }
}
