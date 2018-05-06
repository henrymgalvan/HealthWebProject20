using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{
    public class ScheduleOfNextVisit
    {
        public long id { get; set; }

        //Purpose of Visit
        public bool General { get; set; }
        public bool Filariasis { get; set; }
        public bool ChildCare { get; set; }
        public bool PhysicalExam { get; set; }
        public bool TetanusToxoid { get; set; }
        public bool Diabetes { get; set; }
        public bool Prenatal { get; set; }
        public bool Leprosy { get; set; }
        public bool SickChildren { get; set; }
        public bool SystemReview { get; set; }
        public bool Injury { get; set; }
        public bool Stroke { get; set; }
        public bool PostPartum { get; set; }
        public bool Tuberculosis { get; set; }
        public bool ChildImmunization { get; set; }
        public bool Laboratory { get; set; }
        public bool FirecrackerInjury { get; set; }
        public bool PatientMedication { get; set; }
        public bool FamilyPlanning { get; set; }
        public bool Malaria { get; set; }
        public bool ChildNutrition { get; set; }
        public bool Diagnosis { get; set; }
        public bool Cancer { get; set; }
        public bool AdultImmunization { get; set; }
        public bool DentalCare { get; set; }
        public bool Schistosomiasis { get; set; }
        public bool VitalSigns { get; set; }
        public bool DoctorsPlan { get; set; }
        public bool COPD { get; set; }
        public bool PatientAlert { get; set; }


        //Date of Visit if availablel
        public DateTime DateTimeOfNextVisit { get; set; }

        //page 133




    }
}
