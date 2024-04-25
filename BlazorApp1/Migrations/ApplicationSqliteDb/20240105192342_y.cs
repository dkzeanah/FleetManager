using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations.ApplicationSqliteDb
{
    /// <inheritdoc />
    public partial class y : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    String = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarStatusNews",
                columns: table => new
                {
                    CarStatusNewId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StatusName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarStatusNews", x => x.CarStatusNewId);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    DefaultPriority = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    Street = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "TEXT", maxLength: 3, nullable: false),
                    ZipCode = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DrivingHours = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverId);
                });

            migrationBuilder.CreateTable(
                name: "Entities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ErrorLogs",
                columns: table => new
                {
                    ErrorLogId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: false),
                    ErrorDetails = table.Column<string>(type: "TEXT", nullable: true),
                    ErrorPriority = table.Column<int>(type: "INTEGER", nullable: true),
                    ErrorNotes = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorLogs", x => x.ErrorLogId);
                });

            migrationBuilder.CreateTable(
                name: "EventTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExcelDataRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Data = table.Column<string>(type: "TEXT", nullable: true),
                    Hash = table.Column<string>(type: "TEXT", nullable: true),
                    UploadDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastModified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    JsonData = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcelDataRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserLogin<string>",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserLogin<string>", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserRole<string>",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<string>", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "IdentityUserToken<string>",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserToken<string>", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    IssueId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Summary = table.Column<string>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    Priority = table.Column<string>(type: "TEXT", nullable: false),
                    AssignedTo = table.Column<string>(type: "TEXT", nullable: false),
                    System = table.Column<string>(type: "TEXT", nullable: false),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: false),
                    ModifiedAt = table.Column<string>(type: "TEXT", nullable: false),
                    ModifiedByUser = table.Column<string>(type: "TEXT", nullable: false),
                    SubmittedBy = table.Column<string>(type: "TEXT", nullable: false),
                    SubmittedAt = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.IssueId);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Message = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Time = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterLog",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Message = table.Column<string>(type: "TEXT", nullable: false),
                    Time = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    ModuleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentSoftwareVersion = table.Column<double>(type: "REAL", nullable: true),
                    NextSoftwareVersion = table.Column<double>(type: "REAL", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ProjectedRelease = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ModuleId);
                });

            migrationBuilder.CreateTable(
                name: "MyModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CustomerName = table.Column<string>(type: "TEXT", nullable: false),
                    ShippingInfo = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleEventMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    DefaultEventTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleEventMappings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SensorData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SensorData = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SensorData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SimpleEvent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimpleEvent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SimpleEventTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimpleEventTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Softwares",
                columns: table => new
                {
                    SoftwareId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: false),
                    HeadUnit = table.Column<string>(type: "TEXT", nullable: false),
                    SoftwareVersion = table.Column<string>(type: "TEXT", nullable: false),
                    NextSoftwareVersion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Softwares", x => x.SoftwareId);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestReleases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CalendarWeek = table.Column<int>(type: "INTEGER", nullable: true),
                    CalendarMonth = table.Column<int>(type: "INTEGER", nullable: true),
                    CalendarYear = table.Column<int>(type: "INTEGER", nullable: true),
                    StartDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestReleases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityAttributeValues",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EntityId = table.Column<long>(type: "INTEGER", nullable: false),
                    AttributeId = table.Column<long>(type: "INTEGER", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "ExcelDataRecordAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false),
                    ExcelDataRecordId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcelDataRecordAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExcelDataRecordAttributes_ExcelDataRecords_ExcelDataRecordId",
                        column: x => x.ExcelDataRecordId,
                        principalTable: "ExcelDataRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExcelDataRecordChanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ColumnName = table.Column<string>(type: "TEXT", nullable: false),
                    OldValue = table.Column<string>(type: "TEXT", nullable: false),
                    NewValue = table.Column<string>(type: "TEXT", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ExcelDataRecordId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcelDataRecordChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExcelDataRecordChanges_ExcelDataRecords_ExcelDataRecordId",
                        column: x => x.ExcelDataRecordId,
                        principalTable: "ExcelDataRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewCar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Make = table.Column<string>(type: "TEXT", nullable: true),
                    Model = table.Column<string>(type: "TEXT", nullable: true),
                    Adas = table.Column<bool>(type: "INTEGER", nullable: true),
                    Year = table.Column<int>(type: "INTEGER", nullable: true),
                    TeleGeneration = table.Column<string>(type: "TEXT", nullable: true),
                    Miles = table.Column<int>(type: "INTEGER", nullable: true),
                    Location = table.Column<string>(type: "TEXT", nullable: true),
                    Tagnumber = table.Column<string>(type: "TEXT", nullable: true),
                    Vin = table.Column<string>(type: "TEXT", nullable: true),
                    Finas = table.Column<string>(type: "TEXT", nullable: true),
                    SourceId = table.Column<int>(type: "INTEGER", nullable: true),
                    CarStatusId = table.Column<int>(type: "INTEGER", nullable: true),
                    LoggerId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    Mileage = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewCar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewCar_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Truck",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Make = table.Column<string>(type: "TEXT", nullable: true),
                    Model = table.Column<string>(type: "TEXT", nullable: true),
                    Year = table.Column<int>(type: "INTEGER", nullable: true),
                    TeleGeneration = table.Column<string>(type: "TEXT", nullable: true),
                    Miles = table.Column<int>(type: "INTEGER", nullable: true),
                    Location = table.Column<string>(type: "TEXT", nullable: true),
                    Tagnumber = table.Column<string>(type: "TEXT", nullable: true),
                    Vin = table.Column<string>(type: "TEXT", nullable: true),
                    Finas = table.Column<string>(type: "TEXT", nullable: true),
                    Adas = table.Column<bool>(type: "INTEGER", nullable: true),
                    SourceId = table.Column<int>(type: "INTEGER", nullable: true),
                    TruckDetail = table.Column<int>(type: "INTEGER", nullable: false),
                    TruckStatusId = table.Column<int>(type: "INTEGER", nullable: false),
                    NewTruckLoggerId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Truck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Truck_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PostTag",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "INTEGER", nullable: false),
                    TagId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTag", x => new { x.PostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_PostTag_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTag_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamTimeline",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamTimeline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamTimeline_TeamTypes_TeamId",
                        column: x => x.TeamId,
                        principalTable: "TeamTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: true),
                    FriendlyName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    EventId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserEventId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserDetailId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserCarEventId = table.Column<int>(type: "INTEGER", nullable: false),
                    TeamTypesId = table.Column<int>(type: "INTEGER", nullable: true),
                    TestReleaseId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUser_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationUser_TeamTypes_TeamTypesId",
                        column: x => x.TeamTypesId,
                        principalTable: "TeamTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationUser_TestReleases_TestReleaseId",
                        column: x => x.TestReleaseId,
                        principalTable: "TestReleases",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CarStaticDetail",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "INTEGER", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Vin = table.Column<string>(type: "TEXT", nullable: false),
                    Tag = table.Column<string>(type: "TEXT", nullable: false),
                    Finas = table.Column<string>(type: "TEXT", nullable: false),
                    Adas = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "(1)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarStaticDetail", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_CarStaticDetail_NewCar_CarId",
                        column: x => x.CarId,
                        principalTable: "NewCar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    NewCarId = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusId = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarStatuses", x => new { x.NewCarId, x.Id });
                    table.ForeignKey(
                        name: "FK_CarStatuses_NewCar_NewCarId",
                        column: x => x.NewCarId,
                        principalTable: "NewCar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarStatuses_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TruckDetail",
                columns: table => new
                {
                    TruckDetailId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Make = table.Column<string>(type: "TEXT", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<string>(type: "TEXT", nullable: false),
                    Color = table.Column<string>(type: "TEXT", nullable: false),
                    Vin = table.Column<string>(type: "TEXT", nullable: false),
                    TruckId = table.Column<int>(type: "INTEGER", nullable: false),
                    DetailTypeId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TruckDetail", x => x.TruckDetailId);
                    table.ForeignKey(
                        name: "FK_TruckDetail_Truck_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Truck",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TruckStaticDetail",
                columns: table => new
                {
                    TruckId = table.Column<int>(type: "INTEGER", nullable: false),
                    Vin = table.Column<string>(type: "TEXT", nullable: false),
                    Tag = table.Column<string>(type: "TEXT", nullable: false),
                    Finas = table.Column<string>(type: "TEXT", nullable: false),
                    Adas = table.Column<bool>(type: "INTEGER", nullable: true, defaultValueSql: "(1)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TruckStaticDetail", x => x.TruckId);
                    table.ForeignKey(
                        name: "FK_TruckStaticDetail_Truck_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Truck",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TruckStatus",
                columns: table => new
                {
                    TruckId = table.Column<int>(type: "INTEGER", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusId = table.Column<int>(type: "INTEGER", nullable: true),
                    StatusTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TruckStatus", x => new { x.TruckId, x.Id });
                    table.ForeignKey(
                        name: "FK_TruckStatus_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TruckStatus_Truck_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Truck",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserDetail",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserDetail", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_ApplicationUserDetail_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParkingSpace = table.Column<int>(type: "INTEGER", nullable: true),
                    Make = table.Column<string>(type: "TEXT", nullable: true),
                    Model = table.Column<string>(type: "TEXT", nullable: true),
                    Year = table.Column<double>(type: "REAL", nullable: true),
                    TeleGeneration = table.Column<string>(type: "TEXT", nullable: true),
                    Miles = table.Column<int>(type: "INTEGER", nullable: true),
                    Location = table.Column<string>(type: "TEXT", nullable: true),
                    SourceId = table.Column<int>(type: "INTEGER", nullable: true),
                    LoggerId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    HasLogger = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasHarness = table.Column<bool>(type: "INTEGER", nullable: true),
                    HasTag = table.Column<bool>(type: "INTEGER", nullable: true),
                    IsAdas = table.Column<bool>(type: "INTEGER", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    TestReleaseId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Cars_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cars_TestReleases_TestReleaseId",
                        column: x => x.TestReleaseId,
                        principalTable: "TestReleases",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    AuthorId = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notes_ApplicationUser_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaskModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateAssigned = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Task = table.Column<string>(type: "TEXT", nullable: false),
                    IsComplete = table.Column<bool>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    RangeStart = table.Column<DateTime>(type: "TEXT", nullable: true),
                    RangeEnd = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Importance = table.Column<int>(type: "INTEGER", nullable: true),
                    DateCompleted = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DateExpired = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskModels_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CreatorId = table.Column<string>(type: "TEXT", nullable: false),
                    AssigneeId = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ClosedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    Severity = table.Column<string>(type: "TEXT", nullable: false),
                    Priority = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_ApplicationUser_AssigneeId",
                        column: x => x.AssigneeId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_ApplicationUser_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserCarEvent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: false),
                    EventTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", maxLength: 450, nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    TeamTimelineId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCarEvent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCarEvent_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserCarEvent_EventTypes_EventTypeId",
                        column: x => x.EventTypeId,
                        principalTable: "EventTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCarEvent_TeamTimeline_TeamTimelineId",
                        column: x => x.TeamTimelineId,
                        principalTable: "TeamTimeline",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DetailType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    TruckDetailId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailType_TruckDetail_TruckDetailId",
                        column: x => x.TruckDetailId,
                        principalTable: "TruckDetail",
                        principalColumn: "TruckDetailId");
                });

            migrationBuilder.CreateTable(
                name: "CarModule",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "INTEGER", nullable: false),
                    ModuleId = table.Column<int>(type: "INTEGER", nullable: false),
                    CarId1 = table.Column<int>(type: "INTEGER", nullable: true),
                    ModuleId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModule", x => new { x.CarId, x.ModuleId });
                    table.ForeignKey(
                        name: "FK_CarModule_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarModule_Cars_CarId1",
                        column: x => x.CarId1,
                        principalTable: "Cars",
                        principalColumn: "CarId");
                    table.ForeignKey(
                        name: "FK_CarModule_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "ModuleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarModule_Modules_ModuleId1",
                        column: x => x.ModuleId1,
                        principalTable: "Modules",
                        principalColumn: "ModuleId");
                });

            migrationBuilder.CreateTable(
                name: "CheckListItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: false),
                    TestReleaseId = table.Column<int>(type: "INTEGER", nullable: true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    IsCompleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CompletedOn = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: false),
                    Priority = table.Column<int>(type: "INTEGER", nullable: false),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsGeneric = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckListItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckListItems_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckListItems_TestReleases_TestReleaseId",
                        column: x => x.TestReleaseId,
                        principalTable: "TestReleases",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Logger",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NaturalId = table.Column<int>(type: "INTEGER", nullable: true),
                    TruckId = table.Column<int>(type: "INTEGER", nullable: true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: true),
                    NewCarId = table.Column<int>(type: "INTEGER", nullable: true),
                    TypeLogger = table.Column<int>(type: "INTEGER", nullable: false),
                    NumLoggers = table.Column<int>(type: "INTEGER", nullable: true),
                    NewCarId1 = table.Column<int>(type: "INTEGER", nullable: true),
                    isAssigned = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logger", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logger_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId");
                    table.ForeignKey(
                        name: "FK_Logger_NewCar_NewCarId1",
                        column: x => x.NewCarId1,
                        principalTable: "NewCar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Logger_Truck_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Truck",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NewCarLoggers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TruckId = table.Column<int>(type: "INTEGER", nullable: true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: true),
                    CardId = table.Column<int>(type: "INTEGER", nullable: true),
                    TypeLogger = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: false),
                    NumLoggers = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewCarLoggers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewCarLoggers_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId");
                    table.ForeignKey(
                        name: "FK_NewCarLoggers_NewCar_CardId",
                        column: x => x.CardId,
                        principalTable: "NewCar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewCarLoggers_Truck_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Truck",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NewTruckLoggers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TruckdId = table.Column<int>(type: "INTEGER", nullable: true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: true),
                    NewCarId = table.Column<int>(type: "INTEGER", nullable: true),
                    TypeLogger = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: false),
                    NumLoggers = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewTruckLoggers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewTruckLoggers_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId");
                    table.ForeignKey(
                        name: "FK_NewTruckLoggers_NewCar_NewCarId",
                        column: x => x.NewCarId,
                        principalTable: "NewCar",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NewTruckLoggers_Truck_TruckdId",
                        column: x => x.TruckdId,
                        principalTable: "Truck",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: true),
                    EventTypeId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    NoteId = table.Column<int>(type: "INTEGER", nullable: true),
                    TextNote = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserEventDetailId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserEventDetail = table.Column<string>(type: "TEXT", nullable: true),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EndTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: true),
                    SimpleEventTypeId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Events_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId");
                    table.ForeignKey(
                        name: "FK_Events_EventTypes_EventTypeId",
                        column: x => x.EventTypeId,
                        principalTable: "EventTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Events_Notes_NoteId",
                        column: x => x.NoteId,
                        principalTable: "Notes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Events_SimpleEventTypes_SimpleEventTypeId",
                        column: x => x.SimpleEventTypeId,
                        principalTable: "SimpleEventTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "NoteAttachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NoteId = table.Column<int>(type: "INTEGER", nullable: false),
                    FilePath = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoteAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NoteAttachment_Notes_NoteId",
                        column: x => x.NoteId,
                        principalTable: "Notes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NoteComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NoteId = table.Column<int>(type: "INTEGER", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    AuthorId = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoteComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NoteComment_ApplicationUser_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NoteComment_Notes_NoteId",
                        column: x => x.NoteId,
                        principalTable: "Notes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NoteTag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NoteId = table.Column<int>(type: "INTEGER", nullable: false),
                    Tag = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoteTag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NoteTag_Notes_NoteId",
                        column: x => x.NoteId,
                        principalTable: "Notes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketAttachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false),
                    FilePath = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketAttachment_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    AuthorId = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketComment_ApplicationUser_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketComment_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false),
                    Change = table.Column<string>(type: "TEXT", nullable: false),
                    ChangedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChangedById = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketHistory_ApplicationUser_ChangedById",
                        column: x => x.ChangedById,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketHistory_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TicketTag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false),
                    Tag = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketTag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketTag_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEvents",
                columns: table => new
                {
                    UserEventId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EventId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    UserCarEventId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEvents", x => x.UserEventId);
                    table.ForeignKey(
                        name: "FK_UserEvents_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserEvents_UserCarEvent_UserCarEventId",
                        column: x => x.UserCarEventId,
                        principalTable: "UserCarEvent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Detail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DetailTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "TEXT", nullable: true),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 21, nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    UserEventId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserEventDetailId = table.Column<int>(type: "INTEGER", nullable: true),
                    Note = table.Column<string>(type: "TEXT", nullable: true),
                    UserCarEventId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Detail_ApplicationUser_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Detail_DetailType_DetailTypeId",
                        column: x => x.DetailTypeId,
                        principalTable: "DetailType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detail_UserCarEvent_UserCarEventId",
                        column: x => x.UserCarEventId,
                        principalTable: "UserCarEvent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Detail_UserEvents_UserEventId",
                        column: x => x.UserEventId,
                        principalTable: "UserEvents",
                        principalColumn: "UserEventId");
                });

            migrationBuilder.CreateTable(
                name: "CarDetails",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tag = table.Column<string>(type: "TEXT", nullable: true),
                    Finas = table.Column<string>(type: "TEXT", nullable: true),
                    VinLast4 = table.Column<string>(type: "TEXT", nullable: true),
                    HarnessStatus = table.Column<string>(type: "TEXT", nullable: true),
                    FullVin = table.Column<string>(type: "TEXT", nullable: true),
                    Vin = table.Column<string>(type: "TEXT", nullable: true),
                    HeadUnit = table.Column<string>(type: "TEXT", nullable: true),
                    SoftwareVersion = table.Column<string>(type: "TEXT", nullable: true),
                    Adas = table.Column<string>(type: "TEXT", nullable: true),
                    AdasBool = table.Column<bool>(type: "INTEGER", nullable: true),
                    DetailId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDetails", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_CarDetails_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarDetails_Detail_DetailId",
                        column: x => x.DetailId,
                        principalTable: "Detail",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EventDetail",
                columns: table => new
                {
                    EventDetailId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DetailId = table.Column<int>(type: "INTEGER", nullable: false),
                    EventId = table.Column<int>(type: "INTEGER", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDetail", x => x.EventDetailId);
                    table.ForeignKey(
                        name: "FK_EventDetail_Detail_DetailId",
                        column: x => x.DetailId,
                        principalTable: "Detail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventDetail_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    DetailId = table.Column<int>(type: "INTEGER", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDetail_ApplicationUser_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserDetail_Detail_DetailId",
                        column: x => x.DetailId,
                        principalTable: "Detail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EventId", "FirstName", "FriendlyName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RoleId", "SecurityStamp", "TeamTypesId", "TestReleaseId", "TwoFactorEnabled", "UserCarEventId", "UserDetailId", "UserEventId", "UserName" },
                values: new object[,]
                {
                    { "3de00zzz-2828-0000-0000-3de000000000", 0, "29baa78a-9f0f-4b0e-974e-d25eb0ddfd61", "dummyuser@example.com", false, 0, null, "Dummy User", null, false, null, "DUMMYUSER@EXAMPLE.COM", "DUMMYUSER", null, null, false, null, "af091467-45e5-497e-9df4-4f8fc4e01143", null, null, false, 0, 0, 0, "DummyUser1" },
                    { "3de00zzz-2828-0000-0000-3de000000001", 0, "45df36f8-5abe-4375-9f08-8105728d0de6", "adammen@gmail.com", false, 0, null, "Adam Man", null, false, null, "ADAMMAN@GMAIL.COM", "ADMIN", null, null, false, null, "f38887e8-0c22-4aaa-8a82-659842ffd445", null, null, false, 0, 0, 0, "Adam Man" }
                });

            migrationBuilder.InsertData(
                table: "Blanks",
                columns: new[] { "Id", "Name", "String" },
                values: new object[] { 1, "Item 1", "This is item 1 data" });

            migrationBuilder.InsertData(
                table: "DetailType",
                columns: new[] { "Id", "Name", "TruckDetailId" },
                values: new object[,]
                {
                    { 1, "Ticket", null },
                    { 2, "Car", null },
                    { 3, "Event", null },
                    { 4, "Ticket", null },
                    { 5, "Shop", null },
                    { 6, "Highlight", null },
                    { 7, "Improvement", null },
                    { 8, "Critique", null },
                    { 1001, "Ticket", null },
                    { 1002, "Car", null },
                    { 1003, "Event", null },
                    { 1004, "Ticket", null },
                    { 1005, "Shop", null },
                    { 1006, "Highlight", null },
                    { 1007, "Improvement", null },
                    { 1008, "Critique", null }
                });

            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "BookCar" },
                    { 2, "Comission" },
                    { 3, "Decomission" },
                    { 4, "ErrorIdentification" },
                    { 5, "TestDrive" },
                    { 6, "ShopConfiguration" },
                    { 7, "PreparedForDrive" },
                    { 8, "TagAssigned" },
                    { 9, "TagUnAssigned" },
                    { 10, "LoggerInstall" },
                    { 11, "LoggerUnInstall" },
                    { 12, "MainDriveEvent" },
                    { 13, "RoutineDrive" },
                    { 14, "TicketSubmission" }
                   
                });

            migrationBuilder.InsertData(
                table: "ExcelDataRecords",
                columns: new[] { "Id", "Data", "Hash", "JsonData", "LastModified", "UploadDate" },
                values: new object[,]
                {
                    { 1, "Data1", "hash1", null, new DateTime(2024, 1, 5, 13, 23, 35, 634, DateTimeKind.Local).AddTicks(6710), new DateTime(2024, 1, 5, 13, 23, 35, 634, DateTimeKind.Local).AddTicks(6606) },
                    { 2, "Data2", "hash2", null, new DateTime(2024, 1, 5, 13, 23, 35, 634, DateTimeKind.Local).AddTicks(6720), new DateTime(2024, 1, 5, 13, 23, 35, 634, DateTimeKind.Local).AddTicks(6718) }
                });

            migrationBuilder.InsertData(
                table: "Logger",
                columns: new[] { "Id", "CarId", "NaturalId", "NewCarId", "NewCarId1", "NumLoggers", "TruckId", "TypeLogger", "isAssigned" },
                values: new object[,]
                {
                    { 1, null, null, null, null, 1, null, 0, false },
                    { 2, null, null, null, null, 1, null, 0, false },
                    { 3, null, null, null, null, 1, null, 1, false },
                    { 4, null, null, null, null, 1, null, 1, false },
                    { 5, null, null, null, null, 1, null, 2, false },
                    { 6, null, null, null, null, 1, null, 2, false }
                });

            migrationBuilder.InsertData(
                table: "MasterLog",
                columns: new[] { "Id", "Message", "Time" },
                values: new object[,]
                {
                    { 1L, "App Birth.", new DateTime(2024, 1, 5, 13, 23, 35, 636, DateTimeKind.Local).AddTicks(5195) },
                    { 2L, "Hello from The past.", new DateTime(2024, 1, 5, 13, 23, 35, 636, DateTimeKind.Local).AddTicks(5301) }
                });

            migrationBuilder.InsertData(
                table: "SimpleEventTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "BookCar" },
                    { 2, "Comission" },
                    { 3, "Decomission" },
                    { 4, "ErrorIdentification" },
                    { 5, "TestDrive" },
                    { 6, "ShopConfiguration" },
                    { 7, "PreparedForDrive" },
                    { 8, "TagAssigned" },
                    { 9, "TagUnAssigned" },
                    { 10, "LoggerInstall" },
                    { 11, "LoggerUnInstall" },
                    { 12, "MainDriveEvent" },
                    { 13, "RoutineDrive" },
                    { 14, "TicketSubmission" }
                });

            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Unknown" },
                    { 2, "Purchased" },
                    { 3, "Owned" },
                    { 4, "MarketBorrow" }
          
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Available" },
                    { 2, "NotAvailable" },
                    { 3, "AwaitingAction" }
 
                });

            migrationBuilder.InsertData(
                table: "TeamTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { -3, "Telematics" },
                    { -2, "Adas" },
                    { -1, "Unassigned" },
                    { 1, "Unassigned" },
                    { 2, "Adas" },
                    { 3, "Telematics" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "HasHarness", "HasLogger", "HasTag", "IsAdas", "IsDeleted", "Location", "LoggerId", "Make", "Miles", "Model", "ParkingSpace", "SourceId", "TeleGeneration", "TestReleaseId", "UserId", "Year" },
                values: new object[,]
                {
                    { 1001, false, false, false, false, false, "California", null, "Mercedes", 5000, "EQE 400", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1002, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 5000, "Maybach GLS 600", 1, 1, "NTG6", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1003, false, true, false, false, false, "Tuscaloosa", 1, "Mercedes", 5000, "EQS 450+", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1004, false, true, false, false, false, "Tuscaloosa", 3, "Mercedes", 5000, "GLS 580 4MATIC", 1, 1, "NTG7 * 2", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1005, false, true, false, false, false, "Tuscaloosa", 5, "Mercedes", 0, "EQE 350 4MATIC", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1006, false, true, false, false, false, "Tuscaloosa", 6, "Mercedes", 200, "Maybach EQS 680", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1007, false, true, false, false, false, "Tuscaloosa", 2, "Mercedes", 0, "EQS 580 4MATIC", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1008, false, false, false, false, false, "Tuscaloosa", 4, "Mercedes", 0, "GLS 450 4MATIC", 1, 1, "NTG7 * 2", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1009, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "AMG EQE 53 4MAT", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1010, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "EQS 580 4MATIC", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1011, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "EQS 450", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1012, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "Maybach GLS 600", 1, 1, "NTG7*2", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1013, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "EQE 350", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1014, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "EQS 450 4MATIC", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1015, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "GLE 400 e 4MATIC", 1, 1, "NTG7*2", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1016, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "MAYBACH EQS 680", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1017, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "AMG GLE 63 S 4MAT", 1, 1, "NTG7*2", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1018, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "GLE 400 e 4MATIC", 1, 1, "NTG7*2", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1019, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "AMG EQE 53 4MAT", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1020, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "EQS 580 4MATIC", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1021, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "EQS 580 4MATIC", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1022, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 5000, "C 300", 1, 1, "GEN20", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1023, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "EQS 580 4MATIC", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1024, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "AMG CLA 45", 1, 1, "NTG7*2", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1025, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "EQS 450 4MATIC", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1026, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "AMG S 63 e ", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1027, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "GLC 300", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1028, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "EQE 350", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1029, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "EQE 350", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1030, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "Maybach S 580", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1031, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "AMG EQE 53 4MAT", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1032, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "EQB 350 4MATIC", 1, 1, "NTG6", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1033, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "AMG S 63 e 4MATIC", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1034, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "EQS 550 4MATIC", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1035, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "AMG E 53 4MATIC", 1, 1, "NTG6", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1036, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "E 350 4MATIC", 1, 1, "GEN20", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1037, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "EQE 350 4MATIC", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1038, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "EQS 450", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 },
                    { 1039, false, false, false, false, false, "Tuscaloosa", null, "Mercedes", 0, "EQE 350", 1, 1, "NTG7", null, "3de00zzz-2828-0000-0000-3de000000000", 2023.0 }
                });

            migrationBuilder.InsertData(
                table: "NewCar",
                columns: new[] { "Id", "Adas", "CarStatusId", "Finas", "Location", "LoggerId", "Make", "Mileage", "Miles", "Model", "Name", "SourceId", "Tagnumber", "TeleGeneration", "UserId", "Vin", "Year" },
                values: new object[,]
                {
                    { 1, true, null, "  X294-01019", "California", null, "Mercedes", null, 5000, "EQE 400", null, 2, "180", "NTG7", "d02a99db-8c5a-4e0f-9d01-1da28abf91a4", "4JGGM2BB6PA000131", 2023 },
                    { 2, true, null, "X167-04607", "Tuscaloosa", null, "Mercedes", null, 0, "Maybach GLS 600", null, 2, " 181", "NTG6", "d02a99db-8c5a-4e0f-9d01-1da28abf91a4", "4JGFF8HB5NA357779", 2023 },
                    { 3, true, null, "X296-01198", "Tuscaloosa", null, "Mercedes", null, 0, "EQS 450+", null, 2, " 182", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM2DB4RA003435", 2025 },
                    { 4, true, null, "X167-06625", "Tuscaloosa", null, "Mercedes", null, 0, "GLS 580 4matic", null, 2, " 183", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGFF8FE9RA844776", 2025 },
                    { 5, true, null, "X294-01471", "Tuscaloosa", null, "Mercedes", null, 0, "EQE 350 4matic", null, 2, " 184", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM1CB8RA000790", 2025 },
                    { 6, true, null, "Z296-01209", "Tuscaloosa", null, "Mercedes", null, 0, "Maybach EQS 680", null, 2, " 185", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGDX5FB2RA003388", 2025 },
                    { 7, true, null, "X296-01210", "Tuscaloosa", null, "Mercedes", null, 0, "EQS 580 4MATIC", null, 2, " 186", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM4EB5RA003437", 2025 },
                    { 8, true, null, "X167-06656", "Tuscaloosa", null, "Mercedes", null, 0, "GLS 450 4MATIC", null, 2, " 187", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGFF5KE1RA844775", 2025 },
                    { 9, true, null, "X294-01457", "Tuscaloosa", null, "Mercedes", null, 0, "AMG EQE 53 4MAT", null, 2, " 188", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM5DB8RA001590", 2025 },
                    { 10, true, null, "X296-00421", "Tuscaloosa", null, "Mercedes", null, 0, "EQS 580 4MATIC", null, 2, " 189", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM4EB6PA000351", 2025 },
                    { 11, true, null, "X296-00395", "Tuscaloosa", null, "Mercedes", null, 0, "EQS 450", null, 2, " 190", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM2DB9PA000205", 2025 },
                    { 12, true, null, "X167-06686", "Tuscaloosa", null, "Mercedes", null, 0, "Maybach GLS 600", null, 2, " 191", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGFF8HB1RA844774", 2025 },
                    { 13, true, null, "X294-01532", "Tuscaloosa", null, "Mercedes", null, 0, "EQE 350+", null, 2, " 192", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM2BB2RA000792", 2025 },
                    { 14, true, null, "X296-00702", "Tuscaloosa", null, "Mercedes", null, 0, "EQS 450 4MATIC", null, 2, " 193", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM2EB1PU000194", 2025 },
                    { 15, true, null, "V167-06463", "Tuscaloosa", null, "Mercedes", null, 0, "GLE 400 e 4MATIC", null, 2, " 195", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGFB4GB3RA809370", 2025 },
                    { 16, true, null, "Z296-01192", "Tuscaloosa", null, "Mercedes", null, 0, "MAYBACH EQS 680", null, 2, " 196", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGDX5FB9RA003386", 2025 },
                    { 17, true, null, "C167-06461", "Tuscaloosa", null, "Mercedes", null, 0, "AMG GLE 63 S 4MAT", null, 2, " 197", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGFD8KB4RA809371", 2025 },
                    { 18, true, null, "V167-06567", "Tuscaloosa", null, "Mercedes", null, 0, "GLE 400 e 4MATIC", null, 2, " 198", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGFB4GB1PA883660", 2025 },
                    { 19, true, null, "X294-01456", "Tuscaloosa", null, "Mercedes", null, 0, "AMG EQE 53 4MAT", null, 2, " 199", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM5DBXRA001588", 2025 },
                    { 20, true, null, "X296-00848", "Tuscaloosa", null, "Mercedes", null, 0, "EQS 580 4MATIC", null, 2, " 288", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM4EB7PA000701", 2025 },
                    { 21, true, null, "V297-02377", "Tuscaloosa", null, "Mercedes", null, 0, "EQS 580 4MATIC", null, 2, " 638", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KCG4EB4PA019834", 2025 },
                    { 22, true, null, "W206-01531", "Tuscaloosa", null, "Mercedes", null, 0, "C 300", null, 2, " 651", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KAF4GB9NR000041", 2025 },
                    { 23, true, null, "V297-01008", "Tuscaloosa", null, "Mercedes", null, 0, "EQS 580 4MATIC", null, 2, " 652", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KCG4EB7NA000823", 2025 },
                    { 24, true, null, "A118-01377", "Tuscaloosa", null, "Mercedes", null, 0, "AMG CLA 45 ", null, 2, " 653", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1K5J5EB8RN368913", 2025 },
                    { 25, true, null, "V297-01062", "Tuscaloosa", null, "Mercedes", null, 0, "EQS 450 4MATIC", null, 2, " 654", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KCG2EB8NA003265", 2025 },
                    { 26, true, null, "V223-05154", "Tuscaloosa", null, "Mercedes", null, 0, "AMG S 63 e ", null, 2, " 655", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1K6G8CB9RA200096", 2025 },
                    { 27, true, null, "X254-02459", "Tuscaloosa", null, "Mercedes", null, 0, "GLC 300", null, 2, " 657", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1NKM4GB3PF001221", 2025 },
                    { 28, true, null, "V295-01073", "Tuscaloosa", null, "Mercedes", null, 0, "EQE 350+", null, 2, " 658", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KEG2BB5NF000498", 2025 },
                    { 29, true, null, "V295-01074", "Tuscaloosa", null, "Mercedes", null, 0, "EQE 350+", null, 2, " 659", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KEG2BB7NF000499", 2025 },
                    { 30, true, null, "Z223-05153", "Tuscaloosa", null, "Mercedes", null, 0, "Maybach S 580", null, 2, " 660", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1K6X7GB9RA203259", 2025 },
                    { 31, true, null, "N295-01333", "Tuscaloosa", null, "Mercedes", null, 0, "AMG EQE 53 4MAT", null, 2, " 661", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KEG5DB3PF005779", 2025 },
                    { 32, true, null, "X243-01749", "Tuscaloosa", null, "Mercedes", null, 0, "EQB 350 4MATIC", null, 2, " 662", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1N9M1DB3RN027408", 2025 },
                    { 33, true, null, "V223-04879", "Tuscaloosa", null, "Mercedes", null, 0, "AMG S 63 e 4MATIC", null, 2, " 663", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1K6G8CB5PA159432", 2025 },
                    { 34, true, null, "V297-01298", "Tuscaloosa", null, "Mercedes", null, 0, "EQS 550 4MATIC", null, 2, " 664", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KCG4EB6NA000411", 2025 },
                    { 35, true, null, "A238-02435", "Tuscaloosa", null, "Mercedes", null, 0, "AMG E 53 4MATIC+", null, 2, " 665", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1K1K6BB7PF185712", 2025 },
                    { 36, true, null, "W214-01098", "Tuscaloosa", null, "Mercedes", null, 0, "E 350 4MATIC", null, 2, " 666", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KLF4HB7RA000650", 2025 },
                    { 37, true, null, "X294-00461", "Tuscaloosa", null, "Mercedes", null, 0, "EQE 350 4MATIC", null, 2, " 668", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM1CB5PA000386", 2025 },
                    { 38, true, null, "X296-00322", "Tuscaloosa", null, "Mercedes", null, 0, "EQS 450", null, 2, " 669", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM2DB2PA000031", 2025 },
                    { 39, true, null, "V295-00503", "Tuscaloosa", null, "Mercedes", null, 0, "EQE 350+", null, 2, "670", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KEG2BB5PF000620", 2025 }
                });

            migrationBuilder.InsertData(
                table: "Truck",
                columns: new[] { "Id", "Adas", "Finas", "Location", "Make", "Miles", "Model", "Name", "NewTruckLoggerId", "SourceId", "Tagnumber", "TeleGeneration", "TruckDetail", "TruckStatusId", "UserId", "Vin", "Year" },
                values: new object[,]
                {
                    { 1, true, "X294-01019", "California", "Mercedes", 5000, "EQE 400", null, null, 2, "180", "NTG7", 0, 0, "d02a99db-8c5a-4e0f-9d01-1da28abf91a4", "4JGGM2BB6PA000131", 2023 },
                    { 2, true, "X167-04607", "Tuscaloosa", "Mercedes", 0, "Maybach GLS 600", null, null, 2, "181", "NTG6", 0, 0, "d02a99db-8c5a-4e0f-9d01-1da28abf91a4", "4JGFF8HB5NA357779", 2023 },
                    { 3, true, "X296-01198", "Tuscaloosa", "Mercedes", 0, "EQS 450+", null, null, 2, " 182", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM2DB4RA003435", 2025 },
                    { 4, true, "X167-06625", "Tuscaloosa", "Mercedes", 0, "GLS 580 4matic", null, null, 2, " 183", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGFF8FE9RA844776", 2025 },
                    { 5, true, "X294-01471", "Tuscaloosa", "Mercedes", 0, "EQE 350 4matic", null, null, 2, " 184", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM1CB8RA000790", 2025 },
                    { 6, true, "Z296-01209", "Tuscaloosa", "Mercedes", 0, "Maybach EQS 680", null, null, 2, " 185", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGDX5FB2RA003388", 2025 },
                    { 7, true, "X296-01210", "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", null, null, 2, " 186", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM4EB5RA003437", 2025 },
                    { 8, true, "X167-06656", "Tuscaloosa", "Mercedes", 0, "GLS 450 4MATIC", null, null, 2, " 187", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGFF5KE1RA844775", 2025 },
                    { 9, true, "X294-01457", "Tuscaloosa", "Mercedes", 0, "AMG EQE 53 4MAT", null, null, 2, " 188", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM5DB8RA001590", 2025 },
                    { 10, true, "X296-00421", "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", null, null, 2, " 189", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM4EB6PA000351", 2025 },
                    { 11, true, "X296-00395", "Tuscaloosa", "Mercedes", 0, "EQS 450", null, null, 2, " 190", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM2DB9PA000205", 2025 },
                    { 12, true, "X167-06686", "Tuscaloosa", "Mercedes", 0, "Maybach GLS 600", null, null, 2, " 191", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGFF8HB1RA844774", 2025 },
                    { 13, true, "X294-01532", "Tuscaloosa", "Mercedes", 0, "EQE 350+", null, null, 2, " 192", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM2BB2RA000792", 2025 },
                    { 14, true, "X296-00702", "Tuscaloosa", "Mercedes", 0, "EQS 450 4MATIC", null, null, 2, " 193", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM2EB1PU000194", 2025 },
                    { 15, true, "V167-06463", "Tuscaloosa", "Mercedes", 0, "GLE 400 e 4MATIC", null, null, 2, " 195", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGFB4GB3RA809370", 2025 },
                    { 16, true, "Z296-01192", "Tuscaloosa", "Mercedes", 0, "MAYBACH EQS 680", null, null, 2, " 196", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGDX5FB9RA003386", 2025 },
                    { 17, true, "C167-06461", "Tuscaloosa", "Mercedes", 0, "AMG GLE 63 S 4MAT", null, null, 2, " 197", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGFD8KB4RA809371", 2025 },
                    { 18, true, "V167-06567", "Tuscaloosa", "Mercedes", 0, "GLE 400 e 4MATIC", null, null, 2, " 198", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGFB4GB1PA883660", 2025 },
                    { 19, true, "X294-01456", "Tuscaloosa", "Mercedes", 0, "AMG EQE 53 4MAT", null, null, 2, " 199", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM5DBXRA001588", 2025 },
                    { 20, true, "X296-00848", "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", null, null, 2, " 288", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM4EB7PA000701", 2025 },
                    { 21, true, "V297-02377", "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", null, null, 2, " 638", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KCG4EB4PA019834", 2025 },
                    { 22, true, "W206-01531", "Tuscaloosa", "Mercedes", 0, "C 300", null, null, 2, " 651", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KAF4GB9NR000041", 2025 },
                    { 23, true, "V297-01008", "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", null, null, 2, " 652", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KCG4EB7NA000823", 2025 },
                    { 24, true, "A118-01377", "Tuscaloosa", "Mercedes", 0, "AMG CLA 45 ", null, null, 2, " 653", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1K5J5EB8RN368913", 2025 },
                    { 25, true, "V297-01062", "Tuscaloosa", "Mercedes", 0, "EQS 450 4MATIC", null, null, 2, " 654", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KCG2EB8NA003265", 2025 },
                    { 26, true, "V223-05154", "Tuscaloosa", "Mercedes", 0, "AMG S 63 e ", null, null, 2, " 655", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1K6G8CB9RA200096", 2025 },
                    { 27, true, "X254-02459", "Tuscaloosa", "Mercedes", 0, "GLC 300", null, null, 2, " 657", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1NKM4GB3PF001221", 2025 },
                    { 28, true, "V295-01073", "Tuscaloosa", "Mercedes", 0, "EQE 350+", null, null, 2, " 658", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KEG2BB5NF000498", 2025 },
                    { 29, true, "V295-01074", "Tuscaloosa", "Mercedes", 0, "EQE 350+", null, null, 2, " 659", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KEG2BB7NF000499", 2025 },
                    { 30, true, "Z223-05153", "Tuscaloosa", "Mercedes", 0, "Maybach S 580", null, null, 2, " 660", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1K6X7GB9RA203259", 2025 },
                    { 31, true, "N295-01333", "Tuscaloosa", "Mercedes", 0, "AMG EQE 53 4MAT", null, null, 2, " 661", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KEG5DB3PF005779", 2025 },
                    { 32, true, "X243-01749", "Tuscaloosa", "Mercedes", 0, "EQB 350 4MATIC", null, null, 2, " 662", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1N9M1DB3RN027408", 2025 },
                    { 33, true, "V223-04879", "Tuscaloosa", "Mercedes", 0, "AMG S 63 e 4MATIC", null, null, 2, " 663", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1K6G8CB5PA159432", 2025 },
                    { 34, true, "V297-01298", "Tuscaloosa", "Mercedes", 0, "EQS 550 4MATIC", null, null, 2, " 664", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KCG4EB6NA000411", 2025 },
                    { 35, true, "A238-02435", "Tuscaloosa", "Mercedes", 0, "AMG E 53 4MATIC+", null, null, 2, " 665", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1K1K6BB7PF185712", 2025 },
                    { 36, true, "W214-01098", "Tuscaloosa", "Mercedes", 0, "E 350 4MATIC", null, null, 2, " 666", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KLF4HB7RA000650", 2025 },
                    { 37, true, "X294-00461", "Tuscaloosa", "Mercedes", 0, "EQE 350 4MATIC", null, null, 2, " 668", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM1CB5PA000386", 2025 },
                    { 38, true, "X296-00322", "Tuscaloosa", "Mercedes", 0, "EQS 450", null, null, 2, " 669", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM2DB2PA000031", 2025 },
                    { 39, true, "V295-00503", "Tuscaloosa", "Mercedes", 0, "EQE 350+", null, null, 2, "670", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KEG2BB5PF000620", 2025 }
                });

            migrationBuilder.InsertData(
                table: "CarDetails",
                columns: new[] { "CarId", "Adas", "AdasBool", "DetailId", "Finas", "FullVin", "HarnessStatus", "HeadUnit", "SoftwareVersion", "Tag", "Vin", "VinLast4" },
                values: new object[,]
                {
                    { 1001, null, true, null, "X294-01019", null, null, null, null, "180", "4JGGM2BB6PA000131", null },
                    { 1002, null, true, null, "X167-04607", null, null, "X00.0", null, "181", "4JGFF8HB5NA357779", null },
                    { 1003, null, true, null, "X296-01198", null, null, "X00.0", null, "182", "4JGDM2DB4RA003435", null },
                    { 1004, null, true, null, "X167-06625", null, null, "X00.0", null, "183", "4JGFF8FE9RA844776", null },
                    { 1005, null, true, null, "X294-01471", null, null, "X00.0", null, "184", "4JGGM1CB8RA000790", null },
                    { 1006, null, true, null, "Z296-01209", null, null, "X00.0", null, "185", "4JGDX5FB2RA003388", null },
                    { 1007, null, true, null, "X296-01210", null, null, "X00.0", null, "186", "4JGDM4EB5RA003437", null },
                    { 1008, null, true, null, "X167-06656", null, null, "X00.0", null, "187", "4JGFF5KE1RA844775", null },
                    { 1009, null, true, null, "X294-01457", null, null, "X00.0", null, "188", "4JGGM5DB8RA001590", null },
                    { 1010, null, true, null, "X296-00421", null, null, "X00.0", null, "189", "4JGDM4EB6PA000351", null },
                    { 1011, null, true, null, "X296-00395", null, null, "X00.0", null, "190", "4JGDM2DB9PA000205", null },
                    { 1012, null, true, null, "X167-06686", null, null, "X00.0", null, "191", "4JGFF8HB1RA844774", null },
                    { 1013, null, true, null, "X294-01532", null, null, "X00.0", null, "192", "4JGGM2BB2RA000792", null },
                    { 1014, null, true, null, "X296-00702", null, null, "X00.0", null, "193", "4JGDM2EB1PU000194", null },
                    { 1015, null, true, null, "V167-06463", null, null, "X00.0", null, "195", "4JGFB4GB3RA809370", null },
                    { 1016, null, true, null, "Z296-01192", null, null, "X00.0", null, "196", "4JGDX5FB9RA003386", null },
                    { 1017, null, true, null, "C167-06461", null, null, "X00.0", null, "197", "4JGFD8KB4RA809371", null },
                    { 1018, null, true, null, "V167-06567", null, null, "X00.0", null, "198", "4JGFB4GB1PA883660", null },
                    { 1019, null, true, null, "X294-01456", null, null, "X00.0", null, "199", "4JGGM5DBXRA001588", null },
                    { 1020, null, true, null, "X296-00848", null, null, "X00.0", null, "288", "4JGDM4EB7PA000701", null },
                    { 1021, null, true, null, "V297-02377", null, null, "X00.0", null, "638", "W1KCG4EB4PA019834", null },
                    { 1022, null, true, null, "W206-01531", null, null, "X00.0", null, "651", "W1KAF4GB9NR000041", null },
                    { 1023, null, true, null, "V297-01008", null, null, "X00.0", null, "652", "W1KCG4EB7NA000823", null },
                    { 1024, null, true, null, "A118-01377", null, null, "X00.0", null, "653", "W1K5J5EB8RN368913", null },
                    { 1025, null, true, null, "V297-01062", null, null, "X00.0", null, "654", "W1KCG2EB8NA003265", null },
                    { 1026, null, true, null, "V223-05154", null, null, "X00.0", null, "655", "W1K6G8CB9RA200096", null },
                    { 1027, null, true, null, "X254-02459", null, null, "X00.0", null, "657", "W1NKM4GB3PF001221", null },
                    { 1028, null, true, null, "V295-01073", null, null, "X00.0", null, "658", "W1KEG2BB5NF000498", null },
                    { 1029, null, true, null, "V295-01074", null, null, "X00.0", null, "659", "W1KEG2BB7NF000499", null },
                    { 1030, null, true, null, "Z223-05153", null, null, "X00.0", null, "660", "W1K6X7GB9RA203259", null },
                    { 1031, null, true, null, "N295-01333", null, null, "X00.0", null, "661", "W1KEG5DB3PF005779", null },
                    { 1032, null, true, null, "X243-01749", null, null, "X00.0", null, "662", "W1N9M1DB3RN027408", null },
                    { 1033, null, true, null, "V223-04879", null, null, "X00.0", null, "663", "W1K6G8CB5PA159432", null },
                    { 1034, null, true, null, "V297-01298", null, null, "X00.0", null, "664", "W1KCG4EB6NA000411", null },
                    { 1035, null, true, null, "A238-02435", null, null, "X00.0", null, "665", "W1K1K6BB7PF185712", null },
                    { 1036, null, true, null, "W214-01098", null, null, "X00.0", null, "666", "W1KLF4HB7RA000650", null },
                    { 1037, null, true, null, "X294-00461", null, null, "X00.0", null, "668", "4JGGM1CB5PA000386", null },
                    { 1038, null, true, null, "X296-00322", null, null, "X00.0", null, "669", "4JGDM2DB2PA000031", null },
                    { 1039, null, true, null, "V295-00503", null, null, "X00.0", null, "670", "W1KEG2BB5PF000620", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_RoleId",
                table: "ApplicationUser",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_TeamTypesId",
                table: "ApplicationUser",
                column: "TeamTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_TestReleaseId",
                table: "ApplicationUser",
                column: "TestReleaseId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetails_DetailId",
                table: "CarDetails",
                column: "DetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CarModule_CarId1",
                table: "CarModule",
                column: "CarId1");

            migrationBuilder.CreateIndex(
                name: "IX_CarModule_ModuleId",
                table: "CarModule",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_CarModule_ModuleId1",
                table: "CarModule",
                column: "ModuleId1");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_TestReleaseId",
                table: "Cars",
                column: "TestReleaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_UserId",
                table: "Cars",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CarStatuses_StatusId",
                table: "CarStatuses",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckListItems_CarId",
                table: "CheckListItems",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckListItems_TestReleaseId",
                table: "CheckListItems",
                column: "TestReleaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Detail_ApplicationUserId",
                table: "Detail",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Detail_DetailTypeId",
                table: "Detail",
                column: "DetailTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Detail_UserCarEventId",
                table: "Detail",
                column: "UserCarEventId");

            migrationBuilder.CreateIndex(
                name: "IX_Detail_UserEventId",
                table: "Detail",
                column: "UserEventId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailType_TruckDetailId",
                table: "DetailType",
                column: "TruckDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityAttributeValues_AttributeId",
                table: "EntityAttributeValues",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityAttributeValues_EntityId",
                table: "EntityAttributeValues",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_EventDetail_DetailId",
                table: "EventDetail",
                column: "DetailId");

            migrationBuilder.CreateIndex(
                name: "IX_EventDetail_EventId",
                table: "EventDetail",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CategoryId",
                table: "Events",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventTypeId",
                table: "Events",
                column: "EventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_NoteId",
                table: "Events",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_SimpleEventTypeId",
                table: "Events",
                column: "SimpleEventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EventTypes_Name",
                table: "EventTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExcelDataRecordAttributes_ExcelDataRecordId",
                table: "ExcelDataRecordAttributes",
                column: "ExcelDataRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_ExcelDataRecordChanges_ExcelDataRecordId",
                table: "ExcelDataRecordChanges",
                column: "ExcelDataRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Logger_CarId",
                table: "Logger",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Logger_NewCarId1",
                table: "Logger",
                column: "NewCarId1");

            migrationBuilder.CreateIndex(
                name: "IX_Logger_TruckId",
                table: "Logger",
                column: "TruckId");

            migrationBuilder.CreateIndex(
                name: "IX_NewCar_SourceId",
                table: "NewCar",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_NewCarLoggers_CardId",
                table: "NewCarLoggers",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_NewCarLoggers_CarId",
                table: "NewCarLoggers",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_NewCarLoggers_TruckId",
                table: "NewCarLoggers",
                column: "TruckId");

            migrationBuilder.CreateIndex(
                name: "IX_NewTruckLoggers_CarId",
                table: "NewTruckLoggers",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_NewTruckLoggers_NewCarId",
                table: "NewTruckLoggers",
                column: "NewCarId");

            migrationBuilder.CreateIndex(
                name: "IX_NewTruckLoggers_TruckdId",
                table: "NewTruckLoggers",
                column: "TruckdId");

            migrationBuilder.CreateIndex(
                name: "IX_NoteAttachment_NoteId",
                table: "NoteAttachment",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_NoteComment_AuthorId",
                table: "NoteComment",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_NoteComment_NoteId",
                table: "NoteComment",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_AuthorId",
                table: "Notes",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_NoteTag_NoteId",
                table: "NoteTag",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_TagId",
                table: "PostTag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_SimpleEventTypes_Name",
                table: "SimpleEventTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UX_Source_Name",
                table: "Sources",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UX_Status_Name",
                table: "Status",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaskModels_UserId",
                table: "TaskModels",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamTimeline_TeamId",
                table: "TeamTimeline",
                column: "TeamId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TicketAttachment_TicketId",
                table: "TicketAttachment",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketComment_AuthorId",
                table: "TicketComment",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketComment_TicketId",
                table: "TicketComment",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketHistory_ChangedById",
                table: "TicketHistory",
                column: "ChangedById");

            migrationBuilder.CreateIndex(
                name: "IX_TicketHistory_TicketId",
                table: "TicketHistory",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_AssigneeId",
                table: "Tickets",
                column: "AssigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CreatorId",
                table: "Tickets",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketTag_TicketId",
                table: "TicketTag",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Truck_SourceId",
                table: "Truck",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_TruckDetail_TruckId",
                table: "TruckDetail",
                column: "TruckId");

            migrationBuilder.CreateIndex(
                name: "IX_TruckStatus_StatusId",
                table: "TruckStatus",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCarEvent_EventTypeId",
                table: "UserCarEvent",
                column: "EventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCarEvent_TeamTimelineId",
                table: "UserCarEvent",
                column: "TeamTimelineId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCarEvent_UserId",
                table: "UserCarEvent",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetail_ApplicationUserId",
                table: "UserDetail",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetail_DetailId",
                table: "UserDetail",
                column: "DetailId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_EventId",
                table: "UserEvents",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_UserCarEventId",
                table: "UserEvents",
                column: "UserCarEventId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_UserId",
                table: "UserEvents",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserDetail");

            migrationBuilder.DropTable(
                name: "Blanks");

            migrationBuilder.DropTable(
                name: "CarDetails");

            migrationBuilder.DropTable(
                name: "CarModule");

            migrationBuilder.DropTable(
                name: "CarStaticDetail");

            migrationBuilder.DropTable(
                name: "CarStatuses");

            migrationBuilder.DropTable(
                name: "CarStatusNews");

            migrationBuilder.DropTable(
                name: "CheckListItems");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "EntityAttributeValues");

            migrationBuilder.DropTable(
                name: "ErrorLogs");

            migrationBuilder.DropTable(
                name: "EventDetail");

            migrationBuilder.DropTable(
                name: "ExcelDataRecordAttributes");

            migrationBuilder.DropTable(
                name: "ExcelDataRecordChanges");

            migrationBuilder.DropTable(
                name: "IdentityUserLogin<string>");

            migrationBuilder.DropTable(
                name: "IdentityUserRole<string>");

            migrationBuilder.DropTable(
                name: "IdentityUserToken<string>");

            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Logger");

            migrationBuilder.DropTable(
                name: "MasterLog");

            migrationBuilder.DropTable(
                name: "MyModels");

            migrationBuilder.DropTable(
                name: "NewCarLoggers");

            migrationBuilder.DropTable(
                name: "NewTruckLoggers");

            migrationBuilder.DropTable(
                name: "NoteAttachment");

            migrationBuilder.DropTable(
                name: "NoteComment");

            migrationBuilder.DropTable(
                name: "NoteTag");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PostTag");

            migrationBuilder.DropTable(
                name: "RoleEventMappings");

            migrationBuilder.DropTable(
                name: "SensorData");

            migrationBuilder.DropTable(
                name: "SimpleEvent");

            migrationBuilder.DropTable(
                name: "Softwares");

            migrationBuilder.DropTable(
                name: "TaskModels");

            migrationBuilder.DropTable(
                name: "TicketAttachment");

            migrationBuilder.DropTable(
                name: "TicketComment");

            migrationBuilder.DropTable(
                name: "TicketHistory");

            migrationBuilder.DropTable(
                name: "TicketTag");

            migrationBuilder.DropTable(
                name: "TruckStaticDetail");

            migrationBuilder.DropTable(
                name: "TruckStatus");

            migrationBuilder.DropTable(
                name: "UserDetail");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "Entities");

            migrationBuilder.DropTable(
                name: "ExcelDataRecords");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "NewCar");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Detail");

            migrationBuilder.DropTable(
                name: "DetailType");

            migrationBuilder.DropTable(
                name: "UserEvents");

            migrationBuilder.DropTable(
                name: "TruckDetail");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "UserCarEvent");

            migrationBuilder.DropTable(
                name: "Truck");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "SimpleEventTypes");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.DropTable(
                name: "TeamTimeline");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "TeamTypes");

            migrationBuilder.DropTable(
                name: "TestReleases");
        }
    }
}
