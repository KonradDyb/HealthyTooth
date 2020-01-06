using HealthyTooth.Models.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyTooth.Models.Repositories
{
    public class VisitRepository : IVisitRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly VisitSummary _visitSummary;

        public VisitRepository(AppDbContext appDbContext, VisitSummary visitSummary)
        {
            _appDbContext = appDbContext;
            _visitSummary = visitSummary;
        }

        public void CreateVisit(Visit visit)
        {
            visit.VisitPlaced = DateTime.Now;

            var visitSummaryItems = _visitSummary.VisitSummaryItems;
            visit.VisitDetails = new List<VisitDetail>();


            foreach (var visitSummaryItem in visitSummaryItems)
            {
                var visitDetails = new VisitDetail()
                {
                    DoctorId = visitSummaryItem.Doctor.DoctorId
                };

                visit.VisitDetails.Add(visitDetails);
            }

            _appDbContext.Visits.Add(visit);
            _appDbContext.SaveChanges();
        }
    }
}
