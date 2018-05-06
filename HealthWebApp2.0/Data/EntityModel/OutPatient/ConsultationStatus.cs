using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{
    public class ConsultationStatus
    {
        public long Id { get; set; }
        //link to Consultation

        public long ConsultationId { get; set; }
        public virtual Consultation Consultation { get; set; }

        //Consultation Status : Completed, Incomplete
        public bool Completed { get; set; }
        public bool Incomplete { get; set; }
        public DateTime DateOfFollowUp { get; set; }

        //Follow-up Remarks
        public string FollowUpRemarks { get; set; }

    }
}
