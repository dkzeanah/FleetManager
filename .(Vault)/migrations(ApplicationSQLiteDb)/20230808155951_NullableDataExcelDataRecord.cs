using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations.ApplicationSQLiteDb
{
    /// <inheritdoc />
    public partial class NullableDataExcelDataRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Data",
                table: "ExcelDataRecords",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastModified", "UploadDate" },
                values: new object[] { new DateTime(2023, 8, 8, 10, 59, 50, 651, DateTimeKind.Local).AddTicks(2819), new DateTime(2023, 8, 8, 10, 59, 50, 651, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastModified", "UploadDate" },
                values: new object[] { new DateTime(2023, 8, 8, 10, 59, 50, 651, DateTimeKind.Local).AddTicks(2823), new DateTime(2023, 8, 8, 10, 59, 50, 651, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                table: "MasterLog",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 8, 8, 10, 59, 50, 652, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "MasterLog",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 8, 8, 10, 59, 50, 652, DateTimeKind.Local).AddTicks(161));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Data",
                table: "ExcelDataRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastModified", "UploadDate" },
                values: new object[] { new DateTime(2023, 8, 8, 10, 43, 37, 97, DateTimeKind.Local).AddTicks(4919), new DateTime(2023, 8, 8, 10, 43, 37, 97, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastModified", "UploadDate" },
                values: new object[] { new DateTime(2023, 8, 8, 10, 43, 37, 97, DateTimeKind.Local).AddTicks(4923), new DateTime(2023, 8, 8, 10, 43, 37, 97, DateTimeKind.Local).AddTicks(4922) });

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
        }
    }
}
