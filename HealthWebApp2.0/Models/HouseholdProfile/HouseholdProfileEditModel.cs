using HealthWebApp2._0.Data.EntityModel.Household;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Models.HouseholdProfile
{
    public class HouseholdProfileEditModel
    {
        public long Id { get; set; }
        public string ProfileId { get; set; }
        public string Address { get; set; }
        public long BarangayId { get; set; }
        public string Note { get; set; }
        //public IEnumerable<HouseholdMember> HouseHolds { get; set; }

    }
}
