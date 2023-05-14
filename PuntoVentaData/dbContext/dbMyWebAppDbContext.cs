using PuntoVentaData.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVentaData.dbContext
{
    public class dbMyWebAppDbContext: DbContext
    {
        public dbMyWebAppDbContext(string ConnectionString): base(ConnectionString)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>().ToTable("Product");
        //    modelBuilder.Entity<Product>().ToTable("Category");
        //}
    }
}
