using HealthWebApp2._0.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthWebApp2._0.Data.EntityModel;
using HealthWebApp2._0.Data.EntityModel.Barangays;

namespace HealthWebApp2._0.Data.Services
{
    public class BarangayService : IBarangay
    {
        private ApplicationDbContext _context;
        public BarangayService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Barangay> GetAll()
        {
            return _context.Barangay.ToList();
        }

        public Barangay GetBarangayById(int id)
        {
            return _context.Barangay.FirstOrDefault(b => b.Id == id);
        }
    }
}
