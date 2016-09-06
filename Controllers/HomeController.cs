using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRM.Models;

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

        // Get /home/PersoaneFizice
        public IActionResult PersoaneFizice()
        {
            ViewData["Message"] = "Asta e o persoana";
            var person = new Person() { FirstName = "Dan", LastName = "Niculescu", BirthDate = new DateTime(1984, 10, 10) };
            return View(person);
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
