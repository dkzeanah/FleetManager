// #31: Create a table named "CarEventDetail" with the following columns
migrationBuilder.CreateTable(
    name: "CarEventDetail",
    columns: table => new
    {
        // #32: Primary key column for the "CarEventDetail" table, auto-incremented
        CarEventDetailId = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #33: Foreign key to the "CarEvent" table, representing the related CarEvent's ID
        CarEventId = table.Column<int>(type: "int", nullable: false),
        // #34: A required note for the CarEventDetail
        Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
        // #35: Foreign key to the "CarDetail" table, representing the related CarDetail's ID (optional)
        CarDetailId = table.Column<int>(type: "int", nullable: true)
    },
    constraints: table =>
    {
        // #36: Set the primary key constraint for the "CarEventDetail" table
        table.PrimaryKey("PK_CarEventDetail", x => x.CarEventDetailId);
        // #37: Define a foreign key relationship to the "CarDetail" table based on the "CarDetailId" column
        table.ForeignKey(
            name: "FK_CarEventDetail_CarDetail_CarDetailId",
            column: x => x.CarDetailId,
            principalTable: "CarDetail",
            principalColumn: "Id");
        // #38: Define a foreign key relationship to the "CarEvent" table based on the "CarEventId" column
        table.ForeignKey(
            name: "FK_CarEventDetail_CarEvent_CarEventId",
            column: x => x.CarEventId,
            principalTable: "CarEvent",
            principalColumn: "CarEventId",
            onDelete: ReferentialAction.Cascade);
    });

