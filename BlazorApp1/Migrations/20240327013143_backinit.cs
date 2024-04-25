using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class backinit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUser_Team_TeamId",
                table: "ApplicationUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamTimeline_Team_TeamId",
                table: "TeamTimeline");

            migrationBuilder.DropTable(
                name: "Team");

            //migrationBuilder.RenameColumn(
            //    name: "TeamId",
            //    table: "ApplicationUser",
            //    newName: "TestReleaseId");

            //migrationBuilder.RenameIndex(
            //    name: "IX_ApplicationUser_TeamId",
            //    table: "ApplicationUser",
            //    newName: "IX_ApplicationUser_TestReleaseId");

            //migrationBuilder.AddColumn<int>(
            //    name: "TestReleaseId",
            //    table: "Cars",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<int>(
            //    name: "TeamTypeId",
            //    table: "ApplicationUser",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.CreateTable(
            //    name: "TeamType",
            //    columns: table => new
            //    {
            //        TeamTypeId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TeamType", x => x.TeamTypeId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TestReleases",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CalendarWeek = table.Column<int>(type: "int", nullable: true),
            //        CalendarMonth = table.Column<int>(type: "int", nullable: true),
            //        CalendarYear = table.Column<int>(type: "int", nullable: true),
            //        StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        ReportId = table.Column<int>(type: "int", nullable: false),
            //        LastTested = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TestReleases", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CheckListItems",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CarId = table.Column<int>(type: "int", nullable: false),
            //        TestReleaseId = table.Column<int>(type: "int", nullable: true),
            //        Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        IsCompleted = table.Column<bool>(type: "bit", nullable: false),
            //        Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Priority = table.Column<int>(type: "int", nullable: false),
            //        TargetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
            //        IsGeneric = table.Column<bool>(type: "bit", nullable: false),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CheckListItems", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_CheckListItems_Cars_CarId",
            //            column: x => x.CarId,
            //            principalTable: "Cars",
            //            principalColumn: "CarId",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_CheckListItems_TestReleases_TestReleaseId",
            //            column: x => x.TestReleaseId,
            //            principalTable: "TestReleases",
            //            principalColumn: "Id");
            //    });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "TeamTypeId" },
                values: new object[] { "242431aa-fd88-4b04-bfad-c39de44fa08a", "b164b20f-24ad-4221-b9f5-95c9eb809b1d", null });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "TeamTypeId" },
                values: new object[] { "9d184674-e28b-4db4-92ed-e9c085c93b15", "8ac05b2b-e562-4cbf-bf1d-f11e04975eb8", null });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1001,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1002,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1003,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1004,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1005,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1006,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1007,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1008,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1009,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1010,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1011,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1012,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1013,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1014,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1015,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1016,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1017,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1018,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1019,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1020,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1021,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1022,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1023,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1024,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1025,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1026,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1027,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1028,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1029,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1030,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1031,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1032,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1033,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1034,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1035,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1036,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1037,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1038,
                column: "TestReleaseId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: 1039,
                column: "TestReleaseId",
                value: null);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Cars_TestReleaseId",
            //    table: "Cars",
            //    column: "TestReleaseId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ApplicationUser_TeamTypeId",
            //    table: "ApplicationUser",
            //    column: "TeamTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CheckListItems_CarId",
            //    table: "CheckListItems",
            //    column: "CarId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CheckListItems_TestReleaseId",
            //    table: "CheckListItems",
            //    column: "TestReleaseId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ApplicationUser_TeamType_TeamTypeId",
            //    table: "ApplicationUser",
            //    column: "TeamTypeId",
            //    principalTable: "TeamType",
            //    principalColumn: "TeamTypeId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ApplicationUser_TestReleases_TestReleaseId",
            //    table: "ApplicationUser",
            //    column: "TestReleaseId",
            //    principalTable: "TestReleases",
            //    principalColumn: "Id");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Cars_TestReleases_TestReleaseId",
            //    table: "Cars",
            //    column: "TestReleaseId",
            //    principalTable: "TestReleases",
            //    principalColumn: "Id");

            // migrationBuilder.AddForeignKey(
                //name: "FK_TeamTimeline_TeamType_TeamId",
                //table: "TeamTimeline",
                //column: "TeamId",
                //principalTable: "TeamType",
                //principalColumn: "TeamTypeId",
                //onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUser_TeamType_TeamTypeId",
                table: "ApplicationUser");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUser_TestReleases_TestReleaseId",
                table: "ApplicationUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_TestReleases_TestReleaseId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamTimeline_TeamType_TeamId",
                table: "TeamTimeline");

            migrationBuilder.DropTable(
                name: "CheckListItems");

            migrationBuilder.DropTable(
                name: "TeamType");

            migrationBuilder.DropTable(
                name: "TestReleases");

            migrationBuilder.DropIndex(
                name: "IX_Cars_TestReleaseId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUser_TeamTypeId",
                table: "ApplicationUser");

            migrationBuilder.DropColumn(
                name: "TestReleaseId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "TeamTypeId",
                table: "ApplicationUser");

            migrationBuilder.RenameColumn(
                name: "TestReleaseId",
                table: "ApplicationUser",
                newName: "TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUser_TestReleaseId",
                table: "ApplicationUser",
                newName: "IX_ApplicationUser_TeamId");

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "164db80b-10a7-4f85-b0df-f05f977bb88b", "9d8004cc-7248-4db4-855c-31906712b669" });

            migrationBuilder.UpdateData(
                table: "ApplicationUser",
                keyColumn: "Id",
                keyValue: "3de00zzz-2828-0000-0000-3de000000001",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41556f01-3778-437d-9efe-fa7d0c12d200", "d0cb9d53-df98-46c2-aac0-39d8d2c70875" });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Unassigned" },
                    { 2, "Adas" },
                    { 3, "Telematics" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUser_Team_TeamId",
                table: "ApplicationUser",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamTimeline_Team_TeamId",
                table: "TeamTimeline",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
