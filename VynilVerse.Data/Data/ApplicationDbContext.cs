using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System;
using VynilVerse.Models;

namespace VynilVerse.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Genre> Genres { get; set; } = null!;
        public virtual DbSet<Album> Albums { get; set; } = null!;
        public virtual DbSet<Artist> Artists { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>()
                .HasOne(a => a.Artist)
                .WithMany(artist => artist.Albums)
                .HasForeignKey(a => a.ArtistId);

            modelBuilder.Entity<Album>()
                .HasOne(x => x.Genre)
                .WithMany(x => x.Albums)
                .HasForeignKey(x => x.GenreId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Album>()
                .Property(e => e.TrackList)
                .HasConversion(
                    v => string.Join(";", v),
                    v => v.Split(';', StringSplitOptions.RemoveEmptyEntries).ToList(),
            new ValueComparer<List<string>>(
                (c1, c2) => c1.SequenceEqual(c2),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => c.ToList()));

            

            modelBuilder.Entity<Album>()
                .Property(a => a.Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Jazz", DisplayOrder = 1 },
                new Genre { Id = 2, Name = "Latin", DisplayOrder = 2 },
                new Genre { Id = 3, Name = "Pop", DisplayOrder = 3 },
                new Genre { Id = 4, Name = "Reggae", DisplayOrder = 4 },
                new Genre { Id = 5, Name = "Rock", DisplayOrder = 5 }
                );

            modelBuilder.Entity<Artist>().HasData(
                new Artist 
                { 
                    Id = 1, 
                    Name = "Red Hot Chili Peppers", 
                    Country = "USA", 
                    ArtistImageUrl = "https://ca-times.brightspotcdn.com/dims4/default/cb16b10/2147483647/strip/true/crop/4935x3290+0+0/resize/2400x1600!/quality/75/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2F5b%2F33%2Ff367fb35474d864941e977e5f48e%2F927846-ca-0321-red-hot-chili-peppers-sunday-calendar-cover-mrt-02.jpg"
                },
                new Artist 
                { 
                    Id = 2,
                    Name = "Michael Buble", 
                    Country = "Canada",
                    ArtistImageUrl = "https://ew.com/thmb/S1YcQL0-TGSdkaTuVPXPEhLnB3Y=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/michael-buble-122223-923e3a72df7a4d998aeb51c746bf2b4a.jpg"
                });

            modelBuilder.Entity<Album>().HasData(
                new Album
                {
                    Id = 1,
                    Title = "Californication",
                    ArtistId = 1,
                    GenreId = 1,
                    YearOfRelease = 1999,
                    Description = "Californication is the seventh studio album by American rock band Red Hot Chili Peppers.",
                    Price = 55.99M,
                    Quantity = 150,
                    CoverImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.thisisdig.com%2Ffeature%2Fcalifornication-red-hot-chili-peppers-album%2F&psig=AOvVaw2_uxpUxmYM3PrzgBJ0stid&ust=1709904223869000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCPjrvOCf4oQDFQAAAAAdAAAAABAI",
                    Rating = 8.2,
                    TrackList = new List<string> { "Around the World", "Parallel Universe", "Scar Tissue", "Otherside", "Get on Top", "Californication", "Easily", "Porcelain", "Emit Remmus", "I Like Dirt", "This Velvet Glove", "Savior", "Purple Stain", "Right on Time", "Road Trippin'" }
                },
                new Album
                {
                    Id = 2,
                    Title = "It's Time",
                    ArtistId = 2,
                    GenreId = 3,
                    YearOfRelease = 2005,
                    Description = "It's Time is the fourth studio album by Canadian singer Michael Bublé. It was released on February 8, 2005, by 143 Records and Reprise Records. With arrangements by David Foster, the album contains cover versions of songs from traditional contemporary pop: George Gershwin, Cole Porter, Stevie Wonder, and The Beatles, as well as the original song \"Home\", which was co-written by Bublé.",
                    Price = 24.99M,
                    Quantity = 100,
                    CoverImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.amazon.com%2FIts-Time-Michael-Buble%2Fdp%2FB00074CC1Y&psig=AOvVaw2D9Z8n5Dzrz52WpaYfQBhE&ust=1709905597761000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCOjxw--k4oQDFQAAAAAdAAAAABAE",
                    Rating = 7.5,
                    TrackList = new List<string> { "Feeling Good", "A Foggy Day (In London Town)", "You Don't Know Me", "Quando, Quando, Quando", "Home", "Can't Buy Me Love", "The More I See You", "Save The Last Dance For Me", "Try A Little Tenderness", "How Sweet It Is", "A Song For You", "I've Got You Under My Skin", "You And I", "Dream A Little Dream (Special Edition Only)", "Mack The Knife (Special Edition Only)" }
                });
        }
    }
}
