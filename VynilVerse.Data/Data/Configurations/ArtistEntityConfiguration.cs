using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VynilVerse.Models;

namespace VynilVerse.DataAccess.Data.Configurations
{
    public class ArtistEntityConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasData(GenerateArtists());
        }

        private static List<Artist> GenerateArtists()
        {
            List<Artist> artists = new List<Artist>
            {
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
                },
                new Artist
                {
                    Id = 3,
                    Name = "The Beatles",
                    Country = "United Kingdom",
                    ArtistImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYUQc5xRrd-QaDGUVQu4gwSrxNsPZvc0stWQ&s"
                },
                new Artist
                {
                    Id = 4,
                    Name = "Michael Jackson",
                    Country = "USA",
                    ArtistImageUrl = "https://m.media-amazon.com/images/M/MV5BMTM1NjExNjg1OV5BMl5BanBnXkFtZTcwMTQ0NzIwMw@@._V1_FMjpg_UX1000_.jpg"
                },
                new Artist
                {
                    Id = 5,
                    Name = "Elvis Presley",
                    Country = "USA",
                    ArtistImageUrl = "https://cdn.britannica.com/85/202285-050-EF215325/Elvis-Presley-Girl-Happy-Boris-Sagal.jpg"
                },
                new Artist
                {
                    Id = 6,
                    Name = "Madonna",
                    Country = "USA",
                    ArtistImageUrl = "https://imgix.ranker.com/list_img_v2/4594/2004594/original/young-madonna?fit=crop&fm=pjpg&q=80&dpr=2&w=1200&h=720"
                },
                new Artist
                {
                    Id = 7,
                    Name = "Led Zeppelin",
                    Country = "England",
                    ArtistImageUrl = "https://cdn.britannica.com/47/243647-050-7C88FBF5/Led-Zeppelin-1968-studio-portrait-John-Bohham-Jimmy-Page-Robert-Plant-John-Paul-Jones.jpg"
                },
                new Artist
                {
                    Id = 8,
                    Name = "Pink Floyd",
                    Country = "England",
                    ArtistImageUrl = "https://townsquare.media/site/295/files/2014/08/pinkfloyd.jpg?w=780&q=75"
                },
                new Artist
                {
                    Id = 9,
                    Name = "Queen",
                    Country = "England",
                    ArtistImageUrl = "https://m.media-amazon.com/images/M/MV5BMjI4OTIwNDAxMF5BMl5BanBnXkFtZTgwOTkzOTAyODE@._V1_FMjpg_UX1000_.jpg"
                },
                new Artist
                {
                    Id = 10,
                    Name = "The Rolling Stones",
                    Country = "United Kingdom",
                    ArtistImageUrl = "https://cdn.britannica.com/41/197341-050-4859B808/The-Rolling-Stones-Bill-Wyman-Keith-Richards-1964.jpg"
                },
                new Artist
                {
                    Id = 11,
                    Name = "David Bowie",
                    Country = "USA",
                    ArtistImageUrl = "https://media.vanityfair.com/photos/56935aff030e898e45417924/16:9/w_1280,c_limit/david-bowie-dies-cancer-69.jpg"
                },
                new Artist
                {
                    Id = 12,
                    Name = "Prince",
                    Country = "USA",
                    ArtistImageUrl = "https://assets.exclaim.ca/dr2uqw6xy/image/upload/c_limit,w_890/f_auto/q_auto/prince_2?_a=BAVAfVIB0"
                }
            };

            return artists;
        }
    }
}
