﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Models.HouseholdMember
{
    public class HouseholdMembersIndexModel
    {
        public IEnumerable<HouseholdMemberDetailModel> Members { get; set; }
    }
}