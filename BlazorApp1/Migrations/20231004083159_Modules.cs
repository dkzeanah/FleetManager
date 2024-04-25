using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class Modules : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAssigned",
                table: "TaskModels",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCompleted",
                table: "TaskModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpired",
                table: "TaskModels",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumLoggers",
                table: "Logger",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "NaturalId",
                table: "Logger",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    ModuleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentSoftwareVersion = table.Column<double>(type: "float", nullable: true),
                    NextSoftwareVersion = table.Column<double>(type: "float", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProjectedRelease = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.ModuleId);
                });

            migrationBuilder.CreateTable(
                name: "CarModule",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false),
                    CarId1 = table.Column<int>(type: "int", nullable: true),
                    ModuleId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModule", x => new { x.CarId, x.ModuleId });
                    table.ForeignKey(
                        name: "FK_CarModule_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarModule_Cars_CarId1",
                        column: x => x.CarId1,
                        principalTable: "Cars",
                        principalColumn: "CarId");
                    table.ForeignKey(
                        name: "FK_CarModule_Module_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Module",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarModule_Module_ModuleId1",
                        column: x => x.ModuleId1,
                        principalTable: "Module",
                        principalColumn: "ModuleId");
                });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d97b2aac-3d20-4852-8142-89af576a46b1", "dbc6740f-e6b7-4a52-bb57-74243ba2b305" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bcca370a-0f30-4d8d-a5c3-0d03f18bf53a", "0fd2588f-0286-4b48-934d-44cf0ada148a" });

            migrationBuilder.UpdateData(
                table: "Logger",
                keyColumn: "Id",
                keyValue: 1,
                column: "NaturalId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Logger",
                keyColumn: "Id",
                keyValue: 2,
                column: "NaturalId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Logger",
                keyColumn: "Id",
                keyValue: 3,
                column: "NaturalId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Logger",
                keyColumn: "Id",
                keyValue: 4,
                column: "NaturalId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Logger",
                keyColumn: "Id",
                keyValue: 5,
                column: "NaturalId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Logger",
                keyColumn: "Id",
                keyValue: 6,
                column: "NaturalId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_CarModule_CarId1",
                table: "CarModule",
                column: "CarId1");

            migrationBuilder.CreateIndex(
                name: "IX_CarModule_ModuleId",
                table: "CarModule",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_CarModule_ModuleId1",
                table: "CarModule",
                column: "ModuleId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarModule");

            migrationBuilder.DropTable(
                name: "Module");

            migrationBuilder.DropColumn(
                name: "DateAssigned",
                table: "TaskModels");

            migrationBuilder.DropColumn(
                name: "DateCompleted",
                table: "TaskModels");

            migrationBuilder.DropColumn(
                name: "DateExpired",
                table: "TaskModels");

            migrationBuilder.DropColumn(
                name: "NaturalId",
                table: "Logger");

            migrationBuilder.AlterColumn<int>(
                name: "NumLoggers",
                table: "Logger",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8082ef4b-7dd8-46d7-8d8e-0468def3950d", "6d3aebbc-0139-4356-9e18-0f911f1c8c3a" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fe86abcb-1f79-489a-b5f1-c8f85d2967a1", "5d35b500-5ef7-42b4-a472-49df3eb9191e" });
        }
    }
}
