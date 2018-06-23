using System;
using System.ComponentModel.DataAnnotations;

namespace HealthWebApp2._0.Models.HouseholdMember
{
    public class HouseholdMemberDetailModel
    {
        [Display(Name="Member Id")]
        public long Id {get; set;}

        [Display(Name="Relation To Household Head")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Household")]
        public long HouseholdId { get; set; }

     }
}