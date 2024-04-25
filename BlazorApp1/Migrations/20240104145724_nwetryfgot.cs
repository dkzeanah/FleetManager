using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class nwetryfgot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Discriminator",
                table: "Detail",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Cars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TestReleaseId",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TestReleaseId",
                table: "ApplicationUser",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TestReleases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CalendarWeek = table.Column<int>(type: "int", nullable: true),
                    CalendarMonth = table.Column<int>(type: "int", nullable: true),
                    CalendarYear = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestReleases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CheckListItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    TestReleaseId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    CompletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsGeneric = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckListItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckListItems_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckListItems_TestReleases_TestReleaseId",
                        column: x => x.TestReleaseId,
                        principalTable: "TestReleases",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "TestReleaseId" },
                values: new object[] { "88e72f4f-bbd4-40ea-b15b-99f7c4c6ca9e", "34c556b4-bac2-4c81-aa94-5d55dff646c1", null });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "TestReleaseId" },
                values: new object[] { "8e1b5a2b-b0e8-4906-a1b0-95e2965b0452", "c499120d-1972-4624-9e11-ca06a2e065f5", null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1001,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1002,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1003,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1004,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1005,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1006,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1007,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1008,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1009,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1010,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1011,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1012,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1013,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1014,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1015,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1016,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1017,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1018,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1019,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1020,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1021,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1022,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1023,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1024,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1025,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1026,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1027,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1028,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1029,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1030,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1031,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1032,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1033,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1034,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1035,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1036,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1037,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1038,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1039,
                columns: new[] { "IsDeleted", "TestReleaseId" },
                values: new object[] { false, null });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_TestReleaseId",
                table: "Cars",
                column: "TestReleaseId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_TestReleaseId",
                table: "ApplicationUser",
                column: "TestReleaseId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckListItems_CarId",
                table: "CheckListItems",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckListItems_TestReleaseId",
                table: "CheckListItems",
                column: "TestReleaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUser_TestReleases_TestReleaseId",
                table: "ApplicationUser",
                column: "TestReleaseId",
                principalTable: "TestReleases",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_TestReleases_TestReleaseId",
                table: "Cars",
                column: "TestReleaseId",
                principalTable: "TestReleases",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUser_TestReleases_TestReleaseId",
                table: "ApplicationUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_TestReleases_TestReleaseId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "CheckListItems");

            migrationBuilder.DropTable(
                name: "TestReleases");

            migrationBuilder.DropIndex(
                name: "IX_Cars_TestReleaseId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUser_TestReleaseId",
                table: "ApplicationUser");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "TestReleaseId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "TestReleaseId",
                table: "ApplicationUser");

            migrationBuilder.AlterColumn<string>(
                name: "Discriminator",
                table: "Detail",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(21)",
                oldMaxLength: 21);

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "40c8613d-3fa5-4a42-9cb4-3cdaf1b147fc", "a9f04de2-9c45-41e1-bdc3-94535e9f7204" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70fa0db4-b8f3-4b2a-8303-b4db6730b489", "8cdb3093-fe12-4780-ae3a-c8ab3a60e997" });
        }
    }
}
