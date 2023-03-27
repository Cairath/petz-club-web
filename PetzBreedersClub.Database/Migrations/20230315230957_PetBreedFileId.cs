using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetzBreedersClub.Database.Migrations
{
    /// <inheritdoc />
    public partial class PetBreedFileId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BreedFileId",
                table: "Pets",
                type: "int",
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_BreedFileId",
                table: "Pets",
                column: "BreedFileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_BreedFiles_BreedFileId",
                table: "Pets",
                column: "BreedFileId",
                principalTable: "BreedFiles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_BreedFiles_BreedFileId",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_BreedFileId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "BreedFileId",
                table: "Pets");
        }
    }
}
