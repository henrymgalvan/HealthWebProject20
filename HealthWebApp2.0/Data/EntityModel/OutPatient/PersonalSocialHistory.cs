using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{
    public class PersonalSocialHistory
    {
        public long Id { get; set; }
        public bool Smoking { get; set; }
        public bool QuitSmoking { get; set; }
        public decimal NoOfPackYears { get; set; }

        public bool Alcohol { get; set; }
        public bool Quit { get; set; }
        public int NoOfBottlesPerDay { get; set; }

        public bool illicitDrugs { get; set; }

    }
}
