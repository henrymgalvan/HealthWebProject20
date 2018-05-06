using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Admin
{
    public class Organization
    {
        public long Id { get; set; }
        public long PersonId { get; set; }
        public string NameOfOrganization { get; set; }
        public string Address { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NoOfHours { get; set; }
        public string Position { get; set; }  //or nature of work

    }
}
