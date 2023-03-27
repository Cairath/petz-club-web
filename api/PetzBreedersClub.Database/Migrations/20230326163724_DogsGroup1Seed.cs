using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetzBreedersClub.Database.Migrations
{
    /// <inheritdoc />
    public partial class DogsGroup1Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Breeds_Name",
                table: "Breeds");

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Breeds",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "BreedVarieties",
                columns: new[] { "Id", "AddedBy", "BreedId", "CreatedDate", "LastModifiedDate", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, "system", 22, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), null, null, "fawn" },
                    { 2, "system", 22, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), null, null, "black" },
                    { 3, "system", 22, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), null, null, "blue merle" },
                    { 4, "system", 22, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), null, null, "ash colored" },
                    { 5, "system", 22, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), null, null, "brown" },
                    { 6, "system", 22, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), null, null, "white" },
                    { 7, "system", 23, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), null, null, "pearl-white" },
                    { 8, "system", 23, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), null, null, "black" },
                    { 9, "system", 23, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), null, null, "black shaded with rust-red or gray" },
                    { 10, "system", 23, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), null, null, "fawn" },
                    { 11, "system", 23, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), null, null, "gray in any shade" }
                });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Belgian Shepherd Dog Groenendael");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Belgian Shepherd Dog Laekenois");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Belgian Shepherd Dog Malinois");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Belgian Shepherd Dog Tervueren");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Picardy Sheepdog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Pyrenean Sheepdog - Long haired");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Pyrenean Sheepdog - Smooth faced");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "German Shepherd Dog - Short haired");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "German Shepherd Dog - Longhair");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Rough Collie");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Smooth Collie");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "Puli");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "Pumi");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "Bergamasco Shepherd Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "Maremma Sheepdog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "Polish Lowland Sheepdog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "Tatra Shepherd Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "Portuguese Sheepdog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Romanian Carpathian Shepherd Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "Name",
                value: "Romanian Mioritic Shepherd Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "South Russian Shepherd Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "Name",
                value: "Czechoslovakian Wolfdog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "Slovakian Chuvach");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "Catalan Sheepdog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "Name",
                value: "Majorca Shepherd Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "Name",
                value: "White Swiss Shepherd Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "Name",
                value: "Dutch Schapendoes");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "Name",
                value: "Dutch Shepherd Dog (Short-haired)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "Name",
                value: "Dutch Shepherd Dog (Long Haired)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "Name",
                value: "Dutch Shepherd Dog (Rough haired)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "Name",
                value: "Saarloos Wolfhond");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "Name",
                value: "Australian Shepherd");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Australian Cattle Dog", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "Name",
                value: "Bouvier Des Ardennes");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "Name",
                value: "Bouvier Des Flandres");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "Name",
                value: "Welsh Corgi Cardigan");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "Name",
                value: "Welsh Corgi Pembroke");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "Name",
                value: "Australian Stumpy Tailed Cattle Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "Name",
                value: "Lancashire Heeler");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "Name",
                value: "Miniature American Shepherd");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "Name",
                value: "Catahoula Leopard Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "Name",
                value: "Bohemian Shepherd Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "Name",
                value: "English Shepherd Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Austrian Pinscher", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Danish-Swedish Farmdog", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Affenpinscher", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Dobermann", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Name", "Section" },
                values: new object[] { "German Pinscher", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Miniature Pinscher", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Giant Schnauzer", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Miniature Schnauzer (Pepper and salt)", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Schnauzer", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Dutch Smoushond", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Russian Black Terrier", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "Name",
                value: "Dogo Argentino");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "Name",
                value: "Fila Brasileiro");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "Name",
                value: "Shar Pei");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "Name",
                value: "Broholmer");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "Name",
                value: "Dogue de Bordeaux");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "Name",
                value: "Boxer");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Great Dane (Fawn and Brindle)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Great Dane (Black and Harlequin)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Great Dane (Blue)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Rottweiler", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Bulldog (English)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Bulldog (American)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Bullmastiff", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Mastiff", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Italian Cane Corso", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Neapolitan Mastiff", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Tosa", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Saint Miguel Cattle Dog (Azores)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Majorca Mastiff", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Presa Canario", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Cimarrón Uruguayo", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Bosnian and Herzegovinian - Croatian Shepherd Dog", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Newfoundland", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Pyrenean Mountain Dog", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Hovawart", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Leonberger", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Landseer (European Continental Type)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Group", "Name" },
                values: new object[] { 2, "Atlas Mountain Dog (Aidi)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Group", "Name" },
                values: new object[] { 2, "Yugoslavian Shepherd Dog - Sharplanina" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Group", "Name" },
                values: new object[] { 2, "Castro Laboreiro Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Group", "Name" },
                values: new object[] { 2, "Estrela Mountain Dog (Short haired)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Group", "Name" },
                values: new object[] { 2, "Estrela Mountain Dog (Long haired)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Group", "Name" },
                values: new object[] { 2, "Rafeiro of Alentejo" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Group", "Name" },
                values: new object[] { 2, "Romanian Bucovina Shepherd" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Group", "Name" },
                values: new object[] { 2, "Caucasian Shepherd Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Group", "Name" },
                values: new object[] { 2, "Central Asia Shepherd Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Group", "Name" },
                values: new object[] { 2, "Karst Shepherd Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Group", "Name" },
                values: new object[] { 2, "Pyrenean Mastiff" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Group", "Name" },
                values: new object[] { 2, "Spanish Mastiff" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Group", "Name" },
                values: new object[] { 2, "St. Bernard (Short haired)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Group", "Name" },
                values: new object[] { 2, "St. Bernard (Long haired)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Group", "Name" },
                values: new object[] { 2, "Tibetan Mastiff" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Kangal Shepherd Dog", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Anatolian Shepherd Dog", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Group", "Name" },
                values: new object[] { 2, "Appenzell Cattle Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Group", "Name" },
                values: new object[] { 2, "Bernese Mountain Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Entlebuch Cattle Dog", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Great Swiss Mountain Dog", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Continental Bulldog", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 2, "Transmontano Mastiff", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Brazilian Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "German Hunting Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Airedale Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Bedlington Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Border Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Fox Terrier (Smooth)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Fox Terrier (Wire)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Lakeland Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Manchester Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Parson Russell Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Welsh Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Irish Glen of Imaal Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Irish Soft Coated Wheaten Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Irish Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Kerry Blue Terrier", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Australian Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Cesky Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Cairn Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Dandie Dinmont Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Jack Russell Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Patterdale Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Rat Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Teddy Roosevelt Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Norfolk Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Norwich Terrier", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Scottish Terrier", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Sealyham Terrier", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Skye Terrier", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "West Highland White Terrier", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Japanese Terrier", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Bull Terrier", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Miniature Bull Terrier", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Staffordshire Bull Terrier", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "American Staffordshire Terrier", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Australian Silky Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Yorkshire Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "English Toy Terrier (Black and tan)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Valencian Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 4, "Standard Dachshund (Long haired)", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 4, "Standard Dachshund (Smooth haired)", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 4, "Standard Dachshund (Wire haired)", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 4, "Miniature Dachshund (Long haired)", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 4, "Miniature Dachshund (Smooth haired)", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 4, "Miniature Dachshund (Wire haired)", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 4, "Rabbit Dachshund (Long haired)", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 4, "Rabbit Dachshund (Smooth haired)", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 4, "Rabbit Dachshund (Wire haired)", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Canadian Eskimo Dog", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Greenland Dog", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Samoyed", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Alaskan Malamute", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Siberian Husky", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Finnish Spitz", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Karelian Bear Dog", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Norwegian Elkhound (Black)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Norwegian Elkhound (Grey)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Norwegian Lundehund", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Name", "Section" },
                values: new object[] { "East Siberian Laika", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Russian-European Laika", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Name", "Section" },
                values: new object[] { "West Siberian Laika", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Jämthund", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Norrbottenspitz", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Finnish Lapponian Dog", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Lapponian Herder", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Icelandic Sheepdog", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Norwegian Buhund", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Swedish Lapphund", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Swedish Vallhund", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Name", "Section" },
                values: new object[] { "American Eskimo Dog", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Keeshond (Wolspitz)", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Giant Spitz (White)", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Giant Spitz (Brown and black)", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Medium size Spitz (White)", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Medium size Spitz (Other colours)", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Medium size Spitz (Brown and black)", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Miniature Spitz (Brown and black)", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Miniature Spitz (White)", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Miniature Spitz (Other colours)", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Pomeranian", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Italian Volpino", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Alaskan Klee Kai", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Chow Chow", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Eurasian", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Akita", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "American Akita", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Hokkaido", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Japanese Spitz", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Kai", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Kishu", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Shiba", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Shikoku", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Korea Jindo Dog", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Thai Bangkaew Dog", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Basenji", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Canaan Dog", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Pharoah Hound", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Xoloitzcuintle (Miniature)", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Xoloitzcuintle (Intermediate)", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Xoloitzcuintle (Standard)", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Peruvian Hairless Dog (Large)", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Peruvian Hairless Dog (Medium)", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Peruvian Hairless Dog (Miniature)", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "American Hairless Terrier (Hairless)", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "American Hairless Terrier (Coated)", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Cirneco Dell'Etna", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Portuguese Podengo Small(Long and wire haired)", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Portuguese Podengo Small(Smooth and short haired)", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Portuguese Podengo Medium(Long and wire haired)", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Portuguese Podengo Medium(Smooth and short haired)", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Portuguese Podengo Large(Long and wire haired)", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Portuguese Podengo Large(Smooth and short haired)", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Canarian Warren Hound", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Ibizan Podenco (Smooth haired)", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Ibizan Podenco (Rough haired)", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Taiwan Dog", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Thai Ridgeback Dog", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Yakutian Laika", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Kintamani-Bali Dog", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 279,
                column: "Name",
                value: "Bloodhound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 280,
                column: "Name",
                value: "Brazilian Tracker");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 281,
                column: "Name",
                value: "Billy");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 282,
                column: "Name",
                value: "French Tricolour Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 283,
                column: "Name",
                value: "French White and Black Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 284,
                column: "Name",
                value: "French White and Orange Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 285,
                column: "Name",
                value: "Gascon Saintongeois (Great and small)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 286,
                column: "Name",
                value: "Grand Griffon Vendeen");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 287,
                column: "Name",
                value: "Great Anglo-French Tricolour Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 288,
                column: "Name",
                value: "Great Anglo-French White and Orange Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 289,
                column: "Name",
                value: "Great Anglo-French White and Black Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 290,
                column: "Name",
                value: "Great Gascony Blue");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 291,
                column: "Name",
                value: "Poitevin");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 292,
                column: "Name",
                value: "English Foxhound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 293,
                column: "Name",
                value: "Otterhound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 294,
                column: "Name",
                value: "Polish Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 295,
                column: "Name",
                value: "American Foxhound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 296,
                column: "Name",
                value: "Black and Tan Coonhound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 297,
                column: "Name",
                value: "Bluetick Coonhound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 298,
                column: "Name",
                value: "Redbone Coonhound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 299,
                column: "Name",
                value: "Treeing Walker Coonhound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 300,
                column: "Name",
                value: "Plott Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 301,
                column: "Name",
                value: "Austrian Black and Tan Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 302,
                column: "Name",
                value: "Coarse Haired Styrian Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 303,
                column: "Name",
                value: "Tyrolean Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 304,
                column: "Name",
                value: "Bosnian Broken Haired Hound - Barak");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 305,
                column: "Name",
                value: "Istrian Short Haired Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 306,
                column: "Name",
                value: "Istrian Wire Haired Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 307,
                column: "Name",
                value: "Posavatz Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 308,
                column: "Name",
                value: "Finnish Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 309,
                column: "Name",
                value: "Ariegeois");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 310,
                column: "Name",
                value: "Artois Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 311,
                column: "Name",
                value: "Beagle Harrier");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 312,
                column: "Name",
                value: "Blue Gascony Griffon");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 313,
                column: "Name",
                value: "Briquet Griffon Vendeen");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Fawn Brittany Griffon", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Griffon Nivernais", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Medium sized Anglo-French Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Porcelaine", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Small Blue Gascony", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Harrier", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Hellenic Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Hungarian Hound - Transylvanian Scent Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Italian Rough Haired Segugio" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Italian Short Haired Segugio" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Montenegrin Mountain Hound" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Halden Hound" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Hygen Hound" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Norwegian Hound" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Polish Hunting Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Serbian Hound" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Serbian Tricolour Hound" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Slovakian Hound" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Spanish Hound" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Hamiltonstövare" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Schillerstövare" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Smålandsstövare" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Dunkerstövare" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Bernese Hound" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Jura Hound" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Lucerne Hound" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Schwyz Hound" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Basset Fauve de Bretagne" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Blue Gascony Basset" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Grand Basset Griffon Vendeen" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Norman Artesien Basset" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Petit Basset Griffon Vendeen" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "German Hound" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Westphalian Dachsbracke" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Basset Hound" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Beagle" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Drever" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Group", "Name" },
                values: new object[] { 6, "Small Swiss Hound" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Alpine Dachsbracke", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Bavarian Mountain Scent Hound", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Hanoverian Scent Hound", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Dalmatian", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Rhodesian Ridgeback", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Estonian Hound", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Segugio Maremmano", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "PFM Mutt", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Old Danish Pointing Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Ariege Pointing Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Auvergne Pointer" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Bourbonnais Pointing Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "French Pointing Dog - Gascogne Type" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "French Pointing Dog - Pyrenean Type" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Saint Germain Pointer", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Deutsch Stichelhaar", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "German Short Haired Pointing Dog", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "German Wire Haired Pointing Dog", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "German Long Haired Pointing Dog", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Pudelpointer", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Weimaraner (Short haired)", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Weimaraner (Long haired)", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Hungarian Short Haired Pointer (Vizsla)", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Hungarian Wire Haired Pointer (Vizsla)", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Italian Pointing Dog (Bracco Italiano)", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Portugeuse Pointing Dog", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Slovakian Wire Haired Pointer", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Burgos Pointing Dog", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Blue Picardy Spaniel", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Brittany Spaniel", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "French Spaniel" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Picardy Spaniel" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Pont-Audemer Spaniel" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Deutsch Langhaar" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Kleiner Münsterländer" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Large Munsterlander" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Drentsche Partridge Dog", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Stabijhoun", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Bohemian Wire Haired Griffon", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Wire Haired Pointing Griffon Korthals", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Italian Spinone", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "English Pointer" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "English Setter" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Gordon Setter" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Irish Red and White Setter", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Irish Red Setter", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Nova Scotia Duck Tolling Retriever", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Curly Coated Retriever", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Flat Coated Retriever", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Golden Retriever", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Labrador Retriever", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Chesapeake Bay Retriever", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "German Spaniel (Wachtelhund)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Clumber Spaniel", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "English Cocker Spaniel", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "English Springer Spaniel", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Field Spaniel", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Sussex Spaniel", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Welsh Springer Spaniel", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Nederlandse Kooikerhondje", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "American Cocker Spaniel", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "French Water Dog (Barbet)", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Irish Water Spaniel", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Romagna Water Dog (Lagotto Romagnolo)", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Portuguese Water Dog", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Spanish Water Dog", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Frisian Water Dog (Wetterhoun)", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "American Water Spaniel", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Group", "Name" },
                values: new object[] { 9, "Bichon Frise" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Group", "Name" },
                values: new object[] { 9, "Maltese" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Havanese", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Bolognese", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Coton de Tulear", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Löwchen (Little Lion Dog)", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Standard Poodle (Brown, black and white)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Standard Poodle (Grey and fawn)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Medium Poodle (Brown, black and white)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Medium Poodle (Grey and fawn)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Miniature Poodle (Brown, black and white)", 2 });

            migrationBuilder.InsertData(
                table: "Breeds",
                columns: new[] { "Id", "AddedBy", "BreedStandardId", "CreatedDate", "Group", "LastModifiedDate", "ModifiedBy", "Name", "Section", "Species" },
                values: new object[,]
                {
                    { 431, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Miniature Poodle (Grey and fawn)", 2, "Dogz" },
                    { 432, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Toy Poodle", 2, "Dogz" },
                    { 433, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Multicoloured Poodle", 2, "Dogz" },
                    { 434, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Griffon Belge", 3, "Dogz" },
                    { 435, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Griffon Bruxellois", 3, "Dogz" },
                    { 436, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Petit Brabançon", 3, "Dogz" },
                    { 437, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Chinese Crested Dog", 4, "Dogz" },
                    { 438, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Lhasa Apso", 5, "Dogz" },
                    { 439, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Shih Tzu", 5, "Dogz" },
                    { 440, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Tibetan Spaniel", 5, "Dogz" },
                    { 441, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Tibetan Terrier", 5, "Dogz" },
                    { 442, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Chihuahua (Long haired)", 6, "Dogz" },
                    { 443, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Chihuahua (Smooth haired)", 6, "Dogz" },
                    { 444, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Cavalier King Charles Spaniel", 7, "Dogz" },
                    { 445, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "King Charles Spaniel", 7, "Dogz" },
                    { 446, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Pekingese", 8, "Dogz" },
                    { 447, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Japanese Chin", 8, "Dogz" },
                    { 448, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Continental Toy Spaniel (Papillion)", 9, "Dogz" },
                    { 449, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Continental Toy Spaniel (Phalène)", 9, "Dogz" },
                    { 450, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Russian Toy (Smooth haired)", 9, "Dogz" },
                    { 451, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Russian Toy (Long haired)", 9, "Dogz" },
                    { 452, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Kromfohrländer", 10, "Dogz" },
                    { 453, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Pug", 11, "Dogz" },
                    { 454, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "French Bulldog", 11, "Dogz" },
                    { 455, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Boston Terrier", 11, "Dogz" },
                    { 456, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Prague Ratter", 11, "Dogz" },
                    { 457, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Afghan Hound", 1, "Dogz" },
                    { 458, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Saluki", 1, "Dogz" },
                    { 459, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Borzoi - Russian Hunting Sighthound", 1, "Dogz" },
                    { 460, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Deerhound", 2, "Dogz" },
                    { 461, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Irish Wolfhound", 2, "Dogz" },
                    { 462, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Greyhound", 3, "Dogz" },
                    { 463, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Whippet", 3, "Dogz" },
                    { 464, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Hungarian Greyhound", 3, "Dogz" },
                    { 465, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Azawakh", 3, "Dogz" },
                    { 466, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Sloughi", 3, "Dogz" },
                    { 467, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Polish Greyhound", 3, "Dogz" },
                    { 468, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Spanish Greyhound", 3, "Dogz" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BreedVarieties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BreedVarieties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BreedVarieties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BreedVarieties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BreedVarieties",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BreedVarieties",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BreedVarieties",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BreedVarieties",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BreedVarieties",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BreedVarieties",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BreedVarieties",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Breeds",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Belgian Shepherd Dog (Groenendael)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Belgian Shepherd Dog (Laekenois)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Belgian Shepherd Dog (Malinois)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Belgian Shepherd Dog (Tervueren)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Pyrenean Sheepdog Longhaired");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Picardy Sheepdog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Pyrenean Sheepdog Smooth Faced");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "German Shepherd Dog (Double Coat)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "German Shepherd Dog (Long and Harsh Outer Coat)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Collie (Rough)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Collie (Smooth)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "Puli (pearl-white)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 24,
                column: "Name",
                value: "Puli (other colors)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 25,
                column: "Name",
                value: "Pumi");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 26,
                column: "Name",
                value: "Bergamasco Shepherd Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 27,
                column: "Name",
                value: "Maremma and the Abruzzes Sheepdog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "Polish Lowland Sheepdog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: "Tatra Shepherd Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 30,
                column: "Name",
                value: "Portuguese Sheepdog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31,
                column: "Name",
                value: "Romanian Carpathian Shepherd Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "Romanian Mioritic Shepherd Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33,
                column: "Name",
                value: "South Russian Shepherd Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "Czechoslovakian Wolfdog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "Slovakian Chuvach");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36,
                column: "Name",
                value: "Catalan Sheepdog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37,
                column: "Name",
                value: "Majorca Shepherd Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38,
                column: "Name",
                value: "White Swiss Shepherd Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39,
                column: "Name",
                value: "Dutch Schapendoes");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40,
                column: "Name",
                value: "Dutch Shepherd Dog (Short-haired)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41,
                column: "Name",
                value: "Dutch Shepherd Dog (Long Haired)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42,
                column: "Name",
                value: "Dutch Shepherd Dog (Rough haired)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43,
                column: "Name",
                value: "Saarloos Wolfhond");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Australian Shepherd", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45,
                column: "Name",
                value: "Australian Cattle Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46,
                column: "Name",
                value: "Bouvier Des Ardennes");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47,
                column: "Name",
                value: "Bouvier Des Flandres");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48,
                column: "Name",
                value: "Welsh Corgi (Cardigan)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49,
                column: "Name",
                value: "Welsh Corgi (Pembroke)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50,
                column: "Name",
                value: "Australian Stumpy Tailed Cattle Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51,
                column: "Name",
                value: "Lancashire Heeler");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52,
                column: "Name",
                value: "Miniature American Shepherd");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53,
                column: "Name",
                value: "Catahoula Leopard Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54,
                column: "Name",
                value: "Bohemian Shepherd Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Atlas Mountain Dog (Aidi)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Yugoslavian Shepherd Dog - Sharplanina", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Castro Laboreiro Dog", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Estrela Mountain Dog (Short haired)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Estrela Mountain Dog (Long haired)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Rafeiro of Alentejo", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Romanian Bucovina Shepherd", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Caucasian Shepherd Dog", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Central Asia Shepherd Dog", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Karst Shepherd Dog", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Pyrenean Mastiff", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111,
                column: "Name",
                value: "Spanish Mastiff");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112,
                column: "Name",
                value: "St. Bernard (Short haired)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113,
                column: "Name",
                value: "St. Bernard (Long haired)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114,
                column: "Name",
                value: "Tibetan Mastiff");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115,
                column: "Name",
                value: "Kangal Shepherd Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116,
                column: "Name",
                value: "Anatolian Shepherd Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Appenzell Cattle Dog", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Bernese Mountain Dog", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Entlebuch Cattle Dog", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Great Swiss Mountain Dog", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Continental Bulldog", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Transmontano Mastiff", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Brazilian Terrier", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "German Hunting Terrier", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Airedale Terrier", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Bedlington Terrier", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Border Terrier", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Fox Terrier (Smooth)", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Fox Terrier (Wire)", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Lakeland Terrier", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Manchester Terrier", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Parson Russell Terrier", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Welsh Terrier", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Irish Glen of Imaal Terrier", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Irish Soft Coated Wheaten Terrier", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Irish Terrier", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Kerry Blue Terrier", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Australian Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Cesky Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Cairn Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Dandie Dinmont Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Jack Russell Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Patterdale Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Rat Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Teddy Roosevelt Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Norfolk Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Norwich Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Scottish Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Sealyham Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Skye Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "West Highland White Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Japanese Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Bull Terrier", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Miniature Bull Terrier", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "Staffordshire Bull Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Group", "Name" },
                values: new object[] { 3, "American Staffordshire Terrier" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Australian Silky Terrier", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Yorkshire Terrier", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "English Toy Terrier (Black and tan)", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 3, "Valencian Terrier", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Group", "Name" },
                values: new object[] { 4, "Standard Dachshund (Long haired)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Group", "Name" },
                values: new object[] { 4, "Standard Dachshund (Smooth haired)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Group", "Name" },
                values: new object[] { 4, "Standard Dachshund (Wire haired)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Group", "Name" },
                values: new object[] { 4, "Miniature Dachshund (Long haired)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Group", "Name" },
                values: new object[] { 4, "Miniature Dachshund (Smooth haired)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Group", "Name" },
                values: new object[] { 4, "Miniature Dachshund (Wire haired)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Group", "Name" },
                values: new object[] { 4, "Rabbit Dachshund (Long haired)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Group", "Name" },
                values: new object[] { 4, "Rabbit Dachshund (Smooth haired)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Group", "Name" },
                values: new object[] { 4, "Rabbit Dachshund (Wire haired)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Group", "Name" },
                values: new object[] { 5, "Canadian Eskimo Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Group", "Name" },
                values: new object[] { 5, "Greenland Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Group", "Name" },
                values: new object[] { 5, "Samoyed" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Group", "Name" },
                values: new object[] { 5, "Alaskan Malamute" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Group", "Name" },
                values: new object[] { 5, "Siberian Husky" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Finnish Spitz", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Group", "Name" },
                values: new object[] { 5, "Karelian Bear Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Group", "Name" },
                values: new object[] { 5, "Norwegian Elkhound (Black)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Group", "Name" },
                values: new object[] { 5, "Norwegian Elkhound (Grey)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Group", "Name" },
                values: new object[] { 5, "Norwegian Lundehund" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Group", "Name" },
                values: new object[] { 5, "East Siberian Laika" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Group", "Name" },
                values: new object[] { 5, "Russian-European Laika" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Group", "Name" },
                values: new object[] { 5, "West Siberian Laika" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Group", "Name" },
                values: new object[] { 5, "Jämthund" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Group", "Name" },
                values: new object[] { 5, "Norrbottenspitz" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Finnish Lapponian Dog", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Lapponian Herder", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Icelandic Sheepdog", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Norwegian Buhund", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Swedish Lapphund", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Swedish Vallhund", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "American Eskimo Dog", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Keeshond (Wolspitz)", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Giant Spitz (White)", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Giant Spitz (Brown and black)", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Group", "Name" },
                values: new object[] { 5, "Medium size Spitz (White)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Group", "Name" },
                values: new object[] { 5, "Medium size Spitz (Other colours)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Group", "Name" },
                values: new object[] { 5, "Medium size Spitz (Brown and black)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Group", "Name" },
                values: new object[] { 5, "Miniature Spitz (Brown and black)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Miniature Spitz (White)", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Miniature Spitz (Other colours)", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Pomeranian", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Italian Volpino", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Alaskan Klee Kai", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Chow Chow", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Eurasian", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "Akita", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 5, "American Akita", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Hokkaido", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Japanese Spitz", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Kai", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Kishu", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Shiba", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Shikoku", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Korea Jindo Dog", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Thai Bangkaew Dog", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Basenji", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Canaan Dog", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Pharoah Hound", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Xoloitzcuintle (Miniature)", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Xoloitzcuintle (Intermediate)", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Xoloitzcuintle (Standard)", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Peruvian Hairless Dog (Large)", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Peruvian Hairless Dog (Medium)", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Peruvian Hairless Dog (Miniature)", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Name", "Section" },
                values: new object[] { "American Hairless Terrier (Hairless)", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Name", "Section" },
                values: new object[] { "American Hairless Terrier (Coated)", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Cirneco Dell'Etna", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Portuguese Podengo Small(Long and wire haired)", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Portuguese Podengo Small(Smooth and short haired)", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Portuguese Podengo Medium(Long and wire haired)", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Portuguese Podengo Medium(Smooth and short haired)", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Portuguese Podengo Large(Long and wire haired)", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Portuguese Podengo Large(Smooth and short haired)", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Canarian Warren Hound", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Ibizan Podenco (Smooth haired)", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Ibizan Podenco (Rough haired)", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Taiwan Dog", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Thai Ridgeback Dog", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Yakutian Laika", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Kintamani-Bali Dog", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Bloodhound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Brazilian Tracker", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Billy", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "French Tricolour Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "French White and Black Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "French White and Orange Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Gascon Saintongeois (Great and small)", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Grand Griffon Vendeen", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Great Anglo-French Tricolour Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Great Anglo-French White and Orange Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Great Anglo-French White and Black Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Great Gascony Blue", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Poitevin", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "English Foxhound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Otterhound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Polish Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "American Foxhound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Black and Tan Coonhound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Bluetick Coonhound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Redbone Coonhound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Treeing Walker Coonhound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Plott Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Austrian Black and Tan Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Coarse Haired Styrian Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Tyrolean Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Bosnian Broken Haired Hound - Barak", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Istrian Short Haired Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Istrian Wire Haired Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Posavatz Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Finnish Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Ariegeois", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Artois Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Beagle Harrier", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Blue Gascony Griffon", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Briquet Griffon Vendeen", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Fawn Brittany Griffon", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Griffon Nivernais", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 6, "Medium sized Anglo-French Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 279,
                column: "Name",
                value: "Porcelaine");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 280,
                column: "Name",
                value: "Small Blue Gascony");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 281,
                column: "Name",
                value: "Harrier");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 282,
                column: "Name",
                value: "Hellenic Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 283,
                column: "Name",
                value: "Hungarian Hound - Transylvanian Scent Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 284,
                column: "Name",
                value: "Italian Rough Haired Segugio");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 285,
                column: "Name",
                value: "Italian Short Haired Segugio");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 286,
                column: "Name",
                value: "Montenegrin Mountain Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 287,
                column: "Name",
                value: "Halden Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 288,
                column: "Name",
                value: "Hygen Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 289,
                column: "Name",
                value: "Norwegian Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 290,
                column: "Name",
                value: "Polish Hunting Dog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 291,
                column: "Name",
                value: "Serbian Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 292,
                column: "Name",
                value: "Serbian Tricolour Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 293,
                column: "Name",
                value: "Slovakian Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 294,
                column: "Name",
                value: "Spanish Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 295,
                column: "Name",
                value: "Hamiltonstövare");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 296,
                column: "Name",
                value: "Schillerstövare");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 297,
                column: "Name",
                value: "Smålandsstövare");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 298,
                column: "Name",
                value: "Dunkerstövare");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 299,
                column: "Name",
                value: "Bernese Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 300,
                column: "Name",
                value: "Jura Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 301,
                column: "Name",
                value: "Lucerne Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 302,
                column: "Name",
                value: "Schwyz Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 303,
                column: "Name",
                value: "Basset Fauve de Bretagne");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 304,
                column: "Name",
                value: "Blue Gascony Basset");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 305,
                column: "Name",
                value: "Grand Basset Griffon Vendeen");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 306,
                column: "Name",
                value: "Norman Artesien Basset");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 307,
                column: "Name",
                value: "Petit Basset Griffon Vendeen");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 308,
                column: "Name",
                value: "German Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 309,
                column: "Name",
                value: "Westphalian Dachsbracke");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 310,
                column: "Name",
                value: "Basset Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 311,
                column: "Name",
                value: "Beagle");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 312,
                column: "Name",
                value: "Drever");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 313,
                column: "Name",
                value: "Small Swiss Hound");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Alpine Dachsbracke", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Bavarian Mountain Scent Hound", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Hanoverian Scent Hound", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Dalmatian", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Rhodesian Ridgeback", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Estonian Hound", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "Name", "Section" },
                values: new object[] { "Segugio Maremmano", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "Name", "Section" },
                values: new object[] { "PFM Mutt", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Old Danish Pointing Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Ariege Pointing Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Auvergne Pointer" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Bourbonnais Pointing Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "French Pointing Dog - Gascogne Type" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "French Pointing Dog - Pyrenean Type" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Saint Germain Pointer" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Deutsch Stichelhaar" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "German Short Haired Pointing Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "German Wire Haired Pointing Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "German Long Haired Pointing Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Pudelpointer" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Weimaraner (Short haired)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Weimaraner (Long haired)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Hungarian Short Haired Pointer (Vizsla)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Hungarian Wire Haired Pointer (Vizsla)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Italian Pointing Dog (Bracco Italiano)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Portugeuse Pointing Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Slovakian Wire Haired Pointer" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Burgos Pointing Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Blue Picardy Spaniel" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Brittany Spaniel" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "French Spaniel" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Picardy Spaniel" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Pont-Audemer Spaniel" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Deutsch Langhaar" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Kleiner Münsterländer" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Large Munsterlander" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Drentsche Partridge Dog" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "Group", "Name" },
                values: new object[] { 7, "Stabijhoun" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Bohemian Wire Haired Griffon", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Wire Haired Pointing Griffon Korthals", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Italian Spinone", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "English Pointer", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "English Setter", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Gordon Setter", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Irish Red and White Setter", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 7, "Irish Red Setter", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "Group", "Name" },
                values: new object[] { 8, "Nova Scotia Duck Tolling Retriever" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "Group", "Name" },
                values: new object[] { 8, "Curly Coated Retriever" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "Group", "Name" },
                values: new object[] { 8, "Flat Coated Retriever" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "Group", "Name" },
                values: new object[] { 8, "Golden Retriever" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "Group", "Name" },
                values: new object[] { 8, "Labrador Retriever" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "Group", "Name" },
                values: new object[] { 8, "Chesapeake Bay Retriever" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "German Spaniel (Wachtelhund)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Clumber Spaniel", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "English Cocker Spaniel", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "English Springer Spaniel", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Field Spaniel", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Sussex Spaniel", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Welsh Springer Spaniel", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Nederlandse Kooikerhondje", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "American Cocker Spaniel", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "French Water Dog (Barbet)", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Irish Water Spaniel", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Romagna Water Dog (Lagotto Romagnolo)", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Portuguese Water Dog", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Spanish Water Dog", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "Frisian Water Dog (Wetterhoun)", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 8, "American Water Spaniel", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "Group", "Name" },
                values: new object[] { 9, "Bichon Frise" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "Group", "Name" },
                values: new object[] { 9, "Maltese" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "Group", "Name" },
                values: new object[] { 9, "Havanese" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "Group", "Name" },
                values: new object[] { 9, "Bolognese" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "Group", "Name" },
                values: new object[] { 9, "Coton de Tulear" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "Group", "Name" },
                values: new object[] { 9, "Löwchen (Little Lion Dog)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Standard Poodle (Brown, black and white)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Standard Poodle (Grey and fawn)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Medium Poodle (Brown, black and white)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Medium Poodle (Grey and fawn)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Miniature Poodle (Brown, black and white)", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "Group", "Name" },
                values: new object[] { 9, "Miniature Poodle (Grey and fawn)" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "Group", "Name" },
                values: new object[] { 9, "Toy Poodle" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "Group", "Name" },
                values: new object[] { 9, "Multicoloured Poodle" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Griffon Belge", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Griffon Bruxellois", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Petit Brabançon", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Chinese Crested Dog", 4 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Lhasa Apso", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Shih Tzu", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Tibetan Spaniel", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Tibetan Terrier", 5 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Chihuahua (Long haired)", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Chihuahua (Smooth haired)", 6 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Cavalier King Charles Spaniel", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "King Charles Spaniel", 7 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Pekingese", 8 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Japanese Chin", 8 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Continental Toy Spaniel (Papillion)", 9 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Continental Toy Spaniel (Phalène)", 9 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Russian Toy (Smooth haired)", 9 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Russian Toy (Long haired)", 9 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Kromfohrländer", 10 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Pug", 11 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "French Bulldog", 11 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Boston Terrier", 11 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 9, "Prague Ratter", 11 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 10, "Afghan Hound", 1 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "Group", "Name" },
                values: new object[] { 10, "Saluki" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "Group", "Name" },
                values: new object[] { 10, "Borzoi - Russian Hunting Sighthound" });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 10, "Deerhound", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 10, "Irish Wolfhound", 2 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 10, "Greyhound", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 10, "Whippet", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 10, "Hungarian Greyhound", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 10, "Azawakh", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 10, "Sloughi", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 10, "Polish Greyhound", 3 });

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "Group", "Name", "Section" },
                values: new object[] { 10, "Spanish Greyhound", 3 });

            migrationBuilder.InsertData(
                table: "Breeds",
                columns: new[] { "Id", "AddedBy", "BreedStandardId", "CreatedDate", "Group", "LastModifiedDate", "ModifiedBy", "Name", "Section", "Species" },
                values: new object[,]
                {
                    { 55, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "English Shepherd Dog", 2, "Dogz" },
                    { 56, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Austrian Pinscher", 1, "Dogz" },
                    { 57, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Danish-Swedish Farmdog", 1, "Dogz" },
                    { 58, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Affenpinscher", 1, "Dogz" },
                    { 59, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Dobermann", 1, "Dogz" },
                    { 60, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "German Pinscher", 1, "Dogz" },
                    { 61, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Miniature Pinscher", 1, "Dogz" },
                    { 62, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Giant Schnauzer (Pepper and Salt)", 1, "Dogz" },
                    { 63, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Giant Schnauzer (Black and white)", 1, "Dogz" },
                    { 64, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Giant Schnauzer (Black and silver)", 1, "Dogz" },
                    { 65, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Miniature Schnauzer (Pepper and salt)", 1, "Dogz" },
                    { 66, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Miniature Schnauzer (Black)", 1, "Dogz" },
                    { 67, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Miniature Schnauzer (Black and silver)", 1, "Dogz" },
                    { 68, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Miniature Schnauzer (White)", 1, "Dogz" },
                    { 69, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Schnauzer (Pepper and salt)", 1, "Dogz" },
                    { 70, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Schnauzer (Black)", 1, "Dogz" },
                    { 71, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Dutch Smoushond", 1, "Dogz" },
                    { 72, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Russian Black Terrier", 1, "Dogz" },
                    { 73, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Dogo Argentino", 2, "Dogz" },
                    { 74, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Fila Brasileiro", 2, "Dogz" },
                    { 75, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Shar Pei", 2, "Dogz" },
                    { 76, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Broholmer", 2, "Dogz" },
                    { 77, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Dogue de Bordeaux", 2, "Dogz" },
                    { 78, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Boxer", 2, "Dogz" },
                    { 79, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Great Dane (Fawn and Brindle)", 2, "Dogz" },
                    { 80, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Great Dane (Black and Harlequin)", 2, "Dogz" },
                    { 81, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Great Dane (Blue)", 2, "Dogz" },
                    { 82, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Rottweiler", 2, "Dogz" },
                    { 83, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Bulldog (English)", 2, "Dogz" },
                    { 84, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Bulldog (American)", 2, "Dogz" },
                    { 85, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Bullmastiff", 2, "Dogz" },
                    { 86, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Mastiff", 2, "Dogz" },
                    { 87, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Italian Cane Corso", 2, "Dogz" },
                    { 88, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Neapolitan Mastiff", 2, "Dogz" },
                    { 89, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Tosa", 2, "Dogz" },
                    { 90, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Saint Miguel Cattle Dog (Azores)", 2, "Dogz" },
                    { 91, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Majorca Mastiff", 2, "Dogz" },
                    { 92, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Presa Canario", 2, "Dogz" },
                    { 93, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Cimarrón Uruguayo", 2, "Dogz" },
                    { 94, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Bosnian and Herzegovinian - Croatian Shepherd Dog", 2, "Dogz" },
                    { 95, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Newfoundland", 2, "Dogz" },
                    { 96, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Pyrenean Mountain Dog", 2, "Dogz" },
                    { 97, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Hovawart", 2, "Dogz" },
                    { 98, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Leonberger", 2, "Dogz" },
                    { 99, "system", null, new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Landseer (European Continental Type)", 2, "Dogz" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Breeds_Name",
                table: "Breeds",
                column: "Name",
                unique: true);
        }
    }
}
