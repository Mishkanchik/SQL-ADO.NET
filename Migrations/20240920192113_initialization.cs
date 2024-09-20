using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsoleApp3.Migrations
{
    /// <inheritdoc />
    public partial class initialization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Jenres",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jenres", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PlayLists",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayLists", x => x.id);
                    table.ForeignKey(
                        name: "FK_PlayLists_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.id);
                    table.ForeignKey(
                        name: "FK_Artists_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Alboms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RatingAlbom = table.Column<int>(type: "int", nullable: false),
                    Auditions = table.Column<int>(type: "int", nullable: false),
                    JenreId = table.Column<int>(type: "int", nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alboms", x => x.id);
                    table.ForeignKey(
                        name: "FK_Alboms_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alboms_Jenres_JenreId",
                        column: x => x.JenreId,
                        principalTable: "Jenres",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationsSec = table.Column<int>(type: "int", nullable: false),
                    SongLyrics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    AlbomId = table.Column<int>(type: "int", nullable: false),
                    PlayListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.id);
                    table.ForeignKey(
                        name: "FK_Tracks_Alboms_AlbomId",
                        column: x => x.AlbomId,
                        principalTable: "Alboms",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tracks_PlayLists_PlayListId",
                        column: x => x.PlayListId,
                        principalTable: "PlayLists",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "id", "Name" },
                values: new object[,]
                {
                    { 1, "Favorites" },
                    { 2, "Chill" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "id", "Name" },
                values: new object[,]
                {
                    { 1, "USA" },
                    { 2, "UK" }
                });

            migrationBuilder.InsertData(
                table: "Jenres",
                columns: new[] { "id", "Name" },
                values: new object[,]
                {
                    { 1, "Rock" },
                    { 2, "Pop" }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "XXXTANTIONE" },
                    { 2, 2, "LIL PEEP" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alboms_ArtistId",
                table: "Alboms",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Alboms_JenreId",
                table: "Alboms",
                column: "JenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Artists_CountryId",
                table: "Artists",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayLists_CategoryId",
                table: "PlayLists",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_AlbomId",
                table: "Tracks",
                column: "AlbomId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_PlayListId",
                table: "Tracks",
                column: "PlayListId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Alboms");

            migrationBuilder.DropTable(
                name: "PlayLists");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Jenres");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
