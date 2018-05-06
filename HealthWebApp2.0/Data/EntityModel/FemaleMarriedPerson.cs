using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel
{
    public class FemaleMarriedPerson
    {
        [Key]
        public long PersonId { get; set; }
        public string MaidenMiddleName { get; set; }
        public string MaidenLastName { get; set; }

        public virtual Person Person { get; set; }

    }
}
