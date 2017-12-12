using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace alpha.mvc.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
    }
}