using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class IDRenamesToId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
    name: "FK_Event_ApplicationUser_UserID",
    table: "Event");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Event",
                newName: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_ApplicationUser_UserId",
                table: "Event",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
    name: "FK_Event_ApplicationUser_UserId",
    table: "Event");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Event",
                newName: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_ApplicationUser_UserID",
                table: "Event",
                column: "UserID",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

        }
    }
}
