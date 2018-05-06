using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Household
{
    public class Family
    {
        public long Id { get; set; }

        //[Key]
        //public long PersonId { get; set; }

        //public long FatherId { get; set; }
        //public virtual Person Father { get; set; }

        //public long MotherID { get; set; }
        //public virtual Person Mother { get; set; }

        //public virtual IEnumerable<Person> Siblings { get; set; }
    }
}
