using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace C_ModelsApp.Models
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext() : base("coni")
        {
        }

        public DbSet<Kategori> Kategori { get; set; }

        public DbSet<Makale> Makale { get; set; }

        public DbSet<Yorum> Yorum { get; set; }
    }
}