// #39: Create a table named "CarStatuses" with the following columns
migrationBuilder.CreateTable(
    name: "CarStatuses",
    columns: table => new
    {
        // #40: Primary key column for the "CarStatuses" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #41: Foreign key to the "Cars" table, representing the related Car's ID
        CarId = table.Column<int>(type: "int", nullable: false),
        // #42: Status ID representing the status of the car
        StatusId = table.Column<int>(type: "int", nullable: false),
        // #43: Nullable time for the car status
        StatusTime = table.Column<DateTime>(type: "datetime2", nullable: true)
    },
    constraints: table =>
    {
        // #44: Set the primary key constraint for the "CarStatuses" table
        table.PrimaryKey("PK_CarStatuses", x => x.Id);
        // #45: Define a foreign key relationship to the "Cars" table based on the "CarId" column
        table.ForeignKey(
            name: "FK_CarStatuses_Cars_CarId",
            column: x => x.CarId,
            principalTable: "Cars",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #46: Create a table named "Detail" with the following columns
migrationBuilder.CreateTable(
    name: "Detail",
    columns: table => new
    {
        // #47: Primary key column for the "Detail" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #48: Foreign key to the "DetailTypes" table, representing the related DetailType's ID
        DetailTypeId = table.Column<int>(type: "int", nullable: false),
        // #49: Value for the detail
        Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
        // #50: Foreign key to the "ApplicationUser" table, representing the related ApplicationUser's ID (optional)
        ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
        // #51: Discriminator column for type inheritance (not nullable)
        Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
        // #52: Text data specific to the "Detail" type (nullable)
        Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
        // #53: User ID related to the "Detail" (nullable)
        UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
        // #54: Foreign key to the "UserEvent" table, representing the related UserEvent's ID (nullable)
        UserEventId = table.Column<int>(type: "int", nullable: true),
        // #55: Foreign key to the "UserEventDetail" table, representing the related UserEventDetail's ID (nullable)
        UserEventDetailId = table.Column<int>(type: "int", nullable: true),
        // #56: Additional note for the "Detail" (nullable)
        Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
    },
    constraints: table =>
    {
        // #57: Set the primary key constraint for the "Detail" table
        table.PrimaryKey("PK_Detail", x => x.Id);
        // #58: Define a foreign key relationship to the "ApplicationUser" table based on the "ApplicationUserId" column
        table.ForeignKey(
            name: "FK_Detail_ApplicationUser_ApplicationUserId",
            column: x => x.ApplicationUserId,
            principalTable: "ApplicationUser",
            principalColumn: "Id");
        // #59: Define a foreign key relationship to the "DetailTypes" table based on the "DetailTypeId" column
        table.ForeignKey(
            name: "FK_Detail_DetailTypes_DetailTypeId",
            column: x => x.DetailTypeId,
            principalTable: "DetailTypes",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #60: Create a table named "UserDetail" with the following columns
migrationBuilder.CreateTable(
    name: "UserDetail",
    columns: table => new
    {
        // #61: Primary key column for the "UserDetail" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #62: Foreign key to the "ApplicationUser" table, representing the related ApplicationUser's ID
        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
        // #63: Foreign key to the "UserEvents" table, representing the related UserEvent's ID
        UserEventsId = table.Column<int>(type: "int", nullable: false),
        // #64: Foreign key to the "DriverStats" table, representing the related DriverStats's ID (optional)
        DriverStatsId = table.Column<int>(type: "int", nullable: true),
        // #65: Foreign key to the "Timeline" table, representing the related Timeline's ID (optional)
        TimelineId = table.Column<int>(type: "int", nullable: true),
        // #66: Foreign key to the "Detail" table, representing the related Detail's ID (optional)
        DetailId = table.Column<int>(type: "int", nullable: true)
    },
    constraints: table =>
    {
        // #67: Set the primary key constraint for the "UserDetail" table
        table.PrimaryKey("PK_UserDetail", x => x.Id);
        // #68: Define a foreign key relationship to the "ApplicationUser" table based on the "UserId" column
        table.ForeignKey(
            name: "FK_UserDetail_ApplicationUser_UserId",
            column: x => x.UserId,
            principalTable: "ApplicationUser",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #69: Define a foreign key relationship to the "Detail" table based on the "DetailId" column
        table.ForeignKey(
            name: "FK_UserDetail_Detail_DetailId",
            column: x => x.DetailId,
            principalTable: "Detail",
            principalColumn: "Id");
        // #70: Define a foreign key relationship to the "DriverStats" table based on the "DriverStatsId" column
        table.ForeignKey(
            name: "FK_UserDetail_DriverStats_DriverStatsId",
            column: x => x.DriverStatsId,
            principalTable: "DriverStats",
            principalColumn: "Id");
    });

// #71: Create a table named "Tickets" with the following columns
migrationBuilder.CreateTable(
    name: "Tickets",
    columns: table => new
    {
        // #72: Primary key column for the "Tickets" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #73: Title for the ticket (required)
        Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
        // #74: Description for the ticket (required)
        Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
        // #75: Foreign key to the "UserDetail" table, representing the related UserDetail's ID
        UserDetailId = table.Column<int>(type: "int", nullable: false),
        // #76: Foreign key to the "ApplicationUser" table, representing the creator's ID
        CreatorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
        // #77: Foreign key to the "ApplicationUser" table, representing the assignee's ID
        AssigneeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
        // #78: Creation date of the ticket
        CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
        // #79: Update date of the ticket (nullable)
        UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
        // #80: Closing date of the ticket (nullable)
        ClosedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
        // #81: Status of the ticket (required)
        Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
        // #82: Severity of the ticket (required)
        Severity = table.Column<string>(type: "nvarchar(max)", nullable: false),
        // #83: Priority of the ticket (required)
        Priority = table.Column<string>(type: "nvarchar(max)", nullable: false)
    },
    constraints: table =>
    {
        // #84: Set the primary key constraint for the "Tickets" table
        table.PrimaryKey("PK_Tickets", x => x.Id);
        // #85: Define a foreign key relationship to the "ApplicationUser" table based on the "AssigneeId" column
        table.ForeignKey(
            name: "FK_Tickets_ApplicationUser_AssigneeId",
            column: x => x.AssigneeId,
            principalTable: "ApplicationUser",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #86: Define a foreign key relationship to the "ApplicationUser" table based on the "CreatorId" column
        table.ForeignKey(
            name: "FK_Tickets_ApplicationUser_CreatorId",
            column: x => x.CreatorId,
            principalTable: "ApplicationUser",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #87: Define a foreign key relationship to the "UserDetail" table based on the "UserDetailId" column
        table.ForeignKey(
            name: "FK_Tickets_UserDetail_UserDetailId",
            column: x => x.UserDetailId,
            principalTable: "UserDetail",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #88: Create a table named "Timeline" with the following columns
migrationBuilder.CreateTable(
    name: "Timeline",
    columns: table => new
    {
        // #89: Primary key column for the "Timeline" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #90: Start date of the timeline (required)
        StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        // #91: End date of the timeline (required)
        EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
        // #92: Foreign key to the "UserDetail" table, representing the related UserDetail's ID
        UserDetailId = table.Column<int>(type: "int", nullable: false)
    },
    constraints: table =>
    {
        // #93: Set the primary key constraint for the "Timeline" table
        table.PrimaryKey("PK_Timeline", x => x.Id);
        // #94: Define a foreign key relationship to the "UserDetail" table based on the "UserDetailId" column
        table.ForeignKey(
            name: "FK_Timeline_UserDetail_UserDetailId",
            column: x => x.UserDetailId,
            principalTable: "UserDetail",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #95: Create a table named "TicketAttachment" with the following columns
migrationBuilder.CreateTable(
    name: "TicketAttachment",
    columns: table => new
    {
        // #96: Primary key column for the "TicketAttachment" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #97: Foreign key to the "Tickets" table, representing the related Ticket's ID
        TicketId = table.Column<int>(type: "int", nullable: false),
        // #98: File path for the ticket attachment (required)
        FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
    },
    constraints: table =>
    {
        // #99: Set the primary key constraint for the "TicketAttachment" table
        table.PrimaryKey("PK_TicketAttachment", x => x.Id);
        // #100: Define a foreign key relationship to the "Tickets" table based on the "TicketId" column
        table.ForeignKey(
            name: "FK_TicketAttachment_Tickets_TicketId",
            column: x => x.TicketId,
            principalTable: "Tickets",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #101: Create a table named "TicketComment" with the following columns
migrationBuilder.CreateTable(
    name: "TicketComment",
    columns: table => new
    {
        // #102: Primary key column for the "TicketComment" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #103: Foreign key to the "Tickets" table, representing the related Ticket's ID
        TicketId = table.Column<int>(type: "int", nullable: false),
        // #104: Content of the comment (required)
        Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
        // #105: Foreign key to the "ApplicationUser" table, representing the author's ID
        AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
        // #106: Creation date of the comment
        CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
    },
    constraints: table =>
    {
        // #107: Set the primary key constraint for the "TicketComment" table
        table.PrimaryKey("PK_TicketComment", x => x.Id);
        // #108: Define a foreign key relationship to the "ApplicationUser" table based on the "AuthorId" column
        table.ForeignKey(
            name: "FK_TicketComment_ApplicationUser_AuthorId",
            column: x => x.AuthorId,
            principalTable: "ApplicationUser",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #109: Define a foreign key relationship to the "Tickets" table based on the "TicketId" column
        table.ForeignKey(
            name: "FK_TicketComment_Tickets_TicketId",
            column: x => x.TicketId,
            principalTable: "Tickets",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #110: Create a table named "TicketHistory" with the following columns
migrationBuilder.CreateTable(
    name: "TicketHistory",
    columns: table => new
    {
        // #111: Primary key column for the "TicketHistory" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #112: Foreign key to the "Tickets" table, representing the related Ticket's ID
        TicketId = table.Column<int>(type: "int", nullable: false),
        // #113: Change made to the ticket (required)
        Change = table.Column<string>(type: "nvarchar(max)", nullable: false),
        // #114: Date of the change
        ChangedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
        // #115: ID of the user who made the change (required)
        ChangedById = table.Column<string>(type: "nvarchar(max)", nullable: false),
        // #116: Foreign key to the "ApplicationUser" table, representing the owner's ID
        OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
        // #117: Foreign key to the "UserDetail" table, representing the related UserDetail's ID
        UserDetailId = table.Column<int>(type: "int", nullable: false)
    },
    constraints: table =>
    {
        // #118: Set the primary key constraint for the "TicketHistory" table
        table.PrimaryKey("PK_TicketHistory", x => x.Id);
        // #119: Define a foreign key relationship to the "ApplicationUser" table based on the "OwnerId" column
        table.ForeignKey(
            name: "FK_TicketHistory_ApplicationUser_OwnerId",
            column: x => x.OwnerId,
            principalTable: "ApplicationUser",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #120: Define a foreign key relationship to the "Tickets" table based on the "TicketId" column
        table.ForeignKey(
            name: "FK_TicketHistory_Tickets_TicketId",
            column: x => x.TicketId,
            principalTable: "Tickets",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #121: Define a foreign key relationship to the "UserDetail" table based on the "UserDetailId" column
        table.ForeignKey(
            name: "FK_TicketHistory_UserDetail_UserDetailId",
            column: x => x.UserDetailId,
            principalTable: "UserDetail",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #122: Create a table named "TicketTag" with the following columns
migrationBuilder.CreateTable(
    name: "TicketTag",
    columns: table => new
    {
        // #123: Primary key column for the "TicketTag" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #124: Foreign key to the "Tickets" table, representing the related Ticket's ID
        TicketId = table.Column<int>(type: "int", nullable: false),
        // #125: Tag for the ticket (required)
        Tag = table.Column<string>(type: "nvarchar(max)", nullable: false)
    },
    constraints: table =>
    {
        // #126: Set the primary key constraint for the "TicketTag" table
        table.PrimaryKey("PK_TicketTag", x => x.Id);
        // #127: Define a foreign key relationship to the "Tickets" table based on the "TicketId" column
        table.ForeignKey(
            name: "FK_TicketTag_Tickets_TicketId",
            column: x => x.TicketId,
            principalTable: "Tickets",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #128: Create a table named "Events" with the following columns
migrationBuilder.CreateTable(
    name: "Events",
    columns: table => new
    {
        // #129: Primary key column for the "Events" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #130: Foreign key to the "Cars" table, representing the related Car's ID
        CarId = table.Column<int>(type: "int", nullable: false),
        // #131: Foreign key to the "EventTypes" table, representing the related EventType's ID
        EventTypeId = table.Column<int>(type: "int", nullable: false),
        // #132: Foreign key to the "ApplicationUser" table, representing the user's ID (optional)
        UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
        // #133: Date of the event (required)
        Date = table.Column<DateTime>(type: "datetime2", nullable: false),
        // #134: Foreign key to the "Category" table, representing the related Category's ID (optional)
        CategoryId = table.Column<int>(type: "int", nullable: true),
        // #135: Foreign key to the "UserDetail" table, representing the related UserDetail's ID (optional)
        UserDetailId = table.Column<int>(type: "int", nullable: true),
        // #136: Description of the event (nullable)
        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
        // #137: Note for the event (nullable)
        Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
        // #138: Additional data for the event (nullable)
        AdditionalData = table.Column<string>(type: "nvarchar(max)", nullable: true)
    },
    constraints: table =>
    {
        // #139: Set the primary key constraint for the "Events" table
        table.PrimaryKey("PK_Events", x => x.Id);
        // #140: Define a foreign key relationship to the "Cars" table based on the "CarId" column
        table.ForeignKey(
            name: "FK_Events_Cars_CarId",
            column: x => x.CarId,
            principalTable: "Cars",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #141: Define a foreign key relationship to the "EventTypes" table based on the "EventTypeId" column
        table.ForeignKey(
            name: "FK_Events_EventTypes_EventTypeId",
            column: x => x.EventTypeId,
            principalTable: "EventTypes",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #142: Define a foreign key relationship to the "ApplicationUser" table based on the "UserId" column
        table.ForeignKey(
            name: "FK_Events_ApplicationUser_UserId",
            column: x => x.UserId,
            principalTable: "ApplicationUser",
            principalColumn: "Id");
        // #143: Define a foreign key relationship to the "Category" table based on the "CategoryId" column
        table.ForeignKey(
            name: "FK_Events_Category_CategoryId",
            column: x => x.CategoryId,
            principalTable: "Category",
            principalColumn: "Id");
        // #144: Define a foreign key relationship to the "UserDetail" table based on the "UserDetailId" column
        table.ForeignKey(
            name: "FK_Events_UserDetail_UserDetailId",
            column: x => x.UserDetailId,
            principalTable: "UserDetail",
            principalColumn: "Id");
    });

// #145: Create a table named "EventDetail" with the following columns
migrationBuilder.CreateTable(
    name: "EventDetail",
    columns: table => new
    {
        // #146: Primary key column for the "EventDetail" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #147: Foreign key to the "Events" table, representing the related Event's ID
        EventId = table.Column<int>(type: "int", nullable: false),
        // #148: Foreign key to the "Detail" table, representing the related Detail's ID
        DetailId = table.Column<int>(type: "int", nullable: false),
        // #149: Value for the event detail (required)
        Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
    },
    constraints: table =>
    {
        // #150: Set the primary key constraint for the "EventDetail" table
        table.PrimaryKey("PK_EventDetail", x => x.Id);
        // #151: Define a foreign key relationship to the "Events" table based on the "EventId" column
        table.ForeignKey(
            name: "FK_EventDetail_Events_EventId",
            column: x => x.EventId,
            principalTable: "Events",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #152: Define a foreign key relationship to the "Detail" table based on the "DetailId" column
        table.ForeignKey(
            name: "FK_EventDetail_Detail_DetailId",
            column: x => x.DetailId,
            principalTable: "Detail",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #153: Create a table named "CarEventDetailStatus" with the following columns
migrationBuilder.CreateTable(
    name: "CarEventDetailStatus",
    columns: table => new
    {
        // #154: Primary key column for the "CarEventDetailStatus" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #155: Foreign key to the "CarEventDetail" table, representing the related CarEventDetail's ID
        CarEventDetailId = table.Column<int>(type: "int", nullable: false),
        // #156: Foreign key to the "DetailStatuses" table, representing the related DetailStatus's ID
        DetailStatusId = table.Column<int>(type: "int", nullable: false)
    },
    constraints: table =>
    {
        // #157: Set the primary key constraint for the "CarEventDetailStatus" table
        table.PrimaryKey("PK_CarEventDetailStatus", x => x.Id);
        // #158: Define a foreign key relationship to the "CarEventDetail" table based on the "CarEventDetailId" column
        table.ForeignKey(
            name: "FK_CarEventDetailStatus_CarEventDetail_CarEventDetailId",
            column: x => x.CarEventDetailId,
            principalTable: "CarEventDetail",
            principalColumn: "CarEventDetailId",
            onDelete: ReferentialAction.Cascade);
        // #159: Define a foreign key relationship to the "DetailStatuses" table based on the "DetailStatusId" column
        table.ForeignKey(
            name: "FK_CarEventDetailStatus_DetailStatuses_DetailStatusId",
            column: x => x.DetailStatusId,
            principalTable: "DetailStatuses",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #160: Create a table named "CarEventTag" with the following columns
migrationBuilder.CreateTable(
    name: "CarEventTag",
    columns: table => new
    {
        // #161: Primary key column for the "CarEventTag" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #162: Foreign key to the "CarEvent" table, representing the related CarEvent's ID
        CarEventId = table.Column<int>(type: "int", nullable: false),
        // #163: Tag for the car event (required)
        Tag = table.Column<string>(type: "nvarchar(max)", nullable: false)
    },
    constraints: table =>
    {
        // #164: Set the primary key constraint for the "CarEventTag" table
        table.PrimaryKey("PK_CarEventTag", x => x.Id);
        // #165: Define a foreign key relationship to the "CarEvent" table based on the "CarEventId" column
        table.ForeignKey(
            name: "FK_CarEventTag_Events_CarEventId",
            column: x => x.CarEventId,
            principalTable: "Events",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #166: Create a table named "CarEventStatus" with the following columns
migrationBuilder.CreateTable(
    name: "CarEventStatus",
    columns: table => new
    {
        // #167: Primary key column for the "CarEventStatus" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #168: Foreign key to the "CarEvent" table, representing the related CarEvent's ID
        CarEventId = table.Column<int>(type: "int", nullable: false),
        // #169: Foreign key to the "EventStatuses" table, representing the related EventStatus's ID
        EventStatusId = table.Column<int>(type: "int", nullable: false)
    },
    constraints: table =>
    {
        // #170: Set the primary key constraint for the "CarEventStatus" table
        table.PrimaryKey("PK_CarEventStatus", x => x.Id);
        // #171: Define a foreign key relationship to the "CarEvent" table based on the "CarEventId" column
        table.ForeignKey(
            name: "FK_CarEventStatus_Events_CarEventId",
            column: x => x.CarEventId,
            principalTable: "Events",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #172: Define a foreign key relationship to the "EventStatuses" table based on the "EventStatusId" column
        table.ForeignKey(
            name: "FK_CarEventStatus_EventStatuses_EventStatusId",
            column: x => x.EventStatusId,
            principalTable: "EventStatuses",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #173: Create a table named "CarEventUser" with the following columns
migrationBuilder.CreateTable(
    name: "CarEventUser",
    columns: table => new
    {
        // #174: Primary key column for the "CarEventUser" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #175: Foreign key to the "CarEvent" table, representing the related CarEvent's ID
        CarEventId = table.Column<int>(type: "int", nullable: false),
        // #176: Foreign key to the "ApplicationUser" table, representing the user's ID
        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
    },
    constraints: table =>
    {
        // #177: Set the primary key constraint for the "CarEventUser" table
        table.PrimaryKey("PK_CarEventUser", x => x.Id);
        // #178: Define a foreign key relationship to the "CarEvent" table based on the "CarEventId" column
        table.ForeignKey(
            name: "FK_CarEventUser_Events_CarEventId",
            column: x => x.CarEventId,
            principalTable: "Events",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #179: Define a foreign key relationship to the "ApplicationUser" table based on the "UserId" column
        table.ForeignKey(
            name: "FK_CarEventUser_ApplicationUser_UserId",
            column: x => x.UserId,
            principalTable: "ApplicationUser",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #180: Create a table named "CarEventAssignedTo" with the following columns
migrationBuilder.CreateTable(
    name: "CarEventAssignedTo",
    columns: table => new
    {
        // #181: Primary key column for the "CarEventAssignedTo" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #182: Foreign key to the "CarEvent" table, representing the related CarEvent's ID
        CarEventId = table.Column<int>(type: "int", nullable: false),
        // #183: Foreign key to the "ApplicationUser" table, representing the assignee's ID
        AssigneeId = table.Column<string>(type: "nvarchar(450)", nullable: false)
    },
    constraints: table =>
    {
        // #184: Set the primary key constraint for the "CarEventAssignedTo" table
        table.PrimaryKey("PK_CarEventAssignedTo", x => x.Id);
        // #185: Define a foreign key relationship to the "CarEvent" table based on the "CarEventId" column
        table.ForeignKey(
            name: "FK_CarEventAssignedTo_Events_CarEventId",
            column: x => x.CarEventId,
            principalTable: "Events",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #186: Define a foreign key relationship to the "ApplicationUser" table based on the "AssigneeId" column
        table.ForeignKey(
            name: "FK_CarEventAssignedTo_ApplicationUser_AssigneeId",
            column: x => x.AssigneeId,
            principalTable: "ApplicationUser",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #187: Create a table named "EventAttachment" with the following columns
migrationBuilder.CreateTable(
    name: "EventAttachment",
    columns: table => new
    {
        // #188: Primary key column for the "EventAttachment" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #189: Foreign key to the "CarEvent" table, representing the related CarEvent's ID
        CarEventId = table.Column<int>(type: "int", nullable: false),
        // #190: File path for the event attachment (required)
        FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
    },
    constraints: table =>
    {
        // #191: Set the primary key constraint for the "EventAttachment" table
        table.PrimaryKey("PK_EventAttachment", x => x.Id);
        // #192: Define a foreign key relationship to the "CarEvent" table based on the "CarEventId" column
        table.ForeignKey(
            name: "FK_EventAttachment_Events_CarEventId",
            column: x => x.CarEventId,
            principalTable: "Events",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #193: Create a table named "EventComment" with the following columns
migrationBuilder.CreateTable(
    name: "EventComment",
    columns: table => new
    {
        // #194: Primary key column for the "EventComment" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #195: Foreign key to the "CarEvent" table, representing the related CarEvent's ID
        CarEventId = table.Column<int>(type: "int", nullable: false),
        // #196: Content of the comment (required)
        Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
        // #197: Foreign key to the "ApplicationUser" table, representing the author's ID
        AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
        // #198: Creation date of the comment
        CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
    },
    constraints: table =>
    {
        // #199: Set the primary key constraint for the "EventComment" table
        table.PrimaryKey("PK_EventComment", x => x.Id);
        // #200: Define a foreign key relationship to the "CarEvent" table based on the "CarEventId" column
        table.ForeignKey(
            name: "FK_EventComment_Events_CarEventId",
            column: x => x.CarEventId,
            principalTable: "Events",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #201: Define a foreign key relationship to the "ApplicationUser" table based on the "AuthorId" column
        table.ForeignKey(
            name: "FK_EventComment_ApplicationUser_AuthorId",
            column: x => x.AuthorId,
            principalTable: "ApplicationUser",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #202: Create a table named "EventTag" with the following columns
migrationBuilder.CreateTable(
    name: "EventTag",
    columns: table => new
    {
        // #203: Primary key column for the "EventTag" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #204: Foreign key to the "CarEvent" table, representing the related CarEvent's ID
        CarEventId = table.Column<int>(type: "int", nullable: false),
        // #205: Tag for the car event (required)
        Tag = table.Column<string>(type: "nvarchar(max)", nullable: false)
    },
    constraints: table =>
    {
        // #206: Set the primary key constraint for the "EventTag" table
        table.PrimaryKey("PK_EventTag", x => x.Id);
        // #207: Define a foreign key relationship to the "CarEvent" table based on the "CarEventId" column
        table.ForeignKey(
            name: "FK_EventTag_Events_CarEventId",
            column: x => x.CarEventId,
            principalTable: "Events",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #208: Create a table named "EventAssignedTo" with the following columns
migrationBuilder.CreateTable(
    name: "EventAssignedTo",
    columns: table => new
    {
        // #209: Primary key column for the "EventAssignedTo" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #210: Foreign key to the "CarEvent" table, representing the related CarEvent's ID
        CarEventId = table.Column<int>(type: "int", nullable: false),
        // #211: Foreign key to the "ApplicationUser" table, representing the assignee's ID
        AssigneeId = table.Column<string>(type: "nvarchar(450)", nullable: false)
    },
    constraints: table =>
    {
        // #212: Set the primary key constraint for the "EventAssignedTo" table
        table.PrimaryKey("PK_EventAssignedTo", x => x.Id);
        // #213: Define a foreign key relationship to the "CarEvent" table based on the "CarEventId" column
        table.ForeignKey(
            name: "FK_EventAssignedTo_Events_CarEventId",
            column: x => x.CarEventId,
            principalTable: "Events",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #214: Define a foreign key relationship to the "ApplicationUser" table based on the "AssigneeId" column
        table.ForeignKey(
            name: "FK_EventAssignedTo_ApplicationUser_AssigneeId",
            column: x => x.AssigneeId,
            principalTable: "ApplicationUser",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #215: Create a table named "EventStatus" with the following columns
migrationBuilder.CreateTable(
    name: "EventStatus",
    columns: table => new
    {
        // #216: Primary key column for the "EventStatus" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #217: Foreign key to the "CarEvent" table, representing the related CarEvent's ID
        CarEventId = table.Column<int>(type: "int", nullable: false),
        // #218: Foreign key to the "EventStatuses" table, representing the related EventStatus's ID
        EventStatusId = table.Column<int>(type: "int", nullable: false)
    },
    constraints: table =>
    {
        // #219: Set the primary key constraint for the "EventStatus" table
        table.PrimaryKey("PK_EventStatus", x => x.Id);
        // #220: Define a foreign key relationship to the "CarEvent" table based on the "CarEventId" column
        table.ForeignKey(
            name: "FK_EventStatus_Events_CarEventId",
            column: x => x.CarEventId,
            principalTable: "Events",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #221: Define a foreign key relationship to the "EventStatuses" table based on the "EventStatusId" column
        table.ForeignKey(
            name: "FK_EventStatus_EventStatuses_EventStatusId",
            column: x => x.EventStatusId,
            principalTable: "EventStatuses",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #222: Create a table named "EventDetailStatus" with the following columns
migrationBuilder.CreateTable(
    name: "EventDetailStatus",
    columns: table => new
    {
        // #223: Primary key column for the "EventDetailStatus" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #224: Foreign key to the "EventDetail" table, representing the related EventDetail's ID
        EventDetailId = table.Column<int>(type: "int", nullable: false),
        // #225: Foreign key to the "DetailStatuses" table, representing the related DetailStatus's ID
        DetailStatusId = table.Column<int>(type: "int", nullable: false)
    },
    constraints: table =>
    {
        // #226: Set the primary key constraint for the "EventDetailStatus" table
        table.PrimaryKey("PK_EventDetailStatus", x => x.Id);
        // #227: Define a foreign key relationship to the "EventDetail" table based on the "EventDetailId" column
        table.ForeignKey(
            name: "FK_EventDetailStatus_EventDetail_EventDetailId",
            column: x => x.EventDetailId,
            principalTable: "EventDetail",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #228: Define a foreign key relationship to the "DetailStatuses" table based on the "DetailStatusId" column
        table.ForeignKey(
            name: "FK_EventDetailStatus_DetailStatuses_DetailStatusId",
            column: x => x.DetailStatusId,
            principalTable: "DetailStatuses",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #229: Create a table named "EventDetailTag" with the following columns
migrationBuilder.CreateTable(
    name: "EventDetailTag",
    columns: table => new
    {
        // #230: Primary key column for the "EventDetailTag" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #231: Foreign key to the "EventDetail" table, representing the related EventDetail's ID
        EventDetailId = table.Column<int>(type: "int", nullable: false),
        // #232: Tag for the event detail (required)
        Tag = table.Column<string>(type: "nvarchar(max)", nullable: false)
    },
    constraints: table =>
    {
        // #233: Set the primary key constraint for the "EventDetailTag" table
        table.PrimaryKey("PK_EventDetailTag", x => x.Id);
        // #234: Define a foreign key relationship to the "EventDetail" table based on the "EventDetailId" column
        table.ForeignKey(
            name: "FK_EventDetailTag_EventDetail_EventDetailId",
            column: x => x.EventDetailId,
            principalTable: "EventDetail",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #235: Create a table named "EventTagStatus" with the following columns
migrationBuilder.CreateTable(
    name: "EventTagStatus",
    columns: table => new
    {
        // #236: Primary key column for the "EventTagStatus" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #237: Foreign key to the "EventTag" table, representing the related EventTag's ID
        EventTagId = table.Column<int>(type: "int", nullable: false),
        // #238: Foreign key to the "TagStatuses" table, representing the related TagStatus's ID
        TagStatusId = table.Column<int>(type: "int", nullable: false)
    },
    constraints: table =>
    {
        // #239: Set the primary key constraint for the "EventTagStatus" table
        table.PrimaryKey("PK_EventTagStatus", x => x.Id);
        // #240: Define a foreign key relationship to the "EventTag" table based on the "EventTagId" column
        table.ForeignKey(
            name: "FK_EventTagStatus_EventTag_EventTagId",
            column: x => x.EventTagId,
            principalTable: "EventTag",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #241: Define a foreign key relationship to the "TagStatuses" table based on the "TagStatusId" column
        table.ForeignKey(
            name: "FK_EventTagStatus_TagStatuses_TagStatusId",
            column: x => x.TagStatusId,
            principalTable: "TagStatuses",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #242: Create a table named "EventCommentStatus" with the following columns
migrationBuilder.CreateTable(
    name: "EventCommentStatus",
    columns: table => new
    {
        // #243: Primary key column for the "EventCommentStatus" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #244: Foreign key to the "EventComment" table, representing the related EventComment's ID
        EventCommentId = table.Column<int>(type: "int", nullable: false),
        // #245: Foreign key to the "CommentStatuses" table, representing the related CommentStatus's ID
        CommentStatusId = table.Column<int>(type: "int", nullable: false)
    },
    constraints: table =>
    {
        // #246: Set the primary key constraint for the "EventCommentStatus" table
        table.PrimaryKey("PK_EventCommentStatus", x => x.Id);
        // #247: Define a foreign key relationship to the "EventComment" table based on the "EventCommentId" column
        table.ForeignKey(
            name: "FK_EventCommentStatus_EventComment_EventCommentId",
            column: x => x.EventCommentId,
            principalTable: "EventComment",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #248: Define a foreign key relationship to the "CommentStatuses" table based on the "CommentStatusId" column
        table.ForeignKey(
            name: "FK_EventCommentStatus_CommentStatuses_CommentStatusId",
            column: x => x.CommentStatusId,
            principalTable: "CommentStatuses",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #249: Create a table named "CarEventComment" with the following columns
migrationBuilder.CreateTable(
    name: "CarEventComment",
    columns: table => new
    {
        // #250: Primary key column for the "CarEventComment" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #251: Foreign key to the "CarEvent" table, representing the related CarEvent's ID
        CarEventId = table.Column<int>(type: "int", nullable: false),
        // #252: Foreign key to the "EventComment" table, representing the related EventComment's ID
        EventCommentId = table.Column<int>(type: "int", nullable: false)
    },
    constraints: table =>
    {
        // #253: Set the primary key constraint for the "CarEventComment" table
        table.PrimaryKey("PK_CarEventComment", x => x.Id);
        // #254: Define a foreign key relationship to the "CarEvent" table based on the "CarEventId" column
        table.ForeignKey(
            name: "FK_CarEventComment_Events_CarEventId",
            column: x => x.CarEventId,
            principalTable: "Events",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #255: Define a foreign key relationship to the "EventComment" table based on the "EventCommentId" column
        table.ForeignKey(
            name: "FK_CarEventComment_EventComment_EventCommentId",
            column: x => x.EventCommentId,
            principalTable: "EventComment",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #256: Create a table named "CarEventDetail" with the following columns
migrationBuilder.CreateTable(
    name: "CarEventDetail",
    columns: table => new
    {
        // #257: Primary key column for the "CarEventDetail" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #258: Foreign key to the "CarEvent" table, representing the related CarEvent's ID
        CarEventId = table.Column<int>(type: "int", nullable: false),
        // #259: Foreign key to the "EventDetail" table, representing the related EventDetail's ID
        EventDetailId = table.Column<int>(type: "int", nullable: false)
    },
    constraints: table =>
    {
        // #260: Set the primary key constraint for the "CarEventDetail" table
        table.PrimaryKey("PK_CarEventDetail", x => x.Id);
        // #261: Define a foreign key relationship to the "CarEvent" table based on the "CarEventId" column
        table.ForeignKey(
            name: "FK_CarEventDetail_Events_CarEventId",
            column: x => x.CarEventId,
            principalTable: "Events",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #262: Define a foreign key relationship to the "EventDetail" table based on the "EventDetailId" column
        table.ForeignKey(
            name: "FK_CarEventDetail_EventDetail_EventDetailId",
            column: x => x.EventDetailId,
            principalTable: "EventDetail",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #263: Create a table named "CarEventTag" with the following columns
migrationBuilder.CreateTable(
    name: "CarEventTag",
    columns: table => new
    {
        // #264: Primary key column for the "CarEventTag" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #265: Foreign key to the "CarEvent" table, representing the related CarEvent's ID
        CarEventId = table.Column<int>(type: "int", nullable: false),
        // #266: Foreign key to the "EventTag" table, representing the related EventTag's ID
        EventTagId = table.Column<int>(type: "int", nullable: false)
    },
    constraints: table =>
    {
        // #267: Set the primary key constraint for the "CarEventTag" table
        table.PrimaryKey("PK_CarEventTag", x => x.Id);
        // #268: Define a foreign key relationship to the "CarEvent" table based on the "CarEventId" column
        table.ForeignKey(
            name: "FK_CarEventTag_Events_CarEventId",
            column: x => x.CarEventId,
            principalTable: "Events",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #269: Define a foreign key relationship to the "EventTag" table based on the "EventTagId" column
        table.ForeignKey(
            name: "FK_CarEventTag_EventTag_EventTagId",
            column: x => x.EventTagId,
            principalTable: "EventTag",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #270: Create a table named "CarEventStatus" with the following columns
migrationBuilder.CreateTable(
    name: "CarEventStatus",
    columns: table => new
    {
        // #271: Primary key column for the "CarEventStatus" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #272: Foreign key to the "CarEvent" table, representing the related CarEvent's ID
        CarEventId = table.Column<int>(type: "int", nullable: false),
        // #273: Foreign key to the "EventStatus" table, representing the related EventStatus's ID
        EventStatusId = table.Column<int>(type: "int", nullable: false)
    },
    constraints: table =>
    {
        // #274: Set the primary key constraint for the "CarEventStatus" table
        table.PrimaryKey("PK_CarEventStatus", x => x.Id);
        // #275: Define a foreign key relationship to the "CarEvent" table based on the "CarEventId" column
        table.ForeignKey(
            name: "FK_CarEventStatus_Events_CarEventId",
            column: x => x.CarEventId,
            principalTable: "Events",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #276: Define a foreign key relationship to the "EventStatus" table based on the "EventStatusId" column
        table.ForeignKey(
            name: "FK_CarEventStatus_EventStatuses_EventStatusId",
            column: x => x.EventStatusId,
            principalTable: "EventStatus",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #277: Create a table named "CarEventUser" with the following columns
migrationBuilder.CreateTable(
    name: "CarEventUser",
    columns: table => new
    {
        // #278: Primary key column for the "CarEventUser" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #279: Foreign key to the "CarEvent" table, representing the related CarEvent's ID
        CarEventId = table.Column<int>(type: "int", nullable: false),
        // #280: Foreign key to the "ApplicationUser" table, representing the user's ID
        UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
    },
    constraints: table =>
    {
        // #281: Set the primary key constraint for the "CarEventUser" table
        table.PrimaryKey("PK_CarEventUser", x => x.Id);
        // #282: Define a foreign key relationship to the "CarEvent" table based on the "CarEventId" column
        table.ForeignKey(
            name: "FK_CarEventUser_Events_CarEventId",
            column: x => x.CarEventId,
            principalTable: "Events",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #283: Define a foreign key relationship to the "ApplicationUser" table based on the "UserId" column
        table.ForeignKey(
            name: "FK_CarEventUser_ApplicationUser_UserId",
            column: x => x.UserId,
            principalTable: "ApplicationUser",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #284: Create a table named "CarEventAssignedTo" with the following columns
migrationBuilder.CreateTable(
    name: "CarEventAssignedTo",
    columns: table => new
    {
        // #285: Primary key column for the "CarEventAssignedTo" table, auto-incremented
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        // #286: Foreign key to the "CarEvent" table, representing the related CarEvent's ID
        CarEventId = table.Column<int>(type: "int", nullable: false),
        // #287: Foreign key to the "ApplicationUser" table, representing the assignee's ID
        AssigneeId = table.Column<string>(type: "nvarchar(450)", nullable: false)
    },
    constraints: table =>
    {
        // #288: Set the primary key constraint for the "CarEventAssignedTo" table
        table.PrimaryKey("PK_CarEventAssignedTo", x => x.Id);
        // #289: Define a foreign key relationship to the "CarEvent" table based on the "CarEventId" column
        table.ForeignKey(
            name: "FK_CarEventAssignedTo_Events_CarEventId",
            column: x => x.CarEventId,
            principalTable: "Events",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
        // #290: Define a foreign key relationship to the "ApplicationUser" table based on the "AssigneeId" column
        table.ForeignKey(
            name: "FK_CarEventAssignedTo_ApplicationUser_AssigneeId",
            column: x => x.AssigneeId,
            principalTable: "ApplicationUser",
            principalColumn: "Id",
            onDelete: ReferentialAction.Cascade);
    });

// #291: Create an index on the "CarEventAssignedTo" table for the "CarEventId" column
migrationBuilder.CreateIndex(
    name: "IX_CarEventAssignedTo_CarEventId",
    table: "CarEventAssignedTo",
    column: "CarEventId");

// #292: Create an index on the "CarEventAssignedTo" table for the "AssigneeId" column
migrationBuilder.CreateIndex(
    name: "IX_CarEventAssignedTo_AssigneeId",
    table: "CarEventAssignedTo",
    column: "AssigneeId");

// #293: Create an index on the "CarEventComment" table for the "CarEventId" column
migrationBuilder.CreateIndex(
    name: "IX_CarEventComment_CarEventId",
    table: "CarEventComment",
    column: "CarEventId");

// #294: Create an index on the "CarEventComment" table for the "EventCommentId" column
migrationBuilder.CreateIndex(
    name: "IX_CarEventComment_EventCommentId",
    table: "CarEventComment",
    column: "EventCommentId");

// #295: Create an index on the "CarEventDetail" table for the "CarEventId" column
migrationBuilder.CreateIndex(
    name: "IX_CarEventDetail_CarEventId",
    table: "CarEventDetail",
    column: "CarEventId");

// #296: Create an index on the "CarEventDetail" table for the "EventDetailId" column
migrationBuilder.CreateIndex(
    name: "IX_CarEventDetail_EventDetailId",
    table: "CarEventDetail",
    column: "EventDetailId");

// #297: Create an index on the "CarEventTag" table for the "CarEventId" column
migrationBuilder.CreateIndex(
    name: "IX_CarEventTag_CarEventId",
    table: "CarEventTag",
    column: "CarEventId");

// #298: Create an index on the "CarEventTag" table for the "EventTagId" column
migrationBuilder.CreateIndex(
    name: "IX_CarEventTag_EventTagId",
    table: "CarEventTag",
    column: "EventTagId");

// #299: Create an index on the "CarEventStatus" table for the "CarEventId" column
migrationBuilder.CreateIndex(
    name: "IX_CarEventStatus_CarEventId",
    table: "CarEventStatus",
    column: "CarEventId");

// #300: Create an index on the "CarEventStatus" table for the "EventStatusId" column
migrationBuilder.CreateIndex(
    name: "IX_CarEventStatus_EventStatusId",
    table: "CarEventStatus",
    column: "EventStatusId");

// #301: Create an index on the "CarEventUser" table for the "CarEventId" column
migrationBuilder.CreateIndex(
    name: "IX_CarEventUser_CarEventId",
    table: "CarEventUser",
    column: "CarEventId");

// #302: Create an index on the "CarEventUser" table for the "UserId" column
migrationBuilder.CreateIndex(
    name: "IX_CarEventUser_UserId",
    table: "CarEventUser",
    column: "UserId");

// #303: Create an index on the "EventAssignedTo" table for the "CarEventId" column
migrationBuilder.CreateIndex(
    name: "IX_EventAssignedTo_CarEventId",
    table: "EventAssignedTo",
    column: "CarEventId");

// #304: Create an index on the "EventAssignedTo" table for the "AssigneeId" column
migrationBuilder.CreateIndex(
    name: "IX_EventAssignedTo_AssigneeId",
    table: "EventAssignedTo",
    column: "AssigneeId");

// #305: Create an index on the "EventCommentStatus" table for the "EventCommentId" column
migrationBuilder.CreateIndex(
    name: "IX_EventCommentStatus_EventCommentId",
    table: "EventCommentStatus",
    column: "EventCommentId");

// #306: Create an index on the "EventCommentStatus" table for the "CommentStatusId" column
migrationBuilder.CreateIndex(
    name: "IX_EventCommentStatus_CommentStatusId",
    table: "EventCommentStatus",
    column: "CommentStatusId");

// #307: Create an index on the "EventDetailStatus" table for the "EventDetailId" column
migrationBuilder.CreateIndex(
    name: "IX_EventDetailStatus_EventDetailId",
    table: "EventDetailStatus",
    column: "EventDetailId");

// #308: Create an index on the "EventDetailStatus" table for the "DetailStatusId" column
migrationBuilder.CreateIndex(
    name: "IX_EventDetailStatus_DetailStatusId",
    table: "EventDetailStatus",
    column: "DetailStatusId");

// #309: Create an index on the "EventTagStatus" table for the "EventTagId" column
migrationBuilder.CreateIndex(
    name: "IX_EventTagStatus_EventTagId",
    table: "EventTagStatus",
    column: "EventTagId");

// #310: Create an index on the "EventTagStatus" table for the "TagStatusId" column
migrationBuilder.CreateIndex(
    name: "IX_EventTagStatus_TagStatusId",
    table: "EventTagStatus",
    column: "TagStatusId");

// #311: Create an index on the "EventStatus" table for the "CarEventId" column
migrationBuilder.CreateIndex(
    name: "IX_EventStatus_CarEventId",
    table: "EventStatus",
    column: "CarEventId");

// #312: Create an index on the "EventStatus" table for the "EventStatusId" column
migrationBuilder.CreateIndex(
    name: "IX_EventStatus_EventStatusId",
    table: "EventStatus",
    column: "EventStatusId");
