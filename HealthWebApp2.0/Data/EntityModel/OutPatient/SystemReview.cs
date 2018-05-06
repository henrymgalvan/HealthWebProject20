using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.BasicServices
{
    public class SystemReview
    {
        public long Id { get; set; }
        public long ConsultationId { get; set; }

        //Skin
        public bool SkinRashOrItching { get; set; }
        public bool SkinChangesInSkinColor { get; set; }
        public bool SkinPallor { get; set; }
        public bool SkinJaundice { get; set; }
        public bool SkinGoodSkinTurgor { get; set; }
        public string SkinRemarks { get; set; }

        //Skeletal System
        public bool SkeletalJointPain { get; set; }
        public bool MuscleJointWeakness { get; set; }
        public bool MusclePainOrCramp { get; set; }
        public bool BackPain { get; set; }
        public bool ColdExtremities { get; set; }
        public string SkeletalSystemRemarks { get; set; }

        //HEENT/Optha
        public bool EpiepsyConvulsionSeisure { get; set; }
        public bool SevereHeadacheDizziness { get; set; }
        public bool VisualDisturbanceBlurringOfVision { get; set; }
        public bool Yellowishconjuctiva { get; set; }
        public bool EnlargedThyroid { get; set; }
        public bool AnictericSclerae { get; set; }
        public bool PupilsbrisklyReactiveToLight { get; set; }
        public bool AuralDischarge { get; set; }
        public bool IntactTympanicMembrane { get; set; }
        public bool AlarFlaring { get; set; }
        public bool NasalDischarge { get; set; }
        public bool TonsillopharyngealCongestion { get; set; }
        public bool HypertrophicTonsils { get; set; }
        public bool PalpableMass { get; set; }
        public bool Exudates { get; set; }
        public string HeentOphtaRemarks { get; set; }

        //Cardio/Pulmo
        public bool CardioPulmo { get; set; }
        public string CardioPulmoRemarks { get; set; }

        //Gastrointestinal
        public bool Gastrointestinal { get; set; }
        public string GastrointestinalRemarks { get; set; }

        //Endocrine
        public bool Endocrine { get; set; }
        public bool EndocrineRemarks { get; set; }

        //NeuroPsychiatric
        public bool NeuroPsychiatric { get; set; }
        public string NeuroPsychiatricRemarks { get; set; }

        //GenitoUrinary
        public bool GenitoUrinary { get; set; }
        public string GenitoUrinaryRemarks { get; set; }

        //Chest/Heart
        public bool ChestHeart { get; set; }
        public string ChestHeartRemarks { get; set; }

        //Abdomen
        public bool Abdomen { get; set; }
        public string AdbomenRmarks { get; set; }

        //Respiratory
        public bool Respiratory { get; set; }
        public string RespiratoryRemarks { get; set; }

        //Others
        public string  OtherRemarks { get; set; }

    }
}
