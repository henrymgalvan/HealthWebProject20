using System.Collections.Generic;
using HealthWebApp2._0.Data.EntityModel;

namespace HealthWebApp2._0.Data.Interface
{
    public interface IPerson
    {
        IEnumerable<Person> Getall();
        Person Get(long Id);
        void Add(Person newPerson);
        void Update(Person updatedPerson);
        void Delete(long Id);
         
    }
}