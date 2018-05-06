using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Laboratory
{
    public class Hematology
    {
        public long Id { get; set; }

        public int Hemoglobin { get; set; }
        public int Hematocrit { get; set; }
        public int WBC_Count { get; set; }
        public int Neutrophils { get; set; }
        public int Bands_Stabs { get; set; }
        public int Juveniles { get; set; }
        public int Eosinophils { get; set; }
        public int Basophils { get; set; }
        public int Lymphocytes { get; set; }
        public int Monocytes { get; set; }
        public int Platelet_Count { get; set; }
        public int ESR { get; set; }
        public int Reticulocyte_Count { get; set; }
        public int Bleeding_Time { get; set; }
        public int Clotting_Time { get; set; }
        public int Blood_Type { get; set; }
        public int Rh { get; set; }
        public int BSMP { get; set; }

        public string Remarks { get; set; }

    }
}
