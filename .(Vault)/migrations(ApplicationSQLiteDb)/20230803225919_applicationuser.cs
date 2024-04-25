using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations.ApplicationSQLiteDb
{
    /// <inheritdoc />
    public partial class applicationuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlockNotes");

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
                name: "DriverStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TotalCount = table.Column<int>(type: "INTEGER", nullable: false),
                    AverageDrivingHours = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverStats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MasterLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Message = table.Column<string>(type: "TEXT", nullable: false),
                    Time = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Source",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Source", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TicketCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    DefaultPriority = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
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
                    SourceId = table.Column<int>(type: "INTEGER", nullable: true),
                    CarDetail = table.Column<int>(type: "INTEGER", nullable: false),
                    CarStatusId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Source_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Source",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FriendlyName = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    TeamId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", nullable: true),
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
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUsers_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id");
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
                        name: "FK_TeamTimeline_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarStaticDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Vin = table.Column<string>(type: "TEXT", nullable: false),
                    Tag = table.Column<string>(type: "TEXT", nullable: false),
                    Finas = table.Column<string>(type: "TEXT", nullable: false),
                    Adas = table.Column<bool>(type: "INTEGER", nullable: true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarStaticDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarStaticDetails_Cars_Id",
                        column: x => x.Id,
                        principalTable: "Cars",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CarStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusId = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarStatus_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarStatus_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Logger",
                columns: table => new
                {
                    LoggerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: false),
                    TypeLogger = table.Column<string>(type: "TEXT", nullable: false),
                    NumLoggers = table.Column<int>(type: "INTEGER", nullable: false),
                    LogTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LogText = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logger", x => x.LoggerId);
                    table.ForeignKey(
                        name: "FK_Logger_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserStaticDetail",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    VehicleArea = table.Column<string>(type: "TEXT", nullable: false),
                    ExpertiseCategory = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserStaticDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUserStaticDetail_ApplicationUsers_Id",
                        column: x => x.Id,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_Notes_ApplicationUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_NoteComment_ApplicationUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "ApplicationUsers",
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
                name: "ApplicationUserDetail",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "TEXT", nullable: false),
                    UserEventsId = table.Column<int>(type: "INTEGER", nullable: false),
                    DriverStatsId = table.Column<int>(type: "INTEGER", nullable: true),
                    TimelineId = table.Column<int>(type: "INTEGER", nullable: true),
                    DetailId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationUserDetail_ApplicationUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserDetail_DriverStats_DriverStatsId",
                        column: x => x.DriverStatsId,
                        principalTable: "DriverStats",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ApplicationUserDetailId = table.Column<string>(type: "TEXT", nullable: false),
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
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_ApplicationUserDetail_ApplicationUserDetailId",
                        column: x => x.ApplicationUserDetailId,
                        principalTable: "ApplicationUserDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_ApplicationUserDetail_Id",
                        column: x => x.Id,
                        principalTable: "ApplicationUserDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_ApplicationUsers_AssigneeId",
                        column: x => x.AssigneeId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_ApplicationUsers_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Timeline",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserDetailId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timeline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Timeline_ApplicationUserDetail_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "ApplicationUserDetail",
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
                    TicketId1 = table.Column<string>(type: "TEXT", nullable: false),
                    FilePath = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketAttachment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketAttachment_Ticket_TicketId1",
                        column: x => x.TicketId1,
                        principalTable: "Ticket",
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
                    TicketId1 = table.Column<string>(type: "TEXT", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    AuthorId = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketComment_ApplicationUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketComment_Ticket_TicketId1",
                        column: x => x.TicketId1,
                        principalTable: "Ticket",
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
                    TicketId1 = table.Column<string>(type: "TEXT", nullable: true),
                    Change = table.Column<string>(type: "TEXT", nullable: false),
                    ChangedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChangedById = table.Column<string>(type: "TEXT", nullable: false),
                    OwnerId = table.Column<string>(type: "TEXT", nullable: false),
                    UserDetailId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserDetailId1 = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketHistory_ApplicationUserDetail_UserDetailId1",
                        column: x => x.UserDetailId1,
                        principalTable: "ApplicationUserDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketHistory_ApplicationUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketHistory_Ticket_TicketId1",
                        column: x => x.TicketId1,
                        principalTable: "Ticket",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TicketTag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketId1 = table.Column<string>(type: "TEXT", nullable: false),
                    Tag = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketTag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketTag_Ticket_TicketId1",
                        column: x => x.TicketId1,
                        principalTable: "Ticket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: false),
                    EventTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EndTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    TeamTimelineId = table.Column<int>(type: "INTEGER", nullable: true),
                    TimelineId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Event_ApplicationUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Event_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_EventType_EventTypeId",
                        column: x => x.EventTypeId,
                        principalTable: "EventType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_TeamTimeline_TeamTimelineId",
                        column: x => x.TeamTimelineId,
                        principalTable: "TeamTimeline",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Event_Timeline_TimelineId",
                        column: x => x.TimelineId,
                        principalTable: "Timeline",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CarEvent",
                columns: table => new
                {
                    CarEventId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: false),
                    EventId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarEvent", x => x.CarEventId);
                    table.ForeignKey(
                        name: "FK_CarEvent_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarEvent_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEvent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    EndTime = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    EventId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserDetailId = table.Column<int>(type: "INTEGER", nullable: false),
                    ApplicationUserDetailId = table.Column<string>(type: "TEXT", nullable: false),
                    UserEventDetailId = table.Column<int>(type: "INTEGER", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEvent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEvent_ApplicationUserDetail_ApplicationUserDetailId",
                        column: x => x.ApplicationUserDetailId,
                        principalTable: "ApplicationUserDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEvent_ApplicationUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserEvent_ApplicationUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEvent_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CarDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: false),
                    CarEventId = table.Column<int>(type: "INTEGER", nullable: false),
                    DetailTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    CarEventDetailId = table.Column<int>(type: "INTEGER", nullable: false),
                    DetailId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarDetail_CarEvent_CarEventId",
                        column: x => x.CarEventId,
                        principalTable: "CarEvent",
                        principalColumn: "CarEventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarDetail_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarEventDetail",
                columns: table => new
                {
                    CarEventDetailId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarEventId = table.Column<int>(type: "INTEGER", nullable: false),
                    Note = table.Column<string>(type: "TEXT", nullable: false),
                    CarDetailId = table.Column<int>(type: "INTEGER", nullable: true)
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    CarDetailId = table.Column<int>(type: "INTEGER", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Detail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DetailTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "TEXT", nullable: true),
                    Discriminator = table.Column<string>(type: "TEXT", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    UserEventId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserEventDetailId = table.Column<int>(type: "INTEGER", nullable: true),
                    Note = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Detail_ApplicationUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Detail_DetailTypes_DetailTypeId",
                        column: x => x.DetailTypeId,
                        principalTable: "DetailTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEventDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "TEXT", nullable: false),
                    UserEventId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserEventDetailGrandularId = table.Column<int>(type: "INTEGER", nullable: false),
                    TextId = table.Column<int>(type: "INTEGER", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DetailId = table.Column<int>(type: "INTEGER", nullable: true),
                    EventId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEventDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEventDetail_ApplicationUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEventDetail_ApplicationUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEventDetail_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserEventDetail_Detail_DetailId",
                        column: x => x.DetailId,
                        principalTable: "Detail",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserEventDetail_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserEventDetail_UserEvent_UserEventId",
                        column: x => x.UserEventId,
                        principalTable: "UserEvent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEventDetailText",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    UserEventDetailId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEventDetailText", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEventDetailText_UserEventDetail_UserEventDetailId",
                        column: x => x.UserEventDetailId,
                        principalTable: "UserEventDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DetailTypes",
                columns: new[] { "Id", "CarDetailId", "Name" },
                values: new object[,]
                {
                    { 1, null, "Ticket" },
                    { 2, null, "Car" },
                    { 3, null, "Event" },
                    { 4, null, "Ticket" },
                    { 5, null, "Shop" },
                    { 6, null, "Highlight" },
                    { 7, null, "Improvement" },
                    { 8, null, "Critique" },
                    { 1001, null, "Detail1" },
                    { 1002, null, "Detail2" },
                    { 1003, null, "Detail3" }
                });

            migrationBuilder.InsertData(
                table: "EventType",
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
                    { 13, "RoutineDrive" },
                    { 1001, "Type1" },
                    { 1002, "Type2" },
                    { 1003, "Type3" }
                });

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastModified", "UploadDate" },
                values: new object[] { new DateTime(2023, 8, 3, 17, 59, 16, 622, DateTimeKind.Local).AddTicks(9912), new DateTime(2023, 8, 3, 17, 59, 16, 622, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.InsertData(
                table: "MasterLog",
                columns: new[] { "Id", "Message", "Time" },
                values: new object[,]
                {
                    { 1, "App Birth.", new DateTime(2023, 8, 3, 17, 59, 16, 624, DateTimeKind.Local).AddTicks(92) },
                    { 2, "Hello from The past.", new DateTime(2023, 8, 3, 17, 59, 16, 624, DateTimeKind.Local).AddTicks(120) }
                });

            migrationBuilder.InsertData(
                table: "Source",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "MarketBorrow" },
                    { 2, "Purchased" },
                    { 3, "Owned" },
                    { 1001, "MarketBorrow" },
                    { 1002, "Owned" },
                    { 1003, "Purchased" }
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

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserDetail_ApplicationUserId",
                table: "ApplicationUserDetail",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserDetail_DetailId",
                table: "ApplicationUserDetail",
                column: "DetailId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserDetail_DriverStatsId",
                table: "ApplicationUserDetail",
                column: "DriverStatsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_TeamId",
                table: "ApplicationUsers",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetail_CarEventId",
                table: "CarDetail",
                column: "CarEventId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetail_CarId",
                table: "CarDetail",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetail_DetailId",
                table: "CarDetail",
                column: "DetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CarEvent_CarId",
                table: "CarEvent",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarEvent_EventId",
                table: "CarEvent",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_CarEventDetail_CarDetailId",
                table: "CarEventDetail",
                column: "CarDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CarEventDetail_CarEventId",
                table: "CarEventDetail",
                column: "CarEventId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_SourceId",
                table: "Cars",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_CarStatus_CarId",
                table: "CarStatus",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarStatus_StatusId",
                table: "CarStatus",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Detail_ApplicationUserId",
                table: "Detail",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Detail_DetailTypeId",
                table: "Detail",
                column: "DetailTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Detail_UserEventDetailId",
                table: "Detail",
                column: "UserEventDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailTypes_CarDetailId",
                table: "DetailTypes",
                column: "CarDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailTypes_Name",
                table: "DetailTypes",
                column: "Name",
                unique: false);

            migrationBuilder.CreateIndex(
                name: "IX_Event_CarId",
                table: "Event",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_CategoryId",
                table: "Event",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_EventTypeId",
                table: "Event",
                column: "EventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_TeamTimelineId",
                table: "Event",
                column: "TeamTimelineId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_TimelineId",
                table: "Event",
                column: "TimelineId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_UserId",
                table: "Event",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EventType_Name",
                table: "EventType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Logger_CarId",
                table: "Logger",
                column: "CarId");

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
                name: "IX_Source_Name",
                table: "Source",
                column: "Name",
                unique: false);

            migrationBuilder.CreateIndex(
                name: "IX_TeamTimeline_TeamId",
                table: "TeamTimeline",
                column: "TeamId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ApplicationUserDetailId",
                table: "Ticket",
                column: "ApplicationUserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_AssigneeId",
                table: "Ticket",
                column: "AssigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_CreatorId",
                table: "Ticket",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketAttachment_TicketId1",
                table: "TicketAttachment",
                column: "TicketId1");

            migrationBuilder.CreateIndex(
                name: "IX_TicketComment_AuthorId",
                table: "TicketComment",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketComment_TicketId1",
                table: "TicketComment",
                column: "TicketId1");

            migrationBuilder.CreateIndex(
                name: "IX_TicketHistory_OwnerId",
                table: "TicketHistory",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketHistory_TicketId1",
                table: "TicketHistory",
                column: "TicketId1");

            migrationBuilder.CreateIndex(
                name: "IX_TicketHistory_UserDetailId1",
                table: "TicketHistory",
                column: "UserDetailId1");

            migrationBuilder.CreateIndex(
                name: "IX_TicketTag_TicketId1",
                table: "TicketTag",
                column: "TicketId1");

            migrationBuilder.CreateIndex(
                name: "IX_Timeline_UserDetailId",
                table: "Timeline",
                column: "UserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvent_ApplicationUserDetailId",
                table: "UserEvent",
                column: "ApplicationUserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvent_ApplicationUserId",
                table: "UserEvent",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvent_EventId",
                table: "UserEvent",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEvent_UserId",
                table: "UserEvent",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEventDetail_ApplicationUserId",
                table: "UserEventDetail",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEventDetail_CarId",
                table: "UserEventDetail",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEventDetail_DetailId",
                table: "UserEventDetail",
                column: "DetailId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEventDetail_EventId",
                table: "UserEventDetail",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEventDetail_UserEventId",
                table: "UserEventDetail",
                column: "UserEventId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEventDetail_UserId",
                table: "UserEventDetail",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEventDetailText_UserEventDetailId",
                table: "UserEventDetailText",
                column: "UserEventDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserDetail_Detail_DetailId",
                table: "ApplicationUserDetail",
                column: "DetailId",
                principalTable: "Detail",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarDetail_Detail_DetailId",
                table: "CarDetail",
                column: "DetailId",
                principalTable: "Detail",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Detail_UserEventDetail_UserEventDetailId",
                table: "Detail",
                column: "UserEventDetailId",
                principalTable: "UserEventDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserDetail_ApplicationUsers_ApplicationUserId",
                table: "ApplicationUserDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Detail_ApplicationUsers_ApplicationUserId",
                table: "Detail");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_ApplicationUsers_UserId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEvent_ApplicationUsers_ApplicationUserId",
                table: "UserEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEvent_ApplicationUsers_UserId",
                table: "UserEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEventDetail_ApplicationUsers_ApplicationUserId",
                table: "UserEventDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEventDetail_ApplicationUsers_UserId",
                table: "UserEventDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserDetail_Detail_DetailId",
                table: "ApplicationUserDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_CarDetail_Detail_DetailId",
                table: "CarDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEventDetail_Detail_DetailId",
                table: "UserEventDetail");

            migrationBuilder.DropTable(
                name: "ApplicationUserStaticDetail");

            migrationBuilder.DropTable(
                name: "CarEventDetail");

            migrationBuilder.DropTable(
                name: "CarStaticDetails");

            migrationBuilder.DropTable(
                name: "CarStatus");

            migrationBuilder.DropTable(
                name: "Logger");

            migrationBuilder.DropTable(
                name: "MasterLog");

            migrationBuilder.DropTable(
                name: "NoteAttachment");

            migrationBuilder.DropTable(
                name: "NoteComment");

            migrationBuilder.DropTable(
                name: "NoteTag");

            migrationBuilder.DropTable(
                name: "TicketAttachment");

            migrationBuilder.DropTable(
                name: "TicketCategory");

            migrationBuilder.DropTable(
                name: "TicketComment");

            migrationBuilder.DropTable(
                name: "TicketHistory");

            migrationBuilder.DropTable(
                name: "TicketTag");

            migrationBuilder.DropTable(
                name: "UserEventDetailText");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "Detail");

            migrationBuilder.DropTable(
                name: "DetailTypes");

            migrationBuilder.DropTable(
                name: "UserEventDetail");

            migrationBuilder.DropTable(
                name: "CarDetail");

            migrationBuilder.DropTable(
                name: "UserEvent");

            migrationBuilder.DropTable(
                name: "CarEvent");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "EventType");

            migrationBuilder.DropTable(
                name: "TeamTimeline");

            migrationBuilder.DropTable(
                name: "Timeline");

            migrationBuilder.DropTable(
                name: "Source");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "ApplicationUserDetail");

            migrationBuilder.DropTable(
                name: "DriverStats");

            migrationBuilder.CreateTable(
                name: "BlockNotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NoteContent = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockNotes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "ExcelDataRecords",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LastModified", "UploadDate" },
                values: new object[] { new DateTime(2023, 8, 2, 17, 49, 13, 258, DateTimeKind.Local).AddTicks(5482), new DateTime(2023, 8, 2, 17, 49, 13, 258, DateTimeKind.Local).AddTicks(5427) });
        }
    }
}
