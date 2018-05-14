﻿using HealthWebApp2._0.Data.EntityModel.Household;
using System.Collections.Generic;
 
namespace HealthWebApp2._0.Models.HouseholdProfile
{
    public class HouseholdProfileIndexModel
    {
        public long Id { get; set; }
        public string ProfileId { get; set; }
        public string Address { get; set; }
        public long BarangayId { get; set; }
        public string Note { get; set; }
        public IEnumerable<HouseholdMember> Households { get; set; }


    }
}
