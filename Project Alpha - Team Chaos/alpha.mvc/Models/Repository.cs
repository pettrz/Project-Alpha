using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace alpha.mvc.Models
{
    public class Repository
    {
        private static Repository _repo = new Repository();
        public static Repository GetRepo { get { return _repo; } }

        private List<Store> stores = new List<Store>();
        private List<Product> products = new List<Product>();

        public Repository()
        {
            XMLParse.Parse(products);
            XMLParse.Parse(stores);
           
        }

        public List<Store> Stores
        {
            get
            {

                stores = stores.OrderBy(s => s.Street).ToList();

                return stores;
            }
        }

        public List<Product> Products
        {
            get
            {
                return products;
            }
        }
    }
}
