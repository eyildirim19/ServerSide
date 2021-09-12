using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace I_ScafoldingTemplateApp.Models
{
    public class Ogrenci
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Adı alanı zorunludur")] // Zorunlu Alan...
        [Display(Name = "Adı")]
        public string Adi { get; set; }

        [Required(ErrorMessage = "SoyAdı alanı zorunludur")] // Zorunlu Alan...
        [Display(Name = "SoyAdı")]
        public string SoyAdi { get; set; }
    }
}