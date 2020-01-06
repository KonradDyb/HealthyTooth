using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyTooth.Models
{
    public class Visit
    {
        public int VisitId { get; set; }
        public List<VisitDetail> VisitDetails { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime VisitDateTime { get; set; }
        public DateTime VisitPlaced { get; set; }
    }
}
