using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Barangays
{
    public class CityMunicipality
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ProvinceId { get; set; }
        public virtual Province Province { get; set; }

        public IEnumerable<Barangay> Barangays { get; set; }

    }
}
