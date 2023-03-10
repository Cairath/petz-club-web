using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetzBreedersClub.Database.Migrations
{
    /// <inheritdoc />
    public partial class SeedSomeDogs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Breeds",
                columns: new[] { "Id", "AddedBy", "CreatedDate", "Group", "LastModifiedDate", "ModifiedBy", "Name", "Section", "Species" },
                values: new object[,]
                {
                    { 1, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2719), 1, null, null, "Australian Kelpie", 1, "Dogz" },
                    { 2, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2722), 1, null, null, "Belgian Shepherd Dog (Groenendael)", 1, "Dogz" },
                    { 3, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2723), 1, null, null, "Belgian Shepherd Dog (Laekenois)", 1, "Dogz" },
                    { 4, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2724), 1, null, null, "Belgian Shepherd Dog (Malinois)", 1, "Dogz" },
                    { 5, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2724), 1, null, null, "Belgian Shepherd Dog (Tervueren)", 1, "Dogz" },
                    { 6, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2725), 1, null, null, "Shipperke", 1, "Dogz" },
                    { 7, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2725), 1, null, null, "Croatian Shepherd Dog", 1, "Dogz" },
                    { 8, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2726), 1, null, null, "Briard", 1, "Dogz" },
                    { 9, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2726), 1, null, null, "Pyrenean Sheepdog Longhaired", 1, "Dogz" },
                    { 10, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2728), 1, null, null, "Picardy Sheepdog", 1, "Dogz" },
                    { 11, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2729), 1, null, null, "Pyrenean Sheepdog Smooth Faced", 1, "Dogz" },
                    { 12, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2729), 1, null, null, "German Shepherd Dog (Double Coat)", 1, "Dogz" },
                    { 13, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2730), 1, null, null, "German Shepherd Dog (Long and Harsh Outer Coat)", 1, "Dogz" },
                    { 14, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2730), 1, null, null, "Bearded Collie", 1, "Dogz" },
                    { 15, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2731), 1, null, null, "Border Collie", 1, "Dogz" },
                    { 16, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2731), 1, null, null, "Collie (Rough)", 1, "Dogz" },
                    { 17, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2732), 1, null, null, "Collie (Smooth)", 1, "Dogz" },
                    { 18, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2732), 1, null, null, "Shetland Sheepdog", 1, "Dogz" },
                    { 19, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2733), 1, null, null, "Komondor", 1, "Dogz" },
                    { 20, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2733), 1, null, null, "Kuvasz", 1, "Dogz" },
                    { 21, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2734), 1, null, null, "Mudi", 1, "Dogz" },
                    { 22, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2734), 1, null, null, "Puli (pearl-white)", 1, "Dogz" },
                    { 23, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2735), 1, null, null, "Puli (other colors)", 1, "Dogz" },
                    { 24, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2735), 1, null, null, "Pumi", 1, "Dogz" },
                    { 25, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2736), 1, null, null, "Bergamasco Shepherd Dog", 1, "Dogz" },
                    { 26, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2736), 1, null, null, "Maremma and the Abruzzes Sheepdog", 1, "Dogz" },
                    { 27, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2737), 1, null, null, "Polish Lowland Sheepdog", 1, "Dogz" },
                    { 28, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2737), 1, null, null, "Tatra Shepherd Dog", 1, "Dogz" },
                    { 29, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2738), 1, null, null, "Portuguese Sheepdog", 1, "Dogz" },
                    { 30, "system", new DateTime(2023, 3, 10, 10, 5, 14, 919, DateTimeKind.Utc).AddTicks(2738), 1, null, null, "Romanian Carpathian Shepherd Dog", 1, "Dogz" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30);
        }
    }
}
