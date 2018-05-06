using System;

namespace HealthWebApp2._0.Data.EntityModel.Admin
{
    public class EmploymentRecord
    {
        public long Id { get; set; }
        public long PersonId { get; set; }
        public long EmployeeIdentification { get; set; }
        public string Agency { get; set; }   //Department, Office, Company
        public Position Position { get; set; }
        public string PayGrade { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public EmploymentStatus Status { get; set; }
        public String Notes { get; set; }
    }
}