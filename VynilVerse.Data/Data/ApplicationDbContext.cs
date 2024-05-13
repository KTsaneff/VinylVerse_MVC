using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using VynilVerse.DataAccess.Data.Configurations;
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
                .HasPrecision(18, 2);

            modelBuilder.Entity<Album>()
                .Property(a => a.Price50)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Album>()
                .Property(a => a.Price100)
                .HasPrecision(18, 2);

            modelBuilder.ApplyConfiguration(new GenreEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AlbumEntityConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
