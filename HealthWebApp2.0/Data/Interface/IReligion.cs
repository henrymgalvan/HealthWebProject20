using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthWebApp2._0.Data.EntityModel;

namespace HealthWebApp2._0.Data.Interface
{
    public interface IReligion
    {
        IEnumerable<Religion> Getall();
        Religion Get(int Id);
        void Add(Religion newReligion);
        void Update(Religion updatedReligion);
        void Delete(int Id);
    }
}
