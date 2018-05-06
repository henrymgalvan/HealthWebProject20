using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Admin
{
    public enum Level
    {
        Elementary = 1, Secondary = 2,
        VocationalTradeCourse = 3, College = 4,
        GraduateStudies =5

    }
    public class EducationalBackground
    {
        public long Id { get; set; }
        public long EmployeeId { get; set; }
        public Level Level { get; set; }
        public long SchoolId { get; set; }
        public string Course { get; set; }
        public DateTime StartDate { get; set; }     //Period of Attendance
        public DateTime EndDate { get; set; }
        public string UnitsEarned { get; set; }      //HighestLevel Earned
        public int YearGraduated { get; set; }
        public string HonorsReceived { get; set; }   //Scholarship/AcademicHonors


    }
}
