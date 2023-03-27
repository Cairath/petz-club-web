using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetzBreedersClub.Database.Migrations
{
    /// <inheritdoc />
    public partial class AffixStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AffixSyntax",
                table: "Affixes",
                newName: "Syntax");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Affixes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Affixes");

            migrationBuilder.RenameColumn(
                name: "Syntax",
                table: "Affixes",
                newName: "AffixSyntax");
        }
    }
}
