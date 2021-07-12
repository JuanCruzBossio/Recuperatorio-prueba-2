using Recuperatorio_prueba_2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Recuperatorio_prueba_2.Data
{
    public class AfiliadoDbContext : DbContext
    {
        public AfiliadoDbContext()
        : base("DefaultConnection")
        {
        }
        public DbSet<Afiliado> Afiliados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}