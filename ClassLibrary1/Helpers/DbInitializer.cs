using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1.Helpers
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

        public static void SeedProductDetail(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ProductDetail>().HasData(
                new ProductDetail[]
                {
                    new ProductDetail{ Id = 1, Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",ProductId = 1},
                    new ProductDetail{ Id = 2, Description = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.",ProductId = 2}
                });
        }

        public static void SeedProducts(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Products>().HasData(
                new Products[]
                {
                    new Products{ Id = 1, Name = "Kefir", Price = 20.00m, Discount = 10,Quantity = 1000,IsinStock = true, CategoriesId = 1},
                    new Products{ Id = 2, Name = "Bread" ,Price = 10.40m, Discount = 5,Quantity = 1000,IsinStock = true , CategoriesId = 2}
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
                        new Workers{ Id = 1, Name = "Ivan", SurName = "Turmac", Salary = 10000.00m,Email = "feficar4354@gmail.com",PhoneNumber = "0653457395",PositionId = 1,ShopsId = 1},
                        new Workers{ Id = 2, Name = "Misha" ,SurName = "Tchumak", Salary = 9000.00m, Email = "emilell34@gmail,com",PhoneNumber = "0979735594",PositionId = 2,ShopsId = 2}
                });
        }
















    }
}
