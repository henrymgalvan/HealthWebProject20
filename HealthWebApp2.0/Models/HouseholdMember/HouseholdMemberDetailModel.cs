using System;
using System.ComponentModel.DataAnnotations;

namespace HealthWebApp2._0.Models.HouseholdMember
{
    public class HouseholdMemberDetailModel
    {
        [Display(Name="Member Id")]
        public long PersonId {get; set;}

        [Display(Name="Member Name")]
        public string MemberName {get; set;}

        [Display(Name="Relation To Household Head")]
        public string RelationToHouseholdHead { get; set; }

        [Display(Name = "Household")]
        public long HouseholdId { get; set; }
     }
}