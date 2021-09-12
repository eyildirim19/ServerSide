using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace I_ScafoldingTemplates.Models
{
    public class Ogrenci
    {
        public int ID { get; set; }

        [Display(Name = "Adı")]
        public string Adi { get; set; }

        [Display(Name = "SoyAdı")]
        public string SoyAdi { get; set; }

        [Display(Name = "Email Adresi")]
        public string Email { get; set; }
    }
}