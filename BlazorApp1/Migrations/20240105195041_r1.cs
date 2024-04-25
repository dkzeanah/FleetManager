using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class r1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUser_TeamTypes_TeamId",
                table: "ApplicationUser");

            migrationBuilder.DeleteData(
                table: "TeamTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TeamTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TeamTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TeamTypes",
                newName: "TeamTypeId");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "ApplicationUser",
                newName: "TeamTypesTeamTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUser_TeamId",
                table: "ApplicationUser",
                newName: "IX_ApplicationUser_TeamTypesTeamTypeId");
*/
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CheckListItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "50133329-8629-45c8-9d32-19158e45dd59", "cf57de1e-5c65-4795-ab5e-9f8b8c881d87" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2df4f361-f566-443d-a80d-7fa885cc5527", "c07234ec-f2da-4bd5-adcf-ccc906438c60" });

           /* migrationBuilder.InsertData(
                table: "TeamTypes",
                columns: new[] { "TeamTypeId", "Name" },
                values: new object[,]
                {
                    { -3, "Telematics" },
                    { -2, "Adas" },
                    { -1, "Unassigned" }
                });*/

           /* migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUser_TeamTypes_TeamTypesTeamTypeId",
                table: "ApplicationUser",
                column: "TeamTypesTeamTypeId",
                principalTable: "TeamTypes",
                principalColumn: "TeamTypeId");*/
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
          /*  migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUser_TeamTypes_TeamTypesTeamTypeId",
                table: "ApplicationUser");

            migrationBuilder.DeleteData(
                table: "TeamTypes",
                keyColumn: "TeamTypeId",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "TeamTypes",
                keyColumn: "TeamTypeId",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "TeamTypes",
                keyColumn: "TeamTypeId",
                keyValue: -1);*/

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CheckListItems");

           /* migrationBuilder.RenameColumn(
                name: "TeamTypeId",
                table: "TeamTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TeamTypesTeamTypeId",
                table: "ApplicationUser",
                newName: "TeamId");*/

           /* migrationBuilder.RenameIndex(
                name: "IX_ApplicationUser_TeamTypesTeamTypeId",
                table: "ApplicationUser",
                newName: "IX_ApplicationUser_TeamId");
*/
            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88e72f4f-bbd4-40ea-b15b-99f7c4c6ca9e", "34c556b4-bac2-4c81-aa94-5d55dff646c1" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e1b5a2b-b0e8-4906-a1b0-95e2965b0452", "c499120d-1972-4624-9e11-ca06a2e065f5" });

          /*  migrationBuilder.InsertData(
                table: "TeamTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Unassigned" },
                    { 2, "Adas" },
                    { 3, "Telematics" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUser_TeamTypes_TeamId",
                table: "ApplicationUser",
                column: "TeamId",
                principalTable: "TeamTypes",
                principalColumn: "Id");*/
        }
    }
}
