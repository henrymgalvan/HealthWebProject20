
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient
{
    public class SurgicalHistory
    {
        public long Id { get; set; }
        public string Operation { get; set; }
        public DateTime DateofSurgery { get; set; }
        public string StatusOfOperation { get; set; }


    }
}
