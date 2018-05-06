using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Admin
{
    public class CivilServiceID
    {
        public long Id { get; set; }
        public string CivilServiceId { get; set; }
        public string ShortTitle { get; set; }
        public string LongTitle { get; set; }

        public decimal Rating { get; set; }
        public DateTime DateOfExamination { get; set; }
        public string PlaceOfExamination { get; set; }

    }
}
