using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HealthWebApp2._0.Data.EntityModel.Barangays;
using HealthWebApp2._0.Data.EntityModel.GeoTagging;

namespace HealthWebApp2._0.Data.EntityModel.Household
{
    public class HouseholdProfile
    {
        [Key]
        public long Id { get; set; }
        public string ProfileId { get; set; }
        public string Address { get; set; }

        public long BarangayId { get; set; }
        public virtual Barangay Barangay { get; set; }
        //CityOrMunicipality
        //public int CityMunicipalityId { get; set; }
        //public virtual CityMunicipality City { get; set; }
        //Province
        //public int ProvinceId { get; set; }
        //public virtual Province Province { get; set; }
        //Region
        //public int RegionId { get; set; }
        //public virtual Region Region { get; set; }

        public string Note { get; set; }
        //public int GeotagId { get; set; }
        //public virtual GeoTag Geotag { get; set; }
        public virtual ICollection<HouseholdMember> HouseholdMembers { get; set; }
        public DateTime DateTimeLastUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public long EmployeeId { get; set; }
    }
}