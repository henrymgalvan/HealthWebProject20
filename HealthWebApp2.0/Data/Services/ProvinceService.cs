using HealthWebApp2._0.Data.EntityModel.Barangays;
using HealthWebApp2._0.Data.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.Services
{
    public class ProvinceService : IProvince
    {
        private ApplicationDbContext _context;
        public ProvinceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Province newProvince)
        {
            _context.Add(newProvince);
            _context.SaveChanges();
        }

        public IEnumerable<Province> Getall()
        {
            return _context.Province.ToList();
        }

        public Province Get(int Id)
        {
            return Getall().FirstOrDefault(p => p.Id == Id);
        }

        public void Update(Province UpdatedProvince)
        {
            _context.Entry(UpdatedProvince).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            Province province = _context.Province.FirstOrDefault(p => p.Id == Id);
            _context.Province.Remove(province);
            _context.SaveChanges();
        }

        public int GetId(string province)
        {
            return _context.Province.FirstOrDefault(p => p.Name == province).Id;
        }
    }
}
