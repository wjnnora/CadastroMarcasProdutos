using Domain;
using Repository.Commom;
using Service.Entity.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.EF
{
    public class ProductRepository : IRepositoryGeneric<Product>
    {
        public void Delete(Product entity)
        {
            using (ProductBrandDbContext context = new ProductBrandDbContext())
            {
                context.Products.Attach(entity);
                context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Task<List<Product>> GetAll()
        {
            return Task.Run(() =>
            {
                using (ProductBrandDbContext context = new ProductBrandDbContext())
                {
                    return context.Products.Include("ProductBrand").ToList();
                }
            });            
        }

        public Product GetById(int id)
        {
            using (ProductBrandDbContext context = new ProductBrandDbContext())
            {
                return context.Products.Include("ProductBrand").Single(x => x.Id == id);
            }
        }

        public void Insert(Product entity)
        {
            using (ProductBrandDbContext context = new ProductBrandDbContext())
            {
                Brand productBrand = context.Brands.Find(entity.IdBrand);
                entity.ProductBrand = productBrand;
                context.Products.Add(entity);
                context.SaveChanges();
            }
        }

        public void Update(Product entity)
        {
            using (ProductBrandDbContext context = new ProductBrandDbContext())
            {
                Brand productBrand = context.Brands.Find(entity.IdBrand);
                entity.ProductBrand = productBrand;
                context.Products.Attach(entity);
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
