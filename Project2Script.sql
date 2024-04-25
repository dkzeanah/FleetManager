IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [ApplicationUser] (
    [Id] nvarchar(450) NOT NULL,
    [FriendlyName] nvarchar(max) NOT NULL,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [UserName] nvarchar(max) NULL,
    [NormalizedUserName] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [NormalizedEmail] nvarchar(max) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_ApplicationUser] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Cars] (
    [CarId] int NOT NULL IDENTITY,
    [Make] nvarchar(max) NULL,
    [Model] nvarchar(max) NULL,
    [Year] int NULL,
    [TeleGeneration] nvarchar(max) NULL,
    [Miles] int NULL,
    [Location] nvarchar(max) NULL,
    [SourceId] int NULL,
    [UserId] nvarchar(max) NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY ([CarId])
);
GO

CREATE TABLE [CarStatus_New] (
    [StatusID] int NOT NULL,
    [StatusName] nvarchar(50) NOT NULL,
    CONSTRAINT [PK__CarStatu__C8EE2043D8294AF0] PRIMARY KEY ([StatusID])
);
GO

CREATE TABLE [Category] (
    [CategoryId] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [DefaultPriority] int NOT NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY ([CategoryId])
);
GO

CREATE TABLE [Drivers] (
    [DriverId] int NOT NULL IDENTITY,
    [DrivingHours] decimal(18,2) NOT NULL,
    CONSTRAINT [PK_Drivers] PRIMARY KEY ([DriverId])
);
GO

CREATE TABLE [ErrorLog] (
    [ErrorID] int NOT NULL IDENTITY,
    [CarID] int NOT NULL,
    [ErrorDetails] nvarchar(255) NULL,
    [ErrorPriority] int NULL,
    [ErrorNotes] nvarchar(255) NULL,
    CONSTRAINT [PK__ErrorLog__358565CA8BB277F2] PRIMARY KEY ([ErrorID])
);
GO

CREATE TABLE [EventType] (
    [EventTypeID] int NOT NULL IDENTITY,
    [Id] int NOT NULL,
    [EventId] int NOT NULL,
    [Name] nvarchar(50) NOT NULL,
    CONSTRAINT [PK__EventTyp__A9216B1F734774DB] PRIMARY KEY ([EventTypeID])
);
GO

CREATE TABLE [Issues] (
    [IssueId] int NOT NULL IDENTITY,
    [Summary] nvarchar(max) NOT NULL,
    [Status] nvarchar(max) NOT NULL,
    [Priority] nvarchar(max) NOT NULL,
    [AssignedTo] nvarchar(max) NOT NULL,
    [System] nvarchar(max) NOT NULL,
    [ModifiedBy] nvarchar(max) NOT NULL,
    [ModifiedAt] nvarchar(max) NOT NULL,
    [ModifiedByUser] nvarchar(max) NOT NULL,
    [SubmittedBy] nvarchar(max) NOT NULL,
    [SubmittedAt] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Issues] PRIMARY KEY ([IssueId])
);
GO

CREATE TABLE [Log] (
    [LogID] int NOT NULL IDENTITY,
    [LogMessage] nvarchar(255) NOT NULL,
    [LogTime] datetime NULL DEFAULT ((getdate())),
    CONSTRAINT [PK__Log__5E5499A88878D432] PRIMARY KEY ([LogID])
);
GO

CREATE TABLE [PlaceholderUserRole] (
    [RoleID] int NOT NULL IDENTITY,
    [RoleName] nvarchar(50) NOT NULL,
    CONSTRAINT [PK__Placehol__8AFACE3A8A46317E] PRIMARY KEY ([RoleID])
);
GO

CREATE TABLE [RoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(max) NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_RoleClaims] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Roles] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(max) NULL,
    [NormalizedName] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Software] (
    [SoftwareID] int NOT NULL IDENTITY,
    [CarID] int NOT NULL,
    [HeadUnit] nvarchar(50) NOT NULL,
    [SoftwareVersion] nvarchar(50) NOT NULL,
    [NextSoftwareVersion] nvarchar(50) NOT NULL,
    CONSTRAINT [PK__Software__25EDB8DCFDCE01A5] PRIMARY KEY ([SoftwareID])
);
GO

CREATE TABLE [Source] (
    [SourceID] int NOT NULL IDENTITY,
    [SourceName] nvarchar(50) NULL,
    CONSTRAINT [PK__Source__16E019F99EE16562] PRIMARY KEY ([SourceID])
);
GO

