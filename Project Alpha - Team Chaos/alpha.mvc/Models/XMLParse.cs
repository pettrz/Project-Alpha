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
                Product p;
                if (level1Element.Element("Varugrupp").Value.Contains("vin"))
                {
                    p = new Product();
                    foreach (XElement level2Element in level1Element.Elements())
                    {

                        if (level2Element.Name == "Artikelid")
                            p.Id = Convert.ToInt32(level2Element.Value);
                        else if (level2Element.Name == "Namn")
                            p.Title = level2Element.Value;
                        else if (level2Element.Name == "Prisinklmoms")
                            p.Price = Convert.ToDouble(level2Element.Value.Replace('.', ','));
                        else if (level2Element.Name == "Varugrupp")
                            p.Type = level2Element.Value;
                    }
                    products.Add(p);
                }
            }
        }

        //Fix Parse that takes Store-list

        //public static void Parse(List<Store> stores)
        //{
        //    foreach (XElement level1Element in XElement.Load(HttpContext.Current.Server.MapPath("~/Models/productsmin.xml")).Elements("artikel"))
        //    {
        //        Store s = new Store();
        //        foreach (XElement level2Element in level1Element.Elements())
        //        {
        //            if (level2Element.Name == "Artikelid")
        //                p.Id = Convert.ToInt32(level2Element.Value);
        //            else if (level2Element.Name == "Namn")
        //                p.Title = level2Element.Value;
        //            else if (level2Element.Name == "Prisinklmoms")
        //                p.Price = Convert.ToDouble(level2Element.Value.Replace('.', ','));
        //        }
        //        stores.Add(s);
        //    }
        //}
    }
}