using HealthWebApp2._0.Data.EntityModel.Barangays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.Interface
{
    public interface IProvince
    {
        IEnumerable<Province> Getall();
        Province Get(int Id);
        void Add(Province newProvince);
        void Update(Province updatedProvince);
        void Delete(int Id);
    }
}

