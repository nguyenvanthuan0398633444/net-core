﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PageReview.Domain.Request.Comment
{
    public class SaveReplyReq
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; }
        public int CommentId { get; set; }
    }
}
