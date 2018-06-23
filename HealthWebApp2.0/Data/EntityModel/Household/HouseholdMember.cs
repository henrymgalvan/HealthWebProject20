using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthWebApp2._0.Data.EntityModel.Household
{

    public enum RelationToHouseholdHead
     { 
        Head = 1, Spouse = 2, Son = 3, Daughter = 4, Grandson = 5, GrandDaughter = 6,
        DaughterInLaw = 7, SonInLaw = 8, FatherInLaw = 9, MotherInLaw = 10,
        Father = 11, Mother = 12, Brother = 13, Sister = 14,
        Guest = 15
     }
    public class HouseholdMember
    {
        [Key]
        [ForeignKey("Person")]
        public long PersonId { get; set; }
        public virtual Person Person { get; set; }

        public RelationToHouseholdHead RelationToHead { get; set; }

        public DateTime DateCreated { get; set; }

        public long HouseholdProfileId { get; set; }
        public virtual HouseholdProfile HouseholdProfile { get; set; }

    }
}