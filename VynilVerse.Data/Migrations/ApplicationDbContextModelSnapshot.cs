﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VynilVerse.DataAccess.Data;

#nullable disable

namespace VynilVerse.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VynilVerse.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("CoverImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 4)
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double?>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TrackList")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfRelease")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("GenreId");

                    b.ToTable("Albums");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 1,
                            CoverImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.thisisdig.com%2Ffeature%2Fcalifornication-red-hot-chili-peppers-album%2F&psig=AOvVaw2_uxpUxmYM3PrzgBJ0stid&ust=1709904223869000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCPjrvOCf4oQDFQAAAAAdAAAAABAI",
                            Description = "Californication is the seventh studio album by American rock band Red Hot Chili Peppers.",
                            GenreId = 1,
                            Price = 55.99m,
                            Quantity = 150,
                            Rating = 8.1999999999999993,
                            Title = "Californication",
                            TrackList = "Around the World;Parallel Universe;Scar Tissue;Otherside;GetAsync on Top;Californication;Easily;Porcelain;Emit Remmus;I Like Dirt;This Velvet Glove;Savior;Purple Stain;Right on Time;Road Trippin'",
                            YearOfRelease = 1999
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 2,
                            CoverImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.amazon.com%2FIts-Time-Michael-Buble%2Fdp%2FB00074CC1Y&psig=AOvVaw2D9Z8n5Dzrz52WpaYfQBhE&ust=1709905597761000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCOjxw--k4oQDFQAAAAAdAAAAABAE",
                            Description = "It's Time is the fourth studio album by Canadian singer Michael Bublé. It was released on February 8, 2005, by 143 Records and Reprise Records. With arrangements by David Foster, the album contains cover versions of songs from traditional contemporary pop: George Gershwin, Cole Porter, Stevie Wonder, and The Beatles, as well as the original song \"Home\", which was co-written by Bublé.",
                            GenreId = 3,
                            Price = 24.99m,
                            Quantity = 100,
                            Rating = 7.5,
                            Title = "It's Time",
                            TrackList = "Feeling Good;A Foggy Day (In London Town);You Don't Know Me;Quando, Quando, Quando;Home;Can't Buy Me Love;The More I See You;Save The Last Dance For Me;Try A Little Tenderness;How Sweet It Is;A Song For You;I've Got You Under My Skin;You And I;Dream A Little Dream (Special Edition Only);Mack The Knife (Special Edition Only)",
                            YearOfRelease = 2005
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 3,
                            CoverImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/42/Beatles_-_Abbey_Road.jpg",
                            Description = "Abbey Road is the eleventh studio album by the English rock band the Beatles, released on 26 September 1969 by Apple Records. The recording sessions for the album were the last in which all four Beatles participated. Although Let It Be was the final album that the Beatles completed before the band's dissolution in April 1970, most of the album had been recorded before the Abbey Road sessions began.",
                            GenreId = 1,
                            Price = 39.99m,
                            Quantity = 500,
                            Rating = 9.5,
                            Title = "Abbey Road",
                            TrackList = "Come Together;Something;Maxwell's Silver Hammer;Oh! Darling;Octopus's Garden;I Want You (She's So Heavy);Here Comes the Sun;Because;You Never Give Me Your Money;Sun King;Mean Mr. Mustard;Polythene Pam;She Came In Through the Bathroom Window;Golden Slumbers;Carry That Weight;The End;Her Majesty",
                            YearOfRelease = 1969
                        },
                        new
                        {
                            Id = 4,
                            ArtistId = 4,
                            CoverImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/55/Michael_Jackson_-_Thriller.png",
                            Description = "Thriller is the sixth studio album by American singer Michael Jackson, released on November 30, 1982, by Epic Records. Reunited with Off the Wall producer Quincy Jones, Jackson was inspired to create an album where every song was a killer. With the ongoing backlash against disco, Jackson moved in a new musical direction, incorporating pop, post-disco, rock, funk, and R&B.",
                            GenreId = 2,
                            Price = 49.99m,
                            Quantity = 300,
                            Rating = 9.8000000000000007,
                            Title = "Thriller",
                            TrackList = "Wanna Be Startin' Somethin';Baby Be Mine;The Girl Is Mine;Thriller;Beat It;Billie Jean;Human Nature;P.Y.T. (Pretty Young Thing);The Lady In MyLife",
                            YearOfRelease = 1982
                        },
                        new
                        {
                            Id = 5,
                            ArtistId = 5,
                            CoverImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/5e/Elvis_Presley_album_cover.jpg",
                            Description = "Elvis Presley is the debut studio album by American rock and roll singer Elvis Presley. It was released on RCA Victor, in mono, catalogue number LPM 1254, in March 1956. The recording sessions took place on January 10 and January 11 at the RCA Victor recording studios in Nashville, Tennessee, and on January 30 and January 31 at the RCA Victor studios in New York.",
                            GenreId = 19,
                            Price = 29.99m,
                            Quantity = 200,
                            Rating = 9.0,
                            Title = "Elvis Presley",
                            TrackList = "Blue Suede Shoes;I'm Counting On You;I Got A Woman;One-Sided Love Affair;I Love You Because;Just Because;Tutti Frutti;Trying To GetAsync You;I'm Gonna Sit Right Down And Cry;I'll Never Let Ypu Go;Blue Moon;Money Honey",
                            YearOfRelease = 1956
                        });
                });

            modelBuilder.Entity("VynilVerse.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ArtistImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistImageUrl = "https://ca-times.brightspotcdn.com/dims4/default/cb16b10/2147483647/strip/true/crop/4935x3290+0+0/resize/2400x1600!/quality/75/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2F5b%2F33%2Ff367fb35474d864941e977e5f48e%2F927846-ca-0321-red-hot-chili-peppers-sunday-calendar-cover-mrt-02.jpg",
                            Country = "USA",
                            Name = "Red Hot Chili Peppers"
                        },
                        new
                        {
                            Id = 2,
                            ArtistImageUrl = "https://ew.com/thmb/S1YcQL0-TGSdkaTuVPXPEhLnB3Y=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/michael-buble-122223-923e3a72df7a4d998aeb51c746bf2b4a.jpg",
                            Country = "Canada",
                            Name = "Michael Buble"
                        },
                        new
                        {
                            Id = 3,
                            ArtistImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYUQc5xRrd-QaDGUVQu4gwSrxNsPZvc0stWQ&s",
                            Country = "United Kingdom",
                            Name = "The Beatles"
                        },
                        new
                        {
                            Id = 4,
                            ArtistImageUrl = "https://m.media-amazon.com/images/M/MV5BMTM1NjExNjg1OV5BMl5BanBnXkFtZTcwMTQ0NzIwMw@@._V1_FMjpg_UX1000_.jpg",
                            Country = "USA",
                            Name = "Michael Jackson"
                        },
                        new
                        {
                            Id = 5,
                            ArtistImageUrl = "https://cdn.britannica.com/85/202285-050-EF215325/Elvis-Presley-Girl-Happy-Boris-Sagal.jpg",
                            Country = "USA",
                            Name = "Elvis Presley"
                        },
                        new
                        {
                            Id = 6,
                            ArtistImageUrl = "https://imgix.ranker.com/list_img_v2/4594/2004594/original/young-madonna?fit=crop&fm=pjpg&q=80&dpr=2&w=1200&h=720",
                            Country = "USA",
                            Name = "Madonna"
                        },
                        new
                        {
                            Id = 7,
                            ArtistImageUrl = "https://cdn.britannica.com/47/243647-050-7C88FBF5/Led-Zeppelin-1968-studio-portrait-John-Bohham-Jimmy-Page-Robert-Plant-John-Paul-Jones.jpg",
                            Country = "England",
                            Name = "Led Zeppelin"
                        },
                        new
                        {
                            Id = 8,
                            ArtistImageUrl = "https://townsquare.media/site/295/files/2014/08/pinkfloyd.jpg?w=780&q=75",
                            Country = "England",
                            Name = "Pink Floyd"
                        },
                        new
                        {
                            Id = 9,
                            ArtistImageUrl = "https://m.media-amazon.com/images/M/MV5BMjI4OTIwNDAxMF5BMl5BanBnXkFtZTgwOTkzOTAyODE@._V1_FMjpg_UX1000_.jpg",
                            Country = "England",
                            Name = "Queen"
                        },
                        new
                        {
                            Id = 10,
                            ArtistImageUrl = "https://cdn.britannica.com/41/197341-050-4859B808/The-Rolling-Stones-Bill-Wyman-Keith-Richards-1964.jpg",
                            Country = "United Kingdom",
                            Name = "The Rolling Stones"
                        },
                        new
                        {
                            Id = 11,
                            ArtistImageUrl = "https://static.wikia.nocookie.net/disney/images/4/44/David_Bowie.jpg/revision/latest?cb=20231217194435",
                            Country = "USA",
                            Name = "David Bowie"
                        },
                        new
                        {
                            Id = 12,
                            ArtistImageUrl = "https://assets.exclaim.ca/dr2uqw6xy/image/upload/c_limit,w_890/f_auto/q_auto/prince_2?_a=BAVAfVIB0",
                            Country = "USA",
                            Name = "Prince"
                        });
                });

            modelBuilder.Entity("VynilVerse.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 0,
                            Name = "Rock"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 0,
                            Name = "Pop"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 0,
                            Name = "Hip Hop"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 0,
                            Name = "Jazz"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 0,
                            Name = "Classical"
                        },
                        new
                        {
                            Id = 6,
                            DisplayOrder = 0,
                            Name = "Electronic"
                        },
                        new
                        {
                            Id = 7,
                            DisplayOrder = 0,
                            Name = "Blues"
                        },
                        new
                        {
                            Id = 8,
                            DisplayOrder = 0,
                            Name = "Country"
                        },
                        new
                        {
                            Id = 9,
                            DisplayOrder = 0,
                            Name = "Folk"
                        },
                        new
                        {
                            Id = 10,
                            DisplayOrder = 0,
                            Name = "Reggae"
                        },
                        new
                        {
                            Id = 11,
                            DisplayOrder = 0,
                            Name = "Metal"
                        },
                        new
                        {
                            Id = 12,
                            DisplayOrder = 0,
                            Name = "Punk"
                        },
                        new
                        {
                            Id = 13,
                            DisplayOrder = 0,
                            Name = "R&B"
                        },
                        new
                        {
                            Id = 14,
                            DisplayOrder = 0,
                            Name = "Soul"
                        },
                        new
                        {
                            Id = 15,
                            DisplayOrder = 0,
                            Name = "Funk"
                        },
                        new
                        {
                            Id = 16,
                            DisplayOrder = 0,
                            Name = "Disco"
                        },
                        new
                        {
                            Id = 17,
                            DisplayOrder = 0,
                            Name = "Techno"
                        },
                        new
                        {
                            Id = 18,
                            DisplayOrder = 0,
                            Name = "House"
                        },
                        new
                        {
                            Id = 19,
                            DisplayOrder = 0,
                            Name = "Rock&Roll"
                        });
                });

            modelBuilder.Entity("VynilVerse.Models.Album", b =>
                {
                    b.HasOne("VynilVerse.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VynilVerse.Models.Genre", "Genre")
                        .WithMany("Albums")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("VynilVerse.Models.Artist", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("VynilVerse.Models.Genre", b =>
                {
                    b.Navigation("Albums");
                });
#pragma warning restore 612, 618
        }
    }
}
