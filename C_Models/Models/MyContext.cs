using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace C_Models.Models
{
    public class MyContext : DbContext
    {
        public MyContext() : base("constr")
        {
        }

        public DbSet<Urun> Uruns { get; set; }
    }
}