using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Laboratory
{
    public class BloodChemistry //pg 114
    {
        public long Id { get; set; }

        public int Amylase { get; set; }
        public int Indirect { get; set; }
        public int Direct { get; set; }
        public int Total1 { get; set; }
        public int Ionized { get; set; }
        public int Total2 { get; set; }
        public int Chloride { get; set; }
        public int Sodium { get; set; }
        public int Potassium { get; set; }
        public int SGOT { get; set; }
        public int SGPT { get; set; }
        public int LDH { get; set; }
        public int CPK_MB { get; set; }
        public int BUN { get; set; }
        public int Creatinine { get; set; }
        public int UricAcid { get; set; }
        public int TotalProtien { get; set; }
        public int Albumin { get; set; }
        public int Globulin { get; set; }



    }
}
