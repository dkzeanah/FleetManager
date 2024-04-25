using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class AutogenEvent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0cf9192f-4463-47d8-81c9-418bc7a1add6");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d485512c-682a-4d44-a6dd-aa2d4d0bb24d");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "87f09d8c-00fa-4657-827e-4241de929d84", "9e23d7a8-c403-4c9b-9528-ce9d72930ee9" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c7eff9ac-06a7-4659-a6f4-647cdb800998", "969d92ae-8f7f-4800-bf32-c9696a19ae97" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0cf9192f-4463-47d8-81c9-418bc7a1add6", null, "Visitor", "VISITOR" },
                    { "d485512c-682a-4d44-a6dd-aa2d4d0bb24d", null, "Admin", "ADMIN" }
                });
        }
    }
}
