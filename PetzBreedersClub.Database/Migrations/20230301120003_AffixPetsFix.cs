using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetzBreedersClub.Database.Migrations
{
    /// <inheritdoc />
    public partial class AffixPetsFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Affixes_Pets_PetsId",
                table: "Affixes");

            migrationBuilder.DropIndex(
                name: "IX_Affixes_PetsId",
                table: "Affixes");

            migrationBuilder.DropColumn(
                name: "PetsId",
                table: "Affixes");

            migrationBuilder.AddColumn<int>(
                name: "AffixEntityId",
                table: "Pets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_AffixEntityId",
                table: "Pets",
                column: "AffixEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Affixes_AffixEntityId",
                table: "Pets",
                column: "AffixEntityId",
                principalTable: "Affixes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Affixes_AffixEntityId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_AffixEntityId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "AffixEntityId",
                table: "Pets");

            migrationBuilder.AddColumn<int>(
                name: "PetsId",
                table: "Affixes",
                type: "int",
                nullable: true);

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
        }
    }
}
