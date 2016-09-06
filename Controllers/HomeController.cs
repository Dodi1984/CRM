using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult PersoaneFizice()
        {
            ViewData["Message"] = "Asta e cod din c# din  controller";
            return View();
        }

        public IActionResult PersoaneJuridice()
        {
            ViewData["Message"] = "Asta e cod din c# din  controller";
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