CREATE TABLE [Status] (
    [StatusID] int NOT NULL,
    [StatusName] nvarchar(50) NOT NULL,
    CONSTRAINT [PK__Status__C8EE2043906DCC08] PRIMARY KEY ([StatusID])
);
GO

CREATE TABLE [Temp_ErrorLog] (
    [ErrorID] int NOT NULL IDENTITY,
    [CarID] int NOT NULL,
    [ErrorDetails] nvarchar(255) NULL,
    [ErrorPriority] int NULL,
    [ErrorNotes] nvarchar(255) NULL
);
GO

CREATE TABLE [Temp_Event] (
    [EventID] int NOT NULL IDENTITY,
    [CarID] int NOT NULL,
    [UserID] int NOT NULL,
    [EventTypeID] int NOT NULL,
    [StartTime] datetime NOT NULL,
    [EndTime] datetime NOT NULL
);
GO

CREATE TABLE [Temp_Logger] (
    [LoggerID] int NOT NULL IDENTITY,
    [CarID] int NOT NULL,
    [TypeLogger] nvarchar(50) NOT NULL,
    [NumLoggers] int NOT NULL
);
GO

CREATE TABLE [Temp_Repair] (
    [RepairID] int NOT NULL IDENTITY,
    [CarID] int NOT NULL,
    [TechnicianID] int NOT NULL,
    [RepairDetails] nvarchar(255) NOT NULL,
    [RepairStart] datetime NOT NULL,
    [RepairEnd] datetime NOT NULL
);
GO

CREATE TABLE [Temp_Software] (
    [SoftwareID] int NOT NULL IDENTITY,
    [CarID] int NOT NULL,
    [HeadUnit] nvarchar(50) NOT NULL,
    [SoftwareVersion] nvarchar(50) NOT NULL,
    [NextSoftwareVersion] nvarchar(50) NOT NULL
);
GO

CREATE TABLE [UserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(max) NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_UserClaims] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [UserLogins] (
    [LoginProvider] nvarchar(450) NOT NULL,
    [ProviderKey] nvarchar(450) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(max) NULL,
    CONSTRAINT [PK_UserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey])
);
GO

CREATE TABLE [UserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_UserRoles] PRIMARY KEY ([UserId], [RoleId])
);
GO

CREATE TABLE [UserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(450) NOT NULL,
    [Name] nvarchar(450) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_UserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name])
);
GO

CREATE TABLE [ApplicationUserDetail] (
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_ApplicationUserDetail] PRIMARY KEY ([UserId]),
    CONSTRAINT [FK_ApplicationUserDetail_ApplicationUser_UserId] FOREIGN KEY ([UserId]) REFERENCES [ApplicationUser] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Tickets] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NOT NULL,
    [Description] nvarchar(max) NOT NULL,
    [CreatorId] nvarchar(450) NOT NULL,
    [AssigneeId] nvarchar(450) NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NULL,
    [ClosedAt] datetime2 NULL,
    [Status] nvarchar(max) NOT NULL,
    [Severity] nvarchar(max) NOT NULL,
    [Priority] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Tickets] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Tickets_ApplicationUser_AssigneeId] FOREIGN KEY ([AssigneeId]) REFERENCES [ApplicationUser] ([Id]),
    CONSTRAINT [FK_Tickets_ApplicationUser_CreatorId] FOREIGN KEY ([CreatorId]) REFERENCES [ApplicationUser] ([Id])
);
GO

CREATE TABLE [CarStaticDetails] (
    [CarStaticDetailId] int NOT NULL IDENTITY,
    [CarId] int NOT NULL,
    [Tag] nvarchar(max) NOT NULL,
    [Finas] nvarchar(max) NOT NULL,
    [VinLast4] nvarchar(max) NOT NULL,
    [HarnessStatus] nvarchar(max) NULL,
    [FullVin] nvarchar(max) NULL,
    [SoftwareVersion] nvarchar(max) NULL,
    [Adas] nvarchar(max) NULL,
    CONSTRAINT [PK_CarStaticDetails] PRIMARY KEY ([CarStaticDetailId]),
    CONSTRAINT [FK_CarStaticDetails_Cars_CarId] FOREIGN KEY ([CarId]) REFERENCES [Cars] ([CarId])
);
GO

CREATE TABLE [Logger] (
    [LoggerID] int NOT NULL IDENTITY,
    [CarID] int NOT NULL,
    [TypeLogger] nvarchar(50) NOT NULL,
    [NumLoggers] int NOT NULL,
    CONSTRAINT [PK__Logger__0ABCCA66A1861B17] PRIMARY KEY ([LoggerID]),
    CONSTRAINT [FK__Logger__CarID__5224328E] FOREIGN KEY ([CarID]) REFERENCES [Cars] ([CarId])
);
GO

