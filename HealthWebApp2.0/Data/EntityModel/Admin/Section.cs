using System.Collections.Generic;

namespace HealthWebApp2._0.Data.EntityModel.Admin
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual IEnumerable<Position> Positions { get; set; }

        public virtual IEnumerable<Employee> Staffs { get; set; }
    }
}