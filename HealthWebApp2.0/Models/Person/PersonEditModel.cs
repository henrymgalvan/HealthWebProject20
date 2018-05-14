using HealthWebApp2._0.Data.EntityModel;
using HealthWebApp2._0.Data.EntityModel.PhilHealthFolder;
using System;
using System.ComponentModel.DataAnnotations;

namespace HealthWebApp2._0.Models.Person
{
    public class PersonEditModel
    {
       // [Key]
        public long Id { get; set; }

        public int NameTitleId { get; set; }
        //public NameTitle NameTitle { get; set; }

        [Required, StringLength(30), MinLength(1)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]   //First letter is capital, remaining characters is alphabetical
        [Display(Name = "First Name")]
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
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
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

        //Emergency Contact Person
        [StringLength(30, MinimumLength = 0)]
        [Display(Name = "Contact Person")]
        public string EmergencyContactPerson { get; set; }

        [Phone]
        [Display(Name = "Emergency Contact Number")]
        public string EmergencyContactNumber { get; set; }

        [StringLength(30, MinimumLength = 0)]
        [Display(Name = "Relationship To Patient")]
        public string RelationshipToPatient { get; set; }

        //        public virtual HouseholdProfileDetailMOdel HouseholdProfileDetailMOdel { get; set; }

        //        public long PhilHealthId { get; set; }
        //        public string PhilHealth { get; set; }

        //        public long FatherId { get; set; }
        //       public Person Father { get; set; }

        //        public long MotherId { get; set; }
        //        public virtual Person Mother { get; set; }

        //        public bool PersonConsent { get; set; } //Consent of patient to digital storage

        //        public DateTime DateTimeLastUpdated { get; set; }
        //        public DateTime DateCreated { get; set; }
        //        public long EmployeeId { get; set; }    //Updated by Last Employee

    }
}
