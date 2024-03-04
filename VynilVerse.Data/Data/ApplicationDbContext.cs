using Microsoft.EntityFrameworkCore;
using VynilVerse.Models;

namespace VynilVerse.DataAccess.Data
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
                new Genre { Id=4, Name="Jazz", DisplayOrder = 1},
                new Genre { Id=5, Name="Latin", DisplayOrder = 2},
                new Genre { Id=6, Name="Pop", DisplayOrder = 3},
                new Genre { Id=8, Name="Reggae", DisplayOrder = 4},
                new Genre { Id=9, Name="Rock", DisplayOrder = 5}
                );
        }
    }
}
