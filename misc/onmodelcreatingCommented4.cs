

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




///
        // Comment 42:
        // Creates a table named "UserEvents" with columns "Id" (auto-incrementing primary key of type int),
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

        // Comment 43:
        // Creates a table named "Statuses" with columns "StatusId" (auto-incrementing primary key of type int),
        // "StatusName" (of type string, not nullable), and "UserEventId" (of type int, nullable).
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

        // Comment 44:
        // Creates a table named "UserEventDetail" with columns "Id" (auto-incrementing primary key of type int),
        // "CarId" (of type int, nullable), "UserId" (of type string, not nullable),
        // "ApplicationUserId" (of type string, not nullable), "UserEventId" (of type int, not nullable),
        // "UserEventDetailGrandularId" (of type int, not nullable), "TextId" (of type int, not nullable),
        // "DateAdded" (of type DateTime, not nullable), "DetailId" (of type int, nullable),
        // and "EventId" (of type int, nullable).
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

        // Comment 45:
        // Creates a table named "UserEventDetailText" with columns "Id" (auto-incrementing primary key of type int),
        // "Text" (of type string, not nullable), and "UserEventDetailId" (of type int, not nullable).
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

        // Comment 46:
        // Inserts initial data into the "DetailTypes" table.
        migrationBuilder.InsertData(
            table: "DetailTypes",
            columns: new[] { "Id", "CarDetailId", "Name" },
            values: new object[,]
            {
                { 1001, null, "Detail1" },
                { 1002, null, "Detail2" },
                { 1003, null, "Detail3" }
            });

        // Comment 47:
        // Inserts initial data into the "EventTypes" table.
        migrationBuilder.InsertData(
            table: "EventTypes",
            columns: new[] { "Id", "Name" },
            values: new object[,]
            {
                { 1001, "Type1" },
                { 1002, "Type2" },
                { 1003, "Type3" }
            });

        // Comment 48:
        // Inserts initial data into the "Sources" table.
        migrationBuilder.InsertData(
            table: "Sources",
            columns: new[] { "Id", "Name" },
            values: new object[,]
            {
                { 1001, "MarketBorrow" },
                { 1002, "Owned" },
                { 1003, "Purchased" }
            });

        // Comment 49:
        // Creates an index for the "TeamId" column in the "ApplicationUser" table.
        migrationBuilder.CreateIndex(
            name: "IX_ApplicationUser_TeamId",
            table: "ApplicationUser",
            column: "TeamId");

        // Comment 50:
        // Creates an index for the "CarStaticDetailId" column in the "Car2s" table.
        migrationBuilder.CreateIndex(
            name: "IX_Car2s_CarStaticDetailId",
            table: "Car2s",
            column: "CarStaticDetailId");

        // Comment 51:
        // Creates an index for the "CarEventId" column in the "CarDetail" table.
        migrationBuilder.CreateIndex(
            name: "IX_CarDetail_CarEventId",
            table: "CarDetail",
            column: "CarEventId");

        // Comment 52:
        // Creates an index for the "CarId" column in the "CarDetail" table.
        migrationBuilder.CreateIndex(
            name: "IX_CarDetail_CarId",
            table: "CarDetail",
            column: "CarId");

        // Comment 53:
        // Creates an index for the "DetailId" column in the "CarDetail" table.
        migrationBuilder.CreateIndex(
            name: "IX_CarDetail_DetailId",
            table: "CarDetail",
            column: "DetailId");

        // Comment 54:
        // Creates an index for the "CarId" column in the "CarEvent" table.
        migrationBuilder.CreateIndex(
            name: "IX_CarEvent_CarId",
            table: "CarEvent",
            column: "CarId");

        // Comment 55:
        // Creates an index for the "EventId" column in the "CarEvent" table.
        migrationBuilder.CreateIndex(
            name: "IX_CarEvent_EventId",
            table: "CarEvent",
            column: "EventId");

        // Comment 56:
        // Creates an index for the "CarDetailId" column in the "CarEventDetail" table.
        migrationBuilder.CreateIndex(
            name: "IX_CarEventDetail_CarDetailId",
            table: "CarEventDetail",
            column: "CarDetailId");

        // Comment 57:
        // Creates an index for the "CarEventId" column in the "CarEventDetail" table.
        migrationBuilder.CreateIndex(
            name: "IX_CarEventDetail_CarEventId",
            table: "CarEventDetail",
            column: "CarEventId");

        // Comment 58:
        // Creates an index for the "SourceId" column in the "Cars" table.
        migrationBuilder.CreateIndex(
            name: "IX_Cars_SourceId",
            table: "Cars",
            column: "SourceId");

        // Comment 59:
        // Creates a unique index for the "CarId" column in the "CarStaticDetails" table.
        migrationBuilder.CreateIndex(
            name: "IX_CarStaticDetails_CarId",
            table: "CarStaticDetails",
            column: "CarId",
            unique: true,
            filter: "[CarId] IS NOT NULL");

        // Comment 60:
        // Creates an index for the "CarId" column in the "CarStatuses" table.
        migrationBuilder.CreateIndex(
            name: "IX_CarStatuses_CarId",
            table: "CarStatuses",
            column: "CarId");

        // Comment 61:
        // Creates an index for the "StatusId" column in the "CarStatuses" table.
        migrationBuilder.CreateIndex(
            name: "IX_CarStatuses_StatusId",
            table: "CarStatuses",
            column: "StatusId");

        // Comment 62:
        // Creates an index for the "ApplicationUserId" column in the "Detail" table.
        migrationBuilder.CreateIndex(
            name: "IX_Detail_ApplicationUserId",
            table: "Detail",
            column: "ApplicationUserId");

        // Comment 63:
        // Creates an index for the "DetailTypeId" column in the "Detail" table.
        migrationBuilder.CreateIndex(
            name: "IX_Detail_DetailTypeId",
            table: "Detail",
            column: "DetailTypeId");

        // Comment 64:
        // Creates an index for the "UserEventDetailId" column in the "Detail" table.
        migrationBuilder.CreateIndex(
            name: "IX_Detail_UserEventDetailId",
            table: "Detail",
            column: "UserEventDetailId");

        // Comment 65:
        // Creates an index for the "CarDetailId" column in the "DetailTypes" table.
        migrationBuilder.CreateIndex(
            name: "IX_DetailTypes_CarDetailId",
            table: "DetailTypes",
            column: "CarDetailId");

        // Comment 66:
        // Creates a unique index for the "Name" column in the "DetailTypes" table.
        migrationBuilder.CreateIndex(
            name: "IX_DetailTypes_Name",
            table: "DetailTypes",
            column: "Name",
            unique: true);

        // Comment 67:
        // Creates an index for the "CarId" column in the "Events" table.
        migrationBuilder.CreateIndex(
            name: "IX_Events_CarId",
            table: "Events",
            column: "CarId");

        // Comment 68:
        // Creates an index for the "CategoryId" column in the "Events" table.
        migrationBuilder.CreateIndex(
            name: "IX_Events_CategoryId",
            table: "Events",
            column: "CategoryId");

        // Comment 69:
        // Creates an index for the "EventTypeId" column in the "Events" table.
        migrationBuilder.CreateIndex(
            name: "IX_Events_EventTypeId",
            table: "Events",
            column: "EventTypeId");

        // Comment 70:
        // Creates an index for the "TeamTimelineId" column in the "Events" table.
        migrationBuilder.CreateIndex(
            name: "IX_Events_TeamTimelineId",
            table: "Events",
            column: "TeamTimelineId");
        
        // ... (Continued) [The rest of the comments are omitted for brevity.]
