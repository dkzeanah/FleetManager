using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class OnModelCreatingUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           /* migrationBuilder.DropForeignKey(
                name: "FK_Event_PlaceholderUser_PlaceholderUserId",
                table: "Event");*/

            migrationBuilder.DropTable(
                name: "PlaceholderUser");

            migrationBuilder.DropTable(
                name: "PlaceholderUserRole");

            /*migrationBuilder.DropIndex(
                name: "IX_Event_PlaceholderUserId",
                table: "Event");*/
/*
            migrationBuilder.DropColumn(
                name: "PlaceholderUserId",
                table: "Event");*/

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Event",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Event",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AddColumn<string>(
                name: "PlaceholderUserId",
                table: "Event",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PlaceholderUserRole",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Placehol__8AFACE3A8A46317E", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "PlaceholderUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PlaceholderUserDetailUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceholderUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaceholderUser_ApplicationUserDetail_PlaceholderUserDetailUserId",
                        column: x => x.PlaceholderUserDetailUserId,
                        principalTable: "ApplicationUserDetail",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_PlaceholderUser_PlaceholderUserRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "PlaceholderUserRole",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Event_PlaceholderUserId",
                table: "Event",
                column: "PlaceholderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceholderUser_PlaceholderUserDetailUserId",
                table: "PlaceholderUser",
                column: "PlaceholderUserDetailUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceholderUser_RoleId",
                table: "PlaceholderUser",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_PlaceholderUser_PlaceholderUserId",
                table: "Event",
                column: "PlaceholderUserId",
                principalTable: "PlaceholderUser",
                principalColumn: "Id");
        }
    }
}
