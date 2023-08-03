using OnlineStore2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineStore2.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public Nullable<int> OrderId { get; set; }
        public Nullable<int> MotorcycleId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }

        public virtual Motorcycle Motorcycle { get; set; }
        public virtual Order Order { get; set; }
    }
}