using System;
using System.ComponentModel.DataAnnotations;

namespace HealthWebApp2._0.Models.HouseholdMember
{
    public class HouseholdMemberEditModel
    {
        [Display(Name="Member Id")]
        public long Id {get; set;}

        [Display(Name="Member Name")]
        public string MemberName {get; set;}

        [Display(Name="Relation To Household Head")]
        public string Id { get; set; }

        [Display(Name = "Household")]
        public long HouseholdId { get; set; }
     }
}