CREATE TABLE [AspNetRoles] (
    [Id] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetRoles_Roles_Id] FOREIGN KEY ([Id]) REFERENCES [Roles] ([Id])
);
GO

CREATE TABLE [CarStatus] (
    [CarID] int NOT NULL,
    [StatusID] int NOT NULL,
    [StatusTime] datetime NULL,
    CONSTRAINT [FK__CarStatus__CarID__498EEC8D] FOREIGN KEY ([CarID]) REFERENCES [Cars] ([CarId]),
    CONSTRAINT [FK__CarStatus__Statu__4A8310C6] FOREIGN KEY ([StatusID]) REFERENCES [Status] ([StatusID])
);
GO

CREATE TABLE [PlaceholderUser] (
    [Id] nvarchar(450) NOT NULL,
    [RoleId] int NOT NULL,
    [PlaceholderUserDetailUserId] nvarchar(450) NULL,
    [UserName] nvarchar(max) NULL,
    [NormalizedUserName] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [NormalizedEmail] nvarchar(max) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_PlaceholderUser] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PlaceholderUser_ApplicationUserDetail_PlaceholderUserDetailUserId] FOREIGN KEY ([PlaceholderUserDetailUserId]) REFERENCES [ApplicationUserDetail] ([UserId]),
    CONSTRAINT [FK_PlaceholderUser_PlaceholderUserRole_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [PlaceholderUserRole] ([RoleID])
);
GO

CREATE TABLE [TicketAttachment] (
    [Id] int NOT NULL IDENTITY,
    [TicketId] int NOT NULL,
    [FilePath] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_TicketAttachment] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TicketAttachment_Tickets_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [Tickets] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [TicketComment] (
    [Id] int NOT NULL IDENTITY,
    [TicketId] int NOT NULL,
    [Content] nvarchar(max) NOT NULL,
    [AuthorId] nvarchar(450) NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    CONSTRAINT [PK_TicketComment] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TicketComment_ApplicationUser_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [ApplicationUser] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_TicketComment_Tickets_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [Tickets] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [TicketHistory] (
    [Id] int NOT NULL IDENTITY,
    [TicketId] int NOT NULL,
    [Change] nvarchar(max) NOT NULL,
    [ChangedAt] datetime2 NOT NULL,
    [ChangedById] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_TicketHistory] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TicketHistory_ApplicationUser_ChangedById] FOREIGN KEY ([ChangedById]) REFERENCES [ApplicationUser] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_TicketHistory_Tickets_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [Tickets] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [TicketTag] (
    [Id] int NOT NULL IDENTITY,
    [TicketId] int NOT NULL,
    [Tag] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_TicketTag] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TicketTag_Tickets_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [Tickets] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [Event] (
    [EventID] int NOT NULL IDENTITY,
    [CarID] int NOT NULL,
    [EventTypeID] int NOT NULL,
    [UserID] nvarchar(450) NOT NULL,
    [CategoryId] int NOT NULL,
    [StartTime] datetime NULL,
    [EndTime] datetime NULL,
    [Date] datetime2 NOT NULL,
    [Type] nvarchar(max) NOT NULL,
    [PlaceholderUserId] nvarchar(450) NULL,
    CONSTRAINT [PK__Event__7944C870D4DB1DAC] PRIMARY KEY ([EventID]),
    CONSTRAINT [FK_Event_ApplicationUser_UserID] FOREIGN KEY ([UserID]) REFERENCES [ApplicationUser] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Event_Category_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Category] ([CategoryId]) ON DELETE CASCADE,
    CONSTRAINT [FK_Event_PlaceholderUser_PlaceholderUserId] FOREIGN KEY ([PlaceholderUserId]) REFERENCES [PlaceholderUser] ([Id]),
    CONSTRAINT [FK__Event__EventType__1CBC4616] FOREIGN KEY ([EventTypeID]) REFERENCES [EventType] ([EventTypeID])
);
GO

CREATE TABLE [CarEvent] (
    [CarEventId] int NOT NULL IDENTITY,
    [CarId] int NOT NULL,
    [EventId] int NOT NULL,
    CONSTRAINT [PK_CarEvent] PRIMARY KEY ([CarEventId]),
    CONSTRAINT [FK_CarEvent_Cars_CarId] FOREIGN KEY ([CarId]) REFERENCES [Cars] ([CarId]) ON DELETE CASCADE,
    CONSTRAINT [FK_CarEvent_Event_EventId] FOREIGN KEY ([EventId]) REFERENCES [Event] ([EventID]) ON DELETE CASCADE
);
GO

