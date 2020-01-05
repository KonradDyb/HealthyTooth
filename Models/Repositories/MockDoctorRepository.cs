using HealthyTooth.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyTooth.Models.Repositories
{
    public class MockDoctorRepository : IDoctorRepository
    {


        public IEnumerable<Doctor> AllDoctors =>
            new List<Doctor>
            {

                new Doctor {DoctorId = 1, Name="Cheese cake", ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", ImagePath="doctor1.jpg"},
                new Doctor {DoctorId = 2, Name="Rhubarb Doctor", ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",ImagePath="doctor2.jpg"},
                new Doctor {DoctorId = 3, Name="Pumpkin Doctor", ShortDescription="Lorem Ipsum", LongDescription="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",ImagePath="doctor3.jpg"}
            };

        public Doctor GetDoctorById(int doctorId)
        {
            return AllDoctors.FirstOrDefault(p => p.DoctorId == doctorId);
        }


    }
}
