using HealthWebApp2._0.Data.EntityModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;

namespace HealthWebApp2._0.Models.Person
{
    public class PersonCreateModel
    {
        public int NameTitleId { get; set; }

        [Required, RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Display(Name = "First Name")]
        [StringLength(30, MinimumLength = 1)]
        public string FirstName { get; set; }

        [StringLength(30, MinimumLength = 0)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [StringLength(50, MinimumLength = 1)]
        public string LastName { get; set; }

        [Display(Name = "Extension Name")]
        public EnumExtensionName ExtensionName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Gender")]
        public EnumGender Sex { get; set; }

        [Display(Name = "Civil Status")]
        public EnumCivilStatus CivilStatus { get; set; }

        [Phone]
        [Display(Name = "Contact #")]
        public string ContactNumber { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        public string EmailAddress { get; set; }

        [Display(Name = "Work")]
        public int WorkId { get; set; }

        [Display(Name = "Religion")]
        public int ReligionId { get; set; }

        public bool PersonConsent { get; set; }
        
        public DateTime DateTimeLastUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public long EmployeeId { get; set; }
    }
}
