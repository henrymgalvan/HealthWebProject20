using HealthWebApp2._0.Data.EntityModel;
using HealthWebApp2._0.Data.EntityModel.Household;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.Interface
{
    public interface IHouseholdMember
    {
        IEnumerable<HouseholdMember> GetAll();
        IEnumerable<HouseholdMember> GetAllByHouseholdProfileId(long householdProfileId);
        HouseholdMember Get(long Id);
        Person GetMemberDetail(long PersonId);
        Person GetFather(long FatherId);
        Person GetMother(long MotherId);
        void Add(HouseholdMember newHouseholdMember);
        void Delete(long HouseholdMemberId);
    }
}
