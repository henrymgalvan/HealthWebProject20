using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel
{
    public class Family
    {
        public long Id { get; set; }

        public long PersonId { get; set; }
        public virtual Person Person { get; set; }

        [ForeignKey("Person")]
        public long FatherId { get; set; }
        public virtual Person Father { get; set; }

        [ForeignKey("Person")]
        public long MotherId { get; set; }
        public virtual Person Mother { get; set; }

        [ForeignKey("Person")]
        public long SpouseId { get; set; }
        public virtual Person Spouse { get; set; }

        public virtual ICollection<Person> Children { get; set; }
        public virtual ICollection<Person> Siblings { get; set; }
    }
}
