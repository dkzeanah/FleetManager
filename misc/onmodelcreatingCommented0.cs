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
            //no dependancy tables


            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
                   
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
                name: "Blank",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    String = table.Column<string>(type: "nvarchar(max)", nullable: false)


                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlankModels", x => x.Id);
                });
            migrationBuilder.CreateTable(
                name: "DetailTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),

                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailTypes", x => x.Id);

                });
            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
/*                    CarId = table.Column<int>(type: "int", nullable: true) // add CarId column to Sources table
*/
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                    /*table.ForeignKey(
                        name: "FK_Sources_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id");*/
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
            migrationBuilder.CreateTable(
                name: "MasterLogs",
                columns: table => new
                {
                    MasterLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.MasterLogId);
                });
           
            // onmodelcreating: driver organizer, admin, contact, technician, boss, delegate
            // each user can maintain multiple
            //**** Make unique index on id and name
            ////12// Creates a table named "AspNetRoles" with four columns: 
            //-------------------------------------------------------
            // "Id" (of type string, not nullable),
            // "Name" (of type string, nullable), 
            // "NormalizedName" (of type string, nullable),
            // "ConcurrencyStamp" (of type string, nullable).
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            //single dependancy tables

             ////22: Create the 'ApplicationUser' table with the specified columns
                    // Define the 'Id' column as a string with a maximum length of 450 characters
                    // Define the 'FriendlyName' column as a nullable string
                    // Define the 'FirstName' column as a nullable string
                    // Define the 'LastName' column as a nullable string
                    // callsign
                    // Define the 'TeamId' column as a non-nullable integer
                    // Define the 'UserName' column as a nullable string
            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),

                    FriendlyName = table.Column<string>(type: "nvarchar(max)", nullable: False),

                    CallSign = table.Column<string>(type: "nvarchar(50)", nullable: true),

                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),

                    TeamId = table.Column<int>(type: "int", nullable: true),

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

                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    VehicleArea = table.Column<string>(type: "nvarchar(max)", nullable: false),

                    ExpertiseCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);

                });

            migrationBuilder.CreateTable(
    name: "Softwares",
    columns: table => new
    {
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        CarId = table.Column<int>(type: "int", nullable: false),
        Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
        SoftwareVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
        NextSoftwareVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
        UploadDate = table.Column<DateTime>(type: "datetime2", nullable: true),
        FutureUploadDate = table.Column<DateTime>(type: "datetime2", nullable: true)
    },
    constraints: table =>
    {
        table.PrimaryKey("PK_Softwares", x => x.Id);
    });


            //////  Identity and such //////
            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                    name: "AspNetUserLogins",
                    columns: table => new
                    {
                        LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                        ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                        ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                        table.ForeignKey(
                            name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                            column: x => x.UserId,
                            principalTable: "AspNetUsers",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade);
                    });
            migrationBuilder.CreateTable(
                    name: "AspNetRoleClaims",
                    columns: table => new
                    {
                        Id = table.Column<int>(type: "int", nullable: false)
                            .Annotation("SqlServer:Identity", "1, 1"),
                        RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                        ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                        ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                        table.ForeignKey(
                            name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                            column: x => x.RoleId,
                            principalTable: "AspNetRoles",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Cascade);
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
                    name: "AspNetUserClaims",
                    columns: table => new
                    {
                        Id = table.Column<int>(type: "int", nullable: false)
                            .Annotation("SqlServer:Identity", "1, 1"),
                        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                        ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                        ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                        table.ForeignKey(
                            name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                            column: x => x.UserId,
                            principalTable: "AspNetUsers",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade);
                    });
            migrationBuilder.CreateTable(
                    name: "AspNetUserLogins",
                    columns: table => new
                    {
                        LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                        ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                        ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                        table.ForeignKey(
                            name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                            column: x => x.UserId,
                            principalTable: "AspNetUsers",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade);
                    });
            migrationBuilder.CreateTable(
                    name: "AspNetRoleClaims",
                    columns: table => new
                    {
                        Id = table.Column<int>(type: "int", nullable: false)
                            .Annotation("SqlServer:Identity", "1, 1"),
                        RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                        ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                        ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                        table.ForeignKey(
                            name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                            column: x => x.RoleId,
                            principalTable: "AspNetRoles",
                            principalColumn: "Id",
                            onDelete: ReferentialAction.Cascade);
                    });

            //////  Identity and such \//////


            //car 
                    // 'CarLogId' - nullable integer
                    // 'CarStatusId' - nullable integer
                            // 'Miles' - nullable integer
                            // 'Location' - nullable string
                            // 'UserId' - nullable string
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),

                    Name = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Make = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    TeleGeneration = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Vin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Finas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adas = table.Column<bool>(type: "bit", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                });
                //status Miles = table.Column<int>(type: "int", nullable: true),
                //status Location = table.Column<string>(type: "nvarchar(50)", nullable: true),
                //status UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                // CarDetail = table.Column<int>(type: "int", nullable: true),
                //CarStatusId = table.Column<int>(type: "int", nullable: true),

            //2// Creates a table named "CarStatusTypes" with three columns: "Id" (auto-incrementing primary key of type int),
            // "StatusId" (of type int, not nullable), and "StatusName" (of type string, not nullable).
            // Statuses mapped to 
            migrationBuilder.CreateTable(
                name: "CarStatusTypes",
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



/////////////////

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
            
        
        //doublecheck FK to CarId
            migrationBuilder.CreateTable(
                name: "Loggers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),

                    CarId = table.Column<int>(type: "int", nullable: true),

                    TypeLogger = table.Column<string>(type: "nvarchar(max)", nullable: false),

                    NumberAvailable = table.Column<int>(type: "int", nullable: false),
                    NumberTotal = table.Column<int>(type: "int", nullable: false),

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loggers", x => x.LoggerId);

                    

                    table.ForeignKey(
                        name: "FK_Loggers_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            //40// Creates a table named "TicketTag" with columns:
            //-------------------------------------------------
            // "Id" (auto-incrementing primary key of type int),
            // "TicketId" (of type int, not nullable),
            // "Tag" (of type string, not nullable).
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
            
            


            // 2+ dependancy tables
            //
            //



            // make sure configured with event table to be done
            //////30: Create the 'CarEvent' table with the specified columns
                    // join table:
                    // 'CarId' column as a non-nullable integer
                    // 'EventId' column as a non-nullable integer
                        
            migrationBuilder.CreateTable(
                name: "CarEvent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
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
                });
            





             //CarDetail - the pinnacle complex
            ////28: Create the 'CarDetail' table with the specified columns
                    // Define the 'Id' column as a non-nullable integer with auto-incrementing identity
                    // Define the 'CarId' column as a non-nullable integer
                    // Define the 'CarEventId' column as a non-nullable integer
                    // Define the 'DetailTypeId' column as a non-nullable integer
                    // Define the 'CarEventDetailId' column as a non-nullable integer
                    // Define the 'DetailId' column as a nullable integer
                    // Set the 'Id' column as the primary key of the 'CarDetail' table
                    // Create a foreign key constraint on the 'CarId' column, referencing the 'Id' column of the 'Cars' table with cascade delete
            migrationBuilder.CreateTable(
                name: "CarDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),

                    CarEventId = table.Column<int>(type: "int", nullable: false),

                    DetailTypeId = table.Column<int>(type: "int", nullable: false),

                    CarEventDetailId = table.Column<int>(type: "int", nullable: false),
                    //CarEvent and CarDetail with a string value ascribed

                    DetailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDetail", x => x.Id);

                    table.ForeignKey(
                        name: "FK_CarDetail_Cars_CarId",
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarEventId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
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


           //
           ////33// Creates a table named "Detail" with columns:
            //-------------------------------------------------
            // "Id" (auto-incrementing primary key of type int),
            // "DetailTypeId" (of type int, not nullable), 
            // "Value" (of type string, not nullable),
            // "ApplicationUserId" (of type string, nullable),
            // "Discriminator" (of type string, not nullable),
            // "Text" (of type string, nullable),
            // "UserId" (of type string, nullable),
            // "UserEventId" (of type int, nullable),
            // "UserEventDetailId" (of type int, nullable).
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


           
            

                //log tables
            migrationBuilder.CreateTable(
                name: "CarLog",
                columns: table => new
                {
                    CarLogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarId = table.Column<int>(nullable: false),
                    Action = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                    // Other properties to log about Car
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarLog", x => x.CarLogId);
                    table.ForeignKey(
                        name: "FK_CarLog_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLog",
                columns: table => new
                {
                    UserLogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Action = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                    // Other properties to log about User
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLog", x => x.UserLogId);
                    table.ForeignKey(
                        name: "FK_UserLog_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventLog",
                columns: table => new
                {
                    EventLogId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(nullable: false),
                    Action = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false)
                    // Other properties to log about Event
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventLog", x => x.EventLogId);
                    table.ForeignKey(
                        name: "FK_EventLog_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            //status tables
            //merge
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
            migrationBuilder.CreateTable(
                name: "CarStatus",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    // Other dynamic properties of Car
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarStatus", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_CarStatus_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserStatus",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    // Other dynamic properties of User
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStatus", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UserStatus_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventStatus",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    // Other dynamic properties of Event
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventStatus", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_EventStatus_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });
            


            // join tables

            //usercar
            migrationBuilder.CreateTable(
                name: "UserCar",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    CarId = table.Column<int>(nullable: false),
                    // Other properties about the User and Car relationship
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCar", x => new { x.UserId, x.CarId });
                    table.ForeignKey(
                        name: "FK_UserCar_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCar_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                });


            //userevent
            migrationBuilder.CreateTable(
    name: "UserEvent",
    columns: table => new
    {
        UserId = table.Column<int>(nullable: false),
        EventId = table.Column<int>(nullable: false),
        // Other properties about the User and Event relationship
    },
    constraints: table =>
    {
        table.PrimaryKey("PK_UserEvent", x => new { x.UserId, x.EventId });
        table.ForeignKey(
            name: "FK_UserEvent_User_UserId",
            column: x => x.UserId,
            principalTable: "User",
            principalColumn: "UserId",
            onDelete: ReferentialAction.Cascade);
        table.ForeignKey(
            name: "FK_UserEvent_Event_EventId",
            column: x => x.EventId,
            principalTable: "Event",
            principalColumn: "EventId",
            onDelete: ReferentialAction.Cascade);
    });


            // CarEvent
            migrationBuilder.CreateTable(
                name: "CarEvent",
                columns: table => new
                {
                    CarId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false),
                    // Other properties about the Car and Event relationship
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarEvent", x => new { x.CarId, x.EventId });
                    table.ForeignKey(
                        name: "FK_CarEvent_Car_CarId",
                        column: x => x.CarId,
                        principalTable: "Car",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarEvent_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });






            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });


            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });




            //expand this to include the metrics able to be tracked from a 'car test drive' perspective.
            // hours logged, number errors found, stops, etc
            // driver id should be natural key, of UserId. table holds stats of user
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

            
            
           
            
            
            //await this - other migrations
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
           
             //37// Creates a table named "TicketComment" with columns:
                // #102: Primary key column for the "TicketComment" table, auto-incremented
                // #103: Foreign key to the "Tickets" table, representing the related Ticket's ID
                // #104: Content of the comment (required)
                // #105: Foreign key to the "ApplicationUser" table, representing the author's ID
                // #106: Creation date of the comment
                // #107: Set the primary key constraint for the "TicketComment" table
                     // #108: Define a foreign key relationship to the "ApplicationUser" table based on the "AuthorId" column
                    // #109: Define a foreign key relationship to the "Tickets" table based on the "TicketId" column
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
                table.PrAppimaryKey("PK_TicketComment", x => x.Id);
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
                    
               //???/39// Creates a table named "TicketHistory" with columns:
            //-------------------------------------------------
            // "Id" (auto-incrementing primary key of type int),
            // "TicketId" (of type int, not nullable), 
            // "Change" (of type string, not nullable),
            // "ChangedAt" (of type DateTime, not nullable), 
            // "ChangedById" (of type string, not nullable),
            // and "OwnerId" (of type string, not nullable).
            // UserDetailId
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


           
            //
            //
            //
            // 3 or more depenandancy tables

            ////34// Creates a table named "UserDetail" with columns:
            //-------------------------------------------------
            // "Id" (auto-incrementing primary key of type int),
            // "UserId" (of type string, not nullable),
            // "UserEventsId" (of type int, not nullable),
            // "DriverStatsId" (of type int, nullable),
            // "TimelineId" (of type int, nullable), 
            // "DetailId" (of type int, nullable).
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
            
             ////42// Creates a table named "UserEvents" with columns:
            //-------------------------------------------------
            // "Id" (auto-incrementing primary key of type int),
            // "StartTime" (of type DateTime, nullable), "EndTime" (of type DateTime, nullable),
            // "UserId" (of type string, not nullable), "UserDetailId" (of type int, not nullable),
            // "EventId" (of type int, not nullable), "UserEventDetailId" (of type int, not nullable),
            // "StatusId" (of type int, nullable).
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
                name: "TimelineDate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timeline", x => x.Id);
                    
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
                    EventTypeId = table.Column<int>(type: "int", nullable: false),

                    CarId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),

                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
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
            


            
            //40
            
           
            
           
            
          
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
            
            //*** needed?  
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
        //50
            //73// Creates a unique index for the "Name" column in the "EventTypes" table.
            migrationBuilder.CreateIndex(
            name: "IX_EventTypes_Name",
            table: "EventTypes",
            column: "Name",
            unique: true);
            
            //*** needed?
            //79// Creates a unique index for the "TeamId" column in the "TeamTimeline" table.
            migrationBuilder.CreateIndex(
            name: "IX_TeamTimeline_TeamId",
            table: "TeamTimeline",
            column: "TeamId",
            unique: true);
            
            //*** ensure 1to1 map
            //59// Creates a unique index for the "CarId" column in the "CarStaticDetails" table.
            migrationBuilder.CreateIndex(
                name: "IX_CarStaticDetails_CarId",
                table: "CarStaticDetails",
                column: "CarId",
                unique: true,
                filter: "[CarId] IS NOT NULL");
            
            //*** ???
            //92// Creates a unique index for the "DriverStatsId" column in the "UserDetail" table.
            migrationBuilder.CreateIndex(
            name: "IX_UserDetail_DriverStatsId",
            table: "UserDetail",
            column: "DriverStatsId",
            unique: true,
            filter: "[DriverStatsId] IS NOT NULL");
            
            //*** not needed??
            //93// Creates a unique index for the "UserId" column in the "UserDetail" table.
            migrationBuilder.CreateIndex(
            name: "IX_UserDetail_UserId",
            table: "UserDetail",
            column: "UserId",
            unique: true);
            

            ////// Create Index //////

            // Indexes should be utilized for frequent query filtering on index or joining etc
            // strongly consider not having these?

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
        //60
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
