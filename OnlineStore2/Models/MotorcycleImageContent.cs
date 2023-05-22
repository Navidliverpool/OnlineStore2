using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineStore2.Models;

namespace OnlineStore2.ViewModels
{
    public class MotorcycleImageContent
    {
        Motorcycle _motorcycle = new Motorcycle();
        public MotorcycleImageContent(Motorcycle motorcycle)
        {
            _motorcycle = motorcycle;
            Model = _motorcycle.Model;
            Price = _motorcycle.Price;
            Name = _motorcycle.Brand.Name;
            MotoCategory = _motorcycle.Category.MotoCategory;
        }
        public string Model { get; set; }
        public double Price { get; set; }
        public string Name{ get; set; }
        public string MotoCategory { get; set; }
    
    }
}