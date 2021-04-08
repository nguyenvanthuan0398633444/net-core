using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageReview.View.Models.Comment
{
    public class SaveComment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; }
        public int CommentId { get; set; }
    }
}
