using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class GoodMeasureIDToIdApplicationDbContext : Migration
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

            migrationBuilder.RenameColumn(
                name: "EventTypeID",
                table: "Event",
                newName: "EventTypeId");

            migrationBuilder.RenameColumn(
                name: "CarID",
                table: "Event",
                newName: "CarId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Event",
                newName: "Id");

            /*migrationBuilder.RenameIndex(
                name: "IDX_Event_UserID",
                table: "Event",
                newName: "IdX_Event_UserId");

            migrationBuilder.RenameIndex(
                name: "IDX_Event_EventTypeID",
                table: "Event",
                newName: "IdX_Event_EventTypeId");

            migrationBuilder.RenameIndex(
                name: "IDX_Event_CarID",
                table: "Event",
                newName: "IdX_Event_CarId");*/

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

            migrationBuilder.RenameColumn(
                name: "EventTypeId",
                table: "Event",
                newName: "EventTypeID");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "Event",
                newName: "CarID");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Event",
                newName: "EventID");

            migrationBuilder.RenameIndex(
                name: "IdX_Event_UserId",
                table: "Event",
                newName: "IDX_Event_UserID");

            migrationBuilder.RenameIndex(
                name: "IdX_Event_EventTypeId",
                table: "Event",
                newName: "IDX_Event_EventTypeID");

            migrationBuilder.RenameIndex(
                name: "IdX_Event_CarId",
                table: "Event",
                newName: "IDX_Event_CarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_ApplicationUser_UserID",
                table: "Event",
                column: "UserID",
                principalTable: "ApplicationUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
