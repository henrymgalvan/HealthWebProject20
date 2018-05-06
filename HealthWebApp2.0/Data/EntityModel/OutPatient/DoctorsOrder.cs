
using HealthWebApp2._0.Data.EntityModel.OutPatient.ICD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{
    public enum Disposition
    {
        Absconded = 1, Admission = 2, HomeAgainstMedicalAdvice = 3, SentHome = 4, Referred = 5
    }
    public enum ConditionOfDischarge
    {
        Good = 1, Satisfactory = 2, Serious = 3, Critical = 4, Espired = 5
    }

    public class DoctorsOrder //pg109
    {
        public long Id { get; set; }

        public long ConsultationId { get; set; }
        public virtual Consultation Consultation { get; set; }

        //Laboratory Request
        public bool BloodChemistry { get; set; }
        public bool CompleteBloodCount { get; set; }
        public bool ClinicalChemistry { get; set; }
        public bool Fecalysis { get; set; }
        public bool Hematology { get; set; }
        public bool Immunology { get; set; }
        public bool Serology { get; set; }
        public bool SputumMicroscopy { get; set; }
        public bool Urinalysis { get; set; }

        //Imaging
        public bool ECG { get; set; }
        public bool MRI { get; set; }
        public bool Ultrasound { get; set; }
        public bool XRay { get; set; }

        //Alert Type
        public bool Allergy { get; set; }
        public bool Disability { get; set; }
        public bool Drug { get; set; }
        public bool Handicap { get; set; }
        public bool Impairment { get; set; }
        public bool OtherAlertType { get; set; }
        //Alert Description
        public string AlertDescription { get; set; }

        public IEnumerable<Diagnosis> Diagnosis { get; set; }

        public Disposition Disposition { get; set; }
        public ConditionOfDischarge ConditionOfDischarge { get; set; }
        public DateTime DateOfDischarge { get; set; }

        //For follow-up
        public bool ScheduledNextVisit { get; set; }
        public ScheduleOfNextVisit ScheduleOfNextVisit { get; set; }

        //Prescribe Medicine

        //        public TypeOfConsultationService ConsultationService { get; set; }


        public virtual Referral Referral { get; set; }

    }
}
