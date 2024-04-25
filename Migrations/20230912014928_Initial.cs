using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    String = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blank", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarStatus_New",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false),
                    StatusName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CarStatu__C8EE2043D8294AF0", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultPriority = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrivingHours = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverId);
                });

            migrationBuilder.CreateTable(
                name: "ErrorLog",
                columns: table => new
                {
                    ErrorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    ErrorDetails = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ErrorPriority = table.Column<int>(type: "int", nullable: true),
                    ErrorNotes = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ErrorLog__358565CA8BB277F2", x => x.ErrorID);
                });

            migrationBuilder.CreateTable(
                name: "EventTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExcelDataRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JsonData = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcelDataRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    IssueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    System = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedByUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubmittedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubmittedAt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.IssueId);
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
                name: "Order",
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
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaceholderUserRole",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Placehol__8AFACE3A8A46317E", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
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
                name: "SimpleEvent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimpleEvent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SimpleEventTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimpleEventTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Software",
                columns: table => new
                {
                    SoftwareID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    HeadUnit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SoftwareVersion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NextSoftwareVersion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Software__25EDB8DCFDCE01A5", x => x.SoftwareID);
                });

            migrationBuilder.CreateTable(
                name: "Source",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Source", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
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
                        name: "FK_ExcelDataRecordAttribute_ExcelDataRecord_ExcelDataRecordId",
                        column: x => x.ExcelDataRecordId,
                        principalTable: "ExcelDataRecord",
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
                        name: "FK_ExcelDataRecordChange_ExcelDataRecord_ExcelDataRecordId",
                        column: x => x.ExcelDataRecordId,
                        principalTable: "ExcelDataRecord",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "NewCar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adas = table.Column<bool>(type: "bit", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    TeleGeneration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Miles = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tagnumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Finas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    CarStatusId = table.Column<int>(type: "int", nullable: true),
                    LoggerId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mileage = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewCar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewCar_Source_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Source",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Truck",
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
                    Adas = table.Column<bool>(type: "bit", nullable: true),
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    TruckDetail = table.Column<int>(type: "int", nullable: false),
                    TruckStatusId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Truck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Truck_Source_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Source",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PostTag",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTag", x => new { x.PostId, x.TagId });
                    table.ForeignKey(
                        name: "FK_PostTag_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PostTag_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FriendlyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    UserEventId = table.Column<int>(type: "int", nullable: false),
                    UserDetailId = table.Column<int>(type: "int", nullable: false),
                    UserCarEventId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
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
                        name: "FK_ApplicationUser_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
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
                        name: "FK_CarStaticDetail_NewCar_CarId",
                        column: x => x.CarId,
                        principalTable: "NewCar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CarStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewCarId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CarStatuses_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "NewCar_Loggers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    TruckId = table.Column<int>(type: "int", nullable: false),
                    TypeLogger = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NumLoggers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewCar_Loggers", x => new { x.CardId, x.Id });
                    table.ForeignKey(
                        name: "FK_NewCar_Loggers_NewCar_CardId",
                        column: x => x.CardId,
                        principalTable: "NewCar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_NewCar_Loggers_Truck_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Truck",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Truck_Loggers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TruckdId = table.Column<int>(type: "int", nullable: false),
                    NewCarId = table.Column<int>(type: "int", nullable: false),
                    TypeLogger = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NumLoggers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Truck_Loggers", x => new { x.TruckdId, x.Id });
                    table.ForeignKey(
                        name: "FK_Truck_Loggers_NewCar_NewCarId",
                        column: x => x.NewCarId,
                        principalTable: "NewCar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Truck_Loggers_Truck_TruckdId",
                        column: x => x.TruckdId,
                        principalTable: "Truck",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TruckDetail",
                columns: table => new
                {
                    TruckDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TruckId = table.Column<int>(type: "int", nullable: false),
                    DetailTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TruckDetail", x => x.TruckDetailId);
                    table.ForeignKey(
                        name: "FK_TruckDetail_Truck_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Truck",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TruckStaticDetail",
                columns: table => new
                {
                    TruckId = table.Column<int>(type: "int", nullable: false),
                    Vin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Finas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adas = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "(1)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TruckStaticDetail", x => x.TruckId);
                    table.ForeignKey(
                        name: "FK_TruckStaticDetail_Truck_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Truck",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TruckStatus",
                columns: table => new
                {
                    TruckId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    StatusTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TruckStatus", x => new { x.TruckId, x.Id });
                    table.ForeignKey(
                        name: "FK_TruckStatus_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "StatusID");
                    table.ForeignKey(
                        name: "FK_TruckStatus_Truck_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Truck",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserDetail",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserDetail", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_ApplicationUserDetail_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    TeleGeneration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Miles = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Cars_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tickets_ApplicationUser_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UserCarEvent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    EventTypeId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    TeamTimelineId = table.Column<int>(type: "int", nullable: true)
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
                        onDelete: ReferentialAction.NoAction);
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TruckDetailId = table.Column<int>(type: "int", nullable: true)
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
                name: "PlaceholderUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    PlaceholderUserDetailUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                    table.PrimaryKey("PK_PlaceholderUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaceholderUser_ApplicationUserDetail_PlaceholderUserDetailUserId",
                        column: x => x.PlaceholderUserDetailUserId,
                        principalTable: "ApplicationUserDetail",
                        principalColumn: "UserId");
                    table.ForeignKey(
                        name: "FK_PlaceholderUser_PlaceholderUserRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "PlaceholderUserRole",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TicketComment_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                    ChangedById = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TicketHistory_ApplicationUser_ChangedById",
                        column: x => x.ChangedById,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_TicketHistory_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SimpleEventTypeId = table.Column<int>(type: "int", nullable: true),
                    UserEventId = table.Column<int>(type: "int", nullable: true),
                    EventDetailId = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PlaceholderUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_ApplicationUser_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id");
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
                        name: "FK_Events_PlaceholderUser_PlaceholderUserId",
                        column: x => x.PlaceholderUserId,
                        principalTable: "PlaceholderUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Events_SimpleEventTypes_SimpleEventTypeId",
                        column: x => x.SimpleEventTypeId,
                        principalTable: "SimpleEventTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserEvents",
                columns: table => new
                {
                    UserEventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserCarEventId = table.Column<int>(type: "int", nullable: true)
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetailTypeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEventId = table.Column<int>(type: "int", nullable: true),
                    UserEventDetailId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserCarEventId = table.Column<int>(type: "int", nullable: true)
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
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Detail_UserCarEvent_UserCarEventId",
                        column: x => x.UserCarEventId,
                        principalTable: "UserCarEvent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Detail_UserEvents_UserEventDetailId",
                        column: x => x.UserEventDetailId,
                        principalTable: "UserEvents",
                        principalColumn: "UserEventId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CarDetails",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Finas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VinLast4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HarnessStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullVin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftwareVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDetails", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_CarDetails_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.NoAction);
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
                    EventDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetailId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventDetail", x => x.EventDetailId);
                    table.ForeignKey(
                        name: "FK_EventDetail_Detail_DetailId",
                        column: x => x.DetailId,
                        principalTable: "Detail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_EventDetail_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UserDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailId = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
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
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "EventId", "FirstName", "FriendlyName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RoleId", "SecurityStamp", "TeamId", "TwoFactorEnabled", "UserCarEventId", "UserDetailId", "UserEventId", "UserName" },
                values: new object[,]
                {
                    { "3de00zzz-2828-0000-0000-3de000000000", 0, "d11f4e86-685c-4094-acaf-373e2d6abb0c", "dummyuser@example.com", false, 0, null, "Dummy User", null, false, null, "DUMMYUSER@EXAMPLE.COM", "DUMMYUSER", null, null, false, null, "b4aa64d9-4ce8-4aea-994c-902088989181", null, false, 0, 0, 0, "DummyUser1" },
                    { "3de00zzz-2828-0000-0000-3de000000001", 0, "525d552a-dcbf-45dc-9e23-137c36ed826d", "dkzeanah@gmail.com", false, 0, null, "Admin User", null, false, null, "DKZEANAH@GMAIL.COM", "ADMIN", null, null, false, null, "2a444e13-d1cd-4f8a-90b9-cf6d517a7f5e", null, false, 0, 0, 0, "Admin1" }
                });

            migrationBuilder.InsertData(
                table: "Blank",
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
                    { 8, "Critique", null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "43670aec-fc6a-4ca9-be9e-ba7a33cc17db", null, "Admin", "ADMIN" },
                    { "492b7ce0-02cb-4850-bf32-f5169fb28ea7", null, "Visitor", "VISITOR" }
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
                columns: new[] { "StatusID", "Name" },
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
                columns: new[] { "Id", "Adas", "Finas", "Location", "Make", "Miles", "Model", "Name", "SourceId", "Tagnumber", "TeleGeneration", "TruckDetail", "TruckStatusId", "UserId", "Vin", "Year" },
                values: new object[,]
                {
                    { 1, true, "X294-01019", "California", "Mercedes", 5000, "EQE 400", null, 2, "180", "NTG7", 0, 0, "d02a99db-8c5a-4e0f-9d01-1da28abf91a4", "4JGGM2BB6PA000131", 2023 },
                    { 2, true, "X167-04607", "Tuscaloosa", "Mercedes", 0, "Maybach GLS 600", null, 2, "181", "NTG6", 0, 0, "d02a99db-8c5a-4e0f-9d01-1da28abf91a4", "4JGFF8HB5NA357779", 2023 },
                    { 3, true, "X296-01198", "Tuscaloosa", "Mercedes", 0, "EQS 450+", null, 2, " 182", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM2DB4RA003435", 2025 },
                    { 4, true, "X167-06625", "Tuscaloosa", "Mercedes", 0, "GLS 580 4matic", null, 2, " 183", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGFF8FE9RA844776", 2025 },
                    { 5, true, "X294-01471", "Tuscaloosa", "Mercedes", 0, "EQE 350 4matic", null, 2, " 184", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM1CB8RA000790", 2025 },
                    { 6, true, "Z296-01209", "Tuscaloosa", "Mercedes", 0, "Maybach EQS 680", null, 2, " 185", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGDX5FB2RA003388", 2025 },
                    { 7, true, "X296-01210", "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", null, 2, " 186", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM4EB5RA003437", 2025 },
                    { 8, true, "X167-06656", "Tuscaloosa", "Mercedes", 0, "GLS 450 4MATIC", null, 2, " 187", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGFF5KE1RA844775", 2025 },
                    { 9, true, "X294-01457", "Tuscaloosa", "Mercedes", 0, "AMG EQE 53 4MAT", null, 2, " 188", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM5DB8RA001590", 2025 },
                    { 10, true, "X296-00421", "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", null, 2, " 189", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM4EB6PA000351", 2025 },
                    { 11, true, "X296-00395", "Tuscaloosa", "Mercedes", 0, "EQS 450", null, 2, " 190", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM2DB9PA000205", 2025 },
                    { 12, true, "X167-06686", "Tuscaloosa", "Mercedes", 0, "Maybach GLS 600", null, 2, " 191", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGFF8HB1RA844774", 2025 },
                    { 13, true, "X294-01532", "Tuscaloosa", "Mercedes", 0, "EQE 350+", null, 2, " 192", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM2BB2RA000792", 2025 },
                    { 14, true, "X296-00702", "Tuscaloosa", "Mercedes", 0, "EQS 450 4MATIC", null, 2, " 193", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM2EB1PU000194", 2025 },
                    { 15, true, "V167-06463", "Tuscaloosa", "Mercedes", 0, "GLE 400 e 4MATIC", null, 2, " 195", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGFB4GB3RA809370", 2025 },
                    { 16, true, "Z296-01192", "Tuscaloosa", "Mercedes", 0, "MAYBACH EQS 680", null, 2, " 196", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGDX5FB9RA003386", 2025 },
                    { 17, true, "C167-06461", "Tuscaloosa", "Mercedes", 0, "AMG GLE 63 S 4MAT", null, 2, " 197", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGFD8KB4RA809371", 2025 },
                    { 18, true, "V167-06567", "Tuscaloosa", "Mercedes", 0, "GLE 400 e 4MATIC", null, 2, " 198", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGFB4GB1PA883660", 2025 },
                    { 19, true, "X294-01456", "Tuscaloosa", "Mercedes", 0, "AMG EQE 53 4MAT", null, 2, " 199", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM5DBXRA001588", 2025 },
                    { 20, true, "X296-00848", "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", null, 2, " 288", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM4EB7PA000701", 2025 },
                    { 21, true, "V297-02377", "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", null, 2, " 638", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KCG4EB4PA019834", 2025 },
                    { 22, true, "W206-01531", "Tuscaloosa", "Mercedes", 0, "C 300", null, 2, " 651", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KAF4GB9NR000041", 2025 },
                    { 23, true, "V297-01008", "Tuscaloosa", "Mercedes", 0, "EQS 580 4MATIC", null, 2, " 652", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KCG4EB7NA000823", 2025 },
                    { 24, true, "A118-01377", "Tuscaloosa", "Mercedes", 0, "AMG CLA 45 ", null, 2, " 653", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1K5J5EB8RN368913", 2025 },
                    { 25, true, "V297-01062", "Tuscaloosa", "Mercedes", 0, "EQS 450 4MATIC", null, 2, " 654", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KCG2EB8NA003265", 2025 },
                    { 26, true, "V223-05154", "Tuscaloosa", "Mercedes", 0, "AMG S 63 e ", null, 2, " 655", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1K6G8CB9RA200096", 2025 },
                    { 27, true, "X254-02459", "Tuscaloosa", "Mercedes", 0, "GLC 300", null, 2, " 657", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1NKM4GB3PF001221", 2025 },
                    { 28, true, "V295-01073", "Tuscaloosa", "Mercedes", 0, "EQE 350+", null, 2, " 658", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KEG2BB5NF000498", 2025 },
                    { 29, true, "V295-01074", "Tuscaloosa", "Mercedes", 0, "EQE 350+", null, 2, " 659", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KEG2BB7NF000499", 2025 },
                    { 30, true, "Z223-05153", "Tuscaloosa", "Mercedes", 0, "Maybach S 580", null, 2, " 660", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1K6X7GB9RA203259", 2025 },
                    { 31, true, "N295-01333", "Tuscaloosa", "Mercedes", 0, "AMG EQE 53 4MAT", null, 2, " 661", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KEG5DB3PF005779", 2025 },
                    { 32, true, "X243-01749", "Tuscaloosa", "Mercedes", 0, "EQB 350 4MATIC", null, 2, " 662", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1N9M1DB3RN027408", 2025 },
                    { 33, true, "V223-04879", "Tuscaloosa", "Mercedes", 0, "AMG S 63 e 4MATIC", null, 2, " 663", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1K6G8CB5PA159432", 2025 },
                    { 34, true, "V297-01298", "Tuscaloosa", "Mercedes", 0, "EQS 550 4MATIC", null, 2, " 664", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KCG4EB6NA000411", 2025 },
                    { 35, true, "A238-02435", "Tuscaloosa", "Mercedes", 0, "AMG E 53 4MATIC+", null, 2, " 665", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1K1K6BB7PF185712", 2025 },
                    { 36, true, "W214-01098", "Tuscaloosa", "Mercedes", 0, "E 350 4MATIC", null, 2, " 666", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KLF4HB7RA000650", 2025 },
                    { 37, true, "X294-00461", "Tuscaloosa", "Mercedes", 0, "EQE 350 4MATIC", null, 2, " 668", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGGM1CB5PA000386", 2025 },
                    { 38, true, "X296-00322", "Tuscaloosa", "Mercedes", 0, "EQS 450", null, 2, " 669", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "4JGDM2DB2PA000031", 2025 },
                    { 39, true, "V295-00503", "Tuscaloosa", "Mercedes", 0, "EQE 350+", null, 2, "670", "", 0, 0, "00000000-8c5a-4e0f-9d01-000000000000", "W1KEG2BB5PF000620", 2025 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_RoleId",
                table: "ApplicationUser",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_TeamId",
                table: "ApplicationUser",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetails_DetailId",
                table: "CarDetails",
                column: "DetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_UserId",
                table: "Cars",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CarStatuses_StatusId",
                table: "CarStatuses",
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
                name: "IX_Detail_UserCarEventId",
                table: "Detail",
                column: "UserCarEventId");

            migrationBuilder.CreateIndex(
                name: "IX_Detail_UserEventDetailId",
                table: "Detail",
                column: "UserEventDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailType_TruckDetailId",
                table: "DetailType",
                column: "TruckDetailId");

            migrationBuilder.CreateIndex(
                name: "IDX_ErrorLog_CarID",
                table: "ErrorLog",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_EventDetail_DetailId",
                table: "EventDetail",
                column: "DetailId");

            migrationBuilder.CreateIndex(
                name: "IX_EventDetail_EventId",
                table: "EventDetail",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_ApplicationUserId",
                table: "Events",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_CategoryId",
                table: "Events",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_PlaceholderUserId",
                table: "Events",
                column: "PlaceholderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_SimpleEventTypeId",
                table: "Events",
                column: "SimpleEventTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ExcelDataRecordAttribute_ExcelDataRecordId",
                table: "ExcelDataRecordAttribute",
                column: "ExcelDataRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_ExcelDataRecordChange_ExcelDataRecordId",
                table: "ExcelDataRecordChange",
                column: "ExcelDataRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_NewCar_SourceId",
                table: "NewCar",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_NewCar_Loggers_TruckId",
                table: "NewCar_Loggers",
                column: "TruckId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceholderUser_PlaceholderUserDetailUserId",
                table: "PlaceholderUser",
                column: "PlaceholderUserDetailUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaceholderUser_RoleId",
                table: "PlaceholderUser",
                column: "RoleId");

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
                name: "IDX_Software_CarID",
                table: "Software",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "UX_Source_Name",
                table: "Source",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UX_Status_Name",
                table: "Status",
                column: "Name",
                unique: true);

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
                name: "IX_Truck_Loggers_NewCarId",
                table: "Truck_Loggers",
                column: "NewCarId");

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
                name: "Blank");

            migrationBuilder.DropTable(
                name: "CarDetails");

            migrationBuilder.DropTable(
                name: "CarStaticDetail");

            migrationBuilder.DropTable(
                name: "CarStatus_New");

            migrationBuilder.DropTable(
                name: "CarStatuses");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "ErrorLog");

            migrationBuilder.DropTable(
                name: "EventDetail");

            migrationBuilder.DropTable(
                name: "ExcelDataRecordAttribute");

            migrationBuilder.DropTable(
                name: "ExcelDataRecordChange");

            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "NewCar_Loggers");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "PostTag");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "SimpleEvent");

            migrationBuilder.DropTable(
                name: "Software");

            migrationBuilder.DropTable(
                name: "TicketAttachment");

            migrationBuilder.DropTable(
                name: "TicketComment");

            migrationBuilder.DropTable(
                name: "TicketHistory");

            migrationBuilder.DropTable(
                name: "TicketTag");

            migrationBuilder.DropTable(
                name: "Truck_Loggers");

            migrationBuilder.DropTable(
                name: "TruckStaticDetail");

            migrationBuilder.DropTable(
                name: "TruckStatus");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserDetail");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "ExcelDataRecord");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "NewCar");

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
                name: "PlaceholderUser");

            migrationBuilder.DropTable(
                name: "SimpleEventTypes");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.DropTable(
                name: "TeamTimeline");

            migrationBuilder.DropTable(
                name: "Source");

            migrationBuilder.DropTable(
                name: "ApplicationUserDetail");

            migrationBuilder.DropTable(
                name: "PlaceholderUserRole");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
