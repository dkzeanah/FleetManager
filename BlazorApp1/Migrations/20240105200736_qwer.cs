using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class qwer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          /*  migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUser_TeamTypes_TeamTypesTeamTypeId",
                table: "ApplicationUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamTimeline_TeamTypes_TeamId",
                table: "TeamTimeline");

            migrationBuilder.DropTable(
                name: "TeamTypes");*/

            migrationBuilder.DropPrimaryKey(
                name: "PK__CarStatu__C8EE2043D8294AF0",
                table: "CarStatus_New");

            migrationBuilder.RenameTable(
                name: "CarStatus_New",
                newName: "CarStatusNews");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "ApplicationUser",
                newName: "TeamTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUser_TeamId",
                table: "ApplicationUser",
                newName: "IX_ApplicationUser_TeamTypeId");

            migrationBuilder.RenameColumn(
                name: "StatusID",
                table: "CarStatusNews",
                newName: "CarStatusNewId");

          /*  migrationBuilder.AlterColumn<string>(
                name: "StatusName",
                table: "CarStatus_New",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "CarStatus_New",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");*/

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarStatusNews",
                table: "CarStatusNews",
                column: "CarStatusNewId");

            migrationBuilder.CreateTable(
                name: "TeamType",
                columns: table => new
                {
                    TeamTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamType", x => x.TeamTypeId);
                });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "074bd989-e49d-4965-854e-61ae6b445f50", "b419a8f2-c306-4c2c-b622-22710a704ea2" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7f0107d8-003d-4a5c-8898-19dbfbfd452e", "fab41ef0-62d3-41ec-a3bf-01ae0e63857b" });

            migrationBuilder.InsertData(
                table: "TeamType",
                columns: new[] { "TeamTypeId", "Name" },
                values: new object[,]
                {
                    { -3, "Telematics" },
                    { -2, "Adas" },
                    { -1, "Unassigned" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUser_TeamType_TeamTypeId",
                table: "ApplicationUser",
                column: "TeamTypeId",
                principalTable: "TeamType",
                principalColumn: "TeamTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamTimeline_TeamType_TeamId",
                table: "TeamTimeline",
                column: "TeamId",
                principalTable: "TeamType",
                principalColumn: "TeamTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUser_TeamType_TeamTypeId",
                table: "ApplicationUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamTimeline_TeamType_TeamId",
                table: "TeamTimeline");

            migrationBuilder.DropTable(
                name: "TeamType");*/

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarStatusNews",
                table: "CarStatusNews");

            migrationBuilder.RenameTable(
                name: "CarStatusNews",
                newName: "CarStatus_New");

            migrationBuilder.RenameColumn(
                name: "TeamTypeId",
                table: "ApplicationUser",
                newName: "TeamTypesTeamTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUser_TeamTypeId",
                table: "ApplicationUser",
                newName: "IX_ApplicationUser_TeamTypesTeamTypeId");

            migrationBuilder.RenameColumn(
                name: "CarStatusNewId",
                table: "CarStatus_New",
                newName: "StatusID");

           /* migrationBuilder.AlterColumn<string>(
                name: "StatusName",
                table: "CarStatus_New",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "StatusID",
                table: "CarStatus_New",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");*/

            migrationBuilder.AddPrimaryKey(
                name: "PK__CarStatu__C8EE2043D8294AF0",
                table: "CarStatus_New",
                column: "StatusID");

            migrationBuilder.CreateTable(
                name: "TeamTypes",
                columns: table => new
                {
                    TeamTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamTypes", x => x.TeamTypeId);
                });

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

            migrationBuilder.InsertData(
                table: "TeamTypes",
                columns: new[] { "TeamTypeId", "Name" },
                values: new object[,]
                {
                    { -3, "Telematics" },
                    { -2, "Adas" },
                    { -1, "Unassigned" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUser_TeamTypes_TeamTypesTeamTypeId",
                table: "ApplicationUser",
                column: "TeamTypesTeamTypeId",
                principalTable: "TeamTypes",
                principalColumn: "TeamTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamTimeline_TeamTypes_TeamId",
                table: "TeamTimeline",
                column: "TeamId",
                principalTable: "TeamTypes",
                principalColumn: "TeamTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
