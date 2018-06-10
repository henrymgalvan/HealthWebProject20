using HealthWebApp2._0.Data.EntityModel.Household;
using System.Collections.Generic;
 
namespace HealthWebApp2._0.Models.HouseholdProfile
{
    public class HouseholdProfileIndexModel
    {
        public IEnumerable<HouseholdProfileDetailModel> Households { get; set; }
    }
}
