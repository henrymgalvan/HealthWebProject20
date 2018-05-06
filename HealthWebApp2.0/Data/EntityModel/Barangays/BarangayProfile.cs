
using HealthWebApp2._0.Data.EntityModel.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Barangays
{
    public class BarangayProfile
    {
        public long Id { get; set; }
        public long BarangayId { get; set; }
        public virtual Barangay Barangay { get; set; }

        public virtual IEnumerable<BarangayOfficial> BarangayOfficials { get; set; }
        public virtual IEnumerable<Population> Population { get; set; }

        public virtual IEnumerable<Employee> BarangayNurses { get; set; }
        public virtual IEnumerable<Employee> BarangayHealthWorkers { get; set; }
        public virtual IEnumerable<Employee> BarangayPhysicians { get; set; }

    }
}
