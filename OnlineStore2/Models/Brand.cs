using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore2.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }

        public virtual ICollection<Motorcycle> Motorcycles { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Dealer> Dealers { get; set; }
    }
}