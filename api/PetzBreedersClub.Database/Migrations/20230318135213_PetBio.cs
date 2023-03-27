using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetzBreedersClub.Database.Migrations
{
    /// <inheritdoc />
    public partial class PetBio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Pets");
        }
    }
}
