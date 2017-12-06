﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using alpha.web.Models;

namespace alpha.web.Controllers
{
    public class HomeController : Controller
    {
        Repository _repo = Repository.GetRepo;

        public IActionResult Index()
        {
            
            return View(_repo.Stores);
        }

        public IActionResult Store()
        {
            ViewData["Message"] = "Butikens sortiment";

            return View(_repo.Products);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
