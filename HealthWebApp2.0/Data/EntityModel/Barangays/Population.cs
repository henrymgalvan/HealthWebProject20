namespace HealthWebApp2._0.Data.EntityModel.Barangays
{
    public class Population
    {
        public long Id { get; set; }
        public long BarangayId { get; set; }
        public int Year { get; set; }
        public int Total { get; set; }
        public int NoOfHousehold { get; set; }
        public int NoOfFamilies { get; set; }
    }
}