
            migrationBuilder.CreateIndex(
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
                name: "IX_TicketComment_AuthorId",
                table: "TicketComment",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_TicketComment_TicketId",
                table: "TicketComment",
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
                onDelete: ReferentialAction.Cascade);



// Comment 71:
// Creates an index for the "TimelineId" column in the "Events" table.
migrationBuilder.CreateIndex(
name: "IX_Events_TimelineId",
table: "Events",
column: "TimelineId");

// Comment 72:
// Creates an index for the "UserId" column in the "Events" table.
migrationBuilder.CreateIndex(
name: "IX_Events_UserId",
table: "Events",
column: "UserId");

// Comment 73:
// Creates a unique index for the "Name" column in the "EventTypes" table.
migrationBuilder.CreateIndex(
name: "IX_EventTypes_Name",
table: "EventTypes",
column: "Name",
unique: true);

// Comment 74:
// Creates an index for the "Car2Id" column in the "Loggers" table.
migrationBuilder.CreateIndex(
name: "IX_Loggers_Car2Id",
table: "Loggers",
column: "Car2Id");

// Comment 75:
// Creates an index for the "CarId" column in the "Loggers" table.
migrationBuilder.CreateIndex(
name: "IX_Loggers_CarId",
table: "Loggers",
column: "CarId");

// Comment 76:
// Creates a unique index for the "RoleId" column in the "RoleEventMappings" table.
migrationBuilder.CreateIndex(
name: "IX_RoleEventMappings_RoleId",
table: "RoleEventMappings",
column: "RoleId",
unique: true);

// Comment 77:
// Creates a unique index for the "Name" column in the "Sources" table.
migrationBuilder.CreateIndex(
name: "IX_Sources_Name",
table: "Sources",
column: "Name",
unique: true);

// Comment 78:
// Creates an index for the "UserEventId" column in the "Statuses" table.
migrationBuilder.CreateIndex(
name: "IX_Statuses_UserEventId",
table: "Statuses",
column: "UserEventId");

// Comment 79:
// Creates a unique index for the "TeamId" column in the "TeamTimeline" table.
migrationBuilder.CreateIndex(
name: "IX_TeamTimeline_TeamId",
table: "TeamTimeline",
column: "TeamId",
unique: true);

// Comment 80:
// Creates an index for the "TicketId" column in the "TicketAttachment" table.
migrationBuilder.CreateIndex(
name: "IX_TicketAttachment_TicketId",
table: "TicketAttachment",
column: "TicketId");

// Comment 81:
// Creates an index for the "AuthorId" column in the "TicketComment" table.
migrationBuilder.CreateIndex(
name: "IX_TicketComment_AuthorId",
table: "TicketComment",
column: "AuthorId");

// Comment 82:
// Creates an index for the "TicketId" column in the "TicketComment" table.
migrationBuilder.CreateIndex(
name: "IX_TicketComment_TicketId",
table: "TicketComment",
column: "TicketId");

// Comment 83:
// Creates an index for the "OwnerId" column in the "TicketHistory" table.
migrationBuilder.CreateIndex(
name: "IX_TicketHistory_OwnerId",
table: "TicketHistory",
column: "OwnerId");

// Comment 84:
// Creates an index for the "TicketId" column in the "TicketHistory" table.
migrationBuilder.CreateIndex(
name: "IX_TicketHistory_TicketId",
table: "TicketHistory",
column: "TicketId");

// Comment 85:
// Creates an index for the "UserDetailId" column in the "TicketHistory" table.
migrationBuilder.CreateIndex(
name: "IX_TicketHistory_UserDetailId",
table: "TicketHistory",
column: "UserDetailId");

// Comment 86:
// Creates an index for the "AssigneeId" column in the "Tickets" table.
migrationBuilder.CreateIndex(
name: "IX_Tickets_AssigneeId",
table: "Tickets",
column: "AssigneeId");

// Comment 87:
// Creates an index for the "CreatorId" column in the "Tickets" table.
migrationBuilder.CreateIndex(
name: "IX_Tickets_CreatorId",
table: "Tickets",
column: "CreatorId");

// Comment 88:
// Creates an index for the "UserDetailId" column in the "Tickets" table.
migrationBuilder.CreateIndex(
name: "IX_Tickets_UserDetailId",
table: "Tickets",
column: "UserDetailId");

// Comment 89:
// Creates an index for the "TicketId" column in the "TicketTag" table.
migrationBuilder.CreateIndex(
name: "IX_TicketTag_TicketId",
table: "TicketTag",
column: "TicketId");

// Comment 90:
// Creates an index for the "UserDetailId" column in the "Timeline" table.
migrationBuilder.CreateIndex(
name: "IX_Timeline_UserDetailId",
table: "Timeline",
column: "UserDetailId");

