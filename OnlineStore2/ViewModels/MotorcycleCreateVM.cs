using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using OnlineStore2.Models;

namespace OnlineStore2.ViewModels
{
    public class MotorcycleCreateVM
    {
        public Motorcycle Motorcycle { get; set; }

        [Display(Name = "Select Dealers")]
        public List<int> SelectedDealerIds { get; set; }

        public IEnumerable<SelectListItem> AllDealers { get; set; }
    }
}
