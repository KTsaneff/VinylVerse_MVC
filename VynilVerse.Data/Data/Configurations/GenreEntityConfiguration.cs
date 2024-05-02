using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VynilVerse.Models;

namespace VynilVerse.DataAccess.Data.Configurations
{
    public class GenreEntityConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(GenerateGenres());
        }

        private static List<Genre> GenerateGenres()
        {
            List<Genre> genres = new List<Genre>
            {
                new Genre
                {
                    Id = 1,
                    Name = "Rock"
                },
                new Genre
                {
                    Id = 2,
                    Name = "Pop"
                },
                new Genre
                {
                    Id = 3,
                    Name = "Hip Hop"
                },
                new Genre
                {
                    Id = 4,
                    Name = "Jazz"
                },
                new Genre
                {
                    Id = 5,
                    Name = "Classical"
                },
                new Genre
                {
                    Id = 6,
                    Name = "Electronic"
                },
                new Genre
                {
                    Id = 7,
                    Name = "Blues"
                },
                new Genre
                {
                    Id = 8,
                    Name = "Country"
                },
                new Genre
                {
                    Id = 9,
                    Name = "Folk"
                },
                new Genre
                {
                    Id = 10,
                    Name = "Reggae"
                },
                new Genre
                {
                    Id = 11,
                    Name = "Metal"
                },
                new Genre
                {
                    Id = 12,
                    Name = "Punk"
                },
                new Genre
                {
                    Id = 13,
                    Name = "R&B"
                },
                new Genre
                {
                    Id = 14,
                    Name = "Soul"
                },
                new Genre
                {
                    Id = 15,
                    Name = "Funk"
                },
                new Genre
                {
                    Id = 16,
                    Name = "Disco"
                },
                new Genre
                {
                    Id = 17,
                    Name = "Techno"
                },
            };

            return genres;
        }
    }
}
