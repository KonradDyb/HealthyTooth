﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyTooth.Models
{
    public class VisitDetail
    {
        public int VisitDetailId { get; set; }
        public int VisitId { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public Visit Visit { get; set; }
    }
}
