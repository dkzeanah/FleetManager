using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations.ApplicationSQLiteDb
{
    /// <inheritdoc />
    public partial class addchangemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.AddColumn<string>(
                name: "DataHash",
                table: "ExcelDataRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "ExcelDataRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UploadDate",
                table: "ExcelDataRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "ExcelDataRecordChanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ColumnName = table.Column<string>(type: "TEXT", nullable: false),
                    OldValue = table.Column<string>(type: "TEXT", nullable: false),
                    NewValue = table.Column<string>(type: "TEXT", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExcelDataRecordId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcelDataRecordChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExcelDataRecordChanges_ExcelDataRecords_ExcelDataRecordId",
                        column: x => x.ExcelDataRecordId,
                        principalTable: "ExcelDataRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ExcelDataRecords",
                columns: new[] { "Id", "Data", "DataHash", "LastModified", "UploadDate" },
                values: new object[] { 1, "ExampleData", "ExampleDataHash", new DateTime(2023, 7, 28, 15, 45, 6, 477, DateTimeKind.Local).AddTicks(3479), new DateTime(2023, 7, 28, 15, 45, 6, 477, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.CreateIndex(
                name: "IX_ExcelDataRecordChanges_ExcelDataRecordId",
                table: "ExcelDataRecordChanges",
                column: "ExcelDataRecordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExcelDataRecordChanges");

            migrationBuilder.DeleteData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "DataHash",
                table: "ExcelDataRecords");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "ExcelDataRecords");

            migrationBuilder.DropColumn(
                name: "UploadDate",
                table: "ExcelDataRecords");

            migrationBuilder.InsertData(
                table: "ExcelDataRecords",
                columns: new[] { "Id", "Data" },
                values: new object[] { 1001, "On Model Creating Record" });
        }
    }
}
