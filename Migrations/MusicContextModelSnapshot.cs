﻿// <auto-generated />
using System;
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleApp3.Migrations
{
    [DbContext(typeof(MusicContext))]
    partial class MusicContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConsoleApp1.Albom", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("Auditions")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataStart")
                        .HasColumnType("datetime2");

                    b.Property<int>("JenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RatingAlbom")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("JenreId");

                    b.ToTable("Alboms");
                });

            modelBuilder.Entity("ConsoleApp1.Artist", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("CountryId");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            id = 1,
                            CountryId = 1,
                            Name = "XXXTANTIONE"
                        },
                        new
                        {
                            id = 2,
                            CountryId = 2,
                            Name = "LIL PEEP"
                        });
                });

            modelBuilder.Entity("ConsoleApp1.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Name = "Favorites"
                        },
                        new
                        {
                            id = 2,
                            Name = "Chill"
                        });
                });

            modelBuilder.Entity("ConsoleApp1.Country", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Name = "USA"
                        },
                        new
                        {
                            id = 2,
                            Name = "UK"
                        });
                });

            modelBuilder.Entity("ConsoleApp1.Jenre", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Jenres");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Name = "Rock"
                        },
                        new
                        {
                            id = 2,
                            Name = "Pop"
                        });
                });

            modelBuilder.Entity("ConsoleApp1.PlayList", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("CategoryId");

                    b.ToTable("PlayLists");
                });

            modelBuilder.Entity("ConsoleApp1.Track", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("AlbomId")
                        .HasColumnType("int");

                    b.Property<int>("DurationsSec")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayListId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("SongLyrics")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("AlbomId");

                    b.HasIndex("PlayListId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("ConsoleApp1.Albom", b =>
                {
                    b.HasOne("ConsoleApp1.Artist", "Artist")
                        .WithMany("Albom")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp1.Jenre", "Jenre")
                        .WithMany("Albom")
                        .HasForeignKey("JenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Jenre");
                });

            modelBuilder.Entity("ConsoleApp1.Artist", b =>
                {
                    b.HasOne("ConsoleApp1.Country", "Country")
                        .WithMany("Artists")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ConsoleApp1.PlayList", b =>
                {
                    b.HasOne("ConsoleApp1.Category", "Category")
                        .WithMany("PlayList")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ConsoleApp1.Track", b =>
                {
                    b.HasOne("ConsoleApp1.Albom", "Albom")
                        .WithMany("Track")
                        .HasForeignKey("AlbomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp1.PlayList", "PlayList")
                        .WithMany("Track")
                        .HasForeignKey("PlayListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Albom");

                    b.Navigation("PlayList");
                });

            modelBuilder.Entity("ConsoleApp1.Albom", b =>
                {
                    b.Navigation("Track");
                });

            modelBuilder.Entity("ConsoleApp1.Artist", b =>
                {
                    b.Navigation("Albom");
                });

            modelBuilder.Entity("ConsoleApp1.Category", b =>
                {
                    b.Navigation("PlayList");
                });

            modelBuilder.Entity("ConsoleApp1.Country", b =>
                {
                    b.Navigation("Artists");
                });

            modelBuilder.Entity("ConsoleApp1.Jenre", b =>
                {
                    b.Navigation("Albom");
                });

            modelBuilder.Entity("ConsoleApp1.PlayList", b =>
                {
                    b.Navigation("Track");
                });
#pragma warning restore 612, 618
        }
    }
}
