using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Models.HouseholdMember
{
    public class HouseholdMemberDetailModel
    {
        public long Id { get; set; }
        public String FullName { get; set; }
        public String Sex { get; set; }
        public String RelationToHead { get; set; }
        public String Barangay { get; set; }
        public int YearsOld { get; set; }
        public int MonthsOld { get; set; }
        public int DaysOld { get; set; }
    }
}
