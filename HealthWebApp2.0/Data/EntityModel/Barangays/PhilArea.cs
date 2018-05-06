using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Barangays
{
    public class PhilArea
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Region> Regions { get; set; }

    }
}
