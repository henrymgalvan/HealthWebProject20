using System.Collections.Generic;
using HealthWebApp2._0.Data.EntityModel;
using HealthWebApp2._0.Data.Interface;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using HealthWebApp2._0.Data.EntityModel.Household;

namespace HealthWebApp2._0.Data.Services
{
    public class HouseholdMemberService : IHouseholdMember
    {
        private ApplicationDbContext _context;
        public HouseholdMemberService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(HouseholdMember newHouseholdMember)
        {
            _context.Add(newHouseholdMember);
            _context.SaveChanges();
        }

        public void Delete(long HouseholdMemberId)
        {
            HouseholdMember householdMember = _context.HouseholdMember.FirstOrDefault(p => p.PersonId == HouseholdMemberId);
            _context.HouseholdMember.Remove(householdMember);
            _context.SaveChanges();
        }

        public HouseholdMember Get(long Id)
        {
            return _context.HouseholdMember
                .Include(p => p.Person)
                .Include(hp => hp.HouseholdProfile)
                .FirstOrDefault(p => p.PersonId == Id);
        }

        public IEnumerable<HouseholdMember> GetAll()
        {
            return _context.HouseholdMember
                .Include(p => p.Person)
                .Include(h => h.HouseholdProfile);
                //.ToList();
        }

        public IEnumerable<HouseholdMember> GetAllByHouseholdProfileId(long householdProfileId)
        {
            return _context.HouseholdMember
                .Include(m => m.Person)
                .Where(p => p.HouseholdProfileId == householdProfileId);
                //.ToList();
        }

        public Person GetFather(long FatherId)
        {
            return _context.People.FirstOrDefault(p => p.Id == FatherId);
        }

        public Person GetMemberDetail(long PersonId)
        {
            return _context.People.FirstOrDefault(p => p.Id == PersonId);
        }

        public Person GetMother(long MotherId)
        {
            return _context.People.FirstOrDefault(p => p.Id == MotherId);
        }
    }
}
