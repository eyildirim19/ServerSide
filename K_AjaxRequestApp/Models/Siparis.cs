namespace K_AjaxRequestApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Siparis
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SiparisId { get; set; }

        public DateTime? CreDate { get; set; }

        [StringLength(50)]
        public string UserId { get; set; }
    }
}
