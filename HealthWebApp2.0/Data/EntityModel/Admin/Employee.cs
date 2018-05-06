using HealthWebApp2._0.Data.EntityModel.Barangays;
using System.Collections.Generic;

namespace HealthWebApp2._0.Data.EntityModel.Admin
{
    public enum EmploymentStatus
    {
        Regular = 1, JOE = 2, EOC = 3, Terminated = 4, OnTheJobTraining = 5
    }
    public class Employee
    {
        public long Id { get; set; }
        public long PersonId { get; set; }
        public virtual Person Person { get; set; }
        public string EmployeeIdentification { get; set; }

        public virtual IEnumerable<EducationalBackground> Educations { get; set; }
        public IEnumerable<PRCID> PRCID { get; set; }

        public string GSIS { get; set; }
        public string SSS { get; set; }
        public string PagIbig { get; set; }
        public string TIN { get; set; }

        public int PositionId { get; set; }
        public virtual Position Position { get; set; }

        public int SectionId { get; set; }
        public virtual Section Section { get; set; }

        public virtual IEnumerable<AreaOfAssignment> AreaOfAssignments { get; set; }
        public EmploymentStatus EmployeeStatus { get; set; }
        public bool ActiveInService { get; set; }
        public virtual IEnumerable<EmploymentRecord> EmployeeRecords { get; set; }

        public string Note { get; set; }

    }
}
