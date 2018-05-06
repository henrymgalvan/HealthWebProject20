using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.OutPatient.ICD
{
    public class ICD10
    {
        public long Id { get; set; }
        public string ICDCode { get; set; }
        public string ShortTitle { get; set; }
        public string ICDDescription { get; set; }

    }
}
