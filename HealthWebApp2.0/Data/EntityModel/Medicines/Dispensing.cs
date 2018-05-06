using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Medicines
{
    public class Dispensing
    {
        public long Id { get; set; }
        //Source of Prescription
        public bool Others { get; set; } //specify source
        public bool Facility { get; set; }

        public string DrugCode { get; set; }
        public int Quantity { get; set; }
        public string Remarks { get; set; }
        public DateTime DispensingDate { get; set; }
        public long DispenseBy { get; set; }

    }
}
