using ClassLibrary1.Entities;
using ClassLibrary1.Helpers;
using ClassLibrary1.Navigation_and_Propertys;

using Microsoft.EntityFrameworkCore;

namespace ClassLibrary1
{
   public class ShopContext : DbContext
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Cityes> Cityes { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductDetail> ProductDetail { get; set; }
        public DbSet<Shops> Shops { get; set; }
        public DbSet<Workers> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"workstation id=TempleED.mssql.somee.com;packet size=4096;user id=Mishka_SQLLogin_1;pwd=zcz7wqcb7x;data source=TempleED.mssql.somee.com;persist security info=False;initial catalog=TempleED;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.NPCategories();
            modelBuilder.NPCityes();
            modelBuilder.NPCountries();
            modelBuilder.NPPositions();
            modelBuilder.NPProducts();
            modelBuilder.NPProductsDetail();
            modelBuilder.NPShops();
            modelBuilder.NPWorkers();


            modelBuilder.SeedCategories();
            modelBuilder.SeedCityes();
            modelBuilder.SeedCountries();
            modelBuilder.SeedPositions();
            modelBuilder.SeedProducts();
            modelBuilder.SeedProductDetail();
            modelBuilder.SeedShops();
            modelBuilder.SeedWorkers();


        }
    }
}
