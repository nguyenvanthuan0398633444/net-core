using System;
using System.Collections.Generic;
using System.Text;

namespace PageReview.Domain.Response.Comment
{
    public class CommentView
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
        public string UserName { get; set; }
        public string UserId { get; set; }
        public string Avatar { get; set; }
        public string StatusComment { get; set; }
        public int Status { get; set; }
    }
}
