using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations.ApplicationSqliteDb
{
    /// <inheritdoc />
    public partial class r1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUser_TeamTypes_TeamTypesId",
                table: "ApplicationUser");

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "TeamTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TeamTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TeamTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TeamTypes",
                newName: "TeamTypeId");

            migrationBuilder.RenameColumn(
                name: "TeamTypesId",
                table: "ApplicationUser",
                newName: "TeamTypesTeamTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUser_TeamTypesId",
                table: "ApplicationUser",
                newName: "IX_ApplicationUser_TeamTypesTeamTypeId");

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d4e8b88-6911-422a-95bb-9b7818fece33", "1ba0b31e-5375-4dca-afea-410ade8b64ed" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "73f77d01-f450-4a45-883d-998e8b750709", "40c3e697-8f04-4925-a442-d329e6d7fe87" });

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastModified", "UploadDate" },
                values: new object[] { new DateTime(2024, 1, 5, 13, 50, 3, 410, DateTimeKind.Local).AddTicks(2882), new DateTime(2024, 1, 5, 13, 50, 3, 410, DateTimeKind.Local).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastModified", "UploadDate" },
                values: new object[] { new DateTime(2024, 1, 5, 13, 50, 3, 410, DateTimeKind.Local).AddTicks(2887), new DateTime(2024, 1, 5, 13, 50, 3, 410, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "MasterLog",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Time",
                value: new DateTime(2024, 1, 5, 13, 50, 3, 410, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "MasterLog",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Time",
                value: new DateTime(2024, 1, 5, 13, 50, 3, 410, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUser_TeamTypes_TeamTypesTeamTypeId",
                table: "ApplicationUser",
                column: "TeamTypesTeamTypeId",
                principalTable: "TeamTypes",
                principalColumn: "TeamTypeId");
            */
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            /*
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUser_TeamTypes_TeamTypesTeamTypeId",
                table: "ApplicationUser");

            migrationBuilder.RenameColumn(
                name: "TeamTypeId",
                table: "TeamTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TeamTypesTeamTypeId",
                table: "ApplicationUser",
                newName: "TeamTypesId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUser_TeamTypesTeamTypeId",
                table: "ApplicationUser",
                newName: "IX_ApplicationUser_TeamTypesId");

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "29baa78a-9f0f-4b0e-974e-d25eb0ddfd61", "af091467-45e5-497e-9df4-4f8fc4e01143" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "45df36f8-5abe-4375-9f08-8105728d0de6", "f38887e8-0c22-4aaa-8a82-659842ffd445" });

            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1001, "Comission" },
                    { 1002, "Decomission" },
                    { 1003, "TicketSubmission" },
                    { 1004, "Error Identification" },
                    { 1005, "Test Drive" },
                    { 1006, "Shop Configuration" },
                    { 1007, "Prepared For Drive" },
                    { 1008, "Tag Assigned" },
                    { 1009, "Tag UnAssigned" },
                    { 1010, "Logger Install" },
                    { 1011, "Logger UnInstall" },
                    { 1012, "Main DriveEvent" },
                    { 1013, "Routine Drive" }
                });

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastModified", "UploadDate" },
                values: new object[] { new DateTime(2024, 1, 5, 13, 23, 35, 634, DateTimeKind.Local).AddTicks(6710), new DateTime(2024, 1, 5, 13, 23, 35, 634, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastModified", "UploadDate" },
                values: new object[] { new DateTime(2024, 1, 5, 13, 23, 35, 634, DateTimeKind.Local).AddTicks(6720), new DateTime(2024, 1, 5, 13, 23, 35, 634, DateTimeKind.Local).AddTicks(6718) });

            migrationBuilder.UpdateData(
                table: "MasterLog",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Time",
                value: new DateTime(2024, 1, 5, 13, 23, 35, 636, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "MasterLog",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Time",
                value: new DateTime(2024, 1, 5, 13, 23, 35, 636, DateTimeKind.Local).AddTicks(5301));

            migrationBuilder.InsertData(
                table: "TeamTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Unassigned" },
                    { 2, "Adas" },
                    { 3, "Telematics" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUser_TeamTypes_TeamTypesId",
                table: "ApplicationUser",
                column: "TeamTypesId",
                principalTable: "TeamTypes",
                principalColumn: "Id");*/
        }
    }
}
