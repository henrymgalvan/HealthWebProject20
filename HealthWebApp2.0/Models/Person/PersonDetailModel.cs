using System;
using HealthWebApp2._0.Data.EntityModel;
using System.ComponentModel.DataAnnotations;

namespace HealthWebApp2._0.Models.Person
{
    public class PersonDetailModel
    {
        public long Id { get; set; }
        public string NameTitle { get; set; }        
        public string FirstName { get; set; }
        public string MiddleName { get; set; }  
        public string LastName { get; set; }    
        public string ExtensionName { get; set; }
        public string FullName {get; set;}
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:mm-dd-yyyy}")]
        public string DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string CivilStatus { get; set; }

        public string ContactNumber { get; set; }
        public string EmailAddress { get; set; }

        public string Work { get; set; } 

        public string Address { get; set; }
        public string Barangay { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Region { get; set; }

        public string PhilHealthID { get; set; }

        public string Religion { get; set; }
        public string Father { get; set; }
        public string Mother { get; set; }
        

    }
}