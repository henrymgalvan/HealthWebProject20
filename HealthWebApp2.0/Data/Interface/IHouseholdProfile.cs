using HealthWebApp2._0.Data.EntityModel;
using HealthWebApp2._0.Data.EntityModel.Household;
using System.Collections.Generic;

namespace HealthWebApp2._0.Data.Interface
{
    public interface IHouseholdProfile
    {
        IEnumerable<HouseholdProfile> GetAll();
        IEnumerable<HouseholdProfile> GetallByBarangay(long BarangayId);

        HouseholdProfile GetByPersonId(long PersonId);
        HouseholdProfile GetById(long id);
        HouseholdProfile GetByProfileId(string ProfileId);

        void Add(HouseholdProfile newHouseholdProfile);
        void Update(HouseholdProfile updatedHouseholdProfile);

    }
}
