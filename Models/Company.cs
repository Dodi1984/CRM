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
        public string CUI { get; set; }

        [Required]
        public string J { get; set; }

        [Required]
        public string Adress { get; set; }

        [Required]

        public string FieldOfActivity { get; set; }

        [Required]

        public bool PreviousContract { get; set; }

        [Required]

        public bool HasAutoPark { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public int NrOfDrivers { get; set; }

        [Required]

        public string ServicesOfInterest { get; set; }

        [Required]

        public string DateOfTheFirstContact { get; set; }

        [Required]

        public string DateOfTheSecondContact { get; set; }

        [Required]

        public string DateOfTheThirdContact { get; set; }

        [Required]

        public string DateOfTheFourthContact { get; set; }

        [Required]

        public string DateOfTheFifthContact { get; set; }

        [Required]

        public string Discution1 { get; set; }

        [Required]

        public string Discution2 { get; set; }

        [Required]

        public string Discution3 { get; set; }

        [Required]

        public string Discution4 { get; set; }

        [Required]

        public string Discution5 { get; set; }

        [Required]

        public string LongDiscutions { get; set; }

        [Required]

        public string CallBackDate { get; set; }

        [Required]

        public bool CourseLvl1 { get; set; }

        [Required]

        public bool CourseLvl2 { get; set; }

        [Required]

        public bool CourseLvl3 { get; set; }

        [Required]

        public List<ContactPerson> Persons { get; set; }
    }
}
