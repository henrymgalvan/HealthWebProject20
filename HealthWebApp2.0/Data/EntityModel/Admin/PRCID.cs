using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Admin
{
    public class PRCID
    {
        public long Id { get; set; }
        public long PersonId { get; set; }
        public string PRCId { get; set; }
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public DateTime DateAssigned { get; set; }
        public DateTime DateOfExpiration { get; set; }
        public string PlaceOfExamination_Conferment { get; set; }
        public string Note { get; set; }
    }
}
