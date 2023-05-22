using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using OnlineStore2.Models;

namespace OnlineStore2.ViewModels
{
    public class MotorcycleVM
    {
        public Motorcycle Motorcycle { get; set; }
        public IEnumerable<SelectListItem> AllDealers { get; set; }
        private IEnumerable<int> _selectedDealers;
        public IEnumerable<int> SelectedDealers
        {
            get
            {
                if (_selectedDealers == null)
                {
                    _selectedDealers = Motorcycle.Dealers.Select(m => m.DealerId).ToList();
                }
                return _selectedDealers;
            }
            set { _selectedDealers = value; }
        }

        //public virtual ICollection<Dealer> AllDealersTest { get; set; }
        public IEnumerable<Motorcycle> Motorcycles { get; set; }
        //public IEnumerable<MotorcycleImageContent> MotorcycleImageContents { get; set; }
        //public IEnumerable<MotorcycleImageContent2> MotorcycleImageContents2 { get; set; }
        public List<MotorcycleImageContent2> ImagesContents { get; set; }

    }
}
