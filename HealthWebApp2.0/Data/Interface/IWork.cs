using System.Collections.Generic;
using HealthWebApp2._0.Data.EntityModel;

namespace HealthWebApp2._0.Data.Interface
{
    public interface IWork
    {
        IEnumerable<Work> Getall();
        Work Get(int Id);
        void Add(Work newWork);
        void Update(Work updatedWork);
        void Delete(int Id);
         
    }
}