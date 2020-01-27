using HealthyTooth.Models;
using HealthyTooth.Models.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyTooth.Controllers
{
    public class VisitController : Controller
    {
        private readonly IVisitRepository _visitRepository;
        private readonly VisitSummary _visitSummary;

        public VisitController(IVisitRepository visitRepository, VisitSummary visitSummary)
        {
            _visitRepository = visitRepository;
            _visitSummary = visitSummary;
        }

        public IActionResult CheckVisit()
        {
            return View();     
        }

        [HttpPost]
        public IActionResult CheckVisit(Visit visit)
        {
            var items = _visitSummary.GetVisitSummaryItems();
            _visitSummary.VisitSummaryItems = items;

            if (_visitSummary.VisitSummaryItems.Count == 0)
            {
                ModelState.AddModelError("", "Add visit first!");
            }

            if (ModelState.IsValid)
            {
                _visitRepository.CreateVisit(visit);
                _visitSummary.ClearSummary();
                return RedirectToAction("CheckVisitComplete");
            }

            return View(visit);
        }

        public IActionResult CheckVisitComplete()
        {
            ViewBag.Message = "Pomyślnie dodano wizyte.";

            return View();
        }

    }
}
