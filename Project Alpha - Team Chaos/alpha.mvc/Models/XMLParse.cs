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
            foreach (XElement level1Element in XElement.Load(HttpContext.Current.Server.MapPath("~/Models/products.xml")).Elements("artikel"))
            {  
                if (level1Element.Element("Varugrupp").Value.Contains("vin") && 
                    100 < Convert.ToDouble(level1Element.Element("Prisinklmoms").Value.Replace('.',',')) &&
                    Convert.ToDouble(level1Element.Element("Prisinklmoms").Value.Replace('.', ','))<110)
                {
                    products.Add(new Product()
                    {
                        Id = level1Element.Element("Artikelid").Value,
                        Price = Convert.ToDouble(level1Element.Element("Prisinklmoms").Value.Replace('.', ',')),
                        Type = level1Element.Element("Varugrupp").Value,
                        Title = level1Element.Element("Namn").Value
                    });
                }
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