using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyTooth.Models
{
    public class VisitSummaryItem
    {
        public int VisitSummaryItemId { get; set; }
        public Doctor Doctor { get; set; }
        public string VisitSummaryId { get; set; }
    }
}
