using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyTooth.Models
{
    public class VisitSummary
    {
        private readonly AppDbContext _appDbContext;

        public string VisitSummaryId { get; set; }

        public List<VisitSummaryItem> VisitSummaryItems { get; set; }

        private VisitSummary(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        // give this method access to the services collection
        // managed by dependency injection container
        public static VisitSummary GetSummary(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<AppDbContext>();

            string summaryId= session.GetString("SummaryId") ?? Guid.NewGuid().ToString();
            // return this value if it isn't null ?? otherwise return this value

            session.SetString("SummaryId", summaryId); // guid string will be stored in the session


            return new VisitSummary(context) { VisitSummaryId = summaryId };
            // create an instance of the shopping cart, passing in that cart ID. 
        }

        public void AddToSummary (Doctor Doctor)
        {
            var visitSummaryItem =
                    _appDbContext.VisitSummaryItems.SingleOrDefault(
                        s => s.Doctor.DoctorId == Doctor.DoctorId && s.VisitSummaryId == VisitSummaryId);

            if (visitSummaryItem == null)
            {
                visitSummaryItem = new VisitSummaryItem
                {
                    VisitSummaryId = VisitSummaryId,
                    Doctor = Doctor
                };

                _appDbContext.VisitSummaryItems.Add(visitSummaryItem);
            }
           
            _appDbContext.SaveChanges();

        }

       

        public List<VisitSummaryItem> GetVisitSummaryItems()
        {
            return VisitSummaryItems ??
                   (VisitSummaryItems =
                       _appDbContext.VisitSummaryItems.Where(c => c.VisitSummaryId == VisitSummaryId)
                           .Include(s => s.Doctor)
                           .ToList());
        }

        public void ClearSummary()
        {
            var summaryItems = _appDbContext
                .VisitSummaryItems
                .Where(x => x.VisitSummaryId == VisitSummaryId);

            _appDbContext.VisitSummaryItems.RemoveRange(summaryItems);

            _appDbContext.SaveChanges();
        }

        
    }
}
