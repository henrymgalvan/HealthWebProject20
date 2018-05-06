using HealthWebApp2._0.Data.EntityModel.Medicines;
using HealthWebApp2._0.Data.EntityModel.OutPatient.ICD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{
    public class MedicalHistoryPresentIllness
    {
        public long Id { get; set; }
        public ICD10 ICDCode { get; set; }
        public DateTime DateOfDiagnosis { get; set; }
        public IEnumerable<Prescription> Prescriptions { get; set; }

        public string HistoryOfPresentIllness { get; set; }
        public string PresentMedicalFamilySocialHistory { get; set; }
        public string Remarks { get; set; }


    }
}
