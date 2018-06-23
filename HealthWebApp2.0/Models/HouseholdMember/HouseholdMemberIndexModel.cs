using HealthWebApp2._0.Data.EntityModel.Household;
using System.Collections.Generic;
 
namespace HealthWebApp2._0.Models.HouseholdMember
{
    public class HouseholdMemberIndexModel
    {
        public IEnumerable<HouseholdMemberEditModel> HouseholdMembers { get; set; }
    }
}
