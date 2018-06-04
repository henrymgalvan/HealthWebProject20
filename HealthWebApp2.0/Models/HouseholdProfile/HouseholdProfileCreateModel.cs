using System;

namespace HealthWebApp2._0.Models.HouseholdProfile
{
    public class HouseholdProfileCreateModel
    {
        public string ProfileId { get; set; }
        public string Address { get; set; }
        public long BarangayId { get; set; }
        public string BarangayName { get; set; }

        public long CityId { get; set; }
        public string CityName { get; set; }

        public long ProvinceId { get; set; }
        public string ProvinceName { get; set; }

        public string Note { get; set; }
        public DateTime DateCreated { get; set; }
        public long EmployeeId { get; set; }
    }
}