// Comment 91:
// Creates an index for the "DetailId" column in the "UserDetail" table.
migrationBuilder.CreateIndex(
name: "IX_UserDetail_DetailId",
table: "UserDetail",
column: "DetailId");

// Comment 92:
// Creates a unique index for the "DriverStatsId" column in the "UserDetail" table.
migrationBuilder.CreateIndex(
name: "IX_UserDetail_DriverStatsId",
table: "UserDetail",
column: "DriverStatsId",
unique: true,
filter: "[DriverStatsId] IS NOT NULL");

// Comment 93:
// Creates a unique index for the "UserId" column in the "UserDetail" table.
migrationBuilder.CreateIndex(
name: "IX_UserDetail_UserId",
table: "UserDetail",
column: "UserId",
unique: true);

// Comment 94:
// Creates an index for the "ApplicationUserId" column in the "UserEventDetail" table.
migrationBuilder.CreateIndex(
name: "IX_UserEventDetail_ApplicationUserId",
table: "UserEventDetail",
column: "ApplicationUserId");

// Comment 95:
// Creates an index for the "CarId" column in the "UserEventDetail" table.
migrationBuilder.CreateIndex(
name: "IX_UserEventDetail_CarId",
table: "UserEventDetail",
column: "CarId");

// Comment 96:
// Creates an index for the "DetailId" column in the "UserEventDetail" table.
migrationBuilder.CreateIndex(
name: "IX_UserEventDetail_DetailId",
table: "UserEventDetail",
column: "DetailId");

// Comment 97:
// Creates an index for the "EventId" column in the "UserEventDetail" table.
migrationBuilder.CreateIndex(
name: "IX_UserEventDetail_EventId",
table: "UserEventDetail",
column: "EventId");

// Comment 98:
// Creates an index for the "UserEventId" column in the "UserEventDetail" table.
migrationBuilder.CreateIndex(
name: "IX_UserEventDetail_UserEventId",
table: "UserEventDetail",
column: "UserEventId");

// Comment 99:
// Creates an index for the "UserId" column in the "UserEventDetail" table.
migrationBuilder.CreateIndex(
name: "IX_UserEventDetail_UserId",
table: "UserEventDetail",
column: "UserId");

// Comment 100:
// Creates an index for the "UserEventDetailId" column in the "UserEventDetailText" table.
migrationBuilder.CreateIndex(
name: "IX_UserEventDetailText_UserEventDetailId",
table: "UserEventDetailText",
column: "UserEventDetailId");

// Comment 101:
// Creates an index for the "EventId" column in the "UserEvents" table.
migrationBuilder.CreateIndex(
name: "IX_UserEvents_EventId",
table: "UserEvents",
column: "EventId");

// Comment 102:
// Creates an index for the "UserDetailId" column in the "UserEvents" table.
migrationBuilder.CreateIndex(
name: "IX_UserEvents_UserDetailId",
table: "UserEvents",
column: "UserDetailId");

// Comment 103:
// Creates an index for the "UserId" column in the "UserEvents" table.
migrationBuilder.CreateIndex(
name: "IX_UserEvents_UserId",
table: "UserEvents",
column: "UserId");

// Comment 104:
// Adds foreign key constraints to the "CarEvent" table referencing the "CarEventId" column.
migrationBuilder.AddForeignKey(
name: "FK_CarDetail_CarEvent_CarEventId",
table: "CarDetail",
column: "CarEventId",
principalTable: "CarEvent",
principalColumn: "CarEventId",
onDelete: ReferentialAction.Cascade);

// Comment 105:
// Adds foreign key constraints to the "Detail" table referencing the "Id" column.
migrationBuilder.AddForeignKey(
name: "FK_CarDetail_Detail_DetailId",
table: "CarDetail",
column: "DetailId",
principalTable: "Detail",
principalColumn: "Id");

// Comment 106:
// Adds foreign key constraints to the "CarEvent" table referencing the "EventId" column.
migrationBuilder.AddForeignKey(
name: "FK_CarEvent_Events_EventId",
table: "CarEvent",
column: "EventId",
principalTable: "Events",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);

// Comment 107:
// Adds foreign key constraints to the "Statuses" table referencing the "StatusId" column.
migrationBuilder.AddForeignKey(
name: "FK_CarStatuses_Statuses_StatusId",
table: "CarStatuses",
column: "StatusId",
principalTable: "Statuses",
principalColumn: "StatusId",
onDelete: ReferentialAction.Cascade);

// Comment 108:
// Adds foreign key constraints to the "UserEventDetail" table referencing the "UserEventDetailId" column.
migrationBuilder.AddForeignKey(
name: "FK_Detail_UserEventDetail_UserEventDetailId",
table: "Detail",
column: "UserEventDetailId",
principalTable: "UserEventDetail",
principalColumn: "Id",
onDelete: ReferentialAction.Cascade);