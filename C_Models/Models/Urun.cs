using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C_Models.Models
{
    public class Urun
    {
        public int ID { get; set; }

        public string Adi { get; set; }

        public decimal Fiyat { get; set; }

        public decimal EskiFiyat { get; set; }

        public string ImagePath { get; set; }

        public bool? IndirimVar { get; set; }

    }
}