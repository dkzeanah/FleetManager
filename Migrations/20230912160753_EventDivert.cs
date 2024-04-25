using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class EventDivert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detail_UserEvents_UserEventDetailId",
                table: "Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_ApplicationUser_ApplicationUserId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEvents_Events_EventId",
                table: "UserEvents");

            migrationBuilder.DropIndex(
                name: "IX_Events_ApplicationUserId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Detail_UserEventDetailId",
                table: "Detail");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "250992b3-73b9-41f5-b577-95683943e653");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "c86b1d54-9b68-4135-8151-67ca4afcad04");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventDetailId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UserEventId",
                table: "Events");

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "91973063-23c0-47ea-a489-1687d8cd0b7f", "cb069c62-b927-404e-9f6c-84725ee9cdcf" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3bd71c18-aec6-4e31-b98f-2883d6c589de", "20543820-e7bb-457d-bdc3-11cc3f83403a" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d5bd4f2-7ff3-4ce2-9fe6-ee9d9d046909", null, "Admin", "ADMIN" },
                    { "7c150fb6-5037-4224-8167-986be50e417b", null, "Visitor", "VISITOR" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detail_UserEventId",
                table: "Detail",
                column: "UserEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Detail_UserEvents_UserEventId",
                table: "Detail",
                column: "UserEventId",
                principalTable: "UserEvents",
                principalColumn: "UserEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserEvents_Events_EventId",
                table: "UserEvents",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detail_UserEvents_UserEventId",
                table: "Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEvents_Events_EventId",
                table: "UserEvents");

            migrationBuilder.DropIndex(
                name: "IX_Detail_UserEventId",
                table: "Detail");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5d5bd4f2-7ff3-4ce2-9fe6-ee9d9d046909");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "7c150fb6-5037-4224-8167-986be50e417b");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Events",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventDetailId",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserEventId",
                table: "Events",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Events_ApplicationUserId",
                table: "Events",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Detail_UserEventDetailId",
                table: "Detail",
                column: "UserEventDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Detail_UserEvents_UserEventDetailId",
                table: "Detail",
                column: "UserEventDetailId",
                principalTable: "UserEvents",
                principalColumn: "UserEventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_ApplicationUser_ApplicationUserId",
                table: "Events",
                column: "ApplicationUserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserEvents_Events_EventId",
                table: "UserEvents",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
