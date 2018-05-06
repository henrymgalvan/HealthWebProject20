using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{
    public enum TypeOfDeathEnum
    {
        Maternal = 1, Perinatal = 2, NeonatalTetatus = 3, NeonatalDeath = 4 
    }
    public enum PlaceOfDeathEnum
    {
        FacilityBased = 1, NonInstitutionalDelivery = 2
    }
    public struct Age
    {
        public int Years;
        public int Months;
        public int Days;
    }
    public class DeathRecord
    {
        public long Id { get; set; }
        public DateTime DateTimeOfDeath { get; set; }
        public TypeOfDeathEnum TypeOfDeath { get; set; }
        public PlaceOfDeathEnum PlaceOfDeath { get; set; }
        public Age Age { get; set; }

        public string Remarks { get; set; }

    }
}
