using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Entity.Context
{
    public class ProductBrandDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public ProductBrandDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasRequired(p => p.ProductBrand)
                .WithMany(p => p.Products)
                .HasForeignKey(fk => fk.IdBrand)
                .WillCascadeOnDelete(true);
        }
    }
}
