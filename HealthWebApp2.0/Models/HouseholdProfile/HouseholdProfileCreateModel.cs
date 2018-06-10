using System;
using System.ComponentModel.DataAnnotations;

namespace HealthWebApp2._0.Models.HouseholdProfile
{
    public class HouseholdProfileCreateModel
    {
        [Display(Name="Profile Id")]
        [StringLength(12), RegularExpression(@"^[0-9]*")]
        public string ProfileId { get; set; }
        public string Address { get; set; }

        [Display(Name = "Barangay")]
        public long BarangayId { get; set; }

        [Display(Name = "City")]
        public long CityId { get; set; }

        [Display(Name = "Province")]
        public long ProvinceId { get; set; }

        public string Note { get; set; }
    }
}
