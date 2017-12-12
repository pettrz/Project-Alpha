using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace alpha.mvc.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
    }
}