using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetzBreedersClub.Database.Migrations
{
    /// <inheritdoc />
    public partial class BreedVarieties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BreedStandardId",
                table: "Breeds",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BreedVarieties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BreedId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreedVarieties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BreedVarieties_Breeds_BreedId",
                        column: x => x.BreedId,
                        principalTable: "Breeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 161,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 162,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 163,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 164,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 165,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 166,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 167,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 168,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 169,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 170,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 171,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 172,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 173,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 174,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 175,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 176,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 177,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 178,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 179,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 180,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 181,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 182,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 183,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 184,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 185,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 186,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 187,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 188,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 189,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 190,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 191,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 192,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 193,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 194,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 195,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 196,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 197,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 198,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 199,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 200,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 201,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 202,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 203,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 204,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 205,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 206,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 207,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 208,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 209,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 210,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 211,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 212,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 213,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 214,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 215,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 216,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 217,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 218,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 219,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 220,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 221,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 222,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 223,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 224,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 225,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 226,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 227,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 228,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 229,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 230,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 231,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 232,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 233,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 234,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 235,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 236,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 237,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 238,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 239,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 240,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 241,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 242,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 243,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 244,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 245,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 246,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 247,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 248,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 249,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 250,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 251,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 252,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 253,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 254,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 255,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 256,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 257,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 258,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 259,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 260,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 261,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 262,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 263,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 264,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 265,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 266,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 267,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 268,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 269,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 270,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 271,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 272,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 273,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 274,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 275,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 276,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 277,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 278,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 279,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 280,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 281,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 282,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 283,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 284,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 285,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 286,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 287,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 288,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 289,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 290,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 291,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 292,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 293,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 294,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 295,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 296,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 297,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 298,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 299,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 300,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 301,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 302,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 303,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 304,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 305,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 306,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 307,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 308,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 309,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 310,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 311,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 312,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 313,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 314,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 315,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 316,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 317,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 318,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 319,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 320,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 321,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 322,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 323,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 324,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 325,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 326,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 327,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 328,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 329,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 330,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 331,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 332,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 333,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 334,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 335,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 336,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 337,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 338,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 339,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 340,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 341,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 342,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 343,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 344,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 345,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 346,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 347,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 348,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 349,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 350,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 351,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 352,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 353,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 354,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 355,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 356,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 357,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 358,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 359,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 360,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 361,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 362,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 363,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 364,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 365,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 366,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 367,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 368,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 369,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 370,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 371,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 372,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 373,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 374,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 375,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 376,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 377,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 378,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 379,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 380,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 381,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 382,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 383,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 384,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 385,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 386,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 387,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 388,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 389,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 390,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 391,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 392,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 393,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 394,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 395,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 396,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 397,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 398,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 399,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 400,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 401,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 402,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 403,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 404,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 405,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 406,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 407,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 408,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 409,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 410,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 411,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 412,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 413,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 414,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 415,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 416,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 417,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 418,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 419,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 420,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 421,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 422,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 423,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 424,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 425,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 426,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 427,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 428,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 429,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 430,
                column: "BreedStandardId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_BreedVarieties_BreedId",
                table: "BreedVarieties",
                column: "BreedId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BreedVarieties");

            migrationBuilder.DropColumn(
                name: "BreedStandardId",
                table: "Breeds");
        }
    }
}