CREATE TABLE [UserEvents] (
    [UserEventId] int NOT NULL IDENTITY,
    [EventId] int NOT NULL,
    [UserId] nvarchar(450) NULL,
    CONSTRAINT [PK_UserEvents] PRIMARY KEY ([UserEventId]),
    CONSTRAINT [FK_UserEvents_ApplicationUser_UserId] FOREIGN KEY ([UserId]) REFERENCES [ApplicationUser] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_UserEvents_Event_EventId] FOREIGN KEY ([EventId]) REFERENCES [Event] ([EventID]) ON DELETE CASCADE
);
GO

CREATE TABLE [CarDetail] (
    [CarDetailId] int NOT NULL IDENTITY,
    [Make] nvarchar(max) NOT NULL,
    [Model] nvarchar(max) NOT NULL,
    [Year] nvarchar(max) NOT NULL,
    [Color] nvarchar(max) NOT NULL,
    [Vin] nvarchar(max) NOT NULL,
    [CarId] int NOT NULL,
    [DetailId] int NULL,
    CONSTRAINT [PK_CarDetail] PRIMARY KEY ([CarDetailId]),
    CONSTRAINT [FK_CarDetail_Cars_CarId] FOREIGN KEY ([CarId]) REFERENCES [Cars] ([CarId]) ON DELETE CASCADE
);
GO

CREATE TABLE [CarEventDetail] (
    [CarEventDetailId] int NOT NULL IDENTITY,
    [CarEventId] int NOT NULL,
    [Note] nvarchar(max) NOT NULL,
    [CarDetailId] int NULL,
    CONSTRAINT [PK_CarEventDetail] PRIMARY KEY ([CarEventDetailId]),
    CONSTRAINT [FK_CarEventDetail_CarDetail_CarDetailId] FOREIGN KEY ([CarDetailId]) REFERENCES [CarDetail] ([CarDetailId]),
    CONSTRAINT [FK_CarEventDetail_CarEvent_CarEventId] FOREIGN KEY ([CarEventId]) REFERENCES [CarEvent] ([CarEventId]) ON DELETE CASCADE
);
GO

CREATE TABLE [DetailType] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [CarDetailId] int NULL,
    CONSTRAINT [PK_DetailType] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_DetailType_CarDetail_CarDetailId] FOREIGN KEY ([CarDetailId]) REFERENCES [CarDetail] ([CarDetailId])
);
GO

CREATE TABLE [Detail] (
    [Id] int NOT NULL IDENTITY,
    [DetailTypeId] int NOT NULL,
    [Value] nvarchar(max) NOT NULL,
    [ApplicationUserId] nvarchar(450) NULL,
    [Discriminator] nvarchar(max) NOT NULL,
    [UserId] nvarchar(max) NULL,
    [UserEventId] int NULL,
    [UserEventDetailId] int NULL,
    [Note] nvarchar(max) NULL,
    CONSTRAINT [PK_Detail] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Detail_ApplicationUser_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [ApplicationUser] ([Id]),
    CONSTRAINT [FK_Detail_DetailType_DetailTypeId] FOREIGN KEY ([DetailTypeId]) REFERENCES [DetailType] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Detail_UserEvents_UserEventDetailId] FOREIGN KEY ([UserEventDetailId]) REFERENCES [UserEvents] ([UserEventId]) ON DELETE CASCADE
);
GO

CREATE TABLE [EventDetail] (
    [Id] int NOT NULL IDENTITY,
    [DetailId] int NOT NULL,
    [EventId] int NOT NULL,
    [DateAdded] datetime2 NOT NULL,
    CONSTRAINT [PK_EventDetail] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_EventDetail_Detail_DetailId] FOREIGN KEY ([DetailId]) REFERENCES [Detail] ([Id]),
    CONSTRAINT [FK_EventDetail_Event_EventId] FOREIGN KEY ([EventId]) REFERENCES [Event] ([EventID])
);
GO

CREATE TABLE [UserDetail] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(max) NOT NULL,
    [DetailId] int NOT NULL,
    [ApplicationUserId] nvarchar(450) NULL,
    CONSTRAINT [PK_UserDetail] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_UserDetail_ApplicationUser_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [ApplicationUser] ([Id]),
    CONSTRAINT [FK_UserDetail_Detail_DetailId] FOREIGN KEY ([DetailId]) REFERENCES [Detail] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_CarDetail_CarId] ON [CarDetail] ([CarId]);
