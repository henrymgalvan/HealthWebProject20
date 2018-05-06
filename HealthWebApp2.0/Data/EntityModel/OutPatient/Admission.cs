using HealthWebApp2._0.Data.EntityModel.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{
    public enum NatureOfVisit
    {
        NewAdmission = 1, NewConsultation = 2, FollowUpVisit = 3
    }
    public enum ModeOfTransaction
    {
        Referral = 1, Visited = 2, WalkIn = 3
    }
    public class Admission
    {
        public long Id { get; set; }

        public long PersonId { get; set; }
        public virtual Person Person { get; set; }

        public long ConsultationId { get; set; }
        public virtual Consultation Consultation { get; set; }

        public DateTime Date { get; set; }      //Default to Current Date & Time
        public DateTime Time { get; set; }

        public int AgeInYears { get; set; }     //computed
        public int AgeInMonths { get; set; }    //computed
        public int AgeInDays { get; set; }      //computed

        public NatureOfVisit NatureOfVisit { get; set; }
        public ModeOfTransaction Transaction { get; set; }
        public PurposeOfVisit PurposeOfVisit { get; set; }
        public string ChiefComplaint { get; set; }

        public bool PatientConsent { get; set; } //to digital record for specific admission

        public long EmployeeId { get; set; }
        public virtual Employee AdmittedBy { get; set; } //Baded On LogIn

        public string Notes { get; set; }


    }
}
