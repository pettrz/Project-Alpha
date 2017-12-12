using alpha.mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace alpha.mvc.Controllers
{
    public class HomeController : Controller
    {
        Repository _repo = Repository.GetRepo;

        // GET: Home
        public ActionResult Index()
        {
            return View(_repo.Stores);
        }

        public ActionResult Store()
        {
            return View(_repo.Products);
        }

        public ActionResult StoreList()
        {
            return View(_repo.Stores);
        }
    }
}