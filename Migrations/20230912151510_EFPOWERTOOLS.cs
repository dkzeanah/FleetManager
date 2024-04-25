using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class EFPOWERTOOLS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "43670aec-fc6a-4ca9-be9e-ba7a33cc17db");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "492b7ce0-02cb-4850-bf32-f5169fb28ea7");

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cb927da4-d545-48fb-968f-7c7cdeb03a76", "94de6962-6797-46b8-ac4d-48bd409dcdee" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7008546-44c9-484a-8ebb-a35eaa48f2a3", "b43f187d-0b76-4cb6-a400-80f31ce5540f" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "250992b3-73b9-41f5-b577-95683943e653", null, "Visitor", "VISITOR" },
                    { "c86b1d54-9b68-4135-8151-67ca4afcad04", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "250992b3-73b9-41f5-b577-95683943e653");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c86b1d54-9b68-4135-8151-67ca4afcad04");

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d11f4e86-685c-4094-acaf-373e2d6abb0c", "b4aa64d9-4ce8-4aea-994c-902088989181" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "525d552a-dcbf-45dc-9e23-137c36ed826d", "2a444e13-d1cd-4f8a-90b9-cf6d517a7f5e" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "43670aec-fc6a-4ca9-be9e-ba7a33cc17db", null, "Admin", "ADMIN" },
                    { "492b7ce0-02cb-4850-bf32-f5169fb28ea7", null, "Visitor", "VISITOR" }
                });
        }
    }
}
