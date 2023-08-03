using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineStore2.Models
{
    public class Cart
    {
        [Key]
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<DateTime> DateCreated { get; set; }
        [ForeignKey("Motorcycle")] // Define the foreign key relationship
        public Nullable<int> MotorcycleId { get; set; }
        public Motorcycle Motorcycle { get; set; }
    }
}