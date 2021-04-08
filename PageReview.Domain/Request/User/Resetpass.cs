using System;
using System.Collections.Generic;
using System.Text;

namespace PageReview.Domain.Request.User
{
    public class Resetpass
    {
        public string Id { get; set; }
        public string PassWord { get; set; }
    }
}