GO

CREATE INDEX [IX_CarDetail_DetailId] ON [CarDetail] ([DetailId]);
GO

CREATE INDEX [IX_CarEvent_CarId] ON [CarEvent] ([CarId]);
GO

CREATE INDEX [IX_CarEvent_EventId] ON [CarEvent] ([EventId]);
GO

CREATE INDEX [IX_CarEventDetail_CarDetailId] ON [CarEventDetail] ([CarDetailId]);
GO

CREATE INDEX [IX_CarEventDetail_CarEventId] ON [CarEventDetail] ([CarEventId]);
GO

CREATE UNIQUE INDEX [IX_CarStaticDetails_CarId] ON [CarStaticDetails] ([CarId]);
GO

CREATE INDEX [IX_CarStatus_CarID] ON [CarStatus] ([CarID]);
GO

CREATE INDEX [IX_CarStatus_StatusID] ON [CarStatus] ([StatusID]);
GO

CREATE INDEX [IX_Detail_ApplicationUserId] ON [Detail] ([ApplicationUserId]);
GO

CREATE INDEX [IX_Detail_DetailTypeId] ON [Detail] ([DetailTypeId]);
GO

CREATE INDEX [IX_Detail_UserEventDetailId] ON [Detail] ([UserEventDetailId]);
GO

CREATE INDEX [IX_DetailType_CarDetailId] ON [DetailType] ([CarDetailId]);
GO

CREATE INDEX [IDX_ErrorLog_CarID] ON [ErrorLog] ([CarID]);
GO

CREATE INDEX [IDX_Event_CarID] ON [Event] ([CarID]);
GO

CREATE INDEX [IDX_Event_EventTypeID] ON [Event] ([EventTypeID]);
GO

CREATE INDEX [IDX_Event_UserID] ON [Event] ([UserID]);
GO

CREATE INDEX [IX_Event_CategoryId] ON [Event] ([CategoryId]);
GO

CREATE INDEX [IX_Event_PlaceholderUserId] ON [Event] ([PlaceholderUserId]);
GO

CREATE INDEX [IX_EventDetail_DetailId] ON [EventDetail] ([DetailId]);
GO

CREATE INDEX [IX_EventDetail_EventId] ON [EventDetail] ([EventId]);
GO

CREATE INDEX [IX_Logger_CarID] ON [Logger] ([CarID]);
GO

CREATE INDEX [IX_PlaceholderUser_PlaceholderUserDetailUserId] ON [PlaceholderUser] ([PlaceholderUserDetailUserId]);
GO

CREATE INDEX [IX_PlaceholderUser_RoleId] ON [PlaceholderUser] ([RoleId]);
GO

CREATE INDEX [IDX_Software_CarID] ON [Software] ([CarID]);
GO

CREATE UNIQUE INDEX [UQ_StatusName] ON [Status] ([StatusName]);
GO

CREATE INDEX [IX_TicketAttachment_TicketId] ON [TicketAttachment] ([TicketId]);
GO

CREATE INDEX [IX_TicketComment_AuthorId] ON [TicketComment] ([AuthorId]);
GO

CREATE INDEX [IX_TicketComment_TicketId] ON [TicketComment] ([TicketId]);
GO

CREATE INDEX [IX_TicketHistory_ChangedById] ON [TicketHistory] ([ChangedById]);
GO

CREATE INDEX [IX_TicketHistory_TicketId] ON [TicketHistory] ([TicketId]);
GO

CREATE INDEX [IX_Tickets_AssigneeId] ON [Tickets] ([AssigneeId]);
GO

CREATE INDEX [IX_Tickets_CreatorId] ON [Tickets] ([CreatorId]);
GO

CREATE INDEX [IX_TicketTag_TicketId] ON [TicketTag] ([TicketId]);
GO

CREATE INDEX [IX_UserDetail_ApplicationUserId] ON [UserDetail] ([ApplicationUserId]);
GO

CREATE INDEX [IX_UserDetail_DetailId] ON [UserDetail] ([DetailId]);
GO

CREATE INDEX [IX_UserEvents_EventId] ON [UserEvents] ([EventId]);
GO

CREATE INDEX [IX_UserEvents_UserId] ON [UserEvents] ([UserId]);
GO

ALTER TABLE [CarDetail] ADD CONSTRAINT [FK_CarDetail_Detail_DetailId] FOREIGN KEY ([DetailId]) REFERENCES [Detail] ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230705192853_InitialCreate', N'7.0.8');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230824005708_BlankMigration1', N'7.0.8');
GO

COMMIT;
GO

