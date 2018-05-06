using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Barangays
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int PhilAreaId { get; set; }
        public virtual PhilArea PhilArea { get; set; }

        public virtual IEnumerable<Province> Provinces { get; set; }


    }
}
