using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyTooth.Models
{
    public class Visit
    {
        [BindNever]
        public int VisitId { get; set; }
        public List<VisitDetail> VisitDetails { get; set; }
        [Required(ErrorMessage = "Wpisz imie")]
        [Display(Name = "First name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Wpisz nazwisko")]
        [Display(Name = "Last name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Wpisz nr telefonu")]
        [StringLength(9)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Wybierz date")]
        [StringLength(25)]
        public string VisitDateTime { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime VisitPlaced { get; set; }
    }
}
