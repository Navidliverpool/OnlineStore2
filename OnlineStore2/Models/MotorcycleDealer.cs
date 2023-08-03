using OnlineStore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore2.Models
{
    public class MotorcycleDealer
    {
        public int MotorcycleId { get; set; }
        public Motorcycle Motorcycle { get; set; }
        public int DealerId { get; set; }
        public Dealer Dealer { get; set; }
    }
}