using HealthWebApp2._0.Data.EntityModel.Household;
using System.Collections.Generic;

namespace HealthWebApp2._0.Models.HouseholdProfile
{
    public class HouseholdProfileDetailModel
    {
        public long Id { get; set; }
        public string ProfileId { get; set; }
        public string Address { get; set; }
        public string Barangay { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string NumberOfMembers { get; set; }
        public string Note { get; set; }
        public IEnumerable<HouseholdMember> HouseHolds { get; set; }
    }
}
