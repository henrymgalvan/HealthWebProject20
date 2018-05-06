using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{
    public class PhysicalExam
    {
        public long Id { get; set; }

        public long ConsultationId { get; set; }
        public virtual Consultation Consultation { get; set; }

        //HEENT==> anicteric sclerae, intact tympanic membrane, tonsilopharyngeal congestion, exudate,
        //          pupils brisky reactive to light, alar flaring, hypertrophic tonsils, aural discharge, 
        //          nasal discharge, palpable mass
        public string HeadNotes { get; set; }
        public bool ConjunctivaPale { get; set; }       //Eye Anatomy
        public bool ConjunctivaYellowish { get; set; }
        public string  ConjunctivaRemarks { get; set; }

        public bool NeckEnlargedThyroid { get; set; }
        public bool NeckEnlargeLymphNodes { get; set; }

        //Chest/Lungs==>   symmetrical chest expansion, detractions, wheezes, clear breathsounds, crackles/rales
        //Heart==> adynamic precordium, normal rate regular rhythm, heaves.thrills, murmurs
        public string ChestRemarks { get; set; }

        //Skin ==> pallor, rashes, jaundice, good skin turgor

        public bool BreastMass { get; set; }
        public bool BreastEnlargedAxillaryLymphNodes { get; set; }
        public bool BreastNippleDischarge { get; set; }
        public bool BreastSkinOrangePeelOrDimpling { get; set; }
        public string BreastRemarks { get; set; }

        public bool ThoraxAbnormalHeartSoundsOrCardiacRate { get; set; }
        public bool ThoraxAbnormalBreathSoundsOrRespiratoryRate { get; set; }
        public string ThoraxRemarks { get; set; }

        public bool AbdomenEnlargedLiver { get; set; }
        public bool AbdomenMass { get; set; }
        public bool AbdomenTenderness { get; set; }
        public bool AbdomenScar { get; set; }
        //Abdomen==> flat, flabby, tenderness, globular, muscle guarding, palpable mass
        public string AbdomenRemarks { get; set; }

        public bool Genitals { get; set; }
        public string GenitalsRemarks { get; set; }

        public bool Extremities { get; set; }
        // ==> gross deformity, normal gait, faull and equal pluses
        public string ExtremitiesRemarks { get; set; }

        public bool Others { get; set; }
        public string Remarks { get; set; }

    }
}
