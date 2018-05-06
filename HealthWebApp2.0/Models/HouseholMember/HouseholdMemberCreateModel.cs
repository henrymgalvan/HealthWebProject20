using HealthWebApp2._0.Data.EntityModel.Household;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Models.HouseholMember
{
    public class HouseholdMemberCreateModel
    {
        public long PersonId { get; set; }
        public long HouseholdProfileId { get; set; }
        public RelationToHouseholdHead RelationToHouseholdHead { get; set; }
    }
}
