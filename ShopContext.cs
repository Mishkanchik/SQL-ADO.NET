using ConsoleApp5.Helpers;
using ConsoleApp5.Navigation_and_Propertys;
using ConsoleApp5.Tables;
using Microsoft.EntityFrameworkCore;
namespace ConsoleApp5
{
    class ShopContext : DbContext
    {
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Cityes> Cityes { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Shops> Shops { get; set; }
        public DbSet<Workers> Workers { get; set; }

        public ShopContext()
        {
            //this.Database.EnsureDeleted();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"workstation id=Templesdfsdf.mssql.somee.com;packet size=4096;user id=Mishka_SQLLogin_1;pwd=zcz7wqcb7x;data source=Templesdfsdf.mssql.somee.com;persist security info=False;initial catalog=Templesdfsdf;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.NPCategories();
            modelBuilder.NPCityes();
            modelBuilder.NPCountries();
            modelBuilder.NPPositions();
            modelBuilder.NPProducts();
            modelBuilder.NPShops();
            modelBuilder.NPWorkers();


            modelBuilder.SeedCategories();
            modelBuilder.SeedCityes();
            modelBuilder.SeedCountries();
            modelBuilder.SeedPositions();
            modelBuilder.SeedProducts();
            modelBuilder.SeedShops();
            modelBuilder.SeedWorkers();


        }
    }
}
