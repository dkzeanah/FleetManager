using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class Car2AndMock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.DropForeignKey(
                name: "FK_Car2s_CarStaticDetail_CarStaticDetailId",
                table: "Car2s");*/

            /*migrationBuilder.DropPrimaryKey(
                name: "PK_CarStaticDetails",
                table: "CarStaticDetails");*/

            migrationBuilder.AddColumn<string>(
                name: "LogText",
                table: "Logger",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LogTime",
                table: "Logger",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "EventDetailText",
                table: "EventDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "VinLast4",
                table: "CarStaticDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            /*migrationBuilder.AlterColumn<int>(
                name: "CarStaticDetailId",
                table: "CarStaticDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");*/

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CarStaticDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
               // .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "CarStaticDetails",
                type: "nvarchar(max)",
                nullable: true);

            /*migrationBuilder.AddPrimaryKey(
                name: "PK_CarStaticDetails",
                table: "CarStaticDetails",
                column: "Id");*/

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "Location", "Make", "Miles", "Model", "SourceId", "TeleGeneration", "UserId", "Year" },
                values: new object[,]
                {
                    { 1001, "California", "Mercedes", 5000, "EQE 400", 2, "NTG7", "default", 2023 },
                    { 1002, "Tuscaloosa", "Mercedes", 5000, "Maybach GLS 600", 1, "NTG6", "default", 2023 },
                    { 1003, "Tuscaloosa", "Mercedes", 5000, "EQS 450+", 1, "NTG7", "default", 2023 },
                    { 1004, "Tuscaloosa", "Mercedes", 5000, "GLS 580 4MATIC", 1, "NTG7 * 2", "default", 2023 },
                    { 1005, "Tuscaloosa", "Mercedes", 0, "EQE 350 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1006, "Tuscaloosa", "Mercedes", 200, "Maybach EQS 680", 1, "NTG7", "default", 2023 },
                    { 1007, "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1008, "Tuscaloosa", "Mercedes", 0, "GLS 450 4MATIC", 1, "NTG7 * 2", "default", 2023 },
                    { 1009, "Tuscaloosa", "Mercedes", 0, "AMG EQE 53 4MAT", 1, "NTG7", "default", 2023 },
                    { 1010, "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1011, "Tuscaloosa", "Mercedes", 0, "EQS 450", 1, "NTG7", "default", 2023 },
                    { 1012, "Tuscaloosa", "Mercedes", 0, "Maybach GLS 600", 1, "NTG7*2", "default", 2023 },
                    { 1013, "Tuscaloosa", "Mercedes", 0, "EQE 350", 1, "NTG7", "default", 2023 },
                    { 1014, "Tuscaloosa", "Mercedes", 0, "EQS 450 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1015, "Tuscaloosa", "Mercedes", 0, "GLE 400 e 4MATIC", 1, "NTG7*2", "default", 2023 },
                    { 1016, "Tuscaloosa", "Mercedes", 0, "MAYBACH EQS 680", 1, "NTG7", "default", 2023 },
                    { 1017, "Tuscaloosa", "Mercedes", 0, "AMG GLE 63 S 4MAT", 1, "NTG7*2", "default", 2023 },
                    { 1018, "Tuscaloosa", "Mercedes", 0, "GLE 400 e 4MATIC", 1, "NTG7*2", "default", 2023 },
                    { 1019, "Tuscaloosa", "Mercedes", 0, "AMG EQE 53 4MAT", 1, "NTG7", "default", 2023 },
                    { 1020, "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1021, "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1022, "Tuscaloosa", "Mercedes", 5000, "C 300", 1, "GEN20", "default", 2023 },
                    { 1023, "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1024, "Tuscaloosa", "Mercedes", 0, "AMG CLA 45", 1, "NTG7*2", "default", 2023 },
                    { 1025, "Tuscaloosa", "Mercedes", 0, "EQS 450 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1026, "Tuscaloosa", "Mercedes", 0, "AMG S 63 e ", 1, "NTG7", "default", 2023 },
                    { 1027, "Tuscaloosa", "Mercedes", 0, "GLC 300", 1, "NTG7", "default", 2023 },
                    { 1028, "Tuscaloosa", "Mercedes", 0, "EQE 350", 1, "NTG7", "default", 2023 },
                    { 1029, "Tuscaloosa", "Mercedes", 0, "EQE 350", 1, "NTG7", "default", 2023 },
                    { 1030, "Tuscaloosa", "Mercedes", 0, "Maybach S 580", 1, "NTG7", "default", 2023 },
                    { 1031, "Tuscaloosa", "Mercedes", 0, "AMG EQE 53 4MAT", 1, "NTG7", "default", 2023 },
                    { 1032, "Tuscaloosa", "Mercedes", 0, "EQB 350 4MATIC", 1, "NTG6", "default", 2023 },
                    { 1033, "Tuscaloosa", "Mercedes", 0, "AMG S 63 e 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1034, "Tuscaloosa", "Mercedes", 0, "EQS 550 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1035, "Tuscaloosa", "Mercedes", 0, "AMG E 53 4MATIC", 1, "NTG6", "default", 2023 },
                    { 1036, "Tuscaloosa", "Mercedes", 0, "E 350 4MATIC", 1, "GEN20", "default", 2023 },
                    { 1037, "Tuscaloosa", "Mercedes", 0, "EQE 350 4MATIC", 1, "NTG7", "default", 2023 },
                    { 1038, "Tuscaloosa", "Mercedes", 0, "EQS 450", 1, "NTG7", "default", 2023 },
                    { 1039, "Tuscaloosa", "Mercedes", 0, "EQE 350", 1, "NTG7", "default", 2023 }
                });

            migrationBuilder.InsertData(
                table: "CarStaticDetails",
                columns: new[] { "CarStaticDetailId", "CarId", "Tag", "Finas", "VinLast4", "HarnessStatus", "FullVin", "SoftwareVersion", "Adas", "Vin" },
                values: new object[,]
                {
                    { 1001, 1001, "180","X294-01019", "0000", "0","4JGGM2BB6PA000131",  null, null, "4JGGM2BB6PA000131",  },
                    { 1002, 1002, "181","X167-04607", "0000", "0","4JGFF8HB5NA357779",  null, null, "4JGFF8HB5NA357779",  },
                    { 1003, 1003, "182","X296-01198", "0000", "0","4JGDM2DB4RA003435",  null, null, "4JGDM2DB4RA003435",  },
                    { 1004, 1004, "183","X167-06625", "0000", "0","4JGFF8FE9RA844776",  null, null, "4JGFF8FE9RA844776",  },
                    { 1005, 1005, "184","X294-01471", "0000", "0","4JGGM1CB8RA000790",  null, null, "4JGGM1CB8RA000790",  },
                    { 1006, 1006, "185","Z296-01209", "0000", "0","4JGDX5FB2RA003388",  null, null, "4JGDX5FB2RA003388",  },
                    { 1007, 1007, "186","X296-01210", "0000", "0","4JGDM4EB5RA003437",  null, null, "4JGDM4EB5RA003437",  },
                    { 1008, 1008, "187","X167-06656", "0000", "0","4JGFF5KE1RA844775",  null, null, "4JGFF5KE1RA844775",  },
                    { 1009, 1009, "188","X294-01457", "0000", "0","4JGGM5DB8RA001590",  null, null, "4JGGM5DB8RA001590",  },
                    { 1010, 1010, "189","X296-00421", "0000", "0","4JGDM4EB6PA000351",  null, null, "4JGDM4EB6PA000351",  },
                    { 1011, 1011, "190","X296-00395", "0000", "0","4JGDM2DB9PA000205",  null, null, "4JGDM2DB9PA000205",  },
                    { 1012, 1012, "191","X167-06686", "0000", "0","4JGFF8HB1RA844774",  null, null, "4JGFF8HB1RA844774",  },
                    { 1013, 1013, "192","X294-01532", "0000", "0","4JGGM2BB2RA000792",  null, null, "4JGGM2BB2RA000792",  },
                    { 1014, 1014, "193","X296-00702", "0000", "0","4JGDM2EB1PU000194",  null, null, "4JGDM2EB1PU000194",  },
                    { 1015, 1015, "195","V167-06463", "0000", "0","4JGFB4GB3RA809370",  null, null, "4JGFB4GB3RA809370",  },
                    { 1016, 1016, "196","Z296-01192", "0000", "0","4JGDX5FB9RA003386",  null, null, "4JGDX5FB9RA003386",  },
                    { 1017, 1017, "197","C167-06461", "0000", "0","4JGFD8KB4RA809371",  null, null, "4JGFD8KB4RA809371",  },
                    { 1018, 1018, "198","V167-06567", "0000", "0","4JGFB4GB1PA883660",  null, null, "4JGFB4GB1PA883660",  },
                    { 1019, 1019, "199","X294-01456", "0000", "0","4JGGM5DBXRA001588",  null, null, "4JGGM5DBXRA001588",  },
                    { 1020, 1020, "288","X296-00848", "0000", "0","4JGDM4EB7PA000701",  null, null, "4JGDM4EB7PA000701",  },
                    { 1021, 1021, "638","V297-02377", "0000", "0","W1KCG4EB4PA019834",  null, null, "W1KCG4EB4PA019834",  },
                    { 1022, 1022, "651","W206-01531", "0000", "0","W1KAF4GB9NR000041",  null, null, "W1KAF4GB9NR000041",  },
                    { 1023, 1023, "652","V297-01008", "0000", "0","W1KCG4EB7NA000823",  null, null, "W1KCG4EB7NA000823",  },
                    { 1024, 1024, "653","A118-01377", "0000", "0","W1K5J5EB8RN368913",  null, null, "W1K5J5EB8RN368913",  },
                    { 1025, 1025, "654","V297-01062", "0000", "0","W1KCG2EB8NA003265",  null, null, "W1KCG2EB8NA003265",  },
                    { 1026, 1026, "655","V223-05154", "0000", "0","W1K6G8CB9RA200096",  null, null, "W1K6G8CB9RA200096",  },
                    { 1027, 1027, "657","X254-02459", "0000", "0","W1NKM4GB3PF001221",  null, null, "W1NKM4GB3PF001221",  },
                    { 1028, 1028, "658","V295-01073", "0000", "0","W1KEG2BB5NF000498",  null, null, "W1KEG2BB5NF000498",  },
                    { 1029, 1029, "659","V295-01074", "0000", "0","W1KEG2BB7NF000499",  null, null, "W1KEG2BB7NF000499",  },
                    { 1030, 1030, "660","Z223-05153", "0000", "0","W1K6X7GB9RA203259",  null, null, "W1K6X7GB9RA203259",  },
                    { 1031, 1031, "661","N295-01333", "0000", "0","W1KEG5DB3PF005779",  null, null, "W1KEG5DB3PF005779",  },
                    { 1032, 1032, "662","X243-01749", "0000", "0","W1N9M1DB3RN027408",  null, null, "W1N9M1DB3RN027408",  },
                    { 1033, 1033, "663","V223-04879", "0000", "0","W1K6G8CB5PA159432",  null, null, "W1K6G8CB5PA159432",  },
                    { 1034, 1034, "664","V297-01298", "0000", "0","W1KCG4EB6NA000411",  null, null, "W1KCG4EB6NA000411",  },
                    { 1035, 1035, "665","A238-02435", "0000", "0","W1K1K6BB7PF185712",  null, null, "W1K1K6BB7PF185712",  },
                    { 1036, 1036, "666","W214-01098", "0000", "0","W1KLF4HB7RA000650",  null, null, "W1KLF4HB7RA000650",  },
                    { 1037, 1037, "668","X294-00461", "0000", "0","4JGGM1CB5PA000386",  null, null, "4JGGM1CB5PA000386",  },
                    { 1038, 1038, "669","X296-00322", "0000", "0","4JGDM2DB2PA000031",  null, null, "4JGDM2DB2PA000031",  },
                    { 1039, 1039, "670","V295-00503", "0000", "0","W1KEG2BB5PF000620",  null, null, "W1KEG2BB5PF000620",  }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Car2s_CarStaticDetail2_Id",
                table: "Car2s",
                column: "Id",
                principalTable: "CarStaticDetail2",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Cars_CarId",
                table: "Event",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car2s_CarStaticDetails_CarStaticDetailId",
                table: "Car2s");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_Cars_CarId",
                table: "Event");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarStaticDetails",
                table: "CarStaticDetails");

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "CarStaticDetails",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1039);

            migrationBuilder.DropColumn(
                name: "LogText",
                table: "Logger");

            migrationBuilder.DropColumn(
                name: "LogTime",
                table: "Logger");

            migrationBuilder.DropColumn(
                name: "EventDetailText",
                table: "EventDetail");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CarStaticDetails");

            migrationBuilder.DropColumn(
                name: "Detail",
                table: "CarStaticDetails");

            migrationBuilder.AlterColumn<string>(
                name: "VinLast4",
                table: "CarStaticDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarStaticDetailId",
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
                column: "CarStaticDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Car2s_CarStaticDetails_CarStaticDetailId",
                table: "Car2s",
                column: "CarStaticDetailId",
                principalTable: "CarStaticDetails",
                principalColumn: "CarStaticDetailId");
        }
    }
}
