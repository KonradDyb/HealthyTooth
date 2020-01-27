using HealthyTooth.Models;
using HealthyTooth.Models.Repositories.Interfaces;
using HealthyTooth.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyTooth.Controllers
{
    public class VisitSummaryController : Controller
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly VisitSummary _visitSummary;

        public VisitSummaryController(IDoctorRepository doctorRepository, VisitSummary visitSummary)
        {
            _doctorRepository = doctorRepository;
            _visitSummary = visitSummary;
        }

        public IActionResult Index()
        {
            var items = _visitSummary.GetVisitSummaryItems();
            _visitSummary.VisitSummaryItems = items;

            var visitSummaryViewModel = new VisitSummaryViewModel
            {
                VisitSummary = _visitSummary,
            };

            return View(visitSummaryViewModel);
        }

        public RedirectToActionResult AddToVisitSummary(int doctorId)
        {
            var selectedDoctor = _doctorRepository.AllDoctors.FirstOrDefault(x => x.DoctorId == doctorId);

            if (selectedDoctor != null)
            {
                _visitSummary.AddToSummary(selectedDoctor);
            }

            return RedirectToAction("Index");
        }
    }
}
