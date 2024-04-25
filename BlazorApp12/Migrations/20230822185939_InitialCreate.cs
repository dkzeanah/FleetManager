using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    String = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blanks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DriverStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalCount = table.Column<int>(type: "int", nullable: false),
                    AverageDrivingHours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEventId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExcelDataRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JsonData = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcelDataRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Time = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingInfo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleEventMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DefaultEventTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleEventMappings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Source",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Source", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusId);
                });

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

            migrationBuilder.CreateTable(
                name: "TicketCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultPriority = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "ExcelDataRecordAttribute",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExcelDataRecordId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcelDataRecordAttribute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExcelDataRecordAttribute_ExcelDataRecords_ExcelDataRecordId",
                        column: x => x.ExcelDataRecordId,
                        principalTable: "ExcelDataRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ExcelDataRecordChange",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColumnName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OldValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExcelDataRecordId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcelDataRecordChange", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExcelDataRecordChange_ExcelDataRecords_ExcelDataRecordId",
                        column: x => x.ExcelDataRecordId,
                        principalTable: "ExcelDataRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoles_Roles_Id",
                        column: x => x.Id,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    TeleGeneration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Miles = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tagnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Finas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adas = table.Column<bool>(type: "bit", nullable: false),
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    CarDetail = table.Column<int>(type: "int", nullable: false),
                    CarStatusId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Car_Source_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Source",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FriendlyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamId = table.Column<int>(type: "int", nullable: true),
                    EventId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUser_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ApplicationUser_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TeamTimeline",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamTimeline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamTimeline_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CarStaticDetail",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Vin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Finas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adas = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "(1)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarStaticDetail", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_CarStaticDetail_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CarStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    StatusTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarStatus_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CarStatus_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Loggers",
                columns: table => new
                {
                    LoggerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    TypeLogger = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NumLoggers = table.Column<int>(type: "int", nullable: false),
                    LogTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LogText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loggers", x => new { x.CardId, x.LoggerId });
                    table.ForeignKey(
                        name: "FK_Loggers_Car_CardId",
                        column: x => x.CardId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserDetail",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserEventsId = table.Column<int>(type: "int", nullable: false),
                    DriverStatsId = table.Column<int>(type: "int", nullable: true),
                    TimelineId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUserDetail_ApplicationUser_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ApplicationUserDetail_DriverStats_DriverStatsId",
                        column: x => x.DriverStatsId,
                        principalTable: "DriverStats",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserStaticDetail",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpertiseCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserStaticDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUserStaticDetail_ApplicationUser_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Timeline",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserDetailId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timeline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Timeline_ApplicationUserDetail_ApplicationUserDetailId",
                        column: x => x.ApplicationUserDetailId,
                        principalTable: "ApplicationUserDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UserEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserCarEventId = table.Column<int>(type: "int", nullable: true),
                    ApplicationUserDetailId = table.Column<int>(type: "int", nullable: true),
                    ApplicationUserDetailId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserEventDetailId = table.Column<int>(type: "int", nullable: true),
                    EventId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEvents_ApplicationUserDetail_ApplicationUserDetailId1",
                        column: x => x.ApplicationUserDetailId1,
                        principalTable: "ApplicationUserDetail",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserEvents_ApplicationUser_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserEvents_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserCarEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    EventTypeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TeamTimelineId = table.Column<int>(type: "int", nullable: true),
                    TimelineId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCarEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCarEvents_EventTypes_EventTypeId",
                        column: x => x.EventTypeId,
                        principalTable: "EventTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UserCarEvents_TeamTimeline_TeamTimelineId",
                        column: x => x.TeamTimelineId,
                        principalTable: "TeamTimeline",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserCarEvents_Timeline_TimelineId",
                        column: x => x.TimelineId,
                        principalTable: "Timeline",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserCarEvents_UserEvents_Id",
                        column: x => x.Id,
                        principalTable: "UserEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UserEventDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserEventId = table.Column<int>(type: "int", nullable: true),
                    UserEventDetailGrandularId = table.Column<int>(type: "int", nullable: true),
                    Information = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEventDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEventDetail_ApplicationUser_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserEventDetail_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserEventDetail_UserEvents_UserEventId",
                        column: x => x.UserEventId,
                        principalTable: "UserEvents",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserUserCarEvent",
                columns: table => new
                {
                    ApplicationUsersId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserCarEventsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserUserCarEvent", x => new { x.ApplicationUsersId, x.UserCarEventsId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserUserCarEvent_ApplicationUser_ApplicationUsersId",
                        column: x => x.ApplicationUsersId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ApplicationUserUserCarEvent_UserCarEvents_UserCarEventsId",
                        column: x => x.UserCarEventsId,
                        principalTable: "UserCarEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CarEvent",
                columns: table => new
                {
                    CarEventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    UserCarEventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarEvent", x => x.CarEventId);
                    table.ForeignKey(
                        name: "FK_CarEvent_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CarEvent_UserCarEvents_UserCarEventId",
                        column: x => x.UserCarEventId,
                        principalTable: "UserCarEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UserEventDetailText",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEventDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEventDetailText", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEventDetailText_UserEventDetail_UserEventDetailId",
                        column: x => x.UserEventDetailId,
                        principalTable: "UserEventDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CarDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    CarEventId = table.Column<int>(type: "int", nullable: false),
                    DetailTypeId = table.Column<int>(type: "int", nullable: false),
                    CarEventDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarDetail_CarEvent_CarEventId",
                        column: x => x.CarEventId,
                        principalTable: "CarEvent",
                        principalColumn: "CarEventId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CarDetail_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CarEventDetail",
                columns: table => new
                {
                    CarEventDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarEventId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarDetailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarEventDetail", x => x.CarEventDetailId);
                    table.ForeignKey(
                        name: "FK_CarEventDetail_CarDetail_CarDetailId",
                        column: x => x.CarDetailId,
                        principalTable: "CarDetail",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CarEventDetail_CarEvent_CarEventId",
                        column: x => x.CarEventId,
                        principalTable: "CarEvent",
                        principalColumn: "CarEventId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DetailTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CarDetailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailTypes_CarDetail_CarDetailId",
                        column: x => x.CarDetailId,
                        principalTable: "CarDetail",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Blanks",
                columns: new[] { "Id", "Name", "String" },
                values: new object[] { 1, "Item 1", "This is item 1 data" });

            migrationBuilder.InsertData(
                table: "DetailTypes",
                columns: new[] { "Id", "CarDetailId", "Name" },
                values: new object[,]
                {
                    { 1, null, "Ticket" },
                    { 2, null, "Car" },
                    { 3, null, "UserCarEvent" },
                    { 4, null, "Critique" },
                    { 5, null, "Shop" },
                    { 6, null, "Highlight" },
                    { 7, null, "Improvement" }
                });

            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Comission" },
                    { 2, "Decomission" },
                    { 3, "TicketSubmission" },
                    { 4, "ErrorIdentification" },
                    { 5, "TestDrive" },
                    { 6, "ShopConfiguration" },
                    { 7, "PreparedForDrive" },
                    { 8, "TagAssigned" },
                    { 9, "TagUnAssigned" },
                    { 10, "LoggerInstall" },
                    { 11, "LoggerUnInstall" },
                    { 12, "MainDriveEvent" },
                    { 13, "RoutineDrive" }
                });

            migrationBuilder.InsertData(
                table: "RoleEventMappings",
                columns: new[] { "Id", "DefaultEventTypeId", "RoleId" },
                values: new object[] { 1, 1, "1" });

            migrationBuilder.InsertData(
                table: "Source",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "MarketBorrow" },
                    { 2, "Purchased" },
                    { 3, "Owned" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusId", "Name" },
                values: new object[,]
                {
                    { 1, "Available" },
                    { 2, "NotAvailable" },
                    { 3, "AwaitingAction" }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Unassigned" },
                    { 2, "Adas" },
                    { 3, "Telematics" }
                });

            migrationBuilder.InsertData(
                table: "TicketCategory",
                columns: new[] { "Id", "DefaultPriority", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Voca1" },
                    { 2, 2, "Voca2" },
                    { 3, 3, "Voca3" }
                });

            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "Id", "Adas", "CarDetail", "CarStatusId", "Finas", "Location", "Make", "Miles", "Model", "Name", "SourceId", "Tagnumber", "TeleGeneration", "UserId", "Vin", "Year" },
                values: new object[,]
                {
                    { 1, true, 0, 0, "  X294-01019", "California", "Mercedes", 5000, "EQE 400", null, 2, "180", "NTG7", "d02a99db-8c5a-4e0f-9d01-1da28abf91a4", "4JGGM2BB6PA000131", 2023 },
                    { 2, true, 0, 0, "X167-04607", "Tuscaloosa", "Mercedes", 0, "Maybach GLS 600", null, 2, " 181", "NTG6", "d02a99db-8c5a-4e0f-9d01-1da28abf91a4", "4JGFF8HB5NA357779", 2023 },
                    { 3, true, 0, 0, "X296-01198", "Tuscaloosa", "Mercedes", 0, "EQS 450+", null, 2, " 182", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM2DB4RA003435", 2025 },
                    { 4, true, 0, 0, "X167-06625", "Tuscaloosa", "Mercedes", 0, "GLS 580 4matic", null, 2, " 183", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGFF8FE9RA844776", 2025 },
                    { 5, true, 0, 0, "X294-01471", "Tuscaloosa", "Mercedes", 0, "EQE 350 4matic", null, 2, " 184", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM1CB8RA000790", 2025 },
                    { 6, true, 0, 0, "Z296-01209", "Tuscaloosa", "Mercedes", 0, "Maybach EQS 680", null, 2, " 185", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGDX5FB2RA003388", 2025 },
                    { 7, true, 0, 0, "X296-01210", "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", null, 2, " 186", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM4EB5RA003437", 2025 },
                    { 8, true, 0, 0, "X167-06656", "Tuscaloosa", "Mercedes", 0, "GLS 450 4MATIC", null, 2, " 187", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGFF5KE1RA844775", 2025 },
                    { 9, true, 0, 0, "X294-01457", "Tuscaloosa", "Mercedes", 0, "AMG EQE 53 4MAT", null, 2, " 188", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM5DB8RA001590", 2025 },
                    { 10, true, 0, 0, "X296-00421", "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", null, 2, " 189", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM4EB6PA000351", 2025 },
                    { 11, true, 0, 0, "X296-00395", "Tuscaloosa", "Mercedes", 0, "EQS 450", null, 2, " 190", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM2DB9PA000205", 2025 },
                    { 12, true, 0, 0, "X167-06686", "Tuscaloosa", "Mercedes", 0, "Maybach GLS 600", null, 2, " 191", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGFF8HB1RA844774", 2025 },
                    { 13, true, 0, 0, "X294-01532", "Tuscaloosa", "Mercedes", 0, "EQE 350+", null, 2, " 192", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM2BB2RA000792", 2025 },
                    { 14, true, 0, 0, "X296-00702", "Tuscaloosa", "Mercedes", 0, "EQS 450 4MATIC", null, 2, " 193", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM2EB1PU000194", 2025 },
                    { 15, true, 0, 0, "V167-06463", "Tuscaloosa", "Mercedes", 0, "GLE 400 e 4MATIC", null, 2, " 195", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGFB4GB3RA809370", 2025 },
                    { 16, true, 0, 0, "Z296-01192", "Tuscaloosa", "Mercedes", 0, "MAYBACH EQS 680", null, 2, " 196", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGDX5FB9RA003386", 2025 },
                    { 17, true, 0, 0, "C167-06461", "Tuscaloosa", "Mercedes", 0, "AMG GLE 63 S 4MAT", null, 2, " 197", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGFD8KB4RA809371", 2025 },
                    { 18, true, 0, 0, "V167-06567", "Tuscaloosa", "Mercedes", 0, "GLE 400 e 4MATIC", null, 2, " 198", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGFB4GB1PA883660", 2025 },
                    { 19, true, 0, 0, "X294-01456", "Tuscaloosa", "Mercedes", 0, "AMG EQE 53 4MAT", null, 2, " 199", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM5DBXRA001588", 2025 },
                    { 20, true, 0, 0, "X296-00848", "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", null, 2, " 288", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM4EB7PA000701", 2025 },
                    { 21, true, 0, 0, "V297-02377", "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", null, 2, " 638", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KCG4EB4PA019834", 2025 },
                    { 22, true, 0, 0, "W206-01531", "Tuscaloosa", "Mercedes", 0, "C 300", null, 2, " 651", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KAF4GB9NR000041", 2025 },
                    { 23, true, 0, 0, "V297-01008", "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", null, 2, " 652", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KCG4EB7NA000823", 2025 },
                    { 24, true, 0, 0, "A118-01377", "Tuscaloosa", "Mercedes", 0, "AMG CLA 45 ", null, 2, " 653", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1K5J5EB8RN368913", 2025 },
                    { 25, true, 0, 0, "V297-01062", "Tuscaloosa", "Mercedes", 0, "EQS 450 4MATIC", null, 2, " 654", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KCG2EB8NA003265", 2025 },
                    { 26, true, 0, 0, "V223-05154", "Tuscaloosa", "Mercedes", 0, "AMG S 63 e ", null, 2, " 655", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1K6G8CB9RA200096", 2025 },
                    { 27, true, 0, 0, "X254-02459", "Tuscaloosa", "Mercedes", 0, "GLC 300", null, 2, " 657", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1NKM4GB3PF001221", 2025 },
                    { 28, true, 0, 0, "V295-01073", "Tuscaloosa", "Mercedes", 0, "EQE 350+", null, 2, " 658", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KEG2BB5NF000498", 2025 },
                    { 29, true, 0, 0, "V295-01074", "Tuscaloosa", "Mercedes", 0, "EQE 350+", null, 2, " 659", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KEG2BB7NF000499", 2025 },
                    { 30, true, 0, 0, "Z223-05153", "Tuscaloosa", "Mercedes", 0, "Maybach S 580", null, 2, " 660", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1K6X7GB9RA203259", 2025 },
                    { 31, true, 0, 0, "N295-01333", "Tuscaloosa", "Mercedes", 0, "AMG EQE 53 4MAT", null, 2, " 661", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KEG5DB3PF005779", 2025 },
                    { 32, true, 0, 0, "X243-01749", "Tuscaloosa", "Mercedes", 0, "EQB 350 4MATIC", null, 2, " 662", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1N9M1DB3RN027408", 2025 },
                    { 33, true, 0, 0, "V223-04879", "Tuscaloosa", "Mercedes", 0, "AMG S 63 e 4MATIC", null, 2, " 663", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1K6G8CB5PA159432", 2025 },
                    { 34, true, 0, 0, "V297-01298", "Tuscaloosa", "Mercedes", 0, "EQS 550 4MATIC", null, 2, " 664", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KCG4EB6NA000411", 2025 },
                    { 35, true, 0, 0, "A238-02435", "Tuscaloosa", "Mercedes", 0, "AMG E 53 4MATIC+", null, 2, " 665", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1K1K6BB7PF185712", 2025 },
                    { 36, true, 0, 0, "W214-01098", "Tuscaloosa", "Mercedes", 0, "E 350 4MATIC", null, 2, " 666", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KLF4HB7RA000650", 2025 },
                    { 37, true, 0, 0, "X294-00461", "Tuscaloosa", "Mercedes", 0, "EQE 350 4MATIC", null, 2, " 668", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM1CB5PA000386", 2025 },
                    { 38, true, 0, 0, "X296-00322", "Tuscaloosa", "Mercedes", 0, "EQS 450", null, 2, " 669", "", "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM2DB2PA000031", 2025 },
                    { 39, true, 0, 0, "V295-00503", "Tuscaloosa", "Mercedes", 0, "EQE 350+", null, 2, "670", "", "00000000-8c5a-4e0f-9d01-000000000000", "W1KEG2BB5PF000620", 2025 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_EventId",
                table: "ApplicationUser",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_TeamId",
                table: "ApplicationUser",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserDetail_ApplicationUserId",
                table: "ApplicationUserDetail",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserDetail_DriverStatsId",
                table: "ApplicationUserDetail",
                column: "DriverStatsId",
                unique: true,
                filter: "[DriverStatsId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserStaticDetail_ApplicationUserId",
                table: "ApplicationUserStaticDetail",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserUserCarEvent_UserCarEventsId",
                table: "ApplicationUserUserCarEvent",
                column: "UserCarEventsId");

            migrationBuilder.CreateIndex(
                name: "IX_Car_SourceId",
                table: "Car",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetail_CarEventId",
                table: "CarDetail",
                column: "CarEventId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetail_CarId",
                table: "CarDetail",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarEvent_CarId",
                table: "CarEvent",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarEvent_UserCarEventId",
                table: "CarEvent",
                column: "UserCarEventId");

            migrationBuilder.CreateIndex(
                name: "IX_CarEventDetail_CarDetailId",
                table: "CarEventDetail",
                column: "CarDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CarEventDetail_CarEventId",
                table: "CarEventDetail",
                column: "CarEventId");

            migrationBuilder.CreateIndex(
                name: "IX_CarStatus_CarId",
                table: "CarStatus",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarStatus_StatusId",
                table: "CarStatus",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailTypes_CarDetailId",
                table: "DetailTypes",
                column: "CarDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailTypes_Name",
                table: "DetailTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventTypes_Name",
                table: "EventTypes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExcelDataRecordAttribute_ExcelDataRecordId",
                table: "ExcelDataRecordAttribute",
                column: "ExcelDataRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_ExcelDataRecordChange_ExcelDataRecordId",
                table: "ExcelDataRecordChange",
                column: "ExcelDataRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleEventMappings_RoleId",
                table: "RoleEventMappings",
                column: "RoleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Source",
                table: "Source",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Status",
                table: "Status",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeamTimeline_TeamId",
                table: "TeamTimeline",
                column: "TeamId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Timeline_ApplicationUserDetailId",
                table: "Timeline",
                column: "ApplicationUserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCarEvents_EventTypeId",
                table: "UserCarEvents",
                column: "EventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCarEvents_TeamTimelineId",
                table: "UserCarEvents",
                column: "TeamTimelineId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCarEvents_TimelineId",
                table: "UserCarEvents",
                column: "TimelineId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEventDetail_ApplicationUserId",
                table: "UserEventDetail",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEventDetail_CarId",
                table: "UserEventDetail",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEventDetail_UserEventId",
                table: "UserEventDetail",
                column: "UserEventId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEventDetailText_UserEventDetailId",
                table: "UserEventDetailText",
                column: "UserEventDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_ApplicationUserDetailId1",
                table: "UserEvents",
                column: "ApplicationUserDetailId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_ApplicationUserId",
                table: "UserEvents",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvents_EventId",
                table: "UserEvents",
                column: "EventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserStaticDetail");

            migrationBuilder.DropTable(
                name: "ApplicationUserUserCarEvent");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Blanks");

            migrationBuilder.DropTable(
                name: "CarEventDetail");

            migrationBuilder.DropTable(
                name: "CarStaticDetail");

            migrationBuilder.DropTable(
                name: "CarStatus");

            migrationBuilder.DropTable(
                name: "DetailTypes");

            migrationBuilder.DropTable(
                name: "ExcelDataRecordAttribute");

            migrationBuilder.DropTable(
                name: "ExcelDataRecordChange");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Loggers");

            migrationBuilder.DropTable(
                name: "MasterLogs");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "RoleEventMappings");

            migrationBuilder.DropTable(
                name: "TicketCategory");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserEventDetailText");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "CarDetail");

            migrationBuilder.DropTable(
                name: "ExcelDataRecords");

            migrationBuilder.DropTable(
                name: "UserEventDetail");

            migrationBuilder.DropTable(
                name: "CarEvent");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "UserCarEvents");

            migrationBuilder.DropTable(
                name: "Source");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.DropTable(
                name: "TeamTimeline");

            migrationBuilder.DropTable(
                name: "Timeline");

            migrationBuilder.DropTable(
                name: "UserEvents");

            migrationBuilder.DropTable(
                name: "ApplicationUserDetail");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropTable(
                name: "DriverStats");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
