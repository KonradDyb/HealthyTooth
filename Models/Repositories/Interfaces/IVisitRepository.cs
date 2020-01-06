using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyTooth.Models.Repositories.Interfaces
{
    public interface IVisitRepository
    {
        void CreateVisit(Visit visit);
    }
}
