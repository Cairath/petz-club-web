using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetzBreedersClub.Database.Migrations
{
    /// <inheritdoc />
    public partial class Notifications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AffixesPendingRegistration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AffixSyntax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationStatus = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "SystemNotifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Read = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemNotifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemNotifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
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

            migrationBuilder.CreateIndex(
                name: "IX_SystemNotifications_UserId",
                table: "SystemNotifications",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AffixesPendingRegistration");

            migrationBuilder.DropTable(
                name: "SystemNotifications");
        }
    }
}
