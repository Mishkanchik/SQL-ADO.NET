using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.Tables;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp5.Helpers
{
    public static class DbInitializer
    {

        public static void SeedCategories(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(
                new Categories[]
                {
                        new Categories { Id = 1, Name = "MilksProduct" },
                        new Categories { Id = 2, Name = "Eats" },
                });

        }

        public static void SeedCityes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cityes>().HasData(
                 new Cityes[]
                 {
                        new Cityes{ Id = 1, Name = "London" ,CountriesId = 1},
                        new Cityes{ Id = 2, Name = "Porish" ,CountriesId = 2}
                 });

        }
        public static void SeedCountries(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Countries>().HasData(
                new Countries[]
                {
                    new Countries{ Id = 1, Name = "British" },
                    new Countries{ Id = 2, Name = "France" }
                });
        }
        public static void SeedPositions(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Positions>().HasData(
                new Positions[]
                {
                    new Positions{ Id = 1, Name = "Manaher" },
                    new Positions{ Id = 2, Name = "Casir" }
                });
        }
        public static void SeedProducts(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Products>().HasData(
                new Products[]
                {
                    new Products{ Id = 1, Name = "Kefir", Price = 20.0m, Discount = 10,Quantity = 1000,IsinStock = true, CategoriesId = 1},
                    new Products{ Id = 2, Name = "Bread" ,Price = 10.4m, Discount = 5,Quantity = 1000,IsinStock = true , CategoriesId = 2}
                });
        }
        public static void SeedShops(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shops>().HasData(
              new Shops[]
              {
                    new Shops{ Id = 1, Name = "Volmart", Address = "Kiivska 17", ParkingArea = 10,CityId =1},
                    new Shops{ Id = 2, Name = "ATB" ,Address = "Soborna 34", ParkingArea = 5 , CityId = 2}
              });
        }
        public static void SeedWorkers(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Workers>().HasData(
                new Workers[]
                {
                        new Workers{ Id = 1, Name = "Ivan", SurName = "Turmac", Salary = 10000.0m,Email = "feficar4354@gmail.com",PhoneNumber = "0653457395",PositionId = 1,ShopsId = 1},
                        new Workers{ Id = 2, Name = "Misha" ,SurName = "Tchumak", Salary = 9000.0m, Email = "emilell34@gmail,com",PhoneNumber = "0979735594",PositionId = 2,ShopsId = 2}
                });
        }
















    }
}
