using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetzBreedersClub.Database.Migrations
{
    /// <inheritdoc />
    public partial class AffixPetsAndParentsFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "SireId",
                table: "Pets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DamId",
                table: "Pets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SireId",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DamId",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
