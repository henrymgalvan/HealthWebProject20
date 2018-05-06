using HealthWebApp2._0.Data.EntityModel.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{
    public class ImmunizationRecord
    {
        public long Id { get; set; }
        public long PersonId { get; set; }
        public virtual Person Person { get; set; }

        public int VaccineId { get; set; }
        public virtual Vaccine Vaccine { get; set; }
        public DateTime DateReceived { get; set; }
        public long EmployeeId { get; set; }
        public virtual Employee AdministeredBy { get; set; }

        public string Notes { get; set; }


    }
}
