using HealthWebApp2._0.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthWebApp2._0.Data.EntityModel;
using Microsoft.EntityFrameworkCore;
using HealthWebApp2._0.Data.EntityModel.Household;

namespace HealthWebApp2._0.Data.Services
{
    public class HouseholdProfileService : IHouseholdProfile
    {
        private ApplicationDbContext _context;
        public HouseholdProfileService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(HouseholdProfile newHouseholdProfile)
        {
            _context.Add(newHouseholdProfile);
            _context.SaveChanges();
        }

        public IEnumerable<HouseholdProfile> GetAll()
        {
            return _context.HouseholdProfile
                .Include(b => b.Barangay)
                .Include(c => c.Barangay.CityMunicipality)
                .Include(p => p.Barangay.CityMunicipality.Province)
                .ToList();
        }

        public IEnumerable<HouseholdProfile> GetallByBarangay(long BarangayId)
        {
            return _context.HouseholdProfile
                .Include(b => b.Barangay)
                .Where(b => b.BarangayId == BarangayId);
        }

        public HouseholdProfile GetById(long id)
        {
            return _context.HouseholdProfile
                .Include(b => b.Barangay)
                .Include(m => m.HouseholdMembers)
                .FirstOrDefault(hp => hp.Id == id);
        }

        public HouseholdProfile GetByPersonId(long PersonId)
        {
            throw new NotImplementedException();
        }

        public HouseholdProfile GetByProfileId(string ProfileId)
        {
            return _context.HouseholdProfile
                .Include(b => b.Barangay)
                .FirstOrDefault(hp => hp.ProfileId == ProfileId);
        }

        public void Update(HouseholdProfile updatedHouseholdProfile)
        {
            _context.Entry(updatedHouseholdProfile).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
