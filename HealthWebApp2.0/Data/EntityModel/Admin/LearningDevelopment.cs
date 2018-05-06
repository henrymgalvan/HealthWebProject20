using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Admin
{
    public class LearningDevelopment
    {
        public long Id { get; set; }
        public long PersonId { get; set; }
        public string TitleOfTraining { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal NoOfHours { get; set; }
        public string TypeOfLearning { get; set; }
        public string ConductedBy { get; set; }

    }
}
