using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class CarStaticDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Car",
                newName: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "Car2Id",
                table: "Logger",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vin",
                table: "CarStaticDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Car2s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    TeleGeneration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Miles = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    CarStaticDetailId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Car2s_CarStaticDetails_CarStaticDetailId",
                        column: x => x.CarStaticDetailId,
                        principalTable: "CarStaticDetails",
                        principalColumn: "CarStaticDetailId");
                });

            migrationBuilder.CreateTable(
                name: "CarStaticDetail2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    Vin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Finas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullVin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adas = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarStaticDetail2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarStaticDetail2_Car2s_CarId",
                        column: x => x.CarId,
                        principalTable: "Car2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Car2s",
                columns: new[] { "Id", "CarStaticDetailId", "Location", "Make", "Miles", "Model", "SourceId", "TeleGeneration", "UserId", "Year" },
                values: new object[,]
                {
                    { 1001, null, "California", "Mercedes", 5000, "EQE 400", 2, "NTG7", "default", 2023 },
                    { 1002, null, "Tuscaloosa", "Mercedes", 5000, "Maybach GLS 600", 1, "NTG6", "default", 2023 },
                    { 1003, null, "Tuscaloosa", "Mercedes", 5000, "EQS 450+", 1, "NTG7", "default", 2023 },
                    { 1004, null, "Tuscaloosa", "Mercedes", 5000, "GLS 580 4MATIC", 1, "NTG7 * 2", "default", 2023 },
                    { 1005, null, "Tuscaloosa", "Mercedes", 0, "EQE 350 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1006, null, "Tuscaloosa", "Mercedes", 200, "Maybach EQS 680", 1, "NTG7", "default", 2023 },
                    { 1007, null, "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1008, null, "Tuscaloosa", "Mercedes", 0, "GLS 450 4MATIC", 1, "NTG7 * 2", "default", 2023 },
                    { 1009, null, "Tuscaloosa", "Mercedes", 0, "AMG EQE 53 4MAT", 1, "NTG7", "default", 2023 },
                    { 1010, null, "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1011, null, "Tuscaloosa", "Mercedes", 0, "EQS 450", 1, "NTG7", "default", 2023 },
                    { 1012, null, "Tuscaloosa", "Mercedes", 0, "Maybach GLS 600", 1, "NTG7*2", "default", 2023 },
                    { 1013, null, "Tuscaloosa", "Mercedes", 0, "EQE 350", 1, "NTG7", "default", 2023 },
                    { 1014, null, "Tuscaloosa", "Mercedes", 0, "EQS 450 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1015, null, "Tuscaloosa", "Mercedes", 0, "GLE 400 e 4MATIC", 1, "NTG7*2", "default", 2023 },
                    { 1016, null, "Tuscaloosa", "Mercedes", 0, "MAYBACH EQS 680", 1, "NTG7", "default", 2023 },
                    { 1017, null, "Tuscaloosa", "Mercedes", 0, "AMG GLE 63 S 4MAT", 1, "NTG7*2", "default", 2023 },
                    { 1018, null, "Tuscaloosa", "Mercedes", 0, "GLE 400 e 4MATIC", 1, "NTG7*2", "default", 2023 },
                    { 1019, null, "Tuscaloosa", "Mercedes", 0, "AMG EQE 53 4MAT", 1, "NTG7", "default", 2023 },
                    { 1020, null, "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1021, null, "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1022, null, "Tuscaloosa", "Mercedes", 5000, "C 300", 1, "GEN20", "default", 2023 },
                    { 1023, null, "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1024, null, "Tuscaloosa", "Mercedes", 0, "AMG CLA 45", 1, "NTG7*2", "default", 2023 },
                    { 1025, null, "Tuscaloosa", "Mercedes", 0, "EQS 450 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1026, null, "Tuscaloosa", "Mercedes", 0, "AMG S 63 e ", 1, "NTG7", "default", 2023 },
                    { 1027, null, "Tuscaloosa", "Mercedes", 0, "GLC 300", 1, "NTG7", "default", 2023 },
                    { 1028, null, "Tuscaloosa", "Mercedes", 0, "EQE 350", 1, "NTG7", "default", 2023 },
                    { 1029, null, "Tuscaloosa", "Mercedes", 0, "EQE 350", 1, "NTG7", "default", 2023 },
                    { 1030, null, "Tuscaloosa", "Mercedes", 0, "Maybach S 580", 1, "NTG7", "default", 2023 },
                    { 1031, null, "Tuscaloosa", "Mercedes", 0, "AMG EQE 53 4MAT", 1, "NTG7", "default", 2023 },
                    { 1032, null, "Tuscaloosa", "Mercedes", 0, "EQB 350 4MATIC", 1, "NTG6", "default", 2023 },
                    { 1033, null, "Tuscaloosa", "Mercedes", 0, "AMG S 63 e 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1034, null, "Tuscaloosa", "Mercedes", 0, "EQS 550 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1035, null, "Tuscaloosa", "Mercedes", 0, "AMG E 53 4MATIC", 1, "NTG6", "default", 2023 },
                    { 1036, null, "Tuscaloosa", "Mercedes", 0, "E 350 4MATIC", 1, "GEN20", "default", 2023 },
                    { 1037, null, "Tuscaloosa", "Mercedes", 0, "EQE 350 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1038, null, "Tuscaloosa", "Mercedes", 0, "EQS 450", 1, "NTG7", "default", 2023 },
                    { 1039, null, "Tuscaloosa", "Mercedes", 0, "EQE 350", 1, "NTG7", "default", 2023 }
                });

            migrationBuilder.InsertData(
                table: "CarStaticDetail2",
                columns: new[] { "Id", "Adas", "CarId", "Finas", "FullVin", "Tag", "Vin" },
                values: new object[,]
                {
                    { 1001, "0", 1001, "X294-01019", null, "180", "4JGGM2BB6PA000131" },
                    { 1002, "0", 1002, "X167-04607", null, "181", "4JGFF8HB5NA357779" },
                    { 1003, "0", 1003, "X296-01198", null, "182", "4JGDM2DB4RA003435" },
                    { 1004, "0", 1004, "X167-06625", null, "183", "4JGFF8FE9RA844776" },
                    { 1005, "0", 1005, "X294-01471", null, "184", "4JGGM1CB8RA000790" },
                    { 1006, "0", 1006, "Z296-01209", null, "185", "4JGDX5FB2RA003388" },
                    { 1007, "0", 1007, "X296-01210", null, "186", "4JGDM4EB5RA003437" },
                    { 1008, "0", 1008, "X167-06656", null, "187", "4JGFF5KE1RA844775" },
                    { 1009, "0", 1009, "X294-01457", null, "188", "4JGGM5DB8RA001590" },
                    { 1010, "0", 1010, "X296-00421", null, "189", "4JGDM4EB6PA000351" },
                    { 1011, "0", 1011, "X296-00395", null, "190", "4JGDM2DB9PA000205" },
                    { 1012, "0", 1012, "X167-06686", null, "191", "4JGFF8HB1RA844774" },
                    { 1013, "0", 1013, "X294-01532", null, "192", "4JGGM2BB2RA000792" },
                    { 1014, "0", 1014, "X296-00702", null, "193", "4JGDM2EB1PU000194" },
                    { 1015, "0", 1015, "V167-06463", null, "195", "4JGFB4GB3RA809370" },
                    { 1016, "0", 1016, "Z296-01192", null, "196", "4JGDX5FB9RA003386" },
                    { 1017, "0", 1017, "C167-06461", null, "197", "4JGFD8KB4RA809371" },
                    { 1018, "0", 1018, "V167-06567", null, "198", "4JGFB4GB1PA883660" },
                    { 1019, "0", 1019, "X294-01456", null, "199", "4JGGM5DBXRA001588" },
                    { 1020, "0", 1020, "X296-00848", null, "288", "4JGDM4EB7PA000701" },
                    { 1021, "0", 1021, "V297-02377", null, "638", "W1KCG4EB4PA019834" },
                    { 1022, "0", 1022, "W206-01531", null, "651", "W1KAF4GB9NR000041" },
                    { 1023, "0", 1023, "V297-01008", null, "652", "W1KCG4EB7NA000823" },
                    { 1024, "0", 1024, "A118-01377", null, "653", "W1K5J5EB8RN368913" },
                    { 1025, "0", 1025, "V297-01062", null, "654", "W1KCG2EB8NA003265" },
                    { 1026, "0", 1026, "V223-05154", null, "655", "W1K6G8CB9RA200096" },
                    { 1027, "0", 1027, "X254-02459", null, "657", "W1NKM4GB3PF001221" },
                    { 1028, "0", 1028, "V295-01073", null, "658", "W1KEG2BB5NF000498" },
                    { 1029, "0", 1029, "V295-01074", null, "659", "W1KEG2BB7NF000499" },
                    { 1030, "0", 1030, "Z223-05153", null, "660", "W1K6X7GB9RA203259" },
                    { 1031, "0", 1031, "N295-01333", null, "661", "W1KEG5DB3PF005779" },
                    { 1032, "0", 1032, "X243-01749", null, "662", "W1N9M1DB3RN027408" },
                    { 1033, "0", 1033, "V223-04879", null, "663", "W1K6G8CB5PA159432" },
                    { 1034, "0", 1034, "V297-01298", null, "664", "W1KCG4EB6NA000411" },
                    { 1035, "0", 1035, "A238-02435", null, "665", "W1K1K6BB7PF185712" },
                    { 1036, "0", 1036, "W214-01098", null, "666", "W1KLF4HB7RA000650" },
                    { 1037, "0", 1037, "X294-00461", null, "668", "4JGGM1CB5PA000386" },
                    { 1038, "0", 1038, "X296-00322", null, "669", "4JGDM2DB2PA000031" },
                    { 1039, "0", 1039, "V295-00503", null, "670", "W1KEG2BB5PF000620" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Logger_Car2Id",
                table: "Logger",
                column: "Car2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Car2s_CarStaticDetailId",
                table: "Car2s",
                column: "CarStaticDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CarStaticDetail2_CarId",
                table: "CarStaticDetail2",
                column: "CarId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Logger_Car2s_Car2Id",
                table: "Logger",
                column: "Car2Id",
                principalTable: "Car2s",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logger_Car2s_Car2Id",
                table: "Logger");

            migrationBuilder.DropTable(
                name: "Car2s");

            migrationBuilder.DropTable(
                name: "CarStaticDetail2");

            migrationBuilder.DropIndex(
                name: "IX_Logger_Car2Id",
                table: "Logger");

            migrationBuilder.DropColumn(
                name: "Car2Id",
                table: "Logger");

            migrationBuilder.DropColumn(
                name: "Vin",
                table: "CarStaticDetails");
        }
    }
}
