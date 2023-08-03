﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore2.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal? Total { get; set; }
        public DateTime? OrderDate { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}