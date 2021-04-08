using System;
using System.Collections.Generic;
using System.Text;

namespace PageReview.Domain.Response.GetAll
{
    public class GetsImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string PathImage { get; set; }
    }
}
