using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Laboratory
{
    public class Urinalysis
    {
        public long Id { get; set; }

        public int Color { get; set; }
        public int Characteristic { get; set; }
        public int Reaction_pH { get; set; }
        public int Specific_Gravity { get; set; }
        public int Sugar { get; set; }
        public int Protein { get; set; }
        public int Bilirubin { get; set; }
        public int Ketone { get; set; }
        public int Urobilinogen { get; set; }
        public int Nitrite { get; set; }
        public int Ascorbic_Acid { get; set; }
        public int RBC { get; set; }
        public int WBC { get; set; }
        public int Crystals { get; set; }
        public int Epithelial_Cells { get; set; }
        public int Bacteria { get; set; }
        public int Casts { get; set; }

        public string PregnancyTest { get; set; }
        //...

    }
}
