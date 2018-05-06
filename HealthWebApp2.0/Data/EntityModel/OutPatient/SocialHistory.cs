using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{
    public class SocialHistory
    {
        public long Id { get; set; }
        public bool Smoking { get; set; }
        public bool QuitSmoking { get; set; }
        public int PackYear { get; set; }

        public bool Alcohol { get; set; }
        public bool QuitAlcohol { get; set; }
        public string AlcoholConsumption { get; set; }

        public bool IllicitDrugs { get; set; }
        public bool OralHypoclycemicAgents { get; set; }
        public bool HypertensionMedicines { get; set; }

    }
}
