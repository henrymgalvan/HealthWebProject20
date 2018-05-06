using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Maternal
{
    public enum BirthControlMethod { NaturalMethod = 1, Pills = 2, Injectable = 3, BLT = 4 }
        //Condom,
        //Female Sterilization/Bilateral Tubal Ligation
        //Implant
        //Depo-Medroxy Progestone Acetate(DMPA)
        //Intra-Uterine Device
        //Male Sterilization/Vasectomy
        //Natural family Planning - Basal body Temperature
        //Natural Family Planning - Cervical Mucus Method
        //Lactational Amenorrhea Method
        //Natural Family Planning - Standard Days Method
        //Natural Family Planning - Sympothermal Method
        //Pills
    public class MenstrualHistory
    {
        public long Id { get; set; }
        public long PersonId { get; set; }
        public Person Person { get; set; }

        public DateTime LastMenstrualPeriod { get; set; }
        public string PeriodDuration { get; set; }
        public string IntervalCycle { get; set; }
        public int NoOfPadsPerDayDuringMenstruation { get; set; }

        public string OnsetOfSexualInterCourse { get; set; }


        public BirthControlMethod BirthControlMethod { get; set; }

        public string Notes { get; set; }

    }
}
