namespace K_AjaxRequestApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temptablom2
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Deger { get; set; }
    }
}
