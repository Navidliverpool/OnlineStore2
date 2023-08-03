using OnlineStore2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineStore2.Models
{
    public class Motorcycle
    {
        [Key]
        public int MotorcycleId { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public byte[] Image { get; set; }
        public Nullable<int> BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Dealer> Dealers { get; set; }
    }
}