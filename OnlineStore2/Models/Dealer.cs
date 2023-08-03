using OnlineStore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore2.Models
{
    public class Dealer
    {
        public int DealerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        public virtual ICollection<Brand> Brands { get; set; }
        public virtual ICollection<Motorcycle> Motorcycles { get; set; }
    }
}