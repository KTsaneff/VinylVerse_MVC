using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
                .HasOne(x => x.Genre)
                .WithMany(x => x.Albums)
                .HasForeignKey(x => x.GenreId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Artist>()
                .HasMany(x => x.Albums)
                .WithOne()
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
                .HasOne(a => a.Artist)
                .WithMany(artist => artist.Albums)
                .HasForeignKey(a => a.ArtistId);

            modelBuilder.Entity<Album>()
                .Property(a => a.Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 4, Name = "Jazz", DisplayOrder = 1 },
                new Genre { Id = 5, Name = "Latin", DisplayOrder = 2 },
                new Genre { Id = 6, Name = "Pop", DisplayOrder = 3 },
                new Genre { Id = 8, Name = "Reggae", DisplayOrder = 4 },
                new Genre { Id = 9, Name = "Rock", DisplayOrder = 5 }
                );
        }
    }
}
