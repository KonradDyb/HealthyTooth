using HealthyTooth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyTooth.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Doctor> Doctors { get; set; }
    }
}
