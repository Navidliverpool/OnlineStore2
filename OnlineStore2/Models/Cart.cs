using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore2.Models
{
    public class Cart
    {
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int? Count { get; set; }
        public DateTime? DateCreated { get; set; }
        //[ForeignKey("Motorcycle")] // Define the foreign key relationship
        public int? MotorcycleId { get; set; }
        public Motorcycle Motorcycle { get; set; }
    }
}