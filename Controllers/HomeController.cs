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

        public HomeController(CrmContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            List<string> list = new List<string>();
            list.Add("abc");
            list.Add("defg");
            list.Add("fdbc");
            list.Add("aghjk");
            list.Add("apljk");
            list.Add("vbhjk");
            list.Add("bhjk");
            return View(list);
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
            Person examplePerson = new Person() { FirstName = "Dan", LastName = "Niculescu", BirthDate = new DateTime(10 / 10 / 1984), CNP = 1841010440085 };
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

        [HttpGet]
        public IActionResult PersoaneJuridice()
        {
            var cmp = from c in context.Company
                      select c;

            return View(cmp.ToList());
        }

        [HttpGet]
        public IActionResult AddNewCompany()
        {
            ViewData["Message"] = "Example :";
            Company exampleCompany = new Company() { Name = "Luxoft", City = "Bucharest", CUI = "123456", J = "236/2008" };
            return View(exampleCompany);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        // public async Task<IActionResult> AddNewCompany(Company companyIn)
        public async Task<IActionResult> AddNewCompany([Bind("Name, City, CUI, J, Adress, HasAutoPark")] Company companyIn)
        {

            if (ModelState.IsValid)
            {
                ViewData["Message"] = "You Have added :";
                context.Add(companyIn);
                await context.SaveChangesAsync();
                return View(companyIn);
            }
            ViewData["Message"] = "Please fill all mandatory field:";
            return View(companyIn);
        }

        #endregion

        public IActionResult Error()
        {
            return View();
        }
    }
}
