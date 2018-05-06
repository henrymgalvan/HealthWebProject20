using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{
    public enum TypeOfReferralLookup
    {
        Hospital = 1, RHU = 2, BHS =3

    }
    public enum DateAdmittedDiagnosisLookup
    {

    }
    public enum ServicesRenderedLookup
    {
        MedicalServices = 1, OtherServices = 2
    }
    public enum ReferredToLookup
    {

    }
    public enum ReasonLookup
    {
        NoAvailableDoctor = 1, NoAvailableEquipment = 2, NoLaboratoryAvailable = 3, NoProcedureAvailable = 4,
        NoRoomAvailable = 5, SeekAdviseSecondOpinion = 6, SeekFurtherTreatment = 7, SeekSpecializedEvaluation = 8
    }
    public enum ReferralStatusLookup
    {
        NewInProgress = 1, PendingFurtherActionRequired = 2, ServiceProvided = 3, ServiceNotProvided = 4, Expired = 5
    }
    public class Referral
    {
        public long Id { get; set; }

        public long DoctorsOrderId { get; set; }
        public DoctorsOrder DoctorsOrder { get; set; }

        public DateTime DateOfReferral { get; set; }
        public TypeOfReferralLookup TypeOfReferral { get; set; }
        public DateAdmittedDiagnosisLookup Diagnosis { get; set; }
        public ServicesRenderedLookup ServicesRendered { get; set; }
        public ReferredToLookup ReferredTo { get; set; } // search facility
        public ReasonLookup Reason { get; set; }
        public string Remarks { get; set; }
        public ReferralStatusLookup ReferralStatus { get; set; }
    }
}
