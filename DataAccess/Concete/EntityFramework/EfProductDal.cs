using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entitiy)
        {
            using (NorthwindContext context =new NorthwindContext()) // using bittiğinde belleği temizler.
            {
                var addedEntitiy = context.Entry(entitiy); //Eklenen varlık.
                addedEntitiy.State = EntityState.Added; 
                context.SaveChanges();
            }
        }

        public void Delete(Product entitiy)
        {
            using (NorthwindContext context = new NorthwindContext()) // using bittiğinde belleği temizler.
            {
                var deletedEntitiy = context.Entry(entitiy); //Eklenen varlık.
                deletedEntitiy.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext()) // using bittiğinde belleği temizler.
            {
                return context.Set<Product>().First(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext()) // using bittiğinde belleği temizler.
            {
                return filter == null 
                    ? context.Set<Product>().ToList() 
                    : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entitiy)
        {
            using (NorthwindContext context = new NorthwindContext()) // using bittiğinde belleği temizler.
            {
                var updateEntitiy = context.Entry(entitiy); //Eklenen varlık.
                updateEntitiy.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
