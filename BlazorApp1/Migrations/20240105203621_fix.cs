using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
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
                values: new object[] { "0294bae5-06ae-43d4-95c9-a75aef645d7e", "2a0322b3-f17d-425b-a45f-3a34f67ec4db" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0434a336-e65f-4cef-8106-ca4304b57a6b", "1ae34cc4-f023-40ba-86f2-e0416c61c22a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d4f3dca3-3081-4f84-b150-cdc256f9f06d", "6b8a8755-4a09-4516-84a2-6ce98c6310c7" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6cf9c837-8012-4dcc-8038-eb3e514fc698", "31e248a2-ec92-49e9-862d-7c119373b5a1" });
        }
    }
}
