using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.PhilHealthFolder
{
    public enum StatusType
    {
        Member = 1, NonMember = 2, Dependent = 3
    }

    public enum TypeOfMembership
    {
        Sponsored = 1, IndividuallyPayingProgram = 2, Employed = 3, Lifetime = 4
    }

    public enum TypeOfSponsorship
    {
        NHTS = 1, LGU = 2, NGA = 3, Private =4
    }

    public enum IPP
    {
        OrganizedGroup = 1, OFW = 2
    }

    public enum EmployerType
    {
        Government = 1, Private = 2
    }


    public class PhilHealth
    {
        [Key]
        [ForeignKey("Person")]
        public long PersonId { get; set; }
        public virtual Person Person { get; set; }
        //set length to 12 digits
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
        public long EmployeeId { get; set; }


    }
}
