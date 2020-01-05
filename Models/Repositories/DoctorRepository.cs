using HealthyTooth.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyTooth.Models.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly AppDbContext _appDbContext;

        public DoctorRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Doctor> AllDoctors => _appDbContext.Doctors;

        public Doctor GetDoctorById(int doctorId)
        {
            return _appDbContext.Doctors.FirstOrDefault(x => x.DoctorId == doctorId);
        }
    }
}
