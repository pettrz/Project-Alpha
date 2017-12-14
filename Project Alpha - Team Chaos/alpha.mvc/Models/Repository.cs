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
            //stores.Add(new Store() { Id = 102, Street = "Karlaplan 13", PostCode = "115 20" });
            //stores.Add(new Store() { Id = 102, Street = "Karlaplan 13", PostCode = "115 20" });
            //stores.Add(new Store() { Id = 102, Street = "Karlaplan 13", PostCode = "115 20" });
            //stores.Add(new Store() { Id = 102, Street = "Karlaplan 13", PostCode = "115 20" });
            //stores.Add(new Store() { Id = 102, Street = "Karlaplan 13", PostCode = "115 20" });

            //products.Add(new Product() { Id = 1013561, Price = 109, Title = "Stoneleigh Brut Cuvée" });
            //products.Add(new Product() { Id = 1013561, Price = 109, Title = "Stoneleigh Brut Cuvée" });
            //products.Add(new Product() { Id = 1013561, Price = 109, Title = "Stoneleigh Brut Cuvée" });
            //products.Add(new Product() { Id = 1013561, Price = 109, Title = "Stoneleigh Brut Cuvée" });
            //products.Add(new Product() { Id = 1013561, Price = 109, Title = "Stoneleigh Brut Cuvée" });
        }

        public List<Store> Stores
        {
            get
            {
                return stores;
            }
        }

        public List<Product> Products
        {
            get
            {

                products = products.OrderBy(p => p.Price)
                .ToList();

                return products;
            }
        }
    }
}
