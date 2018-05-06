using HealthWebApp2._0.Data.EntityModel;

namespace HealthWebApp2._0.Data.EntityModel.Barangays
{
    public class BarangayOfficial
    {
        public long Id { get; set; }
        public long BarangayId { get; set; }
        public virtual Barangay Barangay { get; set; }
        public long PersonId { get; set; }
        public virtual Person Officer { get; set; }
        public int DesignationId { get; set; }
        public virtual Designation Position { get; set; }
    }
}