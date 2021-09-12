using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace I_ScafoldingTemplateApp.Models
{
    public class BtAkademiDbContext : DbContext
    {
        public BtAkademiDbContext() : base("con")
        {
        }

        public DbSet<Ogrenci> Ogrencis { get; set; }
    }
}