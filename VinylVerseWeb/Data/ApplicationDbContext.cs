using Microsoft.EntityFrameworkCore;
using VinylVerseWeb.Models;

namespace VinylVerseWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
            
        }

        public virtual DbSet<Genre> Genres { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id=1, Name="Country", DisplayOrder = 1},
                new Genre { Id=2, Name="Electronic", DisplayOrder = 2},
                new Genre { Id=3, Name="Funk", DisplayOrder = 3},
                new Genre { Id=4, Name="Jazz", DisplayOrder = 4},
                new Genre { Id=5, Name="Latin", DisplayOrder = 5},
                new Genre { Id=6, Name="Pop", DisplayOrder = 6},
                new Genre { Id=7, Name="Punk", DisplayOrder = 7},
                new Genre { Id=8, Name="Reggae", DisplayOrder = 8},
                new Genre { Id=9, Name="Rock", DisplayOrder = 9}
                );
        }
    }
}
