using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{
    public class MedicalHistory
    {
        public long Id { get; set; }
        public bool Allergy { get; set; }
        public string TypeOfAllergy { get; set; }
        public bool Asthma { get; set; }
        public bool Cancer { get; set; }
        public string OrganWithCancer { get; set; }
        public bool CerebrovascularDisease { get; set; }
        public bool CoronaryArteryDisease { get; set; }
        public bool DiabetesMellitus { get; set; }
        public bool Emphysema { get; set; }
        public bool EpilepsySeizureDisorder { get; set; }
        public bool Hepatitis { get; set; }
        public string HepatitisType { get; set; }
        public bool Hyperlipidemia { get; set; }
        public bool Hypertension { get; set; }
        public string HighestBP { get; set; }
        public bool PepticUlcerDisease { get; set; }
        public bool Pneumonia { get; set; }
        public bool ThyroidDisease { get; set; }
        public bool Tuberculosis { get; set; }
        public string OrganWithTuberculosis { get; set; }
        public bool PTB { get; set; }
        public string PTBcategory { get; set; }
        public bool UrinaryTractInfection { get; set; }
        public string OtherMedicalHistory { get; set; }

        public bool Stroke { get; set; }
        public bool HeartAttack { get; set; }
        public bool KidneyDisease { get; set; }

        public string Remarks { get; set; }

    }
}
