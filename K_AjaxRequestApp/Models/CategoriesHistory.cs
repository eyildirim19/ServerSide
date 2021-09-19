namespace K_AjaxRequestApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CategoriesHistory")]
    public partial class CategoriesHistory
    {
        public int ID { get; set; }

        public int? CategoryID { get; set; }

        [StringLength(50)]
        public string OldName { get; set; }

        [StringLength(50)]
        public string NewName { get; set; }

        public DateTime? CreDate { get; set; }
    }
}
