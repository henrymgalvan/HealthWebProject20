using System.ComponentModel.DataAnnotations;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{
    public class PurposeOfVisit
    {
        [Key]
        public long AdmissionId { get; set; }

        public bool General { get; set; }
        public bool PreNatal { get; set; }
        public bool PostPartum { get; set; }
        public bool FamilyPlanning { get; set; }
        public bool DentalCare { get; set; }
        public bool Tuberculosis { get; set; }
        public bool ChildCare { get; set; }
        public bool SickChildren { get; set; }
        public bool ChildImmunization { get; set; }
        public bool ChildNutrition { get; set; }
        public bool Injury { get; set; }
        public bool FirecrackerInjury { get; set; }
        public bool AdultImmunization { get; set; }

    }
}