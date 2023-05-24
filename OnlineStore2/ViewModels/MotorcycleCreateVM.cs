﻿using OnlineStore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestUsersCopy.ViewModels
{
    public class MotorcycleCreateVM
    {
        public int MotorcycleId { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        //public byte[] Image { get; set; }
        public HttpPostedFileBase ImageFile { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public ICollection<string> Dealers { get; set; }

    }
}