using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetzBreedersClub.Database.Migrations
{
    /// <inheritdoc />
    public partial class Breeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BreedStandards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Coat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eyes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Faults = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisqualifyingFaults = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BreedId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreedStandards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BreedStandards_Breeds_BreedId",
                        column: x => x.BreedId,
                        principalTable: "Breeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BreedStandards_BreedId",
                table: "BreedStandards",
                column: "BreedId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BreedStandards");
        }
    }
}
