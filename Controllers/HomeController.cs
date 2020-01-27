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
        private readonly VisitSummary _visitSummary;

        public HomeController(IDoctorRepository doctorRepository, VisitSummary visitSummary)
        {
            _doctorRepository = doctorRepository;
            _visitSummary = visitSummary;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel();
            homeViewModel.Doctors = _doctorRepository.AllDoctors;
            ViewBag.Title = "Healthy Tooth";
            _visitSummary.ClearSummary();
            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var doctor = _doctorRepository.GetDoctorById(id);

            if (doctor == null) return NotFound();

            return View(doctor);
        }
    }
}
