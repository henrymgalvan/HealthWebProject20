using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Laboratory
{
    public class CompletBloodCount
    {
        public long Id { get; set; }

        public int Hemoglobin { get; set; }
        public int Hematocrit { get; set; }
        public int RBC_Count { get; set; }
        public int MCV { get; set; }
        public int MCH { get; set; }
        public int MCHC { get; set; }
        public int WBC_Count { get; set; }
        public int Neutrophilis { get; set; }
        public int Lymphocytes { get; set; }
        public int Basophilis { get; set; }
        public int Monocytes { get; set; }
        public int Eosinopnilis { get; set; }
        public int Stabs { get; set; }
        public int Juveniles { get; set; }
        public int Platelet_Count { get; set; }
        public int Reticuloctytes { get; set; }
        public int Bleeding_Time { get; set; }
        public int Clotting_Time { get; set; }
        public int Clot_Retraction { get; set; }
    }
}
