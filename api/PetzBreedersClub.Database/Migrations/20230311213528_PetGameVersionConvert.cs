using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetzBreedersClub.Database.Migrations
{
    /// <inheritdoc />
    public partial class PetGameVersionConvert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "GameVersion",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "GameVersion",
                table: "Pets",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
