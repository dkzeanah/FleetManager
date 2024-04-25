using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations.ApplicationSqliteDb
{
    /// <inheritdoc />
    public partial class fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3614ce74-74ec-4f60-9dd8-e158e412cdf0", "4f282892-50ce-4483-b4b8-e5620c0b7290" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7f6fdb8e-0780-454b-848b-a948129c795c", "d39d8f7f-95c9-4ec9-af1a-bd10bba24476" });

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastModified", "UploadDate" },
                values: new object[] { new DateTime(2024, 1, 5, 14, 36, 41, 961, DateTimeKind.Local).AddTicks(7409), new DateTime(2024, 1, 5, 14, 36, 41, 961, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LastModified", "UploadDate" },
                values: new object[] { new DateTime(2024, 1, 5, 14, 36, 41, 961, DateTimeKind.Local).AddTicks(7414), new DateTime(2024, 1, 5, 14, 36, 41, 961, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "MasterLog",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Time",
                value: new DateTime(2024, 1, 5, 14, 36, 41, 962, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "MasterLog",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Time",
                value: new DateTime(2024, 1, 5, 14, 36, 41, 962, DateTimeKind.Local).AddTicks(3603));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
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
        }
    }
}
