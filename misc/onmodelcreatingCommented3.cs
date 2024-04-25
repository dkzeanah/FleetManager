
// Comment 31:
// Creates a table named "CarEventDetail" with columns "CarEventDetailId" (auto-incrementing primary key of type int),
// "CarEventId" (of type int, not nullable), "Note" (of type string, not nullable), and "CarDetailId" (of type int, nullable).

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
                        onDelete: ReferentialAction.Cascade);
                });
// Comment 32:
// Creates a table named "CarStatuses" with columns "Id" (auto-incrementing primary key of type int),
// "CarId" (of type int, not nullable), "StatusId" (of type int, not nullable), and "StatusTime" (of type DateTime, nullable).
            migrationBuilder.CreateTable(
                name: "CarStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    StatusTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarStatuses_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
// Comment 33:
// Creates a table named "Detail" with columns "Id" (auto-incrementing primary key of type int),
// "DetailTypeId" (of type int, not nullable), "Value" (of type string, not nullable),
// "ApplicationUserId" (of type string, nullable), "Discriminator" (of type string, not nullable),
// "Text" (of type string, nullable), "UserId" (of type string, nullable), "UserEventId" (of type int, nullable),
// and "UserEventDetailId" (of type int, nullable).

            migrationBuilder.CreateTable(
                name: "Detail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetailTypeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEventId = table.Column<int>(type: "int", nullable: true),
                    UserEventDetailId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                        name: "FK_Detail_DetailTypes_DetailTypeId",
                        column: x => x.DetailTypeId,
                        principalTable: "DetailTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
// Comment 34:
// Creates a table named "UserDetail" with columns "Id" (auto-incrementing primary key of type int),
// "UserId" (of type string, not nullable), "UserEventsId" (of type int, not nullable),
// "DriverStatsId" (of type int, nullable), "TimelineId" (of type int, nullable), and "DetailId" (of type int, nullable).

            migrationBuilder.CreateTable(
                name: "UserDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserEventsId = table.Column<int>(type: "int", nullable: false),
                    DriverStatsId = table.Column<int>(type: "int", nullable: true),
                    TimelineId = table.Column<int>(type: "int", nullable: true),
                    DetailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDetail_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetail_Detail_DetailId",
                        column: x => x.DetailId,
                        principalTable: "Detail",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserDetail_DriverStats_DriverStatsId",
                        column: x => x.DriverStatsId,
                        principalTable: "DriverStats",
                        principalColumn: "Id");
                });
// Comment 35:
// Creates a table named "Tickets" with columns "Id" (auto-incrementing primary key of type int),
// "Title" (of type string, not nullable), "Description" (of type string, not nullable),
// "UserDetailId" (of type int, not nullable), "CreatorId" (of type string, not nullable),
// "AssigneeId" (of type string, not nullable), "CreatedAt" (of type DateTime, not nullable),
// "UpdatedAt" (of type DateTime, nullable), "ClosedAt" (of type DateTime, nullable),
// "Status" (of type string, not nullable), "Severity" (of type string, not nullable), and "Priority" (of type string, not nullable).

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserDetailId = table.Column<int>(type: "int", nullable: false),
                    CreatorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AssigneeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClosedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Severity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Tickets_UserDetail_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "UserDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
// Comment 36:
// Creates a table named "Timeline" with columns "Id" (auto-incrementing primary key of type int),
// "StartDate" (of type DateTime, not nullable), "EndDate" (of type DateTime, not nullable),
// and "UserDetailId" (of type int, not nullable).

            migrationBuilder.CreateTable(
                name: "Timeline",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timeline", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Timeline_UserDetail_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "UserDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
// Comment 37:
// Creates a table named "TicketAttachment" with columns "Id" (auto-incrementing primary key of type int),
// "TicketId" (of type int, not nullable), and "FilePath" (of type string, not nullable).

            migrationBuilder.CreateTable(
                name: "TicketAttachment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketId = table.Column<int>(type: "int", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
// Comment 38:
// Creates a table named "TicketComment" with columns "Id" (auto-incrementing primary key of type int),
// "TicketId" (of type int, not nullable), "Content" (of type string, not nullable),
// "AuthorId" (of type string, not nullable), and "CreatedAt" (of type DateTime, not nullable).

            migrationBuilder.CreateTable(
                name: "TicketComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
// Comment 39:
// Creates a table named "TicketHistory" with columns "Id" (auto-incrementing primary key of type int),
// "TicketId" (of type int, not nullable), "Change" (of type string, not nullable),
// "ChangedAt" (of type DateTime, not nullable), "ChangedById" (of type string, not nullable),
// and "OwnerId" (of type string, not nullable).

            migrationBuilder.CreateTable(
                name: "TicketHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketId = table.Column<int>(type: "int", nullable: false),
                    Change = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChangedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChangedById = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketHistory_ApplicationUser_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketHistory_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketHistory_UserDetail_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "UserDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
// Comment 40:
// Creates a table named "TicketTag" with columns "Id" (auto-incrementing primary key of type int),
// "TicketId" (of type int, not nullable), and "Tag" (of type string, not nullable).

            migrationBuilder.CreateTable(
                name: "TicketTag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketId = table.Column<int>(type: "int", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
// Comment 41:
// Creates a table named "Events" with columns "Id" (auto-incrementing primary key of type int),
// "CarId" (of type int, not nullable), "EventTypeId" (of type int, not nullable),
// "UserId" (of type string, nullable), "Date" (of type DateTime, not nullable),
// "CategoryId" (of type int, not nullable), "StartTime" (of type DateTime, nullable),
// "EndTime" (of type DateTime, nullable), "Type" (of type string, nullable),
// "TeamTimelineId" (of type int, nullable), and "TimelineId" (of type int, nullable).

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    EventTypeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamTimelineId = table.Column<int>(type: "int", nullable: true),
                    TimelineId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_Events_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_EventTypes_EventTypeId",
                        column: x => x.EventTypeId,
                        principalTable: "EventTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_TeamTimeline_TeamTimelineId",
                        column: x => x.TeamTimelineId,
                        principalTable: "TeamTimeline",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Events_Timeline_TimelineId",
                        column: x => x.TimelineId,
                        principalTable: "Timeline",
                        principalColumn: "Id");
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
onDelete: ReferentialAction.Cascade);
});


migrationBuilder.CreateTable(
name: "CarStatuses",
columns: table => new
{
Id = table.Column<int>(type: "int", nullable: false)
.Annotation("SqlServer:Identity", "1, 1"),
CarId = table.Column<int>(type: "int", nullable: false),
StatusId = table.Column<int>(type: "int", nullable: false),
StatusTime = table.Column<DateTime>(type: "datetime2", nullable: true)
},
constraints: table =>
{
table.PrimaryKey("PK_CarStatuses", x => x.Id);
table.ForeignKey(
name: "FK_CarStatuses_Cars_CarId",
column: x => x.CarId,
principalTable: "Cars",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);
});

migrationBuilder.CreateTable(
name: "Detail",
columns: table => new
{
Id = table.Column<int>(type: "int", nullable: false)
.Annotation("SqlServer:Identity", "1, 1"),
DetailTypeId = table.Column<int>(type: "int", nullable: false),
Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
UserEventId = table.Column<int>(type: "int", nullable: true),
UserEventDetailId = table.Column<int>(type: "int", nullable: true),
Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
name: "FK_Detail_DetailTypes_DetailTypeId",
column: x => x.DetailTypeId,
principalTable: "DetailTypes",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);
});

migrationBuilder.CreateTable(
name: "UserDetail",
columns: table => new
{
Id = table.Column<int>(type: "int", nullable: false)
.Annotation("SqlServer:Identity", "1, 1"),
UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
UserEventsId = table.Column<int>(type: "int", nullable: false),
DriverStatsId = table.Column<int>(type: "int", nullable: true),
TimelineId = table.Column<int>(type: "int", nullable: true),
DetailId = table.Column<int>(type: "int", nullable: true)
},
constraints: table =>
{
table.PrimaryKey("PK_UserDetail", x => x.Id);
table.ForeignKey(
name: "FK_UserDetail_ApplicationUser_UserId",
column: x => x.UserId,
principalTable: "ApplicationUser",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);
table.ForeignKey(
name: "FK_UserDetail_Detail_DetailId",
column: x => x.DetailId,
principalTable: "Detail",
principalColumn: "Id");
table.ForeignKey(
name: "FK_UserDetail_DriverStats_DriverStatsId",
column: x => x.DriverStatsId,
principalTable: "DriverStats",
principalColumn: "Id");
});

migrationBuilder.CreateTable(
name: "Tickets",
columns: table => new
{
Id = table.Column<int>(type: "int", nullable: false)
.Annotation("SqlServer:Identity", "1, 1"),
Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
UserDetailId = table.Column<int>(type: "int", nullable: false),
CreatorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
AssigneeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
ClosedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
Severity = table.Column<string>(type: "nvarchar(max)", nullable: false),
Priority = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
table.ForeignKey(
name: "FK_Tickets_UserDetail_UserDetailId",
column: x => x.UserDetailId,
principalTable: "UserDetail",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);
});

migrationBuilder.CreateTable(
name: "Timeline",
columns: table => new
{
Id = table.Column<int>(type: "int", nullable: false)
.Annotation("SqlServer:Identity", "1, 1"),
StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
UserDetailId = table.Column<int>(type: "int", nullable: false)
},
constraints: table =>
{
table.PrimaryKey("PK_Timeline", x => x.Id);
table.ForeignKey(
name: "FK_Timeline_UserDetail_UserDetailId",
column: x => x.UserDetailId,
principalTable: "UserDetail",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);
});

migrationBuilder.CreateTable(
name: "TicketAttachment",
columns: table => new
{
Id = table.Column<int>(type: "int", nullable: false)
.Annotation("SqlServer:Identity", "1, 1"),
TicketId = table.Column<int>(type: "int", nullable: false),
FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
Id = table.Column<int>(type: "int", nullable: false)
.Annotation("SqlServer:Identity", "1, 1"),
TicketId = table.Column<int>(type: "int", nullable: false),
Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
Id = table.Column<int>(type: "int", nullable: false)
.Annotation("SqlServer:Identity", "1, 1"),
TicketId = table.Column<int>(type: "int", nullable: false),
Change = table.Column<string>(type: "nvarchar(max)", nullable: false),
ChangedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
ChangedById = table.Column<string>(type: "nvarchar(max)", nullable: false),
OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
UserDetailId = table.Column<int>(type: "int", nullable: false)
},
constraints: table =>
{
table.PrimaryKey("PK_TicketHistory", x => x.Id);
table.ForeignKey(
name: "FK_TicketHistory_ApplicationUser_OwnerId",
column: x => x.OwnerId,
principalTable: "ApplicationUser",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);
table.ForeignKey(
name: "FK_TicketHistory_Tickets_TicketId",
column: x => x.TicketId,
principalTable: "Tickets",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);
table.ForeignKey(
name: "FK_TicketHistory_UserDetail_UserDetailId",
column: x => x.UserDetailId,
principalTable: "UserDetail",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);
});

migrationBuilder.CreateTable(
name: "TicketTag",
columns: table => new
{
Id = table.Column<int>(type: "int", nullable: false)
.Annotation("SqlServer:Identity", "1, 1"),
TicketId = table.Column<int>(type: "int", nullable: false),
Tag = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
name: "Events",
columns: table => new
{
Id = table.Column<int>(type: "int", nullable: false)
.Annotation("SqlServer:Identity", "1, 1"),
CarId = table.Column<int>(type: "int", nullable: false),
EventTypeId = table.Column<int>(type: "int", nullable: false),
UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
Date = table.Column<DateTime>(type: "datetime2", nullable: false),
CategoryId = table.Column<int>(type: "int", nullable: false),
StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
TeamTimelineId = table.Column<int>(type: "int", nullable: true),
TimelineId = table.Column<int>(type: "int", nullable: true)
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
name: "FK_Events_Cars_CarId",
column: x => x.CarId,
principalTable: "Cars",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);
table.ForeignKey(
name: "FK_Events_Category_CategoryId",
column: x => x.CategoryId,
principalTable: "Category",
principalColumn: "CategoryId",
onDelete: ReferentialAction.Cascade);
table.ForeignKey(
name: "FK_Events_EventTypes_EventTypeId",
column: x => x.EventTypeId,
principalTable: "EventTypes",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);
table.ForeignKey(
name: "FK_Events_TeamTimeline_TeamTimelineId",
column: x => x.TeamTimelineId,
principalTable: "TeamTimeline",
principalColumn: "Id");
table.ForeignKey(
name: "FK_Events_Timeline_TimelineId",
column: x => x.TimelineId,
principalTable: "Timeline",
principalColumn: "Id");
});