﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace alpha.mvc.Models
{
    public class Store
    {
        public string Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Type { get; set; }
    }
}