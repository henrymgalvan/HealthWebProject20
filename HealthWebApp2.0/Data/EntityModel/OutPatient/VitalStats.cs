using HealthWebApp2._0.Data.EntityModel.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{

    public enum BPMeasurementAssessment
    {
        Hypertensive = 1, NonHypertensive = 2  //select BP Measurement assessment
    }

    public enum WeightCategory  //for age
    {
        SeverelyUnderWeight = 0, Underweight = 1, Normal = 2, Overweight = 3,
        SeverelyObese = 4, MorbidlyObese = 5
    }

    public enum HeightCategory   //for age
    {
        Midget = 0, VeryShortHeight = 1, ShortHeight = 2, BelowMediumHeight = 3,
        MediumHeight = 4, AboveMediumHeight = 5, TallHeight = 6, VeryTallHeight = 7,
        Giants = 8
    }

    public enum BMICategory
    {
        UnderWeight = 0, NormalWeight = 1, OverWeight = 2, ClassI_Obesity = 3,
        ClassII_Obesity = 4, ClassIII_Obesity_Severe = 5,  ClassIII_Obesity_Morbid = 6, 
        ClassIII_Obesity_Super = 7
    }

    public class VitalStats
    {
        public long Id { get; set; }

        public long ConsultationId { get; set; }
        public virtual Consultation Consultation { get; set; }

        public int Systolic { get; set; }
        public int Diastolic { get; set; }
        public BPMeasurementAssessment BPAssessment { get; set; }

        public int PulseRate { get; set; }
        public int RespiratoryRate { get; set; }
        public int HeartRate { get; set; }
        public bool NormalRate { get; set; }    //yes or no
        public bool RegularRhythm { get; set; } //yes or no
        
        public decimal TemperatureC { get; set; }
        public decimal WeightKgms { get; set; }     //in viewmodel add weightInPounds
        public WeightCategory WeightCategory{ get; set; }
        public decimal HeightCm { get; set; }       //in viewmodel add Height in feet and inches
        public HeightCategory HeightCategory { get; set; }
        public decimal WaistCircumferenceCm { get; set; }   //in viewmodel add waistcircumference in inches
        public BMICategory BodyMassIndex { get; set; }        //Computed

        public string Remarks { get; set; }

        public long EmployeeId { get; set; }
        public virtual Employee AdministeredBy { get; set; } //Baded On LogIn
    }
}
