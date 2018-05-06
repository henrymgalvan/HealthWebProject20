using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Laboratory
{
    public class ClinicalChemistry
    {
        public long Id { get; set; }

        public int Glucose_FBS { get; set; }
        public int Glucose_RBS { get; set; }
        public int Cholesterol { get; set; }
        public int Triglycerides { get; set; }
        public int HDL { get; set; }
        public int LDL { get; set; }
        public int BUN { get; set; }
        public int Creatinine { get; set; }
        public int Uric_Acid { get; set; }
        public int SGOT { get; set; }
        public int SGPT { get; set; }
        public int B2 { get; set; }
        public int B1 { get; set; }
        public int Na { get; set; }
        public int K { get; set; }
        public int Ca { get; set; }

        public string Remarks { get; set; }



    }
}
