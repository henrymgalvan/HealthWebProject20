using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Maternal
{
    public class FamilyPlanning
    {
        public long Id { get; set; }
       // public FamilyPlanningMethod Method { get; set; }
        public DateTime DateStarted { get; set; }
        public string DropOutReason { get; set; }
        public DateTime DropOutDate { get; set; }
        public string Action { get; set; }
        public string Remarks { get; set; }

    }
}
