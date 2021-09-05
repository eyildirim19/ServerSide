using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C_ModelsApp.Models
{
    /// <summary>
    /// Makale bilgilerini tutan entity
    /// </summary>
    public class Makale
    {
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public int KategoriID { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual List<Yorum> Yorum { get; set; }
    }
}