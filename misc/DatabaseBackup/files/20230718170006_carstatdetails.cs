using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class carstatdetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car2s_CarStaticDetails_CarStaticDetailId",
                table: "Car2s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarStaticDetails",
                table: "CarStaticDetails");

            migrationBuilder.DropIndex(
                name: "IX_CarStaticDetails_CarId",
                table: "CarStaticDetails");

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyValue: 1039);

            migrationBuilder.RenameColumn(
                name: "CarStaticDetailId",
                table: "Car2s",
                newName: "CarStaticDetailCarId");

            migrationBuilder.RenameIndex(
                name: "IX_Car2s_CarStaticDetailId",
                table: "Car2s",
                newName: "IX_Car2s_CarStaticDetailCarId");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CarStaticDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarStaticDetails",
                table: "CarStaticDetails",
                column: "CarId");

            migrationBuilder.InsertData(
                table: "CarStaticDetails",
                columns: new[] { "CarId", "Adas", "CarStaticDetailId", "Finas", "FullVin", "HarnessStatus", "Id", "SoftwareVersion", "Tag", "Vin", "VinLast4" },
                values: new object[,]
                {
                    { 1001, "0", null, "X294-01019", null, null, 1001, null, "180", "4JGGM2BB6PA000131", "0000" },
                    { 1002, "0", null, "X167-04607", null, null, 1002, null, "181", "4JGFF8HB5NA357779", "0000" },
                    { 1003, "0", null, "X296-01198", null, null, 1003, null, "182", "4JGDM2DB4RA003435", "0000" },
                    { 1004, "0", null, "X167-06625", null, null, 1004, null, "183", "4JGFF8FE9RA844776", "0000" },
                    { 1005, "0", null, "X294-01471", null, null, 1005, null, "184", "4JGGM1CB8RA000790", "0000" },
                    { 1006, "0", null, "Z296-01209", null, null, 1006, null, "185", "4JGDX5FB2RA003388", "0000" },
                    { 1007, "0", null, "X296-01210", null, null, 1007, null, "186", "4JGDM4EB5RA003437", "0000" },
                    { 1008, "0", null, "X167-06656", null, null, 1008, null, "187", "4JGFF5KE1RA844775", "0000" },
                    { 1009, "0", null, "X294-01457", null, null, 1009, null, "188", "4JGGM5DB8RA001590", "0000" },
                    { 1010, "0", null, "X296-00421", null, null, 1010, null, "189", "4JGDM4EB6PA000351", "0000" },
                    { 1011, "0", null, "X296-00395", null, null, 1011, null, "190", "4JGDM2DB9PA000205", "0000" },
                    { 1012, "0", null, "X167-06686", null, null, 1012, null, "191", "4JGFF8HB1RA844774", "0000" },
                    { 1013, "0", null, "X294-01532", null, null, 1013, null, "192", "4JGGM2BB2RA000792", "0000" },
                    { 1014, "0", null, "X296-00702", null, null, 1014, null, "193", "4JGDM2EB1PU000194", "0000" },
                    { 1015, "0", null, "V167-06463", null, null, 1015, null, "195", "4JGFB4GB3RA809370", "0000" },
                    { 1016, "0", null, "Z296-01192", null, null, 1016, null, "196", "4JGDX5FB9RA003386", "0000" },
                    { 1017, "0", null, "C167-06461", null, null, 1017, null, "197", "4JGFD8KB4RA809371", "0000" },
                    { 1018, "0", null, "V167-06567", null, null, 1018, null, "198", "4JGFB4GB1PA883660", "0000" },
                    { 1019, "0", null, "X294-01456", null, null, 1019, null, "199", "4JGGM5DBXRA001588", "0000" },
                    { 1020, "0", null, "X296-00848", null, null, 1020, null, "288", "4JGDM4EB7PA000701", "0000" },
                    { 1021, "0", null, "V297-02377", null, null, 1021, null, "638", "W1KCG4EB4PA019834", "0000" },
                    { 1022, "0", null, "W206-01531", null, null, 1022, null, "651", "W1KAF4GB9NR000041", "0000" },
                    { 1023, "0", null, "V297-01008", null, null, 1023, null, "652", "W1KCG4EB7NA000823", "0000" },
                    { 1024, "0", null, "A118-01377", null, null, 1024, null, "653", "W1K5J5EB8RN368913", "0000" },
                    { 1025, "0", null, "V297-01062", null, null, 1025, null, "654", "W1KCG2EB8NA003265", "0000" },
                    { 1026, "0", null, "V223-05154", null, null, 1026, null, "655", "W1K6G8CB9RA200096", "0000" },
                    { 1027, "0", null, "X254-02459", null, null, 1027, null, "657", "W1NKM4GB3PF001221", "0000" },
                    { 1028, "0", null, "V295-01073", null, null, 1028, null, "658", "W1KEG2BB5NF000498", "0000" },
                    { 1029, "0", null, "V295-01074", null, null, 1029, null, "659", "W1KEG2BB7NF000499", "0000" },
                    { 1030, "0", null, "Z223-05153", null, null, 1030, null, "660", "W1K6X7GB9RA203259", "0000" },
                    { 1031, "0", null, "N295-01333", null, null, 1031, null, "661", "W1KEG5DB3PF005779", "0000" },
                    { 1032, "0", null, "X243-01749", null, null, 1032, null, "662", "W1N9M1DB3RN027408", "0000" },
                    { 1033, "0", null, "V223-04879", null, null, 1033, null, "663", "W1K6G8CB5PA159432", "0000" },
                    { 1034, "0", null, "V297-01298", null, null, 1034, null, "664", "W1KCG4EB6NA000411", "0000" },
                    { 1035, "0", null, "A238-02435", null, null, 1035, null, "665", "W1K1K6BB7PF185712", "0000" },
                    { 1036, "0", null, "W214-01098", null, null, 1036, null, "666", "W1KLF4HB7RA000650", "0000" },
                    { 1037, "0", null, "X294-00461", null, null, 1037, null, "668", "4JGGM1CB5PA000386", "0000" },
                    { 1038, "0", null, "X296-00322", null, null, 1038, null, "669", "4JGDM2DB2PA000031", "0000" },
                    { 1039, "0", null, "V295-00503", null, null, 1039, null, "670", "W1KEG2BB5PF000620", "0000" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Car2s_CarStaticDetails_CarStaticDetailCarId",
                table: "Car2s",
                column: "CarStaticDetailCarId",
                principalTable: "CarStaticDetails",
                principalColumn: "CarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car2s_CarStaticDetails_CarStaticDetailCarId",
                table: "Car2s");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarStaticDetails",
                table: "CarStaticDetails");

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "CarId",
                keyValue: 1039);

            migrationBuilder.RenameColumn(
                name: "CarStaticDetailCarId",
                table: "Car2s",
                newName: "CarStaticDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_Car2s_CarStaticDetailCarId",
                table: "Car2s",
                newName: "IX_Car2s_CarStaticDetailId");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CarStaticDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarStaticDetails",
                table: "CarStaticDetails",
                column: "Id");

            migrationBuilder.InsertData(
                table: "CarStaticDetails",
                columns: new[] { "Id", "Adas", "CarId", "CarStaticDetailId", "Finas", "FullVin", "HarnessStatus", "SoftwareVersion", "Tag", "Vin", "VinLast4" },
                values: new object[,]
                {
                    { 1001, "0", 1001, null, "X294-01019", null, null, null, "180", "4JGGM2BB6PA000131", "0000" },
                    { 1002, "0", 1002, null, "X167-04607", null, null, null, "181", "4JGFF8HB5NA357779", "0000" },
                    { 1003, "0", 1003, null, "X296-01198", null, null, null, "182", "4JGDM2DB4RA003435", "0000" },
                    { 1004, "0", 1004, null, "X167-06625", null, null, null, "183", "4JGFF8FE9RA844776", "0000" },
                    { 1005, "0", 1005, null, "X294-01471", null, null, null, "184", "4JGGM1CB8RA000790", "0000" },
                    { 1006, "0", 1006, null, "Z296-01209", null, null, null, "185", "4JGDX5FB2RA003388", "0000" },
                    { 1007, "0", 1007, null, "X296-01210", null, null, null, "186", "4JGDM4EB5RA003437", "0000" },
                    { 1008, "0", 1008, null, "X167-06656", null, null, null, "187", "4JGFF5KE1RA844775", "0000" },
                    { 1009, "0", 1009, null, "X294-01457", null, null, null, "188", "4JGGM5DB8RA001590", "0000" },
                    { 1010, "0", 1010, null, "X296-00421", null, null, null, "189", "4JGDM4EB6PA000351", "0000" },
                    { 1011, "0", 1011, null, "X296-00395", null, null, null, "190", "4JGDM2DB9PA000205", "0000" },
                    { 1012, "0", 1012, null, "X167-06686", null, null, null, "191", "4JGFF8HB1RA844774", "0000" },
                    { 1013, "0", 1013, null, "X294-01532", null, null, null, "192", "4JGGM2BB2RA000792", "0000" },
                    { 1014, "0", 1014, null, "X296-00702", null, null, null, "193", "4JGDM2EB1PU000194", "0000" },
                    { 1015, "0", 1015, null, "V167-06463", null, null, null, "195", "4JGFB4GB3RA809370", "0000" },
                    { 1016, "0", 1016, null, "Z296-01192", null, null, null, "196", "4JGDX5FB9RA003386", "0000" },
                    { 1017, "0", 1017, null, "C167-06461", null, null, null, "197", "4JGFD8KB4RA809371", "0000" },
                    { 1018, "0", 1018, null, "V167-06567", null, null, null, "198", "4JGFB4GB1PA883660", "0000" },
                    { 1019, "0", 1019, null, "X294-01456", null, null, null, "199", "4JGGM5DBXRA001588", "0000" },
                    { 1020, "0", 1020, null, "X296-00848", null, null, null, "288", "4JGDM4EB7PA000701", "0000" },
                    { 1021, "0", 1021, null, "V297-02377", null, null, null, "638", "W1KCG4EB4PA019834", "0000" },
                    { 1022, "0", 1022, null, "W206-01531", null, null, null, "651", "W1KAF4GB9NR000041", "0000" },
                    { 1023, "0", 1023, null, "V297-01008", null, null, null, "652", "W1KCG4EB7NA000823", "0000" },
                    { 1024, "0", 1024, null, "A118-01377", null, null, null, "653", "W1K5J5EB8RN368913", "0000" },
                    { 1025, "0", 1025, null, "V297-01062", null, null, null, "654", "W1KCG2EB8NA003265", "0000" },
                    { 1026, "0", 1026, null, "V223-05154", null, null, null, "655", "W1K6G8CB9RA200096", "0000" },
                    { 1027, "0", 1027, null, "X254-02459", null, null, null, "657", "W1NKM4GB3PF001221", "0000" },
                    { 1028, "0", 1028, null, "V295-01073", null, null, null, "658", "W1KEG2BB5NF000498", "0000" },
                    { 1029, "0", 1029, null, "V295-01074", null, null, null, "659", "W1KEG2BB7NF000499", "0000" },
                    { 1030, "0", 1030, null, "Z223-05153", null, null, null, "660", "W1K6X7GB9RA203259", "0000" },
                    { 1031, "0", 1031, null, "N295-01333", null, null, null, "661", "W1KEG5DB3PF005779", "0000" },
                    { 1032, "0", 1032, null, "X243-01749", null, null, null, "662", "W1N9M1DB3RN027408", "0000" },
                    { 1033, "0", 1033, null, "V223-04879", null, null, null, "663", "W1K6G8CB5PA159432", "0000" },
                    { 1034, "0", 1034, null, "V297-01298", null, null, null, "664", "W1KCG4EB6NA000411", "0000" },
                    { 1035, "0", 1035, null, "A238-02435", null, null, null, "665", "W1K1K6BB7PF185712", "0000" },
                    { 1036, "0", 1036, null, "W214-01098", null, null, null, "666", "W1KLF4HB7RA000650", "0000" },
                    { 1037, "0", 1037, null, "X294-00461", null, null, null, "668", "4JGGM1CB5PA000386", "0000" },
                    { 1038, "0", 1038, null, "X296-00322", null, null, null, "669", "4JGDM2DB2PA000031", "0000" },
                    { 1039, "0", 1039, null, "V295-00503", null, null, null, "670", "W1KEG2BB5PF000620", "0000" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarStaticDetails_CarId",
                table: "CarStaticDetails",
                column: "CarId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Car2s_CarStaticDetails_CarStaticDetailId",
                table: "Car2s",
                column: "CarStaticDetailId",
                principalTable: "CarStaticDetails",
                principalColumn: "Id");
        }
    }
}
