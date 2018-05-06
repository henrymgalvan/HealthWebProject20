using HealthWebApp2._0.Data.EntityModel;
using HealthWebApp2._0.Data.EntityModel.Household;
using System;
using System.ComponentModel.DataAnnotations;

namespace HealthWebApp2._0.Models.HouseholdMember
{
    public class HouseholdMemberCreateModel
    {
        public long PersonId { get; set; }
        public long HouseholdProfileId { get; set; }
        public RelationToHouseholdHead RelationToHouseholdHead { get; set; }
    }
}
