using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations.ApplicationSQLiteDb
{
    /// <inheritdoc />
    public partial class excelentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Timeline_ApplicationUserDetail_UserDetailId",
                table: "Timeline");

            migrationBuilder.RenameColumn(
                name: "UserDetailId",
                table: "Timeline",
                newName: "ApplicationUserDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_Timeline_UserDetailId",
                table: "Timeline",
                newName: "IX_Timeline_ApplicationUserDetailId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadDate",
                table: "ExcelDataRecords",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "ExcelDataRecords",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "DataHash",
                table: "ExcelDataRecords",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "JsonData",
                table: "ExcelDataRecords",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityAttributeValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EntityId = table.Column<int>(type: "INTEGER", nullable: false),
                    AttributeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityAttributeValues_Attributes_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntityAttributeValues_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Data", "DataHash", "JsonData", "LastModified", "UploadDate" },
                values: new object[] { "Data1", "DataHash1", "JsonData1", new DateTime(2023, 8, 3, 23, 35, 56, 29, DateTimeKind.Local).AddTicks(4907), new DateTime(2023, 8, 3, 23, 35, 56, 29, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.InsertData(
                table: "ExcelDataRecords",
                columns: new[] { "Id", "Data", "DataHash", "JsonData", "LastModified", "UploadDate" },
                values: new object[] { 2, "Data2", "DataHash2", "JsonData2", new DateTime(2023, 8, 3, 23, 35, 56, 29, DateTimeKind.Local).AddTicks(4913), new DateTime(2023, 8, 3, 23, 35, 56, 29, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "MasterLog",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 8, 3, 23, 35, 56, 30, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "MasterLog",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 8, 3, 23, 35, 56, 30, DateTimeKind.Local).AddTicks(3630));

            migrationBuilder.CreateIndex(
                name: "IX_EntityAttributeValues_AttributeId",
                table: "EntityAttributeValues",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityAttributeValues_EntityId",
                table: "EntityAttributeValues",
                column: "EntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Timeline_ApplicationUserDetail_ApplicationUserDetailId",
                table: "Timeline",
                column: "ApplicationUserDetailId",
                principalTable: "ApplicationUserDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Timeline_ApplicationUserDetail_ApplicationUserDetailId",
                table: "Timeline");

            migrationBuilder.DropTable(
                name: "EntityAttributeValues");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "Entities");

            migrationBuilder.DeleteData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "JsonData",
                table: "ExcelDataRecords");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserDetailId",
                table: "Timeline",
                newName: "UserDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_Timeline_ApplicationUserDetailId",
                table: "Timeline",
                newName: "IX_Timeline_UserDetailId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UploadDate",
                table: "ExcelDataRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModified",
                table: "ExcelDataRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DataHash",
                table: "ExcelDataRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Data", "DataHash", "LastModified", "UploadDate" },
                values: new object[] { "ExampleData", "ExampleDataHash", new DateTime(2023, 8, 3, 17, 59, 16, 622, DateTimeKind.Local).AddTicks(9912), new DateTime(2023, 8, 3, 17, 59, 16, 622, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "MasterLog",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2023, 8, 3, 17, 59, 16, 624, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "MasterLog",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2023, 8, 3, 17, 59, 16, 624, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.AddForeignKey(
                name: "FK_Timeline_ApplicationUserDetail_UserDetailId",
                table: "Timeline",
                column: "UserDetailId",
                principalTable: "ApplicationUserDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
