/*
Unique indexes should be applied to a model/table when you want to enforce the uniqueness of values in one or more columns, 
ensuring that no duplicate values exist across the rows. Unique indexes are used to maintain data integrity by preventing 
the insertion of duplicate data, ensuring that certain columns have distinct values.

/// Here are some scenarios where applying unique indexes is beneficial:

Primary Key: By default, the primary key of a table is always unique, as it uniquely identifies each row. However, in cases where you have a composite primary key (multiple columns as the primary key), you should apply a unique index on those columns to ensure uniqueness.

Natural Keys: If your table contains columns that naturally have unique values, such as email addresses in a user table or social security numbers in an employee table, applying unique indexes on these columns ensures that no two records have the same value for these unique identifiers.

Business Constraints: Sometimes, business rules might dictate that certain columns must have unique values. For example, in an e-commerce application, product codes or SKU numbers might need to be unique. In such cases, applying unique indexes on these columns ensures data integrity and consistency.

Cross-Reference Tables: For many-to-many relationships, where a cross-reference (junction) table is used to link two tables, it's common to apply a unique index on the combination of foreign key columns to ensure that there are no duplicate associations.

Ensuring Uniqueness in Relationships: When working with one-to-one or one-to-many relationships, you might want to ensure that the foreign key column(s) have unique values in the related table. Applying unique indexes on these foreign key columns helps in maintaining data integrity.


/// Preferential Settings for Leveraging Unique Indexes:

Identify Natural Keys: Identify the columns in your table that should naturally have unique values, such as email addresses, usernames, or other identifiers.

Use Primary Key Constraints: For primary keys, consider using the PrimaryKey attribute or Fluent API to define them explicitly. Entity Framework automatically applies unique indexes to primary keys.

Composite Unique Indexes: For composite unique keys (multiple columns together forming a unique key), use the Index attribute or Fluent API to define unique indexes on those combinations of columns.

Evaluate Business Constraints: Analyze the business rules and requirements of your application to determine if any additional columns need unique indexes to maintain data consistency.

Be Mindful of Performance: While unique indexes provide data integrity, keep in mind that they also come with a performance cost during data insertion and updates. Carefully balance the need for data integrity with the performance impact on write operations.

Consider Database-Level Constraints: In some cases, unique constraints might be better applied directly at the database level using SQL commands or migration scripts. This approach can provide more control over the index creation and naming conventions.

In conclusion, unique indexes play a crucial role in maintaining data integrity by preventing duplicate data entries. Applying them to appropriate columns based on natural keys and business rules ensures that your database remains consistent and accurate. However, it's essential to consider the performance implications and strike a balance between data integrity and system efficiency.
*/
using System;
using Microsoft.EntityFrameworkCore.Migrations;
#nullable disable
#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional
namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class ReModeling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //1// Creates a table named "BlankModels" with a single column "Id" of type int.
            // The "Id" column is the primary key, and it auto-increments using the "SqlServer:Identity" feature.
            migrationBuilder.CreateTable(
                name: "BlankModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlankModels", x => x.Id);
                });
            //2// Creates a table named "CarStatusNews" with three columns: "Id" (auto-incrementing primary key of type int),
            // "StatusId" (of type int, not nullable), and "StatusName" (of type string, not nullable).
            migrationBuilder.CreateTable(
                name: "CarStatusNews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarStatusNews", x => x.Id);
                });
            //4// Creates a table named "Drivers" with two columns: "DriverId" (auto-incrementing primary key of type int),
            // and "DrivingHours" (of type decimal, not nullable).
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
            //5// Creates a table named "DriverStats" with three columns: "Id" (auto-incrementing primary key of type int),
            // "TotalCount" (of type int, not nullable), and "AverageDrivingHours" (of type int, not nullable).
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
            //6// Creates a table named "ErrorLogs" with five columns: "Id" (auto-incrementing primary key of type int),
            // "CarId" (of type int, not nullable), "ErrorDetails" (of type string, nullable), "ErrorPriority" (of type int, nullable),
            // and "ErrorNotes" (of type string, nullable).
            migrationBuilder.CreateTable(
                name: "ErrorLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    ErrorDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ErrorPriority = table.Column<int>(type: "int", nullable: true),
                    ErrorNotes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorLogs", x => x.Id);
                });
            //8// Creates a table named "Issues" with ten columns: "IssueId" (auto-incrementing primary key of type int),
            // "Summary" (of type string, not nullable), "Status" (of type string, not nullable),
            // "Priority" (of type string, not nullable), "AssignedTo" (of type string, not nullable),
            // "System" (of type string, not nullable), "ModifiedBy" (of type string, not nullable),
            // "ModifiedAt" (of type string, not nullable), "ModifiedByUser" (of type string, not nullable),
            // and "SubmittedBy" (of type string, not nullable), "SubmittedAt" (of type string, not nullable).
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
            //13// Creates a table named "Softwares" with four columns: "SoftwareId" (auto-incrementing primary key of type int),
            // "CarId" (of type int, not nullable), "HeadUnit" (of type string, not nullable),
            // "SoftwareVersion" (of type string, not nullable), and "NextSoftwareVersion" (of type string, not nullable).
            migrationBuilder.CreateTable(
                name: "Softwares",
                columns: table => new
                {
                    SoftwareId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    HeadUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftwareVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NextSoftwareVersion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Softwares", x => x.SoftwareId);
                });
            //15// Creates a table named "Team" with two columns: "Id" (auto-incrementing primary key of type int),
            // and "Name" (of type string, not nullable).
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
            //23// Create the 'TeamTimeline' table with the specified columns
            migrationBuilder.CreateTable(
                name: "TeamTimeline",
                columns: table => new
                {
                    // Define the 'Id' column as a non-nullable integer with auto-incrementing identity
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),

                    // Define the 'TeamId' column as a non-nullable integer
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    // Set the 'Id' column as the primary key of the 'TeamTimeline' table
                    table.PrimaryKey("PK_TeamTimeline", x => x.Id);

                    // Create a foreign key constraint on the 'TeamId' column, referencing the 'Id' column of the 'Team' table with cascade delete
                    table.ForeignKey(
                        name: "FK_TeamTimeline_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //26// Create the 'Car2s' table with the specified columns
            migrationBuilder.CreateTable(
                name: "Car2s",
                columns: table => new
                {
                    // Define the 'Id' column as a non-nullable integer with auto-incrementing identity
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),

                    // Define the 'Make' column as a nullable string
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'Model' column as a nullable string
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'Year' column as a nullable integer
                    Year = table.Column<int>(type: "int", nullable: true),

                    // Define the 'TeleGeneration' column as a nullable string
                    TeleGeneration = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'Miles' column as a nullable integer
                    Miles = table.Column<int>(type: "int", nullable: true),

                    // Define the 'Location' column as a nullable string
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'SourceId' column as a nullable integer
                    SourceId = table.Column<int>(type: "int", nullable: true),

                    // Define the 'CarStaticDetailId' column as a nullable integer
                    CarStaticDetailId = table.Column<int>(type: "int", nullable: true),

                    // Define the 'UserId' column as a nullable string
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    // Set the 'Id' column as the primary key of the 'Car2s' table
                    table.PrimaryKey("PK_Car2s", x => x.Id);

                    // Create a foreign key constraint on the 'CarStaticDetailId' column, referencing the 'Id' column of the 'CarStaticDetails' table
                    table.ForeignKey(
                        name: "FK_Car2s_CarStaticDetails_CarStaticDetailId",
                        column: x => x.CarStaticDetailId,
                        principalTable: "CarStaticDetails",
                        principalColumn: "Id");
                });

            //35// Creates a table named "Tickets" with columns:
            //-------------------------------------------------
            // "Id" (auto-incrementing primary key of type int),
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
            
            //37// Creates a table named "TicketAttachment" with columns:
            //-------------------------------------------------
            // "Id" (auto-incrementing primary key of type int),
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
            
            //38// Creates a table named "Ticke" with columns//-------------------------------------------------
            // "Id" (auto-incrementing primary key of type int),
            // "TicketId" (of type int, not nullable), "Content" (of type string, not nullable),
            // "AuthorId" (of type string, not nullable), and "CreatedAt" (of type DateTime, not nullable).
            migrationBuilder.Creat            
            //39// Creates a table named "TicketHistory" with columns:
            //-------------------------------------------------
            // "Id" (auto-incrementing primary key of type int),
            // "TicketId" (of type int, not nullable), "Change" (of type string, not nullable),
            // "ChangedAt" (of type DateTime, not nullable), "ChangedById" (of type string, not nullable),
            // and "OwnerI" (of type string, not nullable).
            migrationBuilder.CreateTable(ame: "TicketHistory",
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
            
            //40// Creates a table named "TicketTag" with columns:
            //-------------------------------------------------
            // "Id" (auto-incrementing primary key of type int),
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
            

            ////// Non-Dependant Tables //////

            ///9// Creates a table named "Logs" with two columns: "LogId" (auto-incrementing primary key of type int),
            // and "LogMessage" (of type string, not nullable), and "LogTime" (of type DateTime, nullable).
            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    LogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.LogId);
                });


            /////29// Create the 'DetailTypes' table with the specified columns
            migrationBuilder.CreateTable(
                name: "DetailTypes",
                columns: table => new
                {
                    // Define the 'Id' column as a non-nullable integer with auto-incrementing identity
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),

                    // Define the 'Name' column as a non-nullable string with a maximum length of 450 characters
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),

                    // Define the 'CarDetailId' column as a nullable integer
                    CarDetailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    // Set the 'Id' column as the primary key of the 'DetailTypes' table
                    table.PrimaryKey("PK_DetailTypes", x => x.Id);

                    // Create a foreign key constraint on the 'CarDetailId' column, referencing the 'Id' column of the 'CarDetail' table
                    table.ForeignKey(
                        name: "FK_DetailTypes_CarDetail_CarDetailId",
                        column: x => x.CarDetailId,
                        principalTable: "CarDetail",
                        principalColumn: "Id");
                });

            ////12// Creates a table named "Roles" with three columns: "Id" (of type string, not nullable),
            // "Name" (of type string, nullable), "NormalizedName" (of type string, nullable),
            // and "ConcurrencyStamp" (of type string, nullable).
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

            ////14// Creates a table named "Sources" with two columns: "Id" (auto-incrementing primary key of type int),
            // and "Name" (of type string, not nullable).
            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                });


            ////3// Creates a table named "Category" with three columns: 
            // "CategoryId"         (auto-incrementing primary key of type int),
            // "Name"               (of type string, not nullable), and 
            // "DefaultPriority"    (of type int, not nullable).
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

            ////7// Creates a table named "EventTypes" with two columns: "Id" (auto-incrementing primary key of type int),
            // and "Name" (of type string, not nullable).
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


            ////// Minor-Dependants //////

            ////10// Creates a table named "RoleClaims" with four columns: 
            // "Id" (auto-incrementing primary key of type int),
            // "RoleId" (of type string, nullable), 
            // "ClaimType" (of type string, nullable), and 
            // "ClaimValue" (of type string, nullable).
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

            ////11// Creates a table named "RoleEventMappings" with three columns: 
            //--------------------------------------------------------------------
            // "Id" (auto-incrementing primary key of type int),
            // "RoleId" (of type string, not nullable), and 
            // "DefaultEventTypeId" (of type int, not nullable).
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

            
            //////  Identity and such //////

            ////16// Creates a table named "UserClaims" with three columns: "Id" (auto-incrementing primary key of type int),
            // "UserId" (of type string, nullable), "ClaimType" (of type string, nullable), and "ClaimValue" (of type string, nullable).
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

            ////17// Creates a table named "UserLogins" with four columns: "LoginProvider" (of type string, not nullable),
            // "ProviderKey" (of type string, not nullable), "ProviderDisplayName" (of type string, nullable),
            // and "UserId" (of type string, nullable).
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

            ////18// Creates a table named "UserRoles" with two columns: "UserId" (of type string, not nullable),
            // and "RoleId" (of type string, not nullable).
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

            ////19// Creates a table named "UserTokens" with four columns: "UserId" (of type string, not nullable),
            // "LoginProvider" (of type string, not nullable), "Name" (of type string, not nullable),
            // and "Value" (of type string, nullable).
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

            ////20// Creates a table named "AspNetRoles" with a single column "Id" (of type string, not nullable).
            // This table is linked to the "Roles" table as a foreign key with a cascade delete behavior.
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
                        onDelete: ReferentialAction.Cascade);
                });


            ////// Models

            ////21: Create the 'Cars' table with the specified columns
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    // Define the 'Id' column as an integer with auto-incrementing identity
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),

                    // Define the 'Name' column as a nullable string
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'Make' column as a nullable string
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'Model' column as a nullable string
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'Year' column as a nullable integer
                    Year = table.Column<int>(type: "int", nullable: true),

                    // Define the 'TeleGeneration' column as a nullable string
                    TeleGeneration = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'Miles' column as a nullable integer
                    Miles = table.Column<int>(type: "int", nullable: true),

                    // Define the 'Location' column as a nullable string
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'SourceId' column as a nullable integer
                    SourceId = table.Column<int>(type: "int", nullable: true),

                    // Define the 'CarDetail' column as a non-nullable integer
                    CarDetail = table.Column<int>(type: "int", nullable: false),

                    // Define the 'CarStatusId' column as a non-nullable integer
                    CarStatusId = table.Column<int>(type: "int", nullable: false),

                    // Define the 'UserId' column as a nullable string
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    // Set the 'Id' column as the primary key of the 'Cars' table
                    table.PrimaryKey("PK_Cars", x => x.Id);

                    // Create a foreign key constraint on the 'SourceId' column, referencing the 'Id' column of the 'Sources' table
                    table.ForeignKey(
                        name: "FK_Cars_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id");
                });

            ////22: Create the 'ApplicationUser' table with the specified columns
            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    // Define the 'Id' column as a string with a maximum length of 450 characters
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),

                    // Define the 'FriendlyName' column as a nullable string
                    FriendlyName = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'FirstName' column as a nullable string
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'LastName' column as a nullable string
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'TeamId' column as a non-nullable integer
                    TeamId = table.Column<int>(type: "int", nullable: false),

                    // Define the 'UserName' column as a nullable string
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'NormalizedUserName' column as a nullable string
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'Email' column as a nullable string
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'NormalizedEmail' column as a nullable string
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'EmailConfirmed' column as a non-nullable boolean
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),

                    // Define the 'PasswordHash' column as a nullable string
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'SecurityStamp' column as a nullable string
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'ConcurrencyStamp' column as a nullable string
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'PhoneNumber' column as a nullable string
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    // Define the 'PhoneNumberConfirmed' column as a non-nullable boolean
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),

                    // Define the 'TwoFactorEnabled' column as a non-nullable boolean
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),

                    // Define the 'LockoutEnd' column as a nullable DateTimeOffset
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),

                    // Define the 'LockoutEnabled' column as a non-nullable boolean
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),

                    // Define the 'AccessFailedCount' column as a non-nullable integer
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    // Set the 'Id' column as the primary key of the 'ApplicationUser' table
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);

                    // Create a foreign key constraint on the 'TeamId' column, referencing the 'Id' column of the 'Team' table with cascade delete
                    table.ForeignKey(
                        name: "FK_ApplicationUser_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            ////24: Create the 'CarStaticDetails' table with the specified columns
            migrationBuilder.CreateTable(
                name: "CarStaticDetails",
                columns: table => new
                {
                    // Define the 'Id' column as a non-nullable integer with auto-incrementing identity
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),

                    // Define the 'Vin' column as a non-nullable string
                    Vin = table.Column<string>(type: "nvarchar(max)", nullable: false),

                    // Define the 'Tag' column as a non-nullable string
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),

                    // Define the 'Finas' column as a non-nullable string
                    Finas = table.Column<string>(type: "nvarchar(max)", nullable: false),

                    // Define the 'Adas' column as a nullable boolean
                    Adas = table.Column<bool>(type: "bit", nullable: true),

                    // Define the 'CarId' column as a nullable integer
                    CarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    // Set the 'Id' column as the primary key of the 'CarStaticDetails' table
                    table.PrimaryKey("PK_CarStaticDetails", x => x.Id);

                    // Create a foreign key constraint on the 'CarId' column, referencing the 'Id' column of the 'Cars' table
                    table.ForeignKey(
                        name: "FK_CarStaticDetails_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id");
                });

            ////25: Create the 'UserStaticDetail' table with the specified columns
            migrationBuilder.CreateTable(
                name: "UserStaticDetail",
                columns: table => new
                {
                    // Define the 'Id' column as a string with a maximum length of 450 characters
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),

                    // Define the 'PhoneNumber' column as a non-nullable string
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),

                    // Define the 'VehicleArea' column as a non-nullable string
                    VehicleArea = table.Column<string>(type: "nvarchar(max)", nullable: false),

                    // Define the 'ExpertiseCategory' column as a non-nullable string
                    ExpertiseCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    // Set the 'Id' column as the primary key of the 'UserStaticDetail' table
                    table.PrimaryKey("PK_UserStaticDetail", x => x.Id);

                    // Create a foreign key constraint on the 'Id' column, referencing the 'Id' column of the 'ApplicationUser' table with cascade delete
                    table.ForeignKey(
                        name: "FK_UserStaticDetail_ApplicationUser_Id",
                        column: x => x.Id,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            ////27: Create the 'Loggers' table with the specified columns
            migrationBuilder.CreateTable(
                name: "Loggers",
                columns: table => new
                {
                    // Define the 'LoggerId' column as a non-nullable integer with auto-incrementing identity
                    LoggerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),

                    // Define the 'CarId' column as a non-nullable integer
                    CarId = table.Column<int>(type: "int", nullable: false),

                    // Define the 'TypeLogger' column as a non-nullable string
                    TypeLogger = table.Column<string>(type: "nvarchar(max)", nullable: false),

                    // Define the 'NumLoggers' column as a non-nullable integer
                    NumLoggers = table.Column<int>(type: "int", nullable: false),

                    // Define the 'LogTime' column as a non-nullable DateTime
                    LogTime = table.Column<DateTime>(type: "datetime2", nullable: false),

                    // Define the 'LogText' column as a non-nullable string
                    LogText = table.Column<string>(type: "nvarchar(max)", nullable: false),

                    // Define the 'Car2Id' column as a nullable integer
                    Car2Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    // Set the 'LoggerId' column as the primary key of the 'Loggers' table
                    table.PrimaryKey("PK_Loggers", x => x.LoggerId);

                    // Create a foreign key constraint on the 'Car2Id' column, referencing the 'Id' column of the 'Car2s' table
                    table.ForeignKey(
                        name: "FK_Loggers_Car2s_Car2Id",
                        column: x => x.Car2Id,
                        principalTable: "Car2s",
                        principalColumn: "Id");

                    // Create a foreign key constraint on the 'CarId' column, referencing the 'Id' column of the 'Cars' table with cascade delete
                    table.ForeignKey(
                        name: "FK_Loggers_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            ////28: Create the 'CarDetail' table with the specified columns
            migrationBuilder.CreateTable(
                name: "CarDetail",
                columns: table => new
                {
                    // Define the 'Id' column as a non-nullable integer with auto-incrementing identity
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),

                    // Define the 'CarId' column as a non-nullable integer
                    CarId = table.Column<int>(type: "int", nullable: false),

                    // Define the 'CarEventId' column as a non-nullable integer
                    CarEventId = table.Column<int>(type: "int", nullable: false),

                    // Define the 'DetailTypeId' column as a non-nullable integer
                    DetailTypeId = table.Column<int>(type: "int", nullable: false),

                    // Define the 'CarEventDetailId' column as a non-nullable integer
                    CarEventDetailId = table.Column<int>(type: "int", nullable: false),

                    // Define the 'DetailId' column as a nullable integer
                    DetailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    // Set the 'Id' column as the primary key of the 'CarDetail' table
                    table.PrimaryKey("PK_CarDetail", x => x.Id);

                    // Create a foreign key constraint on the 'CarId' column, referencing the 'Id' column of the 'Cars' table with cascade delete
                    table.ForeignKey(
                        name: "FK_CarDetail_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            
            ////30: Create the 'CarEvent' table with the specified columns
            migrationBuilder.CreateTable(
                name: "CarEvent",
                columns: table => new
                {
                    // Define the 'CarEventId' column as a non-nullable integer with auto-incrementing identity
                    CarEventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),

                    // Define the 'CarId' column as a non-nullable integer
                    CarId = table.Column<int>(type: "int", nullable: false),

                    // Define the 'EventId' column as a non-nullable integer
                    EventId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    // Set the 'CarEventId' column as the primary key of the 'CarEvent' table
                    table.PrimaryKey("PK_CarEvent", x => x.CarEventId);

                    // Create a foreign key constraint on the 'CarId' column, referencing the 'Id' column of the 'Cars' table with cascade delete
                    table.ForeignKey(
                        name: "FK_CarEvent_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            
            ////31// Creates a table named "CarEventDetail" with columns:
            //-------------------------------------------------
            // "CarEventDetailId" (auto-incrementing primary key of type int),
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
            
            ////32// Creates a table named "CarStatuses" with columns:
            //-------------------------------------------------
            // "Id" (auto-incrementing primary key of type int),
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
            
            ////33// Creates a table named "Detail" with columns:
            //-------------------------------------------------
            // "Id" (auto-incrementing primary key of type int),
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
            
            ////34// Creates a table named "UserDetail" with columns:
            //-------------------------------------------------
            // "Id" (auto-incrementing primary key of type int),
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
            
            ////36// Creates a table named "Timeline" with columns:
            //-------------------------------------------------
            // "Id" (auto-incrementing primary key of type int),
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
            
            ////41// Creates a table named "Events" with columns:
            //-------------------------------------------------
            // "Id" (auto-incrementing primary key of type int),
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

            ////42// Creates a table named "UserEvents" with columns:
            //-------------------------------------------------
            // "Id" (auto-incrementing primary key of type int),
            // "StartTime" (of type DateTime, nullable), "EndTime" (of type DateTime, nullable),
            // "UserId" (of type string, not nullable), "UserDetailId" (of type int, not nullable),
            // "EventId" (of type int, not nullable), "UserEventDetailId" (of type int, not nullable),
            // and "StatusId" (of type int, nullable).
            migrationBuilder.CreateTable(
                name: "UserEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserDetailId = table.Column<int>(type: "int", nullable: false),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    UserEventDetailId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEvents", x => x.Id);
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEvents_UserDetail_UserDetailId",
                        column: x => x.UserDetailId,
                        principalTable: "UserDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            
            ////43// Creates a table named "Statuses" with columns:
            //-------------------------------------------------
            // "StatusId" (auto-incrementing primary key of type int),
            // "StatusName" (of type string, not nullable), and 
            // "UserEventId" (of type int, nullable).
            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEventId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
                    table.ForeignKey(
                        name: "FK_Statuses_UserEvents_UserEventId",
                        column: x => x.UserEventId,
                        principalTable: "UserEvents",
                        principalColumn: "Id");
                });
            
            ////44// Creates a table named "UserEventDetail" with columns:
            //-------------------------------------------------
            // "Id" (auto-incrementing primary key of type int),
            // "CarId" (of type int, nullable),
            // "UserId" (of type string, not nullable),
            // "ApplicationUserId" (of type string, not nullable),
            // "UserEventId" (of type int, not nullable),
            // "UserEventDetailGrandularId" (of type int, not nullable),
            // "TextId" (of type int, not nullable),
            // "DateAdded" (of type DateTime, not nullable),
            // "DetailId" (of type int, nullable), and 
            // "EventId" (of type int, nullable).
            migrationBuilder.CreateTable(
                name: "UserEventDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserEventId = table.Column<int>(type: "int", nullable: false),
                    UserEventDetailGrandularId = table.Column<int>(type: "int", nullable: false),
                    TextId = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DetailId = table.Column<int>(type: "int", nullable: true),
                    EventId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEventDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEventDetail_ApplicationUser_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEventDetail_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
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
                        name: "FK_UserEventDetail_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserEventDetail_UserEvents_UserEventId",
                        column: x => x.UserEventId,
                        principalTable: "UserEvents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            
            ////45// Creates a table named "UserEventDetailText" with columns:
            //-------------------------------------------------
            // "Id" (auto-incrementing primary key of type int),
            // "Text" (of type string, not nullable), and 
            // "UserEventDetailId" (of type int, not nullable).
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
                        onDelete: ReferentialAction.Cascade);
                });
            

            ////// Insert Data

            ///// 46// Inserts initial data into the "DetailTypes" table.
            migrationBuilder.InsertData(
                table: "DetailTypes",
                columns: new[] { "Id", "CarDetailId", "Name" },
                values: new object[,]
                {
                { 1001, null, "Detail1" },
                { 1002, null, "Detail2" },
                { 1003, null, "Detail3" }
                });
            
            ///// 47// Inserts initial data into the "EventTypes" table.
            migrationBuilder.InsertData(
                table: "EventTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                { 1001, "Type1" },
                { 1002, "Type2" },
                { 1003, "Type3" }
                });
            
            ///// 48// Inserts initial data into the "Sources" table.
            migrationBuilder.InsertData(
                table: "Sources",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                { 1001, "MarketBorrow" },
                { 1002, "Owned" },
                { 1003, "Purchased" }
                });
            

            ////// Create Unique Index //////

            //66// Creates a unique index for the "Name" column in the "DetailTypes" table.
            migrationBuilder.CreateIndex(
                name: "IX_DetailTypes_Name",
                table: "DetailTypes",
                column: "Name",
                unique: true);
              
            //76// Creates a unique index for the "RoleId" column in the "RoleEventMappings" table.
            migrationBuilder.CreateIndex(
            name: "IX_RoleEventMappings_RoleId",
            table: "RoleEventMappings",
            column: "RoleId",
            unique: true);
            
            //77// Creates a unique index for the "Name" column in the "Sources" table.
            migrationBuilder.CreateIndex(
            name: "IX_Sources_Name",
            table: "Sources",
            column: "Name",
            unique: true);
            
            //73// Creates a unique index for the "Name" column in the "EventTypes" table.
            migrationBuilder.CreateIndex(
            name: "IX_EventTypes_Name",
            table: "EventTypes",
            column: "Name",
            unique: true);
            
            //79// Creates a unique index for the "TeamId" column in the "TeamTimeline" table.
            migrationBuilder.CreateIndex(
            name: "IX_TeamTimeline_TeamId",
            table: "TeamTimeline",
            column: "TeamId",
            unique: true);
            
            //59// Creates a unique index for the "CarId" column in the "CarStaticDetails" table.
            migrationBuilder.CreateIndex(
                name: "IX_CarStaticDetails_CarId",
                table: "CarStaticDetails",
                column: "CarId",
                unique: true,
                filter: "[CarId] IS NOT NULL");
            
            //92// Creates a unique index for the "DriverStatsId" column in the "UserDetail" table.
            migrationBuilder.CreateIndex(
            name: "IX_UserDetail_DriverStatsId",
            table: "UserDetail",
            column: "DriverStatsId",
            unique: true,
            filter: "[DriverStatsId] IS NOT NULL");
            
            //93// Creates a unique index for the "UserId" column in the "UserDetail" table.
            migrationBuilder.CreateIndex(
            name: "IX_UserDetail_UserId",
            table: "UserDetail",
            column: "UserId",
            unique: true);
            

            ////// Create Index //////

            // 49// Creates an index for the "TeamId" column in the "ApplicationUser" table.
            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_TeamId",
                table: "ApplicationUser",
                column: "TeamId");
            
            // 50// Creates an index for the "CarStaticDetailId" column in the "Car2s" table.
            migrationBuilder.CreateIndex(
                name: "IX_Car2s_CarStaticDetailId",
                table: "Car2s",
                column: "CarStaticDetailId");
            
            // 51// Creates an index for the "CarEventId" column in the "CarDetail" table.
            migrationBuilder.CreateIndex(
                name: "IX_CarDetail_CarEventId",
                table: "CarDetail",
                column: "CarEventId");
            
            // 52// Creates an index for the "CarId" column in the "CarDetail" table.
            migrationBuilder.CreateIndex(
                name: "IX_CarDetail_CarId",
                table: "CarDetail",
                column: "CarId");
            
            // 53// Creates an index for the "DetailId" column in the "CarDetail" table.
            migrationBuilder.CreateIndex(
                name: "IX_CarDetail_DetailId",
                table: "CarDetail",
                column: "DetailId");
            
            // 54// Creates an index for the "CarId" column in the "CarEvent" table.
            migrationBuilder.CreateIndex(
                name: "IX_CarEvent_CarId",
                table: "CarEvent",
                column: "CarId");
            
            // 55// Creates an index for the "EventId" column in the "CarEvent" table.
            migrationBuilder.CreateIndex(
                name: "IX_CarEvent_EventId",
                table: "CarEvent",
                column: "EventId");
            
            // 56// Creates an index for the "CarDetailId" column in the "CarEventDetail" table.
            migrationBuilder.CreateIndex(
                name: "IX_CarEventDetail_CarDetailId",
                table: "CarEventDetail",
                column: "CarDetailId");
            
            // 57// Creates an index for the "CarEventId" column in the "CarEventDetail" table.
            migrationBuilder.CreateIndex(
                name: "IX_CarEventDetail_CarEventId",
                table: "CarEventDetail",
                column: "CarEventId");
            
            // 58// Creates an index for the "SourceId" column in the "Cars" table.
            migrationBuilder.CreateIndex(
                name: "IX_Cars_SourceId",
                table: "Cars",
                column: "SourceId");
            
            // 60// Creates an index for the "CarId" column in the "CarStatuses" table.
            migrationBuilder.CreateIndex(
                name: "IX_CarStatuses_CarId",
                table: "CarStatuses",
                column: "CarId");
            
            // 61// Creates an index for the "StatusId" column in the "CarStatuses" table.
            migrationBuilder.CreateIndex(
                name: "IX_CarStatuses_StatusId",
                table: "CarStatuses",
                column: "StatusId");
            
            // 62// Creates an index for the "ApplicationUserId" column in the "Detail" table.
            migrationBuilder.CreateIndex(
                name: "IX_Detail_ApplicationUserId",
                table: "Detail",
                column: "ApplicationUserId");
            
            // 63// Creates an index for the "DetailTypeId" column in the "Detail" table.
            migrationBuilder.CreateIndex(
                name: "IX_Detail_DetailTypeId",
                table: "Detail",
                column: "DetailTypeId");
            
            // 64// Creates an index for the "UserEventDetailId" column in the "Detail" table.
            migrationBuilder.CreateIndex(
                name: "IX_Detail_UserEventDetailId",
                table: "Detail",
                column: "UserEventDetailId");
            
            // 65// Creates an index for the "CarDetailId" column in the "DetailTypes" table.
            migrationBuilder.CreateIndex(
                name: "IX_DetailTypes_CarDetailId",
                table: "DetailTypes",
                column: "CarDetailId");
            
            
            // 67// Creates an index for the "CarId" column in the "Events" table.
            migrationBuilder.CreateIndex(
                name: "IX_Events_CarId",
                table: "Events",
                column: "CarId");
            
            // 68// Creates an index for the "CategoryId" column in the "Events" table.
            migrationBuilder.CreateIndex(
                name: "IX_Events_CategoryId",
                table: "Events",
                column: "CategoryId");
            
            // 69// Creates an index for the "EventTypeId" column in the "Events" table.
            migrationBuilder.CreateIndex(
                name: "IX_Events_EventTypeId",
                table: "Events",
                column: "EventTypeId");
            
            // 70// Creates an index for the "TeamTimelineId" column in the "Events" table.
            migrationBuilder.CreateIndex(
                name: "IX_Events_TeamTimelineId",
                table: "Events",
                column: "TeamTimelineId");
            
            // 71// Creates an index for the "TimelineId" column in the "Events" table.
            migrationBuilder.CreateIndex(
            name: "IX_Events_TimelineId",
            table: "Events",
            column: "TimelineId");
            
            // 72// Creates an index for the "UserId" column in the "Events" table.
            migrationBuilder.CreateIndex(
            name: "IX_Events_UserId",
            table: "Events",
            column: "UserId");
            
            // 74// Creates an index for the "Car2Id" column in the "Loggers" table.
            migrationBuilder.CreateIndex(
            name: "IX_Loggers_Car2Id",
            table: "Loggers",
            column: "Car2Id");
            
            // 75// Creates an index for the "CarId" column in the "Loggers" table.
            migrationBuilder.CreateIndex(
            name: "IX_Loggers_CarId",
            table: "Loggers",
            column: "CarId");
            
            // 78// Creates an index for the "UserEventId" column in the "Statuses" table.
            migrationBuilder.CreateIndex(
            name: "IX_Statuses_UserEventId",
            table: "Statuses",
            column: "UserEventId");
            
            // 80// Creates an index for the "TicketId" column in the "TicketAttachment" table.
            migrationBuilder.CreateIndex(
            name: "IX_TicketAttachment_TicketId",
            table: "TicketAttachment",
            column: "TicketId");
            
            // 81// Creates an index for the "AuthorId" column in the "Ticke" tablemigrationBuilder.Creat            
            // 82// Creates an index for the "TicketId" column in the "Ticke" tablemigrationBuilder.Creat            
            // 83// Creates an index for the "OwnerId" column in the "TicketHistory" table.
            migrationBuilder.CreateIndex(
            name: "IX_TicketHistory_OwnerId",
            table: "TicketHistory",
            column: "OwnerId");
            
            // 84// Creates an index for the "TicketId" column in the "TicketHistory" table.
            migrationBuilder.CreateIndex(
            name: "IX_TicketHistory_TicketId",
            table: "TicketHistory",
            column: "TicketId");
            
            // 85// Creates an index for the "UserDetailId" column in the "TicketHistory" table.
            migrationBuilder.CreateIndex(
            name: "IX_TicketHistory_UserDetailId",
            table: "TicketHistory",
            column: "UserDetailId");
            
            // 86// Creates an index for the "AssigneeId" column in the "Tickets" table.
            migrationBuilder.CreateIndex(
            name: "IX_Tickets_AssigneeId",
            table: "Tickets",
            column: "AssigneeId");
            
            // 87// Creates an index for the "CreatorId" column in the "Tickets" table.
            migrationBuilder.CreateIndex(
            name: "IX_Tickets_CreatorId",
            table: "Tickets",
            column: "CreatorId");
            
            // 88// Creates an index for the "UserDetailId" column in the "Tickets" table.
            migrationBuilder.CreateIndex(
            name: "IX_Tickets_UserDetailId",
            table: "Tickets",
            column: "UserDetailId");
            
            // 89// Creates an index for the "TicketId" column in the "TicketTag" table.
            migrationBuilder.CreateIndex(
            name: "IX_TicketTag_TicketId",
            table: "TicketTag",
            column: "TicketId");
            
            // 90// Creates an index for the "UserDetailId" column in the "Timeline" table.
            migrationBuilder.CreateIndex(
            name: "IX_Timeline_UserDetailId",
            table: "Timeline",
            column: "UserDetailId");
            
            // 91// Creates an index for the "DetailId" column in the "UserDetail" table.
            migrationBuilder.CreateIndex(
            name: "IX_UserDetail_DetailId",
            table: "UserDetail",
            column: "DetailId");
            
            
            // 94// Creates an index for the "ApplicationUserId" column in the "UserEventDetail" table.
            migrationBuilder.CreateIndex(
            name: "IX_UserEventDetail_ApplicationUserId",
            table: "UserEventDetail",
            column: "ApplicationUserId");
            
            // 95// Creates an index for the "CarId" column in the "UserEventDetail" table.
            migrationBuilder.CreateIndex(
            name: "IX_UserEventDetail_CarId",
            table: "UserEventDetail",
            column: "CarId");
            
            // 96// Creates an index for the "DetailId" column in the "UserEventDetail" table.
            migrationBuilder.CreateIndex(
            name: "IX_UserEventDetail_DetailId",
            table: "UserEventDetail",
            column: "DetailId");
            
            // 97// Creates an index for the "EventId" column in the "UserEventDetail" table.
            migrationBuilder.CreateIndex(
            name: "IX_UserEventDetail_EventId",
            table: "UserEventDetail",
            column: "EventId");
            
            // 98// Creates an index for the "UserEventId" column in the "UserEventDetail" table.
            migrationBuilder.CreateIndex(
            name: "IX_UserEventDetail_UserEventId",
            table: "UserEventDetail",
            column: "UserEventId");
            
            // 99// Creates an index for the "UserId" column in the "UserEventDetail" table.
            migrationBuilder.CreateIndex(
            name: "IX_UserEventDetail_UserId",
            table: "UserEventDetail",
            column: "UserId");
            
            // 100// Creates an index for the "UserEventDetailId" column in the "UserEventDetailText" table.
            migrationBuilder.CreateIndex(
            name: "IX_UserEventDetailText_UserEventDetailId",
            table: "UserEventDetailText",
            column: "UserEventDetailId");
            
            // 101// Creates an index for the "EventId" column in the "UserEvents" table.
            migrationBuilder.CreateIndex(
            name: "IX_UserEvents_EventId",
            table: "UserEvents",
            column: "EventId");
            
            // 102// Creates an index for the "UserDetailId" column in the "UserEvents" table.
            migrationBuilder.CreateIndex(
            name: "IX_UserEvents_UserDetailId",
            table: "UserEvents",
            column: "UserDetailId");
            
            // 103// Creates an index for the "UserId" column in the "UserEvents" table.
            migrationBuilder.CreateIndex(
            name: "IX_UserEvents_UserId",
            table: "UserEvents",
            column: "UserId");
            


            ////// Create ForeignKey Constraint

            // 104// Adds foreign key constraints to the "CarEvent" table referencing the "CarEventId" column.
            migrationBuilder.AddForeignKey(
            name: "FK_CarDetail_CarEvent_CarEventId",
            table: "CarDetail",
            column: "CarEventId",
            principalTable: "CarEvent",
            principalColumn: "CarEventId",
            onDelete: ReferentialAction.Cascade);
            
            // 105// Adds foreign key constraints to the "Detail" table referencing the "Id" column.
            migrationBuilder.AddForeignKey(
            name: "FK_CarDetail_Detail_DetailId",
            table: "CarDetail",
            column: "DetailId",
            principalTable: "Detail",
            principalColumn: "Id");
            
            // 106// Adds foreign key constraints to the "CarEvent" table referencing the "EventId" column.
            migrationBuilder.AddForeignKey(
            name: "FK_CarEvent_Events_EventId",
            table: "CarEvent",
            column: "EventId",
            principalTable: "Events",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
            
            // 107// Adds foreign key constraints to the "Statuses" table referencing the "StatusId" column.
            migrationBuilder.AddForeignKey(
            name: "FK_CarStatuses_Statuses_StatusId",
            table: "CarStatuses",
            column: "StatusId",
            principalTable: "Statuses",
            principalColumn: "StatusId",
            onDelete: ReferentialAction.Cascade);
            
            // 108// Adds foreign key constraints to the "UserEventDetail" table referencing the "UserEventDetailId" column.
            migrationBuilder.AddForeignKey(
            name: "FK_Detail_UserEventDetail_UserEventDetailId",
            table: "Detail",
            column: "UserEventDetailId",
            principalTable: "UserEventDetail",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);


 /*

                        migrationBuilder.CreateTable(
                            name: "UserEvents",
                            columns: table => new
                            {
                                Id = table.Column<int>(type: "int", nullable: false)
                                    .Annotation("SqlServer:Identity", "1, 1"),
                                StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                                EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                                UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                                UserDetailId = table.Column<int>(type: "int", nullable: false),
                                EventId = table.Column<int>(type: "int", nullable: false),
                                UserEventDetailId = table.Column<int>(type: "int", nullable: false),
                                StatusId = table.Column<int>(type: "int", nullable: true)
                            },
                            constraints: table =>
                            {
                                table.PrimaryKey("PK_UserEvents", x => x.Id);
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
                                    onDelete: ReferentialAction.Cascade);
                                table.ForeignKey(
                                    name: "FK_UserEvents_UserDetail_UserDetailId",
                                    column: x => x.UserDetailId,
                                    principalTable: "UserDetail",
                                    principalColumn: "Id",
                                    onDelete: ReferentialAction.Cascade);
                            });

                        migrationBuilder.CreateTable(
                            name: "Statuses",
                            columns: table => new
                            {
                                StatusId = table.Column<int>(type: "int", nullable: false)
                                    .Annotation("SqlServer:Identity", "1, 1"),
                                StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                                UserEventId = table.Column<int>(type: "int", nullable: true)
                            },
                            constraints: table =>
                            {
                                table.PrimaryKey("PK_Statuses", x => x.StatusId);
                                table.ForeignKey(
                                    name: "FK_Statuses_UserEvents_UserEventId",
                                    column: x => x.UserEventId,
                                    principalTable: "UserEvents",
                                    principalColumn: "Id");
                            });

                        migrationBuilder.CreateTable(
                            name: "UserEventDetail",
                            columns: table => new
                            {
                                Id = table.Column<int>(type: "int", nullable: false)
                                    .Annotation("SqlServer:Identity", "1, 1"),
                                CarId = table.Column<int>(type: "int", nullable: true),
                                UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                                ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                                UserEventId = table.Column<int>(type: "int", nullable: false),
                                UserEventDetailGrandularId = table.Column<int>(type: "int", nullable: false),
                                TextId = table.Column<int>(type: "int", nullable: false),
                                DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                                DetailId = table.Column<int>(type: "int", nullable: true),
                                EventId = table.Column<int>(type: "int", nullable: true)
                            },
                            constraints: table =>
                            {
                                table.PrimaryKey("PK_UserEventDetail", x => x.Id);
                                table.ForeignKey(
                                    name: "FK_UserEventDetail_ApplicationUser_ApplicationUserId",
                                    column: x => x.ApplicationUserId,
                                    principalTable: "ApplicationUser",
                                    principalColumn: "Id",
                                    onDelete: ReferentialAction.Cascade);
                                table.ForeignKey(
                                    name: "FK_UserEventDetail_ApplicationUser_UserId",
                                    column: x => x.UserId,
                                    principalTable: "ApplicationUser",
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
                                    name: "FK_UserEventDetail_Events_EventId",
                                    column: x => x.EventId,
                                    principalTable: "Events",
                                    principalColumn: "Id");
                                table.ForeignKey(
                                    name: "FK_UserEventDetail_UserEvents_UserEventId",
                                    column: x => x.UserEventId,
                                    principalTable: "UserEvents",
                                    principalColumn: "Id",
                                    onDelete: ReferentialAction.Cascade);
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
                                    onDelete: ReferentialAction.Cascade);
                            });

                        migrationBuilder.InsertData(
                            table: "DetailTypes",
                            columns: new[] { "Id", "CarDetailId", "Name" },
                            values: new object[,]
                            {
                                { 1001, null, "Detail1" },
                                { 1002, null, "Detail2" },
                                { 1003, null, "Detail3" }
                            });

                        migrationBuilder.InsertData(
                            table: "EventTypes",
                            columns: new[] { "Id", "Name" },
                            values: new object[,]
                            {
                                { 1001, "Type1" },
                                { 1002, "Type2" },
                                { 1003, "Type3" }
                            });

                        migrationBuilder.InsertData(
                            table: "Sources",
                            columns: new[] { "Id", "Name" },
                            values: new object[,]
                            {
                                { 1001, "MarketBorrow" },
                                { 1002, "Owned" },
                                { 1003, "Purchased" }
                            });

                        migrationBuilder.CreateIndex(
                            name: "IX_ApplicationUser_TeamId",
                            table: "ApplicationUser",
                            column: "TeamId");

                        migrationBuilder.CreateIndex(
                            name: "IX_Car2s_CarStaticDetailId",
                            table: "Car2s",
                            column: "CarStaticDetailId");

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
                            name: "IX_CarStaticDetails_CarId",
                            table: "CarStaticDetails",
                            column: "CarId",
                            unique: true,
                            filter: "[CarId] IS NOT NULL");

                        migrationBuilder.CreateIndex(
                            name: "IX_CarStatuses_CarId",
                            table: "CarStatuses",
                            column: "CarId");

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
                            unique: true);

                        migrationBuilder.CreateIndex(
                            name: "IX_Events_CarId",
                            table: "Events",
                            column: "CarId");

                        migrationBuilder.CreateIndex(
                            name: "IX_Events_CategoryId",
                            table: "Events",
                            column: "CategoryId");

                        migrationBuilder.CreateIndex(
                            name: "IX_Events_EventTypeId",
                            table: "Events",
                            column: "EventTypeId");

                        migrationBuilder.CreateIndex(
                            name: "IX_Events_TeamTimelineId",
                            table: "Events",
                            column: "TeamTimelineId");
            */
/*
                        migrationBuilder.CreateTable(
                            name: "CarEvent",
                            columns: table => new
                            {
                                CarEventId = table.Column<int>(type: "int", nullable: false)
                                    .Annotation("SqlServer:Identity", "1, 1"),
                                CarId = table.Column<int>(type: "int", nullable: false),
                                EventId = table.Column<int>(type: "int", nullable: false)
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
                            });*/
            /*
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
                            name: "Ticke",
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
                                table.PrimaryKey("PK_Ticke", x => x.Id);
                  table.ForeignKey(
                                    name: "FK_Ticke_ApplicationUser_AuthorId",
                      column: x => x.AuthorId,
                                    principalTable: "ApplicationUser",
                                    principalColumn: "Id",
                                    onDelete: ReferentialAction.Cascade);
                                table.ForeignKey(
                                    name: "FK_Ticke_Tickets_TicketId",
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
                            });*/

            /*            migrationBuilder.CreateIndex(
                            name: "IX_Events_TimelineId",
                            table: "Events",
                            column: "TimelineId");

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
                            name: "IX_Loggers_Car2Id",
                            table: "Loggers",
                            column: "Car2Id");

                        migrationBuilder.CreateIndex(
                            name: "IX_Loggers_CarId",
                            table: "Loggers",
                            column: "CarId");

                        migrationBuilder.CreateIndex(
                            name: "IX_RoleEventMappings_RoleId",
                            table: "RoleEventMappings",
                            column: "RoleId",
                            unique: true);

                        migrationBuilder.CreateIndex(
                            name: "IX_Sources_Name",
                            table: "Sources",
                            column: "Name",
                            unique: true);

                        migrationBuilder.CreateIndex(
                            name: "IX_Statuses_UserEventId",
                            table: "Statuses",
                            column: "UserEventId");

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
                            name: "IX_Ticke_AuthorId",
              table: "Ticke",
              column: "AuthorId");

                        migrationBuilder.CreateIndex(
                            name: "IX_Ticke_TicketId",
              table: "Ticke",
              column: "TicketId");

                        migrationBuilder.CreateIndex(
                            name: "IX_TicketHistory_OwnerId",
                            table: "TicketHistory",
                            column: "OwnerId");

                        migrationBuilder.CreateIndex(
                            name: "IX_TicketHistory_TicketId",
                            table: "TicketHistory",
                            column: "TicketId");

                        migrationBuilder.CreateIndex(
                            name: "IX_TicketHistory_UserDetailId",
                            table: "TicketHistory",
                            column: "UserDetailId");

                        migrationBuilder.CreateIndex(
                            name: "IX_Tickets_AssigneeId",
                            table: "Tickets",
                            column: "AssigneeId");

                        migrationBuilder.CreateIndex(
                            name: "IX_Tickets_CreatorId",
                            table: "Tickets",
                            column: "CreatorId");

                        migrationBuilder.CreateIndex(
                            name: "IX_Tickets_UserDetailId",
                            table: "Tickets",
                            column: "UserDetailId");

                        migrationBuilder.CreateIndex(
                            name: "IX_TicketTag_TicketId",
                            table: "TicketTag",
                            column: "TicketId");

                        migrationBuilder.CreateIndex(
                            name: "IX_Timeline_UserDetailId",
                            table: "Timeline",
                            column: "UserDetailId");

                        migrationBuilder.CreateIndex(
                            name: "IX_UserDetail_DetailId",
                            table: "UserDetail",
                            column: "DetailId");

                        migrationBuilder.CreateIndex(
                            name: "IX_UserDetail_DriverStatsId",
                            table: "UserDetail",
                            column: "DriverStatsId",
                            unique: true,
                            filter: "[DriverStatsId] IS NOT NULL");

                        migrationBuilder.CreateIndex(
                            name: "IX_UserDetail_UserId",
                            table: "UserDetail",
                            column: "UserId",
                            unique: true);

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

                        migrationBuilder.CreateIndex(
                            name: "IX_UserEvents_EventId",
                            table: "UserEvents",
                            column: "EventId");

                        migrationBuilder.CreateIndex(
                            name: "IX_UserEvents_UserDetailId",
                            table: "UserEvents",
                            column: "UserDetailId");

                        migrationBuilder.CreateIndex(
                            name: "IX_UserEvents_UserId",
                            table: "UserEvents",
                            column: "UserId");

                        migrationBuilder.AddForeignKey(
                            name: "FK_CarDetail_CarEvent_CarEventId",
                            table: "CarDetail",
                            column: "CarEventId",
                            principalTable: "CarEvent",
                            principalColumn: "CarEventId",
                            onDelete: ReferentialAction.Cascade);

                        migrationBuilder.AddForeignKey(
                            name: "FK_CarDetail_Detail_DetailId",
                            table: "CarDetail",
                            column: "DetailId",
                            principalTable: "Detail",
                            principalColumn: "Id");

                        migrationBuilder.AddForeignKey(
                            name: "FK_CarEvent_Events_EventId",
                            table: "CarEvent",
                            column: "EventId",
                            principalTable: "Events",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade);

                        migrationBuilder.AddForeignKey(
                            name: "FK_CarStatuses_Statuses_StatusId",
                            table: "CarStatuses",
                            column: "StatusId",
                            principalTable: "Statuses",
                            principalColumn: "StatusId",
                            onDelete: ReferentialAction.Cascade);

                        migrationBuilder.AddForeignKey(
                            name: "FK_Detail_UserEventDetail_UserEventDetailId",
                            table: "Detail",
                            column: "UserEventDetailId",
                            principalTable: "UserEventDetail",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade);*/
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUser_Team_TeamId",
                table: "ApplicationUser");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamTimeline_Team_TeamId",
                table: "TeamTimeline");

            migrationBuilder.DropForeignKey(
                name: "FK_CarDetail_CarEvent_CarEventId",
                table: "CarDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_CarDetail_Cars_CarId",
                table: "CarDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Cars_CarId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEventDetail_Cars_CarId",
                table: "UserEventDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_CarDetail_Detail_DetailId",
                table: "CarDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDetail_Detail_DetailId",
                table: "UserDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_UserEventDetail_Detail_DetailId",
                table: "UserEventDetail");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "BlankModels");

            migrationBuilder.DropTable(
                name: "CarEventDetail");

            migrationBuilder.DropTable(
                name: "CarStatuses");

            migrationBuilder.DropTable(
                name: "CarStatusNews");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "ErrorLogs");

            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "Loggers");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "RoleEventMappings");

            migrationBuilder.DropTable(
                name: "Softwares");

            migrationBuilder.DropTable(
                name: "TicketAttachment");

            migrationBuilder.Dro
            migrationBuilder.DropTable(
                name: "TicketHistory");

            migrationBuilder.DropTable(
                name: "TicketTag");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserEventDetailText");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserStaticDetail");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Car2s");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "CarStaticDetails");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "CarEvent");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DropTable(
                name: "Detail");

            migrationBuilder.DropTable(
                name: "DetailTypes");

            migrationBuilder.DropTable(
                name: "UserEventDetail");

            migrationBuilder.DropTable(
                name: "CarDetail");

            migrationBuilder.DropTable(
                name: "UserEvents");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.DropTable(
                name: "TeamTimeline");

            migrationBuilder.DropTable(
                name: "Timeline");

            migrationBuilder.DropTable(
                name: "UserDetail");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropTable(
                name: "DriverStats");
        }
    }
}
