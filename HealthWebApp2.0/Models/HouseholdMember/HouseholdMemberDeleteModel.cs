using System;
using System.ComponentModel.DataAnnotations;

namespace HealthWebApp2._0.Models.HouseholdMember
{
    public class HouseholdMemberDeleteModel
    {
        [Display(Name="Member Id")]
        public long Id {get; set;}

        [Display(Name="Relation To Household Head")]
        public int HouseholdHeadId { get; set; }

        [Display(Name = "Household")]
        public long HouseholdId { get; set; }

     }
}