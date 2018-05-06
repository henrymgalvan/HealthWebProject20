using HealthWebApp2._0.Data.EntityModel.PhilHealthFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{
    public enum BloodTypeEnum { A = 1, B = 2, AB = 3, O = 4 }
    public enum RhDEnum{ Negative = 1, Positive = 2 }

    public class Patient 
    {
        [Key]
        [ForeignKey("Person")]
        public long PersonId { get; set; }
        public Person Person { get; set; }

        public BloodTypeEnum BloodType { get; set; }
        public RhDEnum RhDType { get; set; }

        public ChildBirthRecord BirthRecord { get; set; }

        public FamilyHistory FamilyHistory { get; set; }
        public MedicalHistory MedicalHistory { get; set; }
        public ICollection<MedicalHistoryPresentIllness> Presentillnesses { get; set; }
        public PersonalSocialHistory SocialHistory { get; set; }
        public SurgicalHistory SurgicalHistory { get; set; }

        public ImmunizationRecord ImmunizationRecord { get; set; }
        public ICollection<Consultation> Consultations { get; set; }



    }
}
