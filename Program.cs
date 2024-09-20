using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    public class MusicContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Albom> Alboms { get; set; }
        public DbSet<Jenre> Jenres { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
        public DbSet<Category> Categories { get; set; }

        public MusicContext()
        {
            //this.Database.EnsureDeleted();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"workstation id=Templeeee111112.mssql.somee.com;packet size=4096;user id=Mishka_SQLLogin_1;pwd=zcz7wqcb7x;data source=Templeeee111112.mssql.somee.com;persist security info=False;initial catalog=Templeeee111112;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(
                new Country[]
                {
                    new Country { id = 1, Name = "USA" },
                    new Country { id = 2, Name = "UK" },
                });

            modelBuilder.Entity<Jenre>().HasData(
                new Jenre[]
                {
                    new Jenre{ id = 1, Name = "Rock" },
                    new Jenre{ id = 2, Name = "Pop" }
                });

            modelBuilder.Entity<Category>().HasData(
                new Category[]
                {
                    new Category{ id = 1, Name = "Favorites" },
                    new Category{ id = 2, Name = "Chill" }
                });
            modelBuilder.Entity<Artist>().HasData(new Artist[]
            {
                new Artist{ id = 1, Name = "XXXTANTIONE",CountryId = 1},
                new Artist{ id = 2, Name = "LIL PEEP",CountryId = 2}
            });
        }
    }

    public class Country
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public ICollection<Artist> ?Artists { get; set; }
    }

    public class Artist
    {
        public int id { get; set; }
        public string ?Name { get; set; }
        public Country ?Country { get; set; }
        public int CountryId { get; set; }
        public ICollection<Albom>? Albom { get; set; }
    }

    public class Albom
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public DateTime DataStart { get; set; }
        public int RatingAlbom { get; set; }
        public int Auditions { get; set; }
        public Jenre ?Jenre { get; set; }
        public int JenreId { get; set; }
        public Artist ?Artist { get; set; }
        public int ArtistId { get; set; }
        public ICollection<Track>?       Track { get; set; }
    }

    public class Jenre
    {
        public int id { get; set; }
        public string ?Name { get; set; }
        public ICollection<Albom> ?Albom { get; set; }
    }

    public class Track
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public int DurationsSec { get; set; }

        public string? SongLyrics {  get; set; }

        public int Rating { get; set; }
        public int AlbomId { get; set; }
        public Albom? Albom { get; set; }
        public int PlayListId { get; set; }
        public PlayList? PlayList { get; set; }
    }

    public class PlayList
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public ICollection<Track>? Track { get; set; }
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
    }

    public class Category
    {
        public int id { get; set; }
        public string? Name { get; set; }
        public ICollection<PlayList>? PlayList { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MusicContext())
            {


                // context.Database.EnsureCreated();

                //foreach (var item in context.Jenres)
                //{
                //    Console.WriteLine($"{item.id}  {item.Name}");
                //}


                //foreach (var item in context.Artists)
                //{
                //    Console.WriteLine($"{item.id}  {item.Name}");
                //}

                //context.Alboms.Add(new Albom()
                //{
                //    Name = "TNT",
                //    DataStart = DateTime.Now,

                //    RatingAlbom = 1,
                //    Auditions = 100,
                //    ArtistId = 1,
                //    JenreId = 1


                //});
                //context.SaveChanges();
                //foreach (var item in context.Alboms)
                //{
                //    Console.WriteLine($"{item.id}  {item.Name} {item.RatingAlbom}");
                //}






                //context.PlayLists.Add(new PlayList()
                //{
                //    Name = "My Rock Playlist",
                //    CategoryId = 1
                //});





                //var track1 = new Track { Name = "TNT", DurationsSec = 200, SongLyrics = "See me ride out of the sunset\r\nOn your color TV screen\r\nOut for all that I can get\r\nIf you know what I mean\r\nWomen to the left of me\r\nAnd women to the right\r\n\r\n[Pre-Chorus]\r\nAin't got no gun\r\nAin't got no knife\r\nDon't you start no fight\r\n\r\n[Chorus]\r\n'Cause I'm T.N.T., I'm dynamite\r\nT.N.T., and I'll win the fight\r\nT.N.T., I'm a power load\r\nT.N.T., watch me explode\r\n\r\n[Verse 2]\r\nI'm dirty, mean, I'm mighty unclean\r\nI'm a wanted man\r\nPublic enemy number one\r\nUnderstand?\r\nSee upcoming rock shows\r\nGet tickets for your favorite artists\r\nYou might also like\r\nFamily Matters\r\nDrake\r\nBut Daddy I Love Him\r\nTaylor Swift\r\nSo Long, London\r\nTaylor Swift\r\n[Pre-Chorus]\r\nSo lock up your daughter\r\nLock up your wife\r\nLock up your back door\r\nRun for your life\r\nThe man is back in town\r\nSo don't you mess me 'round\r\n\r\n[Chorus]\r\n'Cause I'm T.N.T., I'm dynamite\r\nT.N.T., and I'll win the fight\r\nT.N.T., I'm a power load\r\nT.N.T., watch me explode\r\n\r\n[Guitar Solo]\r\n\r\n[Bridge]\r\nT.N.T\r\nOi! Oi! Oi!\r\nT.N.T\r\nOi! Oi! Oi!\r\nT.N.T\r\nOi! Oi! Oi!\r\nT.N.T\r\nOi! Oi! Oi!\r\nT.N.T\r\nOi! Oi! Oi!\r\n[Chorus]\r\nI'm dynamite\r\nT.N.T\r\nOi! Oi! Oi!\r\nAnd I'll win the fight\r\nT.N.T\r\nOi! Oi! Oi!\r\nI'm a power load\r\nT.N.T., watch me explode!" , Rating = 1, AlbomId = 1, PlayListId = 1 };
                //var track2 = new Track { Name = "Paranoid", SongLyrics = "Finished with my woman 'cause\r\nShe couldn't help me with my mind\r\nPeople think I'm insane because\r\nI am frowning all the time\r\nAll day long I think of things\r\nBut nothing seems to satisfy\r\nThink I'll lose my mind\r\nIf I don't find something to pacify\r\nCan you help me\r\nOccupy my brain?\r\nOh yeah\r\nI need someone to show me\r\nThe things in life that I can't find\r\nI can't see the things that make\r\nTrue happiness, I must be blind\r\nMake a joke and I will sigh\r\nAnd you will laugh and I will cry\r\nHappiness I cannot feel\r\nAnd love to me is so unreal\r\nAnd so as you hear these words\r\nTelling you now of my state\r\nI tell you to enjoy life\r\nI wish I could but it's too late\r\n", DurationsSec = 180, Rating = 3, AlbomId = 1, PlayListId = 1 };










                //context.Tracks.Add(track1);
                //context.Tracks.Add(track2);
                //context.SaveChanges();






                //context.Tracks.Where(track => track.AlbomId == track.id).Where(track => track.Rating > context.Tracks.Where(t => t.AlbomId == t.id).Average(t => t.Rating)).Select(track => new { track.Name, track.Rating });

                //foreach (var track in context.Tracks)
                //{
                //    Console.WriteLine(track.Name);
                //}




                //var ratingSort = context.Tracks.Join(context.Alboms, track => track.AlbomId, albom => albom.id, (track, albom) => new { track, albom }).Where(x => x.albom.ArtistId == x.albom.id).OrderByDescending(x => x.track.Rating).Take(3).Select(x => new { x.track.Name, x.track.Rating });



                // foreach (var track in ratingSort)
                // {
                //     Console.WriteLine(track);
                // }

               // string ForSearch = "T";

               //var search = context.Tracks.Where(x => x.Name.Contains(ForSearch)).Select(x => x.Name);


               // foreach (var track in search)
               // {
               //     Console.WriteLine(track);
               // }





                //foreach (var item in context.Tracks)
                //{
                //    Console.WriteLine($"{item.id}  {item.Name}, {item.Rating}");
                //}





                //Console.WriteLine("da");
            }
        }
    }
}
