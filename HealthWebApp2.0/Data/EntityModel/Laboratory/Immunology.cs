using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Laboratory
{
    public class Immunology
    {
        public long Id { get; set; }

        public int Hbs_Ag { get; set; }
        public int Anti_HBs { get; set; }
        public int Anti_HBc_lgG { get; set; }
        public int Anti_Hbc_lgM { get; set; }
        public int Anti_HCV { get; set; }
        public int Anti_HBc { get; set; }
        public int Anti_HAV_lgG { get; set; }
        public int anti_HAV_lgM { get; set; }
        public int HBc_Ag { get; set; }

        public string Remarks { get; set; }

    }
}
