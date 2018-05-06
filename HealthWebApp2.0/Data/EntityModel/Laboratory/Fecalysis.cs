using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Laboratory
{
    public class Fecalysis
    {
        public int Id { get; set; }

        public int Direct { get; set; }
        public int Concentration { get; set; }
        public int Color { get; set; }
        public int consistency { get; set; }
        public int Occult_Blood { get; set; }
        public string Others1 { get; set; }
        public int Pus_Cells { get; set; }
        public int Red_Cells { get; set; }
        public int Yeast_Cells { get; set; }
        public int Bacteria { get; set; }
        public int Fat_Globules { get; set; }
        public int Ascaris_Lumbricoides { get; set; }
        public int Trichuris_Trichuira { get; set; }
        public int S_Sterocoralis { get; set; }
        public int Hookworm { get; set; }
        public string Others2 { get; set; }
        //...
    }
}
