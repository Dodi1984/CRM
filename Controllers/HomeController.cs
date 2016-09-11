using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRM.Models;
using WebApplication.Data;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private CrmContext context;

        public HomeController(CrmContext contextt)
        {
            context = contextt;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        #region Persoane Fizice
        // Get /home/PersoaneFizice      
        [HttpGet]
        public IActionResult PersoaneFizice()
        {                      
            var prs = from c in context.Person
                      select c;
            return View(prs.ToList());
        }

        [HttpGet]
        public IActionResult AddNewPerson()
        {
            ViewData["Message"] = "Example :";
            Person examplePerson = new Person() { FirstName = "Dan", LastName = "Niculescu", BirthDate = new DateTime(10/10/1984), CNP = 1841010440085 };
            return View(examplePerson);
        }

        [HttpPost]
        public IActionResult AddNewPerson(Person personIn)
        {
            ViewData["Message"] = "You Have added :";
            context.Add(personIn);
            context.SaveChanges();
            return View(personIn);
        }

        #endregion

        #region Persoane Juridice
        public IActionResult PersoaneJuridice()
        {
            ViewData["Message"] = "Asta e cod din c# din  controller";
            return View();
        }

        #endregion
        public IActionResult Error()
        {
            return View();
        }
    }
}
