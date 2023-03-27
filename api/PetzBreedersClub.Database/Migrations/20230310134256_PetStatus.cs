using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetzBreedersClub.Database.Migrations
{
    /// <inheritdoc />
    public partial class PetStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 13, 42, 56, 201, DateTimeKind.Utc).AddTicks(7750));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Pets");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2738));
        }
    }
}
