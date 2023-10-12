using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CIS174_TestCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OlympicCategories",
                columns: table => new
                {
                    OlympicCategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlympicCategories", x => x.OlympicCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "OlympicGames",
                columns: table => new
                {
                    OlympicGameID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlympicGames", x => x.OlympicGameID);
                });

            migrationBuilder.CreateTable(
                name: "OlympicTeams",
                columns: table => new
                {
                    OlympicTeamID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlympicGameID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OlympicCategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FlagImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlympicTeams", x => x.OlympicTeamID);
                    table.ForeignKey(
                        name: "FK_OlympicTeams_OlympicCategories_OlympicCategoryID",
                        column: x => x.OlympicCategoryID,
                        principalTable: "OlympicCategories",
                        principalColumn: "OlympicCategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OlympicTeams_OlympicGames_OlympicGameID",
                        column: x => x.OlympicGameID,
                        principalTable: "OlympicGames",
                        principalColumn: "OlympicGameID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OlympicCategories",
                columns: new[] { "OlympicCategoryID", "Name" },
                values: new object[,]
                {
                    { "indoor", "Indoor" },
                    { "outdoor", "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "OlympicGames",
                columns: new[] { "OlympicGameID", "Name" },
                values: new object[,]
                {
                    { "para", "Paralympics" },
                    { "summer", "Summer Olympics" },
                    { "winter", "Winter Olympics" },
                    { "youth", "Youth Olympic Games" }
                });

            migrationBuilder.InsertData(
                table: "OlympicTeams",
                columns: new[] { "OlympicTeamID", "FlagImage", "Name", "OlympicCategoryID", "OlympicGameID" },
                values: new object[,]
                {
                    { "aut", "aut.jpg", "Austria Canoe Sprint", "outdoor", "para" },
                    { "bra", "bra.jpg", "Brazil Road Cycling", "outdoor", "summer" },
                    { "can", "can.jpg", "Canada Curling", "indoor", "winter" },
                    { "chn", "chn.jpg", "China Diving", "indoor", "summer" },
                    { "cyp", "cyp.jpg", "Cyprus Breakdancing", "indoor", "youth" },
                    { "deu", "deu.jpg", "Germany Diving", "indoor", "summer" },
                    { "fin", "fin.jpg", "Finland Skateboarding", "outdoor", "youth" },
                    { "fra", "fra.jpg", "France Breakdancing", "indoor", "youth" },
                    { "gbr", "gbr.jpg", "Great Britain Curling", "indoor", "winter" },
                    { "ita", "ita.jpg", "Italy Bobsleigh", "outdoor", "winter" },
                    { "jam", "jam.jpg", "Jamaica Bobsleigh", "outdoor", "winter" },
                    { "jpn", "jpn.jpg", "Japan Bobsleigh", "outdoor", "winter" },
                    { "mex", "mex.jpg", "Mexico Diving", "indoor", "summer" },
                    { "nld", "nld.jpg", "Netherlands Road Cycling", "outdoor", "summer" },
                    { "pak", "pak.jpg", "Pakistan Canoe Sprint", "outdoor", "para" },
                    { "prt", "prt.jpg", "Portugal Skateboarding", "outdoor", "youth" },
                    { "rus", "rus.jpg", "Russia Breakdancing", "indoor", "youth" },
                    { "svk", "svk.jpg", "Slovakia Skateboarding", "outdoor", "youth" },
                    { "swe", "swe.jpg", "Sweden Curling", "indoor", "winter" },
                    { "tha", "tha.jpg", "Thailand Archery", "indoor", "para" },
                    { "ukr", "ukr.jpg", "Ukraine Archery", "indoor", "para" },
                    { "ury", "ury.jpg", "Uruguay Archery", "indoor", "para" },
                    { "usa", "usa.jpg", "USA Road Cycling", "outdoor", "summer" },
                    { "zwe", "zwe.jpg", "Zimbabwe Canoe Sprint", "outdoor", "para" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OlympicTeams_OlympicCategoryID",
                table: "OlympicTeams",
                column: "OlympicCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_OlympicTeams_OlympicGameID",
                table: "OlympicTeams",
                column: "OlympicGameID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OlympicTeams");

            migrationBuilder.DropTable(
                name: "OlympicCategories");

            migrationBuilder.DropTable(
                name: "OlympicGames");
        }
    }
}
