using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetzBreedersClub.Database.Migrations
{
    /// <inheritdoc />
    public partial class RemovePendingTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AffixesPendingRegistration");

            migrationBuilder.AddColumn<int>(
                name: "RegistrarId",
                table: "Affixes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                table: "Affixes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Affixes_RegistrarId",
                table: "Affixes",
                column: "RegistrarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Affixes_Members_RegistrarId",
                table: "Affixes",
                column: "RegistrarId",
                principalTable: "Members",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Affixes_Members_RegistrarId",
                table: "Affixes");

            migrationBuilder.DropIndex(
                name: "IX_Affixes_RegistrarId",
                table: "Affixes");

            migrationBuilder.DropColumn(
                name: "RegistrarId",
                table: "Affixes");

            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                table: "Affixes");

            migrationBuilder.CreateTable(
                name: "AffixesPendingRegistration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RegistrationStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Syntax = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AffixesPendingRegistration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AffixesPendingRegistration_Members_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AffixesPendingRegistration_Name",
                table: "AffixesPendingRegistration",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AffixesPendingRegistration_OwnerId",
                table: "AffixesPendingRegistration",
                column: "OwnerId");
        }
    }
}
