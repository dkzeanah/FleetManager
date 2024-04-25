using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations.ApplicationSQLiteDb
{
    /// <inheritdoc />
    public partial class ExcelDataRecordFluff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadDate",
                table: "ExcelDataRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "ExcelDataRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ExcelDataRecordAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false),
                    ExcelDataRecordId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcelDataRecordAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExcelDataRecordAttributes_ExcelDataRecords_ExcelDataRecordId",
                        column: x => x.ExcelDataRecordId,
                        principalTable: "ExcelDataRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ExcelDataRecordAttributes",
                columns: new[] { "Id", "ExcelDataRecordId", "Name", "Value" },
                values: new object[,]
                {
                    { 1, 1, "TestAttribute1", "TestValue1" },
                    { 2, 1, "TestAttribute2", "TestValue2" },
                    { 3, 2, "TestAttribute1", "TestValue1" },
                    { 4, 2, "TestAttribute2", "TestValue2" }
                });

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataHash", "JsonData", "LastModified", "UploadDate" },
                values: new object[] { "hash1", null, new DateTime(2023, 8, 8, 10, 43, 37, 97, DateTimeKind.Local).AddTicks(4919), new DateTime(2023, 8, 8, 10, 43, 37, 97, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataHash", "JsonData", "LastModified", "UploadDate" },
                values: new object[] { "hash2", null, new DateTime(2023, 8, 8, 10, 43, 37, 97, DateTimeKind.Local).AddTicks(4923), new DateTime(2023, 8, 8, 10, 43, 37, 97, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "MasterLog",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 8, 8, 10, 43, 37, 98, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "MasterLog",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 8, 8, 10, 43, 37, 98, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.CreateIndex(
                name: "IX_ExcelDataRecordAttributes_ExcelDataRecordId",
                table: "ExcelDataRecordAttributes",
                column: "ExcelDataRecordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExcelDataRecordAttributes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadDate",
                table: "ExcelDataRecords",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "ExcelDataRecords",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataHash", "JsonData", "LastModified", "UploadDate" },
                values: new object[] { "DataHash1", "JsonData1", new DateTime(2023, 8, 3, 23, 35, 56, 29, DateTimeKind.Local).AddTicks(4907), new DateTime(2023, 8, 3, 23, 35, 56, 29, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataHash", "JsonData", "LastModified", "UploadDate" },
                values: new object[] { "DataHash2", "JsonData2", new DateTime(2023, 8, 3, 23, 35, 56, 29, DateTimeKind.Local).AddTicks(4913), new DateTime(2023, 8, 3, 23, 35, 56, 29, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "MasterLog",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 8, 3, 23, 35, 56, 30, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "MasterLog",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 8, 3, 23, 35, 56, 30, DateTimeKind.Local).AddTicks(3630));
        }
    }
}
