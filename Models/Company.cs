using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Company
    {
        public int CompanyId {get;set;}
        public string Name { get; set; }
        public string Adress {get;set;}
        public string City {get;set;}
        public string CUI { get; set; }
        public List<Person> Persons {get;set;}
    }
}
