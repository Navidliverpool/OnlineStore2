﻿using OnlineStore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore2.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string MotoCategory { get; set; }

        public virtual ICollection<Motorcycle> Motorcycles { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
    }
}