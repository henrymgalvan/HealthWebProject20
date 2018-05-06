using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Medicines
{
    public enum UnitForm
    {
        Tablet = 1, Capsule = 2, Bottle = 3, Sachet = 4, tube = 5 
    }
    //public enum UnitDescription
    //{

    //}
    public class MedicineInventory
    {

        //Inventory Drugs, All Drugs
        public long Id { get; set; }
        public string DrugCode { get; set; }
        public string DrugName { get; set; }
        public string DrugDescription { get; set; }
        public UnitForm Unit { get; set; }
        public string UnitDetail { get; set; }  // mg, ml, 
        public int OnStock { get; set; }

    }
}
