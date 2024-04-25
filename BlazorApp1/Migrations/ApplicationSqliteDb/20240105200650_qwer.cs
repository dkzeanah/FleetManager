using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations.ApplicationSqliteDb
{
    /// <inheritdoc />
    public partial class qwer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUser_TeamTypes_TeamTypesTeamTypeId",
                table: "ApplicationUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamTimeline_TeamTypes_TeamId",
                table: "TeamTimeline");*/

          /*  migrationBuilder.DropTable(
                name: "Team");*/

          /*  migrationBuilder.RenameColumn(
                name: "TeamTypesTeamTypeId",
                table: "ApplicationUser",
                newName: "TeamTypeId");
*/
          /*  migrationBuilder.RenameIndex(
                name: "IX_ApplicationUser_TeamTypesTeamTypeId",
                table: "ApplicationUser",
                newName: "IX_ApplicationUser_TeamTypeId");*/

            migrationBuilder.CreateTable(
                name: "TeamType",
                columns: table => new
                {
                    TeamTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamType", x => x.TeamTypeId);
                });

/*            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4287889c-56cd-4d2e-a15d-369717c0aac9", "a9695902-9edf-4077-b1b3-00ccfbb7f87f" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1d5f4e0-7a3a-4f09-8fed-94ccf80bc98b", "87e83496-b2ae-42e9-abbc-8b566f661465" });

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastModified", "UploadDate" },
                values: new object[] { new DateTime(2024, 1, 5, 14, 6, 45, 979, DateTimeKind.Local).AddTicks(7066), new DateTime(2024, 1, 5, 14, 6, 45, 979, DateTimeKind.Local).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastModified", "UploadDate" },
                values: new object[] { new DateTime(2024, 1, 5, 14, 6, 45, 979, DateTimeKind.Local).AddTicks(7069), new DateTime(2024, 1, 5, 14, 6, 45, 979, DateTimeKind.Local).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "MasterLog",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Time",
                value: new DateTime(2024, 1, 5, 14, 6, 45, 980, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "MasterLog",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Time",
                value: new DateTime(2024, 1, 5, 14, 6, 45, 980, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.InsertData(
                table: "TeamType",
                columns: new[] { "TeamTypeId", "Name" },
                values: new object[,]
                {
                    { -3, "Telematics" },
                    { -2, "Adas" },
                    { -1, "Unassigned" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUser_TeamType_TeamTypeId",
                table: "ApplicationUser",
                column: "TeamTypeId",
                principalTable: "TeamType",
                principalColumn: "TeamTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamTimeline_TeamType_TeamId",
                table: "TeamTimeline",
                column: "TeamId",
                principalTable: "TeamType",
                principalColumn: "TeamTypeId",
                onDelete: ReferentialAction.Cascade);*/
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
          /*  migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUser_TeamType_TeamTypeId",
                table: "ApplicationUser");*/

  /*          migrationBuilder.DropForeignKey(
                name: "FK_TeamTimeline_TeamType_TeamId",
                table: "TeamTimeline");*/
/*
            migrationBuilder.DropTable(
                name: "TeamType");

            migrationBuilder.RenameColumn(
                name: "TeamTypeId",
                table: "ApplicationUser",
                newName: "TeamTypesTeamTypeId");*/

            /*migrationBuilder.RenameIndex(
                name: "IX_ApplicationUser_TeamTypeId",
                table: "ApplicationUser",
                newName: "IX_ApplicationUser_TeamTypesTeamTypeId");*/

           /* migrationBuilder.CreateTable(
                name: "TeamTypes",
                columns: table => new
                {
                    TeamTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamTypes", x => x.TeamTypeId);
                });*/
/*
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

            migrationBuilder.InsertData(
                table: "TeamTypes",
                columns: new[] { "TeamTypeId", "Name" },
                values: new object[,]
                {
                    { -3, "Telematics" },
                    { -2, "Adas" },
                    { -1, "Unassigned" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUser_TeamTypes_TeamTypesTeamTypeId",
                table: "ApplicationUser",
                column: "TeamTypesTeamTypeId",
                principalTable: "TeamTypes",
                principalColumn: "TeamTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamTimeline_TeamTypes_TeamId",
                table: "TeamTimeline",
                column: "TeamId",
                principalTable: "TeamTypes",
                principalColumn: "TeamTypeId",
                onDelete: ReferentialAction.Cascade);*/
        }
    }
}
