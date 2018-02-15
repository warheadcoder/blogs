using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoadMoreMVCSample.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductPicture { get; set; }
        public string ProductDescription { get; set; }
        public DateTime ProductDate { get; set; }
        public decimal ProductPrice { get; set; }
    }
}