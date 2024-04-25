using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class AutogenEventRetry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7998e7a5-ca56-4b28-8287-63938af4b707");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "85de7294-e8c8-4e6b-af50-1f7b20cc681d");

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9c63379d-80be-4f7a-9527-ccf5c41274e2", "7041493f-cd0f-455c-9266-06c25502d585" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "58742b77-4aee-49c4-bcd8-6dd29e6ab3d3", "33500d4e-f65e-49af-93aa-0abeb68f8c97" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9e0ddc2f-54ec-4483-90a5-6fc259c132aa", null, "Admin", "ADMIN" },
                    { "f3f4c9ba-592d-4448-9610-719613579041", null, "Visitor", "VISITOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9e0ddc2f-54ec-4483-90a5-6fc259c132aa");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f3f4c9ba-592d-4448-9610-719613579041");

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "873ff300-a44a-44e7-bb23-5ed076b0e2c4", "e1958af9-cfa6-4c13-8c77-4493ab05515e" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "607b3f6a-775d-46e7-a440-a2df731b8022", "f53326f3-9d30-4ae2-973a-5cba633ff6d0" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7998e7a5-ca56-4b28-8287-63938af4b707", null, "Admin", "ADMIN" },
                    { "85de7294-e8c8-4e6b-af50-1f7b20cc681d", null, "Visitor", "VISITOR" }
                });
        }
    }
}
