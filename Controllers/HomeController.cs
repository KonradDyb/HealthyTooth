using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HealthyTooth.Models;
using HealthyTooth.Models.Repositories.Interfaces;
using HealthyTooth.ViewModels;

namespace HealthyTooth.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDoctorRepository _doctorRepository;

        public HomeController(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel();
            homeViewModel.Doctors = _doctorRepository.AllDoctors;
            return View(homeViewModel);
        }

        
    }
}
