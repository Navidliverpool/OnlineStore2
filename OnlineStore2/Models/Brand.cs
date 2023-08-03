using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineStore2.Models
{
    public partial class Brand
    {
        [Key]
        public int BrandId { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public virtual ICollection<Motorcycle> Motorcycles { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Dealer> Dealers { get; set; }
    }
}