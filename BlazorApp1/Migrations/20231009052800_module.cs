using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class module : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModule_Module_ModuleId",
                table: "CarModule");

            migrationBuilder.DropForeignKey(
                name: "FK_CarModule_Module_ModuleId1",
                table: "CarModule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Module",
                table: "Module");

            migrationBuilder.RenameTable(
                name: "Module",
                newName: "Modules");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Modules",
                table: "Modules",
                column: "ModuleId");

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "34bdfe2d-b874-4639-aa28-b3e6702b783e", "47ff0dde-b96e-461d-ade5-07d0ab9333d9" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a2e5398b-f842-49ec-b0f6-47726684c16c", "f9b4b27f-f53a-443d-845b-4f2f4592422f" });

            migrationBuilder.AddForeignKey(
                name: "FK_CarModule_Modules_ModuleId",
                table: "CarModule",
                column: "ModuleId",
                principalTable: "Modules",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarModule_Modules_ModuleId1",
                table: "CarModule",
                column: "ModuleId1",
                principalTable: "Modules",
                principalColumn: "ModuleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarModule_Modules_ModuleId",
                table: "CarModule");

            migrationBuilder.DropForeignKey(
                name: "FK_CarModule_Modules_ModuleId1",
                table: "CarModule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Modules",
                table: "Modules");

            migrationBuilder.RenameTable(
                name: "Modules",
                newName: "Module");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Module",
                table: "Module",
                column: "ModuleId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_CarModule_Module_ModuleId",
                table: "CarModule",
                column: "ModuleId",
                principalTable: "Module",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarModule_Module_ModuleId1",
                table: "CarModule",
                column: "ModuleId1",
                principalTable: "Module",
                principalColumn: "ModuleId");
        }
    }
}
