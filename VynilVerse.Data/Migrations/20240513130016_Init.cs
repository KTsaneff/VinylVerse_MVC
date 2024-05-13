using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VynilVerse.DataAccess.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ArtistImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    YearOfRelease = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Price50 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Price100 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: true),
                    TrackList = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Albums_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "ArtistImageUrl", "Country", "Name" },
                values: new object[,]
                {
                    { 1, "https://ca-times.brightspotcdn.com/dims4/default/cb16b10/2147483647/strip/true/crop/4935x3290+0+0/resize/2400x1600!/quality/75/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2F5b%2F33%2Ff367fb35474d864941e977e5f48e%2F927846-ca-0321-red-hot-chili-peppers-sunday-calendar-cover-mrt-02.jpg", "USA", "Red Hot Chili Peppers" },
                    { 2, "https://ew.com/thmb/S1YcQL0-TGSdkaTuVPXPEhLnB3Y=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/michael-buble-122223-923e3a72df7a4d998aeb51c746bf2b4a.jpg", "Canada", "Michael Buble" },
                    { 3, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYUQc5xRrd-QaDGUVQu4gwSrxNsPZvc0stWQ&s", "United Kingdom", "The Beatles" },
                    { 4, "https://m.media-amazon.com/images/M/MV5BMTM1NjExNjg1OV5BMl5BanBnXkFtZTcwMTQ0NzIwMw@@._V1_FMjpg_UX1000_.jpg", "USA", "Michael Jackson" },
                    { 5, "https://cdn.britannica.com/85/202285-050-EF215325/Elvis-Presley-Girl-Happy-Boris-Sagal.jpg", "USA", "Elvis Presley" },
                    { 6, "https://imgix.ranker.com/list_img_v2/4594/2004594/original/young-madonna?fit=crop&fm=pjpg&q=80&dpr=2&w=1200&h=720", "USA", "Madonna" },
                    { 7, "https://cdn.britannica.com/47/243647-050-7C88FBF5/Led-Zeppelin-1968-studio-portrait-John-Bohham-Jimmy-Page-Robert-Plant-John-Paul-Jones.jpg", "England", "Led Zeppelin" },
                    { 8, "https://townsquare.media/site/295/files/2014/08/pinkfloyd.jpg?w=780&q=75", "England", "Pink Floyd" },
                    { 9, "https://m.media-amazon.com/images/M/MV5BMjI4OTIwNDAxMF5BMl5BanBnXkFtZTgwOTkzOTAyODE@._V1_FMjpg_UX1000_.jpg", "England", "Queen" },
                    { 10, "https://cdn.britannica.com/41/197341-050-4859B808/The-Rolling-Stones-Bill-Wyman-Keith-Richards-1964.jpg", "United Kingdom", "The Rolling Stones" },
                    { 11, "https://media.vanityfair.com/photos/56935aff030e898e45417924/16:9/w_1280,c_limit/david-bowie-dies-cancer-69.jpg", "USA", "David Bowie" },
                    { 12, "https://assets.exclaim.ca/dr2uqw6xy/image/upload/c_limit,w_890/f_auto/q_auto/prince_2?_a=BAVAfVIB0", "USA", "Prince" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 0, "Rock" },
                    { 2, 0, "Pop" },
                    { 3, 0, "Hip Hop" },
                    { 4, 0, "Jazz" },
                    { 5, 0, "Classical" },
                    { 6, 0, "Electronic" },
                    { 7, 0, "Blues" },
                    { 8, 0, "Country" },
                    { 9, 0, "Folk" },
                    { 10, 0, "Reggae" },
                    { 11, 0, "Metal" },
                    { 12, 0, "Punk" },
                    { 13, 0, "R&B" },
                    { 14, 0, "Soul" },
                    { 15, 0, "Funk" },
                    { 16, 0, "Disco" },
                    { 17, 0, "Techno" },
                    { 18, 0, "House" },
                    { 19, 0, "Rock&Roll" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "CoverImageUrl", "Description", "GenreId", "Price", "Price100", "Price50", "Quantity", "Rating", "Title", "TrackList", "YearOfRelease" },
                values: new object[,]
                {
                    { 1, 1, "https://i.discogs.com/3hPxEdlaArkKnI2FmcNqsHLI5k6mUVdlSOVHVFvvpPk/rs:fit/g:sm/q:90/h:600/w:589/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTcyNzMz/OS0xNDM5MDQ1Mzk4/LTkyOTguanBlZw.jpeg", "Californication is the seventh studio album by American rock band Red Hot Chili Peppers.", 1, 55.99m, 45.99m, 50.99m, 150, 8.1999999999999993, "Californication", "Around the World;Parallel Universe;Scar Tissue;Otherside;GetAsync on Top;Californication;Easily;Porcelain;Emit Remmus;I Like Dirt;This Velvet Glove;Savior;Purple Stain;Right on Time;Road Trippin'", 1999 },
                    { 2, 2, "https://m.media-amazon.com/images/I/61iUTlo0r5L._UF1000,1000_QL80_.jpg", "It's Time is the fourth studio album by Canadian singer Michael Bublé. It was released on February 8, 2005, by 143 Records and Reprise Records. With arrangements by David Foster, the album contains cover versions of songs from traditional contemporary pop: George Gershwin, Cole Porter, Stevie Wonder, and The Beatles, as well as the original song \"Home\", which was co-written by Bublé.", 3, 24.99m, 14.99m, 19.99m, 100, 7.5, "It's Time", "Feeling Good;A Foggy Day (In London Town);You Don't Know Me;Quando, Quando, Quando;Home;Can't Buy Me Love;The More I See You;Save The Last Dance For Me;Try A Little Tenderness;How Sweet It Is;A Song For You;I've Got You Under My Skin;You And I;Dream A Little Dream (Special Edition Only);Mack The Knife (Special Edition Only)", 2005 },
                    { 3, 3, "https://upload.wikimedia.org/wikipedia/en/4/42/Beatles_-_Abbey_Road.jpg", "Abbey Road is the eleventh studio album by the English rock band the Beatles, released on 26 September 1969 by Apple Records. The recording sessions for the album were the last in which all four Beatles participated. Although Let It Be was the final album that the Beatles completed before the band's dissolution in April 1970, most of the album had been recorded before the Abbey Road sessions began.", 1, 39.99m, 29.99m, 34.99m, 500, 9.5, "Abbey Road", "Come Together;Something;Maxwell's Silver Hammer;Oh! Darling;Octopus's Garden;I Want You (She's So Heavy);Here Comes the Sun;Because;You Never Give Me Your Money;Sun King;Mean Mr. Mustard;Polythene Pam;She Came In Through the Bathroom Window;Golden Slumbers;Carry That Weight;The End;Her Majesty", 1969 },
                    { 4, 4, "https://upload.wikimedia.org/wikipedia/en/5/55/Michael_Jackson_-_Thriller.png", "Thriller is the sixth studio album by American singer Michael Jackson, released on November 30, 1982, by Epic Records. Reunited with Off the Wall producer Quincy Jones, Jackson was inspired to create an album where every song was a killer. With the ongoing backlash against disco, Jackson moved in a new musical direction, incorporating pop, post-disco, rock, funk, and R&B.", 2, 49.99m, 39.99m, 44.99m, 300, 9.8000000000000007, "Thriller", "Wanna Be Startin' Somethin';Baby Be Mine;The Girl Is Mine;Thriller;Beat It;Billie Jean;Human Nature;P.Y.T. (Pretty Young Thing);The Lady In MyLife", 1982 },
                    { 5, 5, "https://m.media-amazon.com/images/I/6115u83KaTL._UF1000,1000_QL80_.jpg", "Elvis Presley is the debut studio album by American rock and roll singer Elvis Presley. It was released on RCA Victor, in mono, catalogue number LPM 1254, in March 1956. The recording sessions took place on January 10 and January 11 at the RCA Victor recording studios in Nashville, Tennessee, and on January 30 and January 31 at the RCA Victor studios in New York.", 19, 29.99m, 19.99m, 24.99m, 200, 9.0, "Elvis Presley", "Blue Suede Shoes;I'm Counting On You;I Got A Woman;One-Sided Love Affair;I Love You Because;Just Because;Tutti Frutti;Trying To GetAsync You;I'm Gonna Sit Right Down And Cry;I'll Never Let Ypu Go;Blue Moon;Money Honey", 1956 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_GenreId",
                table: "Albums",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
