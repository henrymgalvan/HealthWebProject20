using HealthWebApp2._0.Data.EntityModel.Barangays;
using HealthWebApp2._0.Data.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.Services
{
    public class CityService : ICity
    {
        private ApplicationDbContext _context;
        public CityService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(CityMunicipality newCity)
        {
            _context.Add(newCity);
            _context.SaveChanges();
        }

        public IEnumerable<CityMunicipality> Getall()
        {
            return _context.City.ToList();
        }

        public CityMunicipality Get(int Id)
        {
            return Getall().FirstOrDefault(p => p.Id == Id);
        }

        public void Update(CityMunicipality UpdatedCity)
        {
            _context.Entry(UpdatedCity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            CityMunicipality city = _context.City.FirstOrDefault(p => p.Id == Id);
            _context.City.Remove(city);
            _context.SaveChanges();
        }

        public int GetId(string city)
        {
            return _context.City.FirstOrDefault(c => c.Name == city).Id;
        }
    }
}

