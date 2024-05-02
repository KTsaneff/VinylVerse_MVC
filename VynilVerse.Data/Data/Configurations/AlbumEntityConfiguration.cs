using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VynilVerse.Models;

namespace VynilVerse.DataAccess.Data.Configurations
{
    public class AlbumEntityConfiguration
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.HasData(GenerateAlbums());
        }

        private static List<Album> GenerateAlbums()
        {
            List<Album> albums = new List<Album>
            {
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
                },
                new Album
                {
                    Id = 3,
                    Title = "Abbey Road",
                    ArtistId = 3,
                    GenreId = 1,
                    YearOfRelease = 1969,
                    Description = "Abbey Road is the eleventh studio album by the English rock band the Beatles, released on 26 September 1969 by Apple Records. The recording sessions for the album were the last in which all four Beatles participated. Although Let It Be was the final album that the Beatles completed before the band's dissolution in April 1970, most of the album had been recorded before the Abbey Road sessions began.",
                    Price = 39.99M,
                    Quantity = 500,
                    CoverImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/42/Beatles_-_Abbey_Road.jpg",
                    Rating = 9.5,
                    TrackList = new List<string> { "Come Together", "Something", "Maxwell's Silver Hammer", "Oh! Darling", "Octopus's Garden", "I Want You (She's So Heavy)", "Here Comes the Sun", "Because", "You Never Give Me Your Money", "Sun King", "Mean Mr. Mustard", "Polythene Pam", "She Came In Through the Bathroom Window", "Golden Slumbers", "Carry That Weight", "The End", "Her Majesty" }
                }
            };
            return albums;
        }
    }
}
