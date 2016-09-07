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
        [HttpGet]
        public IActionResult PersoaneFizice()
        {
            ViewData["Message"] = "Example";
            var examplePerson = new Person() { FirstName = "Dan", LastName = "Niculescu", BirthDate = new DateTime(1984, 10, 10) };
            return View(examplePerson);
        }

        // POST - add new person to db
        [HttpPost]
        public IActionResult PersoaneFizice(Person personIn)
        {
            ViewData["Message"] = "You have added :";
            return View(personIn);
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
