using HealthWebApp2._0.Data.EntityModel.Admin;
using HealthWebApp2._0.Data.EntityModel.Household;
using HealthWebApp2._0.Data.EntityModel.PhilHealthFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthWebApp2._0.Data.EntityModel
{
    public enum EnumGender
    {
        Male = 1, Female = 2
    }

    public enum EnumCivilStatus
    {
        Single = 1, Married, LiveIn, Separated, Annulled, Widow
    }

    public enum EnumExtensionName
    {
        NA = 0, II = 1, III = 2, IV = 3, V = 4, Jr = 5, Sr = 6
    }

    public class Person
    {
        [Key]
        public long Id { get; set; }

        public int NameTitleId { get; set; }
        public virtual NameTitle NameTitle { get; set; } 

        [Required, StringLength(30), MinLength(1)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]   //First letter is capital, remaining characters is alphabetical
        public string FirstName { get; set; }

        [StringLength(30)]
        public string MiddleName { get; set; }

        [Required, StringLength(30)]
        public string LastName { get; set; }

        public EnumExtensionName ExtensionName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DateOfBirth { get; set; }

        public EnumGender Sex { get; set; }
        
        public EnumCivilStatus CivilStatus { get; set; }

        [Phone]
        public string ContactNumber { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }

        public int WorkId { get; set; }
        public virtual Work Work { get; set; }

        public virtual HouseholdMember HouseholdMember { get; set; }

        public long? FamilyId { get; set; }
        public virtual Family Family { get; set; }
        //public long FatherId {get; set;}
        //public long MotherId {get; set;}

        public virtual PhilHealth PhilHealth { get; set; }

        public int ReligionId { get; set; }
        public virtual Religion Religion { get; set; }

        public bool PersonConsent { get; set; } //Consent of patient to digital storage

        public DateTime DateTimeLastUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public long EmployeeId { get; set; }    //Updated by Last Employee

        public string FullName => (FirstName + " " + MiddleName + " " + LastName + " " + ExtensionName);

        //Emergency Contact Person
        public string EmergencyContactPerson { get; set; }
        public string EmergencyContactNumber { get; set; }
        public RelationToHouseholdHead RelationshipToPatient { get; set; }
    }
}