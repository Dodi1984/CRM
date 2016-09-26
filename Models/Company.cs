using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Required]
        public string Name { get; set; }

        [StringLength(50, MinimumLength = 2)]
        [Required]
        public string City { get; set; }

        [StringLength(50, MinimumLength = 2)]
        [Required]
        public string CUI { get; set; }

        [Required]
        public string J { get; set; }

        [Required]
        public string Adress { get; set; }

        public string FieldOfActivity { get; set; }

        public bool PreviousContract { get; set; }

        public bool HasAutoPark { get; set; }
        
        public int NrOfDrivers { get; set; }

        public string ServicesOfInterest { get; set; }

        public string DateOfTheFirstContact { get; set; }

        public string DateOfTheSecondContact { get; set; }

        public string DateOfTheThirdContact { get; set; }

        public string DateOfTheFourthContact { get; set; }

        public string DateOfTheFifthContact { get; set; }

        public string Discution1 { get; set; }

        public string Discution2 { get; set; }

        public string Discution3 { get; set; }

        public string Discution4 { get; set; }

        public string Discution5 { get; set; }

        public string LongDiscutions { get; set; }

        public string CallBackDate { get; set; }

        public bool CourseLvl1 { get; set; }

        public bool CourseLvl2 { get; set; }

        public bool CourseLvl3 { get; set; }

        public List<ContactPerson> Persons { get; set; }
    }
}
