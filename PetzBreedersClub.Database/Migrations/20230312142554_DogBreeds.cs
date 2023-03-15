using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetzBreedersClub.Database.Migrations
{
    /// <inheritdoc />
    public partial class DogBreeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Old English Sheepdog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "Shetland Sheepdog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "Komondor");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "Kuvasz");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "Mudi");

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

            migrationBuilder.InsertData(
                table: "Breeds",
                columns: new[] { "Id", "AddedBy", "CreatedDate", "Group", "LastModifiedDate", "ModifiedBy", "Name", "Section", "Species" },
                values: new object[,]
                {
                    { 31, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Romanian Carpathian Shepherd Dog", 1, "Dogz" },
                    { 32, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Romanian Mioritic Shepherd Dog", 1, "Dogz" },
                    { 33, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "South Russian Shepherd Dog", 1, "Dogz" },
                    { 34, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Czechoslovakian Wolfdog", 1, "Dogz" },
                    { 35, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Slovakian Chuvach", 1, "Dogz" },
                    { 36, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Catalan Sheepdog", 1, "Dogz" },
                    { 37, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Majorca Shepherd Dog", 1, "Dogz" },
                    { 38, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "White Swiss Shepherd Dog", 1, "Dogz" },
                    { 39, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Dutch Schapendoes", 1, "Dogz" },
                    { 40, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Dutch Shepherd Dog (Short-haired)", 1, "Dogz" },
                    { 41, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Dutch Shepherd Dog (Long Haired)", 1, "Dogz" },
                    { 42, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Dutch Shepherd Dog (Rough haired)", 1, "Dogz" },
                    { 43, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Saarloos Wolfhond", 1, "Dogz" },
                    { 44, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Australian Shepherd", 1, "Dogz" },
                    { 45, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Australian Cattle Dog", 2, "Dogz" },
                    { 46, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Bouvier Des Ardennes", 2, "Dogz" },
                    { 47, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Bouvier Des Flandres", 2, "Dogz" },
                    { 48, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Welsh Corgi (Cardigan)", 2, "Dogz" },
                    { 49, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Welsh Corgi (Pembroke)", 2, "Dogz" },
                    { 50, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Australian Stumpy Tailed Cattle Dog", 2, "Dogz" },
                    { 51, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Lancashire Heeler", 2, "Dogz" },
                    { 52, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Miniature American Shepherd", 2, "Dogz" },
                    { 53, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Catahoula Leopard Dog", 2, "Dogz" },
                    { 54, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "Bohemian Shepherd Dog", 2, "Dogz" },
                    { 55, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 1, null, null, "English Shepherd Dog", 2, "Dogz" },
                    { 56, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Austrian Pinscher", 1, "Dogz" },
                    { 57, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Danish-Swedish Farmdog", 1, "Dogz" },
                    { 58, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Affenpinscher", 1, "Dogz" },
                    { 59, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Dobermann", 1, "Dogz" },
                    { 60, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "German Pinscher", 1, "Dogz" },
                    { 61, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Miniature Pinscher", 1, "Dogz" },
                    { 62, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Giant Schnauzer (Pepper and Salt)", 1, "Dogz" },
                    { 63, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Giant Schnauzer (Black and white)", 1, "Dogz" },
                    { 64, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Giant Schnauzer (Black and silver)", 1, "Dogz" },
                    { 65, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Miniature Schnauzer (Pepper and salt)", 1, "Dogz" },
                    { 66, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Miniature Schnauzer (Black)", 1, "Dogz" },
                    { 67, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Miniature Schnauzer (Black and silver)", 1, "Dogz" },
                    { 68, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Miniature Schnauzer (White)", 1, "Dogz" },
                    { 69, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Schnauzer (Pepper and salt)", 1, "Dogz" },
                    { 70, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Schnauzer (Black)", 1, "Dogz" },
                    { 71, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Dutch Smoushond", 1, "Dogz" },
                    { 72, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Russian Black Terrier", 1, "Dogz" },
                    { 73, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Dogo Argentino", 2, "Dogz" },
                    { 74, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Fila Brasileiro", 2, "Dogz" },
                    { 75, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Shar Pei", 2, "Dogz" },
                    { 76, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Broholmer", 2, "Dogz" },
                    { 77, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Dogue de Bordeaux", 2, "Dogz" },
                    { 78, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Boxer", 2, "Dogz" },
                    { 79, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Great Dane (Fawn and Brindle)", 2, "Dogz" },
                    { 80, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Great Dane (Black and Harlequin)", 2, "Dogz" },
                    { 81, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Great Dane (Blue)", 2, "Dogz" },
                    { 82, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Rottweiler", 2, "Dogz" },
                    { 83, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Bulldog (English)", 2, "Dogz" },
                    { 84, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Bulldog (American)", 2, "Dogz" },
                    { 85, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Bullmastiff", 2, "Dogz" },
                    { 86, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Mastiff", 2, "Dogz" },
                    { 87, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Italian Cane Corso", 2, "Dogz" },
                    { 88, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Neapolitan Mastiff", 2, "Dogz" },
                    { 89, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Tosa", 2, "Dogz" },
                    { 90, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Saint Miguel Cattle Dog (Azores)", 2, "Dogz" },
                    { 91, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Majorca Mastiff", 2, "Dogz" },
                    { 92, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Presa Canario", 2, "Dogz" },
                    { 93, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Cimarrón Uruguayo", 2, "Dogz" },
                    { 94, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Bosnian and Herzegovinian - Croatian Shepherd Dog", 2, "Dogz" },
                    { 95, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Newfoundland", 2, "Dogz" },
                    { 96, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Pyrenean Mountain Dog", 2, "Dogz" },
                    { 97, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Hovawart", 2, "Dogz" },
                    { 98, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Leonberger", 2, "Dogz" },
                    { 99, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Landseer (European Continental Type)", 2, "Dogz" },
                    { 100, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Atlas Mountain Dog (Aidi)", 2, "Dogz" },
                    { 101, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Yugoslavian Shepherd Dog - Sharplanina", 2, "Dogz" },
                    { 102, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Castro Laboreiro Dog", 2, "Dogz" },
                    { 103, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Estrela Mountain Dog (Short haired)", 2, "Dogz" },
                    { 104, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Estrela Mountain Dog (Long haired)", 2, "Dogz" },
                    { 105, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Rafeiro of Alentejo", 2, "Dogz" },
                    { 106, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Romanian Bucovina Shepherd", 2, "Dogz" },
                    { 107, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Caucasian Shepherd Dog", 2, "Dogz" },
                    { 108, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Central Asia Shepherd Dog", 2, "Dogz" },
                    { 109, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Karst Shepherd Dog", 2, "Dogz" },
                    { 110, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Pyrenean Mastiff", 2, "Dogz" },
                    { 111, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Spanish Mastiff", 2, "Dogz" },
                    { 112, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "St. Bernard (Short haired)", 2, "Dogz" },
                    { 113, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "St. Bernard (Long haired)", 2, "Dogz" },
                    { 114, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Tibetan Mastiff", 2, "Dogz" },
                    { 115, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Kangal Shepherd Dog", 2, "Dogz" },
                    { 116, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Anatolian Shepherd Dog", 2, "Dogz" },
                    { 117, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Appenzell Cattle Dog", 3, "Dogz" },
                    { 118, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Bernese Mountain Dog", 3, "Dogz" },
                    { 119, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Entlebuch Cattle Dog", 3, "Dogz" },
                    { 120, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Great Swiss Mountain Dog", 3, "Dogz" },
                    { 121, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Continental Bulldog", 3, "Dogz" },
                    { 122, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 2, null, null, "Transmontano Mastiff", 3, "Dogz" },
                    { 123, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Brazilian Terrier", 1, "Dogz" },
                    { 124, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "German Hunting Terrier", 1, "Dogz" },
                    { 125, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Airedale Terrier", 1, "Dogz" },
                    { 126, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Bedlington Terrier", 1, "Dogz" },
                    { 127, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Border Terrier", 1, "Dogz" },
                    { 128, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Fox Terrier (Smooth)", 1, "Dogz" },
                    { 129, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Fox Terrier (Wire)", 1, "Dogz" },
                    { 130, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Lakeland Terrier", 1, "Dogz" },
                    { 131, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Manchester Terrier", 1, "Dogz" },
                    { 132, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Parson Russell Terrier", 1, "Dogz" },
                    { 133, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Welsh Terrier", 1, "Dogz" },
                    { 134, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Irish Glen of Imaal Terrier", 1, "Dogz" },
                    { 135, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Irish Soft Coated Wheaten Terrier", 1, "Dogz" },
                    { 136, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Irish Terrier", 1, "Dogz" },
                    { 137, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Kerry Blue Terrier", 1, "Dogz" },
                    { 138, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Australian Terrier", 2, "Dogz" },
                    { 139, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Cesky Terrier", 2, "Dogz" },
                    { 140, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Cairn Terrier", 2, "Dogz" },
                    { 141, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Dandie Dinmont Terrier", 2, "Dogz" },
                    { 142, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Jack Russell Terrier", 2, "Dogz" },
                    { 143, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Patterdale Terrier", 2, "Dogz" },
                    { 144, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Rat Terrier", 2, "Dogz" },
                    { 145, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Teddy Roosevelt Terrier", 2, "Dogz" },
                    { 146, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Norfolk Terrier", 2, "Dogz" },
                    { 147, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Norwich Terrier", 2, "Dogz" },
                    { 148, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Scottish Terrier", 2, "Dogz" },
                    { 149, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Sealyham Terrier", 2, "Dogz" },
                    { 150, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Skye Terrier", 2, "Dogz" },
                    { 151, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "West Highland White Terrier", 2, "Dogz" },
                    { 152, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Japanese Terrier", 2, "Dogz" },
                    { 153, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Bull Terrier", 3, "Dogz" },
                    { 154, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Miniature Bull Terrier", 3, "Dogz" },
                    { 155, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Staffordshire Bull Terrier", 3, "Dogz" },
                    { 156, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "American Staffordshire Terrier", 3, "Dogz" },
                    { 157, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Australian Silky Terrier", 4, "Dogz" },
                    { 158, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Yorkshire Terrier", 4, "Dogz" },
                    { 159, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "English Toy Terrier (Black and tan)", 4, "Dogz" },
                    { 160, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 3, null, null, "Valencian Terrier", 4, "Dogz" },
                    { 161, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 4, null, null, "Standard Dachshund (Long haired)", 1, "Dogz" },
                    { 162, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 4, null, null, "Standard Dachshund (Smooth haired)", 1, "Dogz" },
                    { 163, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 4, null, null, "Standard Dachshund (Wire haired)", 1, "Dogz" },
                    { 164, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 4, null, null, "Miniature Dachshund (Long haired)", 1, "Dogz" },
                    { 165, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 4, null, null, "Miniature Dachshund (Smooth haired)", 1, "Dogz" },
                    { 166, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 4, null, null, "Miniature Dachshund (Wire haired)", 1, "Dogz" },
                    { 167, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 4, null, null, "Rabbit Dachshund (Long haired)", 1, "Dogz" },
                    { 168, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 4, null, null, "Rabbit Dachshund (Smooth haired)", 1, "Dogz" },
                    { 169, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 4, null, null, "Rabbit Dachshund (Wire haired)", 1, "Dogz" },
                    { 170, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Canadian Eskimo Dog", 1, "Dogz" },
                    { 171, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Greenland Dog", 1, "Dogz" },
                    { 172, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Samoyed", 1, "Dogz" },
                    { 173, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Alaskan Malamute", 1, "Dogz" },
                    { 174, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Siberian Husky", 1, "Dogz" },
                    { 175, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Finnish Spitz", 2, "Dogz" },
                    { 176, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Karelian Bear Dog", 2, "Dogz" },
                    { 177, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Norwegian Elkhound (Black)", 2, "Dogz" },
                    { 178, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Norwegian Elkhound (Grey)", 2, "Dogz" },
                    { 179, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Norwegian Lundehund", 2, "Dogz" },
                    { 180, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "East Siberian Laika", 2, "Dogz" },
                    { 181, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Russian-European Laika", 2, "Dogz" },
                    { 182, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "West Siberian Laika", 2, "Dogz" },
                    { 183, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Jämthund", 2, "Dogz" },
                    { 184, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Norrbottenspitz", 2, "Dogz" },
                    { 185, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Finnish Lapponian Dog", 3, "Dogz" },
                    { 186, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Lapponian Herder", 3, "Dogz" },
                    { 187, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Icelandic Sheepdog", 3, "Dogz" },
                    { 188, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Norwegian Buhund", 3, "Dogz" },
                    { 189, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Swedish Lapphund", 3, "Dogz" },
                    { 190, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Swedish Vallhund", 3, "Dogz" },
                    { 191, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "American Eskimo Dog", 4, "Dogz" },
                    { 192, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Keeshond (Wolspitz)", 4, "Dogz" },
                    { 193, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Giant Spitz (White)", 4, "Dogz" },
                    { 194, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Giant Spitz (Brown and black)", 4, "Dogz" },
                    { 195, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Medium size Spitz (White)", 4, "Dogz" },
                    { 196, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Medium size Spitz (Other colours)", 4, "Dogz" },
                    { 197, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Medium size Spitz (Brown and black)", 4, "Dogz" },
                    { 198, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Miniature Spitz (Brown and black)", 4, "Dogz" },
                    { 199, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Miniature Spitz (White)", 4, "Dogz" },
                    { 200, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Miniature Spitz (Other colours)", 4, "Dogz" },
                    { 201, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Pomeranian", 4, "Dogz" },
                    { 202, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Italian Volpino", 4, "Dogz" },
                    { 203, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Alaskan Klee Kai", 4, "Dogz" },
                    { 204, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Chow Chow", 5, "Dogz" },
                    { 205, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Eurasian", 5, "Dogz" },
                    { 206, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Akita", 5, "Dogz" },
                    { 207, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "American Akita", 5, "Dogz" },
                    { 208, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Hokkaido", 5, "Dogz" },
                    { 209, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Japanese Spitz", 5, "Dogz" },
                    { 210, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Kai", 5, "Dogz" },
                    { 211, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Kishu", 5, "Dogz" },
                    { 212, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Shiba", 5, "Dogz" },
                    { 213, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Shikoku", 5, "Dogz" },
                    { 214, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Korea Jindo Dog", 5, "Dogz" },
                    { 215, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Thai Bangkaew Dog", 5, "Dogz" },
                    { 216, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Basenji", 6, "Dogz" },
                    { 217, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Canaan Dog", 6, "Dogz" },
                    { 218, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Pharoah Hound", 6, "Dogz" },
                    { 219, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Xoloitzcuintle (Miniature)", 6, "Dogz" },
                    { 220, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Xoloitzcuintle (Intermediate)", 6, "Dogz" },
                    { 221, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Xoloitzcuintle (Standard)", 6, "Dogz" },
                    { 222, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Peruvian Hairless Dog (Large)", 6, "Dogz" },
                    { 223, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Peruvian Hairless Dog (Medium)", 6, "Dogz" },
                    { 224, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Peruvian Hairless Dog (Miniature)", 6, "Dogz" },
                    { 225, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "American Hairless Terrier (Hairless)", 6, "Dogz" },
                    { 226, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "American Hairless Terrier (Coated)", 6, "Dogz" },
                    { 227, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Cirneco Dell'Etna", 7, "Dogz" },
                    { 228, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Portuguese Podengo Small(Long and wire haired)", 7, "Dogz" },
                    { 229, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Portuguese Podengo Small(Smooth and short haired)", 7, "Dogz" },
                    { 230, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Portuguese Podengo Medium(Long and wire haired)", 7, "Dogz" },
                    { 231, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Portuguese Podengo Medium(Smooth and short haired)", 7, "Dogz" },
                    { 232, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Portuguese Podengo Large(Long and wire haired)", 7, "Dogz" },
                    { 233, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Portuguese Podengo Large(Smooth and short haired)", 7, "Dogz" },
                    { 234, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Canarian Warren Hound", 7, "Dogz" },
                    { 235, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Ibizan Podenco (Smooth haired)", 7, "Dogz" },
                    { 236, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Ibizan Podenco (Rough haired)", 7, "Dogz" },
                    { 237, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Taiwan Dog", 7, "Dogz" },
                    { 238, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Thai Ridgeback Dog", 7, "Dogz" },
                    { 239, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Yakutian Laika", 7, "Dogz" },
                    { 240, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 5, null, null, "Kintamani-Bali Dog", 7, "Dogz" },
                    { 241, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Bloodhound", 1, "Dogz" },
                    { 242, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Brazilian Tracker", 1, "Dogz" },
                    { 243, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Billy", 1, "Dogz" },
                    { 244, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "French Tricolour Hound", 1, "Dogz" },
                    { 245, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "French White and Black Hound", 1, "Dogz" },
                    { 246, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "French White and Orange Hound", 1, "Dogz" },
                    { 247, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Gascon Saintongeois (Great and small)", 1, "Dogz" },
                    { 248, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Grand Griffon Vendeen", 1, "Dogz" },
                    { 249, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Great Anglo-French Tricolour Hound", 1, "Dogz" },
                    { 250, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Great Anglo-French White and Orange Hound", 1, "Dogz" },
                    { 251, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Great Anglo-French White and Black Hound", 1, "Dogz" },
                    { 252, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Great Gascony Blue", 1, "Dogz" },
                    { 253, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Poitevin", 1, "Dogz" },
                    { 254, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "English Foxhound", 1, "Dogz" },
                    { 255, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Otterhound", 1, "Dogz" },
                    { 256, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Polish Hound", 1, "Dogz" },
                    { 257, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "American Foxhound", 1, "Dogz" },
                    { 258, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Black and Tan Coonhound", 1, "Dogz" },
                    { 259, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Bluetick Coonhound", 1, "Dogz" },
                    { 260, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Redbone Coonhound", 1, "Dogz" },
                    { 261, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Treeing Walker Coonhound", 1, "Dogz" },
                    { 262, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Plott Hound", 1, "Dogz" },
                    { 263, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Austrian Black and Tan Hound", 1, "Dogz" },
                    { 264, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Coarse Haired Styrian Hound", 1, "Dogz" },
                    { 265, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Tyrolean Hound", 1, "Dogz" },
                    { 266, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Bosnian Broken Haired Hound - Barak", 1, "Dogz" },
                    { 267, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Istrian Short Haired Hound", 1, "Dogz" },
                    { 268, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Istrian Wire Haired Hound", 1, "Dogz" },
                    { 269, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Posavatz Hound", 1, "Dogz" },
                    { 270, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Finnish Hound", 1, "Dogz" },
                    { 271, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Ariegeois", 1, "Dogz" },
                    { 272, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Artois Hound", 1, "Dogz" },
                    { 273, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Beagle Harrier", 1, "Dogz" },
                    { 274, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Blue Gascony Griffon", 1, "Dogz" },
                    { 275, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Briquet Griffon Vendeen", 1, "Dogz" },
                    { 276, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Fawn Brittany Griffon", 1, "Dogz" },
                    { 277, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Griffon Nivernais", 1, "Dogz" },
                    { 278, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Medium sized Anglo-French Hound", 1, "Dogz" },
                    { 279, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Porcelaine", 1, "Dogz" },
                    { 280, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Small Blue Gascony", 1, "Dogz" },
                    { 281, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Harrier", 1, "Dogz" },
                    { 282, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Hellenic Hound", 1, "Dogz" },
                    { 283, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Hungarian Hound - Transylvanian Scent Hound", 1, "Dogz" },
                    { 284, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Italian Rough Haired Segugio", 1, "Dogz" },
                    { 285, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Italian Short Haired Segugio", 1, "Dogz" },
                    { 286, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Montenegrin Mountain Hound", 1, "Dogz" },
                    { 287, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Halden Hound", 1, "Dogz" },
                    { 288, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Hygen Hound", 1, "Dogz" },
                    { 289, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Norwegian Hound", 1, "Dogz" },
                    { 290, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Polish Hunting Dog", 1, "Dogz" },
                    { 291, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Serbian Hound", 1, "Dogz" },
                    { 292, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Serbian Tricolour Hound", 1, "Dogz" },
                    { 293, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Slovakian Hound", 1, "Dogz" },
                    { 294, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Spanish Hound", 1, "Dogz" },
                    { 295, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Hamiltonstövare", 1, "Dogz" },
                    { 296, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Schillerstövare", 1, "Dogz" },
                    { 297, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Smålandsstövare", 1, "Dogz" },
                    { 298, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Dunkerstövare", 1, "Dogz" },
                    { 299, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Bernese Hound", 1, "Dogz" },
                    { 300, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Jura Hound", 1, "Dogz" },
                    { 301, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Lucerne Hound", 1, "Dogz" },
                    { 302, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Schwyz Hound", 1, "Dogz" },
                    { 303, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Basset Fauve de Bretagne", 1, "Dogz" },
                    { 304, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Blue Gascony Basset", 1, "Dogz" },
                    { 305, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Grand Basset Griffon Vendeen", 1, "Dogz" },
                    { 306, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Norman Artesien Basset", 1, "Dogz" },
                    { 307, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Petit Basset Griffon Vendeen", 1, "Dogz" },
                    { 308, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "German Hound", 1, "Dogz" },
                    { 309, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Westphalian Dachsbracke", 1, "Dogz" },
                    { 310, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Basset Hound", 1, "Dogz" },
                    { 311, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Beagle", 1, "Dogz" },
                    { 312, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Drever", 1, "Dogz" },
                    { 313, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Small Swiss Hound", 1, "Dogz" },
                    { 314, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Alpine Dachsbracke", 2, "Dogz" },
                    { 315, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Bavarian Mountain Scent Hound", 2, "Dogz" },
                    { 316, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Hanoverian Scent Hound", 2, "Dogz" },
                    { 317, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Dalmatian", 3, "Dogz" },
                    { 318, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Rhodesian Ridgeback", 3, "Dogz" },
                    { 319, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Estonian Hound", 3, "Dogz" },
                    { 320, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "Segugio Maremmano", 3, "Dogz" },
                    { 321, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 6, null, null, "PFM Mutt", 3, "Dogz" },
                    { 322, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Old Danish Pointing Dog", 1, "Dogz" },
                    { 323, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Ariege Pointing Dog", 1, "Dogz" },
                    { 324, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Auvergne Pointer", 1, "Dogz" },
                    { 325, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Bourbonnais Pointing Dog", 1, "Dogz" },
                    { 326, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "French Pointing Dog - Gascogne Type", 1, "Dogz" },
                    { 327, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "French Pointing Dog - Pyrenean Type", 1, "Dogz" },
                    { 328, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Saint Germain Pointer", 1, "Dogz" },
                    { 329, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Deutsch Stichelhaar", 1, "Dogz" },
                    { 330, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "German Short Haired Pointing Dog", 1, "Dogz" },
                    { 331, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "German Wire Haired Pointing Dog", 1, "Dogz" },
                    { 332, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "German Long Haired Pointing Dog", 1, "Dogz" },
                    { 333, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Pudelpointer", 1, "Dogz" },
                    { 334, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Weimaraner (Short haired)", 1, "Dogz" },
                    { 335, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Weimaraner (Long haired)", 1, "Dogz" },
                    { 336, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Hungarian Short Haired Pointer (Vizsla)", 1, "Dogz" },
                    { 337, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Hungarian Wire Haired Pointer (Vizsla)", 1, "Dogz" },
                    { 338, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Italian Pointing Dog (Bracco Italiano)", 1, "Dogz" },
                    { 339, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Portugeuse Pointing Dog", 1, "Dogz" },
                    { 340, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Slovakian Wire Haired Pointer", 1, "Dogz" },
                    { 341, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Burgos Pointing Dog", 1, "Dogz" },
                    { 342, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Blue Picardy Spaniel", 1, "Dogz" },
                    { 343, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Brittany Spaniel", 1, "Dogz" },
                    { 344, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "French Spaniel", 1, "Dogz" },
                    { 345, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Picardy Spaniel", 1, "Dogz" },
                    { 346, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Pont-Audemer Spaniel", 1, "Dogz" },
                    { 347, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Deutsch Langhaar", 1, "Dogz" },
                    { 348, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Kleiner Münsterländer", 1, "Dogz" },
                    { 349, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Large Munsterlander", 1, "Dogz" },
                    { 350, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Drentsche Partridge Dog", 1, "Dogz" },
                    { 351, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Stabijhoun", 1, "Dogz" },
                    { 352, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Bohemian Wire Haired Griffon", 1, "Dogz" },
                    { 353, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Wire Haired Pointing Griffon Korthals", 1, "Dogz" },
                    { 354, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Italian Spinone", 1, "Dogz" },
                    { 355, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "English Pointer", 2, "Dogz" },
                    { 356, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "English Setter", 2, "Dogz" },
                    { 357, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Gordon Setter", 2, "Dogz" },
                    { 358, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Irish Red and White Setter", 2, "Dogz" },
                    { 359, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 7, null, null, "Irish Red Setter", 2, "Dogz" },
                    { 360, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "Nova Scotia Duck Tolling Retriever", 1, "Dogz" },
                    { 361, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "Curly Coated Retriever", 1, "Dogz" },
                    { 362, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "Flat Coated Retriever", 1, "Dogz" },
                    { 363, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "Golden Retriever", 1, "Dogz" },
                    { 364, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "Labrador Retriever", 1, "Dogz" },
                    { 365, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "Chesapeake Bay Retriever", 1, "Dogz" },
                    { 366, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "German Spaniel (Wachtelhund)", 2, "Dogz" },
                    { 367, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "Clumber Spaniel", 2, "Dogz" },
                    { 368, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "English Cocker Spaniel", 2, "Dogz" },
                    { 369, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "English Springer Spaniel", 2, "Dogz" },
                    { 370, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "Field Spaniel", 2, "Dogz" },
                    { 371, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "Sussex Spaniel", 2, "Dogz" },
                    { 372, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "Welsh Springer Spaniel", 2, "Dogz" },
                    { 373, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "Nederlandse Kooikerhondje", 2, "Dogz" },
                    { 374, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "American Cocker Spaniel", 2, "Dogz" },
                    { 375, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "French Water Dog (Barbet)", 3, "Dogz" },
                    { 376, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "Irish Water Spaniel", 3, "Dogz" },
                    { 377, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "Romagna Water Dog (Lagotto Romagnolo)", 3, "Dogz" },
                    { 378, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "Portuguese Water Dog", 3, "Dogz" },
                    { 379, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "Spanish Water Dog", 3, "Dogz" },
                    { 380, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "Frisian Water Dog (Wetterhoun)", 3, "Dogz" },
                    { 381, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 8, null, null, "American Water Spaniel", 3, "Dogz" },
                    { 382, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Bichon Frise", 1, "Dogz" },
                    { 383, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Maltese", 1, "Dogz" },
                    { 384, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Havanese", 1, "Dogz" },
                    { 385, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Bolognese", 1, "Dogz" },
                    { 386, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Coton de Tulear", 1, "Dogz" },
                    { 387, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Löwchen (Little Lion Dog)", 1, "Dogz" },
                    { 388, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Standard Poodle (Brown, black and white)", 2, "Dogz" },
                    { 389, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Standard Poodle (Grey and fawn)", 2, "Dogz" },
                    { 390, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Medium Poodle (Brown, black and white)", 2, "Dogz" },
                    { 391, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Medium Poodle (Grey and fawn)", 2, "Dogz" },
                    { 392, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Miniature Poodle (Brown, black and white)", 2, "Dogz" },
                    { 393, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Miniature Poodle (Grey and fawn)", 2, "Dogz" },
                    { 394, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Toy Poodle", 2, "Dogz" },
                    { 395, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Multicoloured Poodle", 2, "Dogz" },
                    { 396, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Griffon Belge", 3, "Dogz" },
                    { 397, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Griffon Bruxellois", 3, "Dogz" },
                    { 398, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Petit Brabançon", 3, "Dogz" },
                    { 399, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Chinese Crested Dog", 4, "Dogz" },
                    { 400, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Lhasa Apso", 5, "Dogz" },
                    { 401, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Shih Tzu", 5, "Dogz" },
                    { 402, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Tibetan Spaniel", 5, "Dogz" },
                    { 403, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Tibetan Terrier", 5, "Dogz" },
                    { 404, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Chihuahua (Long haired)", 6, "Dogz" },
                    { 405, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Chihuahua (Smooth haired)", 6, "Dogz" },
                    { 406, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Cavalier King Charles Spaniel", 7, "Dogz" },
                    { 407, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "King Charles Spaniel", 7, "Dogz" },
                    { 408, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Pekingese", 8, "Dogz" },
                    { 409, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Japanese Chin", 8, "Dogz" },
                    { 410, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Continental Toy Spaniel (Papillion)", 9, "Dogz" },
                    { 411, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Continental Toy Spaniel (Phalène)", 9, "Dogz" },
                    { 412, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Russian Toy (Smooth haired)", 9, "Dogz" },
                    { 413, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Russian Toy (Long haired)", 9, "Dogz" },
                    { 414, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Kromfohrländer", 10, "Dogz" },
                    { 415, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Pug", 11, "Dogz" },
                    { 416, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "French Bulldog", 11, "Dogz" },
                    { 417, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Boston Terrier", 11, "Dogz" },
                    { 418, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 9, null, null, "Prague Ratter", 11, "Dogz" },
                    { 419, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Afghan Hound", 1, "Dogz" },
                    { 420, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Saluki", 1, "Dogz" },
                    { 421, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Borzoi - Russian Hunting Sighthound", 1, "Dogz" },
                    { 422, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Deerhound", 2, "Dogz" },
                    { 423, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Irish Wolfhound", 2, "Dogz" },
                    { 424, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Greyhound", 3, "Dogz" },
                    { 425, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Whippet", 3, "Dogz" },
                    { 426, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Hungarian Greyhound", 3, "Dogz" },
                    { 427, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Azawakh", 3, "Dogz" },
                    { 428, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Sloughi", 3, "Dogz" },
                    { 429, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Polish Greyhound", 3, "Dogz" },
                    { 430, "system", new DateTime(2023, 3, 10, 23, 0, 0, 0, DateTimeKind.Utc), 10, null, null, "Spanish Greyhound", 3, "Dogz" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 54);

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

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Shetland Sheepdog");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "Komondor");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "Kuvasz");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "Mudi");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "Puli (pearl-white)");

            migrationBuilder.UpdateData(
                table: "Breeds",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "Puli (other colors)");

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
                value: "Maremma and the Abruzzes Sheepdog");

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
        }
    }
}
