namespace J_MVCControllerWithAction.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ogrencis
    {
        public int ID { get; set; }

        [Required]
        public string Adi { get; set; }

        [Required]
        public string SoyAdi { get; set; }
    }
}
