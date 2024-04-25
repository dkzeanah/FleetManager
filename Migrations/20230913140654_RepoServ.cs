using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class RepoServ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExcelDataRecordAttribute_ExcelDataRecord_ExcelDataRecordId",
                table: "ExcelDataRecordAttribute");

            migrationBuilder.DropForeignKey(
                name: "FK_ExcelDataRecordChange_ExcelDataRecord_ExcelDataRecordId",
                table: "ExcelDataRecordChange");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExcelDataRecordChange",
                table: "ExcelDataRecordChange");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExcelDataRecord",
                table: "ExcelDataRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blank",
                table: "Blank");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "789188bb-14a0-4eb5-bc4c-7820b54a76c2");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ef191376-da76-4aa4-b5e2-de02e4af19f4");

            migrationBuilder.RenameTable(
                name: "ExcelDataRecordChange",
                newName: "ExcelDataRecordChanges");

            migrationBuilder.RenameTable(
                name: "ExcelDataRecord",
                newName: "ExcelDataRecords");

            migrationBuilder.RenameTable(
                name: "Blank",
                newName: "Blanks");

            migrationBuilder.RenameIndex(
                name: "IX_ExcelDataRecordChange_ExcelDataRecordId",
                table: "ExcelDataRecordChanges",
                newName: "IX_ExcelDataRecordChanges_ExcelDataRecordId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExcelDataRecordChanges",
                table: "ExcelDataRecordChanges",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExcelDataRecords",
                table: "ExcelDataRecords",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blanks",
                table: "Blanks",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "RoleEventMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultEventTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleEventMappings", x => x.Id);
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_ExcelDataRecordAttribute_ExcelDataRecords_ExcelDataRecordId",
                table: "ExcelDataRecordAttribute",
                column: "ExcelDataRecordId",
                principalTable: "ExcelDataRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExcelDataRecordChanges_ExcelDataRecords_ExcelDataRecordId",
                table: "ExcelDataRecordChanges",
                column: "ExcelDataRecordId",
                principalTable: "ExcelDataRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExcelDataRecordAttribute_ExcelDataRecords_ExcelDataRecordId",
                table: "ExcelDataRecordAttribute");

            migrationBuilder.DropForeignKey(
                name: "FK_ExcelDataRecordChanges_ExcelDataRecords_ExcelDataRecordId",
                table: "ExcelDataRecordChanges");

            migrationBuilder.DropTable(
                name: "RoleEventMappings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExcelDataRecords",
                table: "ExcelDataRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExcelDataRecordChanges",
                table: "ExcelDataRecordChanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blanks",
                table: "Blanks");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "0cf9192f-4463-47d8-81c9-418bc7a1add6");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d485512c-682a-4d44-a6dd-aa2d4d0bb24d");

            migrationBuilder.RenameTable(
                name: "ExcelDataRecords",
                newName: "ExcelDataRecord");

            migrationBuilder.RenameTable(
                name: "ExcelDataRecordChanges",
                newName: "ExcelDataRecordChange");

            migrationBuilder.RenameTable(
                name: "Blanks",
                newName: "Blank");

            migrationBuilder.RenameIndex(
                name: "IX_ExcelDataRecordChanges_ExcelDataRecordId",
                table: "ExcelDataRecordChange",
                newName: "IX_ExcelDataRecordChange_ExcelDataRecordId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExcelDataRecord",
                table: "ExcelDataRecord",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExcelDataRecordChange",
                table: "ExcelDataRecordChange",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blank",
                table: "Blank",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1db62d57-9f79-45af-b249-fb94190ea391", "085d23f5-5dbd-43ba-a0c5-944c6c835e10" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "07e0e33f-88e4-4752-af88-d5bc6b493051", "67e7dc5a-f24a-463f-ac32-245ab346a23c" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "789188bb-14a0-4eb5-bc4c-7820b54a76c2", null, "Visitor", "VISITOR" },
                    { "ef191376-da76-4aa4-b5e2-de02e4af19f4", null, "Admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ExcelDataRecordAttribute_ExcelDataRecord_ExcelDataRecordId",
                table: "ExcelDataRecordAttribute",
                column: "ExcelDataRecordId",
                principalTable: "ExcelDataRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExcelDataRecordChange_ExcelDataRecord_ExcelDataRecordId",
                table: "ExcelDataRecordChange",
                column: "ExcelDataRecordId",
                principalTable: "ExcelDataRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
