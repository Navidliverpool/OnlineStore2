using OnlineStore2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineStore2.Models
{
    public class BrandCategory
    {
        [ForeignKey("Brand")] // Define the foreign key relationship
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        [ForeignKey("Category")] // Define the foreign key relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}