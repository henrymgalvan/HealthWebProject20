using HealthWebApp2._0.Data.EntityModel;
using HealthWebApp2._0.Data.EntityModel.Barangays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.Interface
{
    public interface IBarangay
    {
        IEnumerable<Barangay> GetAll();
        Barangay GetBarangayById(int id);
    }
}
