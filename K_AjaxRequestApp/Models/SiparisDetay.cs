namespace K_AjaxRequestApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SiparisDetay")]
    public partial class SiparisDetay
    {
        public int Id { get; set; }

        public int? SiparisId { get; set; }

        public int? ProductId { get; set; }

        public int? Price { get; set; }
    }
}
