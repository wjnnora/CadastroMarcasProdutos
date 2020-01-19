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
    public class BrandRepository : IRepositoryGeneric<Brand>
    {
        public void Delete(Brand entity)
        {
            using (ProductBrandDbContext context = new ProductBrandDbContext())
            {
                context.Brands.Attach(entity);
                context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Task<List<Brand>> GetAll()
        {
            return Task.Run(() =>
            {
                using (ProductBrandDbContext context = new ProductBrandDbContext())
                {
                    return context.Brands.ToList();
                }
            });
            
        }

        public Brand GetById(int id)
        {
            using (ProductBrandDbContext context = new ProductBrandDbContext())
            {
                return context.Brands.Find(id);
            }
        }

        public void Insert(Brand entity)
        {
            using (ProductBrandDbContext context = new ProductBrandDbContext())
            {
                context.Brands.Add(entity);
                context.SaveChanges();
            }
        }

        public void Update(Brand entity)
        {
            using (ProductBrandDbContext context = new ProductBrandDbContext())
            {
                context.Brands.Attach(entity);
                context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
