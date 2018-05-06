using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Admin
{
    public enum Areas
    {
        Clerical = 1, IT = 2, Pharmacy = 3, Engineering = 4, OPD = 5, Laboratory = 6,
        Midwife = 7, Dental = 8, Sanitation = 9, Cashier = 10, Security = 11, Transport = 12,
        Supplies = 13 , AnimalBite = 14, Barangay = 15
    }
    public enum Designation
    {
        Physician = 1, Nurse = 2, BN = 3, Midwife = 4, MedTech = 5
    }

    public class AreaOfAssignment
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public Areas AreaAssigned { get; set; }
        public Designation Designation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

    }
}
