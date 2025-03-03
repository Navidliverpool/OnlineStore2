﻿using System.ComponentModel.DataAnnotations;

namespace OnlineStore2.Models
{
    public class DealerMetaData
    {
        //[Required]
        //[StringLength(20)]
        public string Name { get; set; }
        //[Required]
        //[StringLength(20)]
        public string Address { get; set; }
        //[Required]
        //[Range(1, 11)]
        public int PhoneNumber { get; set; }
    }

    [MetadataType(typeof(DealerMetaData))]
    public partial class Dealer
    {
    }
}