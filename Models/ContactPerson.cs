using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class ContactPerson
    {
        public int ContactPersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public long CNP { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PositionInCompany { get; set; }

        public Company Company { get; set; }

    }
}
