using HealthWebApp2._0.Data.EntityModel.Medicines;
using HealthWebApp2._0.Data.EntityModel.OutPatient.ICD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{
    public enum TypeOfDiagnosis
    {
        Admitting = 1, Final = 2, Working = 3, NotApplicable = 4
    }

    public class Diagnosis
    {
        public long Id { get; set; }

        public long DoctorsOrderId { get; set; }
        public virtual DoctorsOrder DoctorsOrder { get; set; }
        
        //Type Of Diagnosis Admitting, Final, Working, Not Applicable
        public TypeOfDiagnosis DiagnosisType { get; set; }
        public ICD10 ICD10 { get; set; } //List of ICD10 code
        public string TreatmentPlan { get; set; }

        public IEnumerable<Prescription> Prescriptions { get; set; }


        public string Remarks { get; set; }
    }
}
