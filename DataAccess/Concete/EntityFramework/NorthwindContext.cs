using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını bağlamak
    //DbContext : Entitiy framework contextidir. Bağlantıyı sağlar.
    public class NorthwindContext : DbContext
    {
        //Proje hangi veritabanı ile ilişkili bunu belirtiriz.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=BDH-5CG8105D81\SQLEXPRESS;Database=Northwind; Trusted_Connection=true"); //sqlserver kullanacağız.
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
