using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VynilVerse.Models;

namespace VynilVerse.DataAccess.Data.Configurations
{
    public class AlbumEntityConfiguration : IEntityTypeConfiguration<Album>
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
                    CoverImageUrl = "https://i.discogs.com/3hPxEdlaArkKnI2FmcNqsHLI5k6mUVdlSOVHVFvvpPk/rs:fit/g:sm/q:90/h:600/w:589/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTcyNzMz/OS0xNDM5MDQ1Mzk4/LTkyOTguanBlZw.jpeg",
                    Rating = 8.2,
                    TrackList = new List<string> { "Around the World", "Parallel Universe", "Scar Tissue", "Otherside", "GetAsync on Top", "Californication", "Easily", "Porcelain", "Emit Remmus", "I Like Dirt", "This Velvet Glove", "Savior", "Purple Stain", "Right on Time", "Road Trippin'" }
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
                    CoverImageUrl = "https://m.media-amazon.com/images/I/61iUTlo0r5L._UF1000,1000_QL80_.jpg",
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
                },
                new Album
                {
                    Id = 4,
                    Title = "Thriller",
                    ArtistId = 4,
                    GenreId = 2,
                    YearOfRelease = 1982,
                    Description = "Thriller is the sixth studio album by American singer Michael Jackson, released on November 30, 1982, by Epic Records. Reunited with Off the Wall producer Quincy Jones, Jackson was inspired to create an album where every song was a killer. With the ongoing backlash against disco, Jackson moved in a new musical direction, incorporating pop, post-disco, rock, funk, and R&B.",
                    Price = 49.99M,
                    Quantity = 300,
                    CoverImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/55/Michael_Jackson_-_Thriller.png",
                    Rating = 9.8,
                    TrackList = new List<string> { "Wanna Be Startin' Somethin'", "Baby Be Mine", "The Girl Is Mine", "Thriller", "Beat It", "Billie Jean", "Human Nature", "P.Y.T. (Pretty Young Thing)", "The Lady In MyLife"}
                },
                new Album
                {
                    Id = 5,
                    Title = "Elvis Presley",
                    ArtistId = 5,
                    GenreId = 19,
                    YearOfRelease = 1956,
                    Description = "Elvis Presley is the debut studio album by American rock and roll singer Elvis Presley. It was released on RCA Victor, in mono, catalogue number LPM 1254, in March 1956. The recording sessions took place on January 10 and January 11 at the RCA Victor recording studios in Nashville, Tennessee, and on January 30 and January 31 at the RCA Victor studios in New York.",
                    Price = 29.99M,
                    Quantity = 200,
                    CoverImageUrl = "https://m.media-amazon.com/images/I/6115u83KaTL._UF1000,1000_QL80_.jpg",
                    Rating = 9.0,
                    TrackList = new List<string> { "Blue Suede Shoes", "I'm Counting On You", "I Got A Woman", "One-Sided Love Affair", "I Love You Because", "Just Because", "Tutti Frutti", "Trying To GetAsync You", "I'm Gonna Sit Right Down And Cry", "I'll Never Let Ypu Go", "Blue Moon", "Money Honey"}
                }
            };
            return albums;
        }
    }
}
