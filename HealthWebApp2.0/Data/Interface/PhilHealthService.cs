using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthWebApp2._0.Data.EntityModel.PhilHealthFolder;

namespace HealthWebApp2._0.Data.Interface
{
    public class PhilHealthService : IPhilHealth
    {
        void IPhilHealth.Add(PhilHealth newPhilHealth)
        {
            throw new NotImplementedException();
        }

        void IPhilHealth.Delete(long Id)
        {
            throw new NotImplementedException();
        }

        PhilHealth IPhilHealth.Get(long Id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<PhilHealth> IPhilHealth.Getall()
        {
            throw new NotImplementedException();
        }

        void IPhilHealth.Update(PhilHealth updatedPhilHealth)
        {
            throw new NotImplementedException();
        }
    }
}
