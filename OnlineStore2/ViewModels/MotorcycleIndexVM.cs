using OnlineStore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore2.ViewModels
{
    public class MotorcycleIndexVM
    {
        //public Motorcycle Motorcycle { get; set; }
        //public IEnumerable<MotorcycleImageContent2> ImagesContents { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public string BrandName { get; set; }
        public string Category { get; set; }
    }
}