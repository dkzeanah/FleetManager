using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class DropEventTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
        name: "FK_CarEvent_Event_EventId",
        table: "CarEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEvents_Event_EventId",
                table: "UserEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_EventDetail_Event_EventId",
                table: "EventDetail");

            migrationBuilder.DropTable(
                name: "Event");


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            //  migrationBuilder.CreateTable(
            // name: "Event",
            // (other table creation details omitted for brevity)...
            // );

            migrationBuilder.AddForeignKey(
                name: "FK_CarEvent_Event_EventId",
                table: "CarEvent",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "EventID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserEvents_Event_EventId",
                table: "UserEvents",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "EventID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventDetail_Event_EventId",
                table: "EventDetail",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "EventID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
