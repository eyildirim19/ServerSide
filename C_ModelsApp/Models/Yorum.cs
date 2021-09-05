using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C_ModelsApp.Models
{
    public class Yorum
    {
        public int ID { get; set; }

        public DateTime Tarih { get; set; }

        public string Nick { get; set; }

        public string Icerik { get; set; }

        public int MakaleID { get; set; }

        public virtual Makale Makale { get; set; }
    }
}