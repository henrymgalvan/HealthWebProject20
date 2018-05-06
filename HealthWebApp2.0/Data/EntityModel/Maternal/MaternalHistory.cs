using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Maternal
{
    public class MaternalHistory
    {
        public long PersonId { get; set; }
        public Person Person { get; set; }

        public DateTime Menarche { get; set; }  //*First menstrual period
        public int OnsetOfSexualIntercourse { get; set; }   //*Start of

        public int Gravida { get; set; }        //#times the woman has been pregnant
        public int Parity { get; set; }         //#times the woman has given birth
        public int FullTerm { get; set; }       //#times the woman has entire duration of normal pregnancy
        public int Premature { get; set; }      //giving birth less than the normal time
        public int Abortion { get; set; }
        public int LivingChildren { get; set; }
        public bool PreEclampsia { get; set; }
        public bool AccessToFamilyPlanning { get; set; }
        public bool Menopause { get; set; }
        public DateTime? MenopausalAge { get; set; }
        
        public string Notes { get; set; }


    }
}
