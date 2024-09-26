using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1.Navigation_and_Propertys
{
    public static class NavigationAndPropertis
    {
        public static void NPCategories(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Categories>().Property(n => n.Name).HasMaxLength(50).IsRequired();
        }

        public static void NPCityes(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Cityes>().Property(n => n.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Cityes>().HasOne(c => c.Countries).WithMany(con => con.Cityes).HasForeignKey(c => c.CountriesId);

        }
        public static void NPCountries(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Countries>().Property(n => n.Name).HasMaxLength(50).IsRequired();


        }
        public static void NPPositions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Positions>().Property(n => n.Name).HasMaxLength(50).IsRequired();

        }
        public static void NPProducts(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().Property(n => n.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Products>().HasOne(p => p.Categories).WithMany(ctg => ctg.Products).HasForeignKey(p => p.CategoriesId);
        }

        public static void NPProductsDetail(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductDetail>().HasOne(pd => pd.Products).WithOne(p => p.ProductDetail).HasForeignKey<ProductDetail>(pd => pd.ProductId);
        }
        public static void NPShops(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Shops>().Property(n => n.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Shops>().Property(n => n.Address).HasMaxLength(90).IsRequired();
            modelBuilder.Entity<Shops>().HasOne(s => s.Cityes).WithMany(c => c.Shops).HasForeignKey(s => s.CityId);
            modelBuilder.Entity<Shops>().HasMany(s => s.Products).WithMany(c => c.Shops);


        }
        public static void NPWorkers(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Workers>().Property(n => n.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Workers>().Property(n => n.SurName).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Workers>().Property(n => n.Email).HasMaxLength(225).IsRequired();
            modelBuilder.Entity<Workers>().HasIndex(w => w.Email).HasName("index_Email").IsUnique();

            modelBuilder.Entity<Workers>().Property(n => n.PhoneNumber).HasMaxLength(15).IsRequired(false);
            modelBuilder.Entity<Workers>().HasOne(w => w.Positions).WithMany(p => p.Workers).HasForeignKey(w => w.PositionId);
            modelBuilder.Entity<Workers>().HasOne(w => w.Shops).WithMany(p => p.Workers).HasForeignKey(w => w.ShopsId);


        }


    }
}
