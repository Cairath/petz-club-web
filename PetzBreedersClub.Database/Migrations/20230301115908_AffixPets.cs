using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetzBreedersClub.Database.Migrations
{
    /// <inheritdoc />
    public partial class AffixPets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AffixId",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PartialShowName",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PetsId",
                table: "Affixes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_AffixId",
                table: "Pets",
                column: "AffixId");

            migrationBuilder.CreateIndex(
                name: "IX_Affixes_PetsId",
                table: "Affixes",
                column: "PetsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Affixes_Pets_PetsId",
                table: "Affixes",
                column: "PetsId",
                principalTable: "Pets",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Affixes_AffixId",
                table: "Pets",
                column: "AffixId",
                principalTable: "Affixes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Affixes_Pets_PetsId",
                table: "Affixes");

            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Affixes_AffixId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_AffixId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Affixes_PetsId",
                table: "Affixes");

            migrationBuilder.DropColumn(
                name: "AffixId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "PartialShowName",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "PetsId",
                table: "Affixes");
        }
    }
}
