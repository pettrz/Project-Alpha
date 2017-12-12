using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml.Linq;

namespace alpha.mvc.Models
{
    public class XMLParse
    {
        public static void Parse(List<Product> products)
        {
            foreach (XElement level1Element in XElement.Load(HttpContext.Current.Server.MapPath("~/Models/productsmin.xml")).Elements("artikel"))
            {
                Product p = new Product();
                foreach (XElement level2Element in level1Element.Elements())
                {
                    if (level2Element.Name == "Artikelid")
                        p.Id = Convert.ToInt32(level2Element.Value);
                    else if (level2Element.Name == "Namn")
                        p.Title = level2Element.Value;
                    else if (level2Element.Name == "Prisinklmoms")
                        p.Price = Convert.ToDouble(level2Element.Value.Replace('.', ','));
                }
                products.Add(p);
            }
        }

        public static void Parse(List<Store> stores)
        {
            foreach (XElement level1Element in XElement.Load(HttpContext.Current.Server.MapPath("~/Models/stores.xml")).Elements("ButikOmbud"))
            {
                if (level1Element.Element("Typ").Value == "Butik")
                {
                    stores.Add(new Store()
                    {
                        Id = level1Element.Element("Nr").Value,
                        Street = level1Element.Element("Address1").Value,
                        City = level1Element.Element("Address4").Value,
                        PostCode = level1Element.Element("Address3").Value,
                        Type = level1Element.Element("Typ").Value
                    });

                }
            }
        }
    }
}