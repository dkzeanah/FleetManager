using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class MyModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NaturalId",
                table: "Logger",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "MyModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyModels", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0c283c1e-9645-4222-9819-ab71e52a9c4e", "4f6efd7d-ab36-4b2e-a79b-e81710b70a29" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f13917db-c9e5-4eac-9c7c-5d48253665aa", "4efa49b4-001a-4225-b0a6-2ea46c07b04e" });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyModels");

            migrationBuilder.AlterColumn<string>(
                name: "NaturalId",
                table: "Logger",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd2de933-2613-4559-9e01-3202e9f89ae8", "4ef7ed7c-c112-4606-81b8-489e97eea01c" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6a269004-a739-4627-a93f-f8fc0feab142", "05705964-21eb-4f52-8150-46b1cb873389" });

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
        }
    }
}
