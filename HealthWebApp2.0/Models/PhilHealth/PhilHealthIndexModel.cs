using System;

namespace HealthWebApp2._0.Models.PhilHealth
{
    public class PhilHealthIndexModel
    {
        public long PersonId {get; set;}
        public string NameOfMember {get; set; }
        public string PhilHealthId { get; set; }
        public string StatusType { get; set; }
        public string Category { get; set; }
        //Sponsored
        public string Sponsored { get; set; }
        //Individually Paying Program (IPP)
        public string Individual { get; set; }
        //Employed
        public string EmployerType { get; set; }
        public bool Lifetime { get; set; }
        public DateTime DateAssigned { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}