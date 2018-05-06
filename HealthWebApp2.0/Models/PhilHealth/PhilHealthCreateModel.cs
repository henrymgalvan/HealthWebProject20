using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthWebApp2._0.Data.EntityModel.PhilHealthFolder;

namespace HealthWebApp2._0.Models.PhilHealth
{
    public class PhilHealthCreateModel
    {
        public long PersonId {get; set;}
        public String NameOfMember {get; set; }
        public string PhilHealthId { get; set; }
        public StatusType StatusType { get; set; }
        public TypeOfMembership Category { get; set; }
        //Sponsored
        public TypeOfSponsorship Sponsored { get; set; }
        //Individually Paying Program (IPP)
        public IPP Individual { get; set; }
        //Employed
        public EmployerType EmployerType { get; set; }
        public bool Lifetime { get; set; }
        public DateTime DateAssigned { get; set; }
        public DateTime ExpirationDate { get; set; }


    }
}
