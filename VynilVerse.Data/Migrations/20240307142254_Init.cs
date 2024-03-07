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
                    Descriprion = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,4)", precision: 18, scale: 4, nullable: false),
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
                    { 1, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.futuro.cl%2F2022%2F06%2Fred-hot-chili-peppers-y-californication-en-su-mejor-forma%2F&psig=AOvVaw2_uxpUxmYM3PrzgBJ0stid&ust=1709904223869000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCPjrvOCf4oQDFQAAAAAdAAAAABA9", "USA", "Red Hot Chili Peppers" },
                    { 2, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.futuro.cl%2F2022%2F06%2Fred-hot-chili-peppers-y-californication-en-su-mejor-forma%2F&psig=AOvVaw2_uxpUxmYM3PrzgBJ0stid&ust=1709904223869000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCPjrvOCf4oQDFQAAAAAdAAAAABA9", "Canada", "Michael Buble" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Jazz" },
                    { 2, 2, "Latin" },
                    { 3, 3, "Pop" },
                    { 4, 4, "Reggae" },
                    { 5, 5, "Rock" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "CoverImageUrl", "Descriprion", "GenreId", "Price", "Quantity", "Rating", "Title", "TrackList", "YearOfRelease" },
                values: new object[] { 1, 1, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.thisisdig.com%2Ffeature%2Fcalifornication-red-hot-chili-peppers-album%2F&psig=AOvVaw2_uxpUxmYM3PrzgBJ0stid&ust=1709904223869000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCPjrvOCf4oQDFQAAAAAdAAAAABAI", "Californication is the seventh studio album by American rock band Red Hot Chili Peppers.", 1, 55.99m, 150, 8.1999999999999993, "Californication", "Around the World;Parallel Universe;Scar Tissue;Otherside;Get on Top;Californication;Easily;Porcelain;Emit Remmus;I Like Dirt;This Velvet Glove;Savior;Purple Stain;Right on Time;Road Trippin'", 1999 });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "CoverImageUrl", "Descriprion", "GenreId", "Price", "Quantity", "Rating", "Title", "TrackList", "YearOfRelease" },
                values: new object[] { 2, 2, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.amazon.com%2FIts-Time-Michael-Buble%2Fdp%2FB00074CC1Y&psig=AOvVaw2D9Z8n5Dzrz52WpaYfQBhE&ust=1709905597761000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCOjxw--k4oQDFQAAAAAdAAAAABAE", "It's Time is the fourth studio album by Canadian singer Michael Bublé. It was released on February 8, 2005, by 143 Records and Reprise Records. With arrangements by David Foster, the album contains cover versions of songs from traditional contemporary pop: George Gershwin, Cole Porter, Stevie Wonder, and The Beatles, as well as the original song \"Home\", which was co-written by Bublé.", 3, 24.99m, 100, 7.5, "It's Time", "Feeling Good;A Foggy Day (In London Town);You Don't Know Me;Quando, Quando, Quando;Home;Can't Buy Me Love;The More I See You;Save The Last Dance For Me;Try A Little Tenderness;How Sweet It Is;A Song For You;I've Got You Under My Skin;You And I;Dream A Little Dream (Special Edition Only);Mack The Knife (Special Edition Only)", 2005 });

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
