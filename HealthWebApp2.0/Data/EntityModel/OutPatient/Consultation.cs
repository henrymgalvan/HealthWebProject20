using HealthWebApp2._0.Data.EntityModel.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{
    public class Consultation
    {
        public long Id { get; set; }

        public long PersonId { get; set; }
        public virtual Patient Patient { get; set; }

        public long AdmissionId { get; set; }
        public virtual Admission Admission { get; set; }

        public virtual IEnumerable<VitalStats> VitalStats { get; set; }

        public virtual PhysicalExam PhysicalExam { get; set; }

        public virtual RiskAssessment RiskAssessment { get; set; }

        public virtual DoctorsOrder DoctorsOrder { get; set; }

        public virtual ConsultationStatus ConsultationStatus { get; set; }


        public bool DoneConsult { get; set; }
        

        public long EmployeeId { get; set; } // based on PhysicianId
        public Physician Physician { get; set; }
    }
}
