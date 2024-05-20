using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorWebAssemblyCrud.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "artikuls",
                columns: table => new
                {
                    ArtikulID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtikulName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtikulPrice = table.Column<double>(type: "float", nullable: false),
                    ArtikulDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_artikuls", x => x.ArtikulID);
                });

            migrationBuilder.InsertData(
                table: "artikuls",
                columns: new[] { "ArtikulID", "ArtikulDate", "ArtikulName", "ArtikulPrice" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Televizor", 5.3300000000000001 },
                    { 2, new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kasetofon", 6.5999999999999996 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "artikuls");
        }
    }
}
