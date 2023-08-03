using OnlineStore2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineStore2.Models
{
    public class MotorcycleDealer
    {
        [Key]
        public int MotorcycleId { get; set; }
        public Motorcycle Motorcycle { get; set; }
        public int DealerId { get; set; }
        public Dealer Dealer { get; set; }
    }
}