using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations.ApplicationSQLiteDb
{
    /// <inheritdoc />
    public partial class BlockNote : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlockNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NoteContent = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockNotes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastModified", "UploadDate" },
                values: new object[] { new DateTime(2023, 8, 2, 17, 49, 13, 258, DateTimeKind.Local).AddTicks(5482), new DateTime(2023, 8, 2, 17, 49, 13, 258, DateTimeKind.Local).AddTicks(5427) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlockNotes");

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastModified", "UploadDate" },
                values: new object[] { new DateTime(2023, 7, 28, 15, 45, 6, 477, DateTimeKind.Local).AddTicks(3479), new DateTime(2023, 7, 28, 15, 45, 6, 477, DateTimeKind.Local).AddTicks(3253) });
        }
    }
}
