using HealthWebApp2._0.Data.EntityModel.Barangays;
using System.Collections.Generic;

namespace HealthWebApp2._0.Data.Interface
{
    public interface ICity
    {
        IEnumerable<CityMunicipality> Getall();
        CityMunicipality Get(int Id);
        void Add(CityMunicipality newCity);
        void Update(CityMunicipality updatedCity);
        void Delete(int Id);
    }
}
