using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyTooth.Models.Repositories.Interfaces
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> AllDoctors { get; }
        Doctor GetDoctorById(int doctorId);
    }
}
