using OnlineStore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore2.Models
{
    public class Motorcycle
    {
        public int MotorcycleId { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public byte[] Image { get; set; }
        public int? BrandId { get; set; }
        //[ForeignKey("Brand")] // Define the foreign key relationship
        public virtual Brand Brand { get; set; }
        public int? CategoryId { get; set; }
        //[ForeignKey("Category")] // Define the foreign key relationship
        public virtual Category Category { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<OnlineStore2.Models.OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Dealer> Dealers { get; set; }
    }
}