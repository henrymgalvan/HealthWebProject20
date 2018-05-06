using HealthWebApp2._0.Data.EntityModel.OutPatient;
using HealthWebApp2._0.Data.EntityModel.OutPatient.ICD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Medicines
{
    public enum FrequencyLookUp
    {
        Daily = 1, Weekly = 2, Monthly = 3, Quarterly = 4, Yearly = 5, Indifinite = 6
    }
    public enum DoseRegimenLookUp
    {
        OnceADay = 1, TwiceADay = 2, ThriceADay = 3, FourTimesADay = 4, Every4Hours = 5, Every6Hours = 6,
        EveryMorning = 7, EveryEvening = 7, Others = 8
    }

    public class Prescription
    {
        public long Id { get; set; }

        public long DiagnosisId { get; set; }
        public virtual Diagnosis Diagnosis { get; set; }

        public string DrugCode { get; set; }
        public FrequencyLookUp Frequency { get; set; }
        public DoseRegimenLookUp doseRegimen { get; set; }
        public int TotalQuantity { get; set; }
        public string QuantityUnitOfMeasure { get; set; }
        public string IntendedPurposeOfMedicine { get; set; } //lookup
        public string Medication { get; set; }
        public DateTime DateOfPrescription { get; set; }
        public long PrescribedBy { get; set; }


    }
}
