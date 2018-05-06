using HealthWebApp2._0.Data.EntityModel.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{
    public enum TypeOfDelivery
    {
        Normal = 1, CS =2
    }

    public enum PlaceOfBirthCategory
    {
        Home = 1, Hospital = 2, BirthingHome = 3, PublicPlace = 4
    }

    public class ChildBirthRecord
    {
        public long Id { get; set; }
        public long PersonId { get; set; }
        public virtual Person  Person { get; set; }

        public int Months { get; set; }
        public int Weeks { get; set; }
        public int Days { get; set; }
        public TypeOfDelivery TypeOfDelivery { get; set; }
        public decimal BirthWeightLbs { get; set; }
        public decimal BirthLengthCm { get; set; }
        public decimal HeadCircumferenceCm { get; set; }
        public decimal ChestCircumferenceCm { get; set; }
        public decimal AbdominalCircumferenceCm { get; set; }

        public long EmployeeId { get; set; }
        public virtual Employee AdministeredBy { get; set; }

        public PlaceOfBirthCategory PlaceOfBirthCategory { get; set; }
        public string  PlaceOfBirth { get; set; }

        public string Notes { get; set; }

    }
}
