using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VynilVerseWebRazor_Temp.Migrations
{
    public partial class AddGenreToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Country" },
                    { 2, 2, "Electronic" },
                    { 3, 3, "Funk" },
                    { 4, 4, "Jazz" },
                    { 5, 5, "Latin" },
                    { 6, 6, "Pop" },
                    { 7, 7, "Punk" },
                    { 8, 8, "Reggae" },
                    { 9, 9, "Rock" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
