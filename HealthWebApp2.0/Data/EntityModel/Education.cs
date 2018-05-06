namespace HealthWebApp2._0.Data.EntityModel
{
    //Highest Educational Attainment 
    public class Education
    {
        
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }

        public long EmployeeId { get; set; }
    }
}