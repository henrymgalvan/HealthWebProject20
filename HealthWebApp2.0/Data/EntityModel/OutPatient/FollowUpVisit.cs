using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{
    public class FollowUpVisit
    {
        public long Id { get; set; }
        public long PersonId { get; set; }
        public virtual Person Child { get; set; }
        public DateTime Date { get; set; }
        public short AgeInYears { get; set; }
        public short AgeInMonths { get; set; }
        public short AgeInDays { get; set; }
        public decimal WeightLbs { get; set; }
        public decimal HeightCm { get; set; }
        public decimal WaistCircumferenceCm { get; set; }

        public string Diagnosis { get; set; }
        public string Notes { get; set; }

    }
}
