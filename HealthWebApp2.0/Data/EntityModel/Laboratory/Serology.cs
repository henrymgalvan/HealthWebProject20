using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Laboratory
{
    public class Serology
    {
        public long Id { get; set; }

        public int HIV { get; set; }
        public int HCV { get; set; }
        public int Anti_Streptloysin_O { get; set; }
        public int C_Reactive_Protien { get; set; }
        public int Rheumatoid_factor { get; set; }
        public int Rapid_Plasma_Reagin { get; set; }

        public string Remarks { get; set; }
    }
}
