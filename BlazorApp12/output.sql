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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [Blanks] (
        [Id] int NOT NULL IDENTITY,
        [String] nvarchar(max) NOT NULL,
        [Name] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Blanks] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [CarStatusNews] (
        [Id] int NOT NULL IDENTITY,
        [StatusId] int NOT NULL,
        [StatusName] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_CarStatusNews] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [Category] (
        [CategoryId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [DefaultPriority] int NOT NULL,
        CONSTRAINT [PK_Category] PRIMARY KEY ([CategoryId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [Drivers] (
        [DriverId] int NOT NULL IDENTITY,
        [DrivingHours] decimal(18,2) NOT NULL,
        CONSTRAINT [PK_Drivers] PRIMARY KEY ([DriverId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [DriverStats] (
        [Id] int NOT NULL IDENTITY,
        [TotalCount] int NOT NULL,
        [AverageDrivingHours] int NOT NULL,
        CONSTRAINT [PK_DriverStats] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [ErrorLogs] (
        [Id] int NOT NULL IDENTITY,
        [CarId] int NOT NULL,
        [ErrorDetails] nvarchar(max) NULL,
        [ErrorPriority] int NULL,
        [ErrorNotes] nvarchar(max) NULL,
        CONSTRAINT [PK_ErrorLogs] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [EventTypes] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_EventTypes] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
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
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [MasterLogs] (
        [Id] int NOT NULL IDENTITY,
        [Message] nvarchar(max) NOT NULL,
        [Time] datetime2 NULL,
        CONSTRAINT [PK_MasterLogs] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [RoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(max) NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_RoleClaims] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [RoleEventMappings] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [DefaultEventTypeId] int NOT NULL,
        CONSTRAINT [PK_RoleEventMappings] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [Roles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(max) NULL,
        [NormalizedName] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_Roles] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [Softwares] (
        [Id] int NOT NULL IDENTITY,
        [Unit] nvarchar(max) NOT NULL,
        [SoftwareVersion] nvarchar(max) NOT NULL,
        [NextSoftwareVersion] nvarchar(max) NULL,
        [UploadDate] datetime2 NULL,
        [FutureUploadDate] datetime2 NULL,
        [CarId] int NULL,
        CONSTRAINT [PK_Softwares] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [Sources] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_Sources] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [Statuses] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Statuses] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [Team] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Team] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [TicketCategory] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [DefaultPriority] int NOT NULL,
        CONSTRAINT [PK_TicketCategory] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [UserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(max) NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_UserClaims] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [UserLogins] (
        [LoginProvider] nvarchar(450) NOT NULL,
        [ProviderKey] nvarchar(450) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(max) NULL,
        CONSTRAINT [PK_UserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [UserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_UserRoles] PRIMARY KEY ([UserId], [RoleId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [UserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(450) NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_UserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoles_Roles_Id] FOREIGN KEY ([Id]) REFERENCES [Roles] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [Cars] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Make] nvarchar(max) NULL,
        [Model] nvarchar(max) NULL,
        [Year] int NULL,
        [TeleGeneration] nvarchar(max) NULL,
        [Miles] int NULL,
        [Location] nvarchar(max) NULL,
        [SourceId] int NULL,
        [CarDetail] int NOT NULL,
        [CarStatusId] int NOT NULL,
        [UserId] nvarchar(max) NULL,
        [SoftwareId] int NULL,
        CONSTRAINT [PK_Cars] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Cars_Softwares_SoftwareId] FOREIGN KEY ([SoftwareId]) REFERENCES [Softwares] ([Id]),
        CONSTRAINT [FK_Cars_Sources_SourceId] FOREIGN KEY ([SourceId]) REFERENCES [Sources] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [ApplicationUser] (
        [Id] nvarchar(450) NOT NULL,
        [FriendlyName] nvarchar(max) NULL,
        [FirstName] nvarchar(max) NULL,
        [LastName] nvarchar(max) NULL,
        [TeamId] int NOT NULL,
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
        CONSTRAINT [PK_ApplicationUser] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ApplicationUser_Team_TeamId] FOREIGN KEY ([TeamId]) REFERENCES [Team] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [TeamTimeline] (
        [Id] int NOT NULL IDENTITY,
        [TeamId] int NOT NULL,
        CONSTRAINT [PK_TeamTimeline] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_TeamTimeline_Team_TeamId] FOREIGN KEY ([TeamId]) REFERENCES [Team] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [CarStaticDetails] (
        [Id] int NOT NULL IDENTITY,
        [Vin] nvarchar(max) NOT NULL,
        [Tag] nvarchar(max) NOT NULL,
        [Finas] nvarchar(max) NOT NULL,
        [Adas] bit NULL,
        [CarId] int NULL,
        CONSTRAINT [PK_CarStaticDetails] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_CarStaticDetails_Cars_CarId] FOREIGN KEY ([CarId]) REFERENCES [Cars] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [CarStatuses] (
        [Id] int NOT NULL IDENTITY,
        [CarId] int NOT NULL,
        [StatusId] int NOT NULL,
        [StatusTime] datetime2 NULL,
        CONSTRAINT [PK_CarStatuses] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_CarStatuses_Cars_CarId] FOREIGN KEY ([CarId]) REFERENCES [Cars] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_CarStatuses_Statuses_StatusId] FOREIGN KEY ([StatusId]) REFERENCES [Statuses] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [UserStaticDetail] (
        [Id] nvarchar(450) NOT NULL,
        [PhoneNumber] nvarchar(max) NOT NULL,
        [VehicleArea] nvarchar(max) NOT NULL,
        [ExpertiseCategory] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_UserStaticDetail] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_UserStaticDetail_ApplicationUser_Id] FOREIGN KEY ([Id]) REFERENCES [ApplicationUser] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [Car2s] (
        [Id] int NOT NULL IDENTITY,
        [Make] nvarchar(max) NULL,
        [Model] nvarchar(max) NULL,
        [Year] int NULL,
        [TeleGeneration] nvarchar(max) NULL,
        [Miles] int NULL,
        [Location] nvarchar(max) NULL,
        [SourceId] int NULL,
        [CarStaticDetailId] int NULL,
        [UserId] nvarchar(max) NULL,
        CONSTRAINT [PK_Car2s] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Car2s_CarStaticDetails_CarStaticDetailId] FOREIGN KEY ([CarStaticDetailId]) REFERENCES [CarStaticDetails] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [Loggers] (
        [LoggerId] int NOT NULL IDENTITY,
        [CarId] int NOT NULL,
        [TypeLogger] nvarchar(max) NOT NULL,
        [NumLoggers] int NOT NULL,
        [LogTime] datetime2 NOT NULL,
        [LogText] nvarchar(max) NOT NULL,
        [Car2Id] int NULL,
        CONSTRAINT [PK_Loggers] PRIMARY KEY ([LoggerId]),
        CONSTRAINT [FK_Loggers_Car2s_Car2Id] FOREIGN KEY ([Car2Id]) REFERENCES [Car2s] ([Id]),
        CONSTRAINT [FK_Loggers_Cars_CarId] FOREIGN KEY ([CarId]) REFERENCES [Cars] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [CarDetail] (
        [Id] int NOT NULL IDENTITY,
        [CarId] int NOT NULL,
        [CarEventId] int NOT NULL,
        [DetailTypeId] int NOT NULL,
        [CarEventDetailId] int NOT NULL,
        [DetailId] int NULL,
        CONSTRAINT [PK_CarDetail] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_CarDetail_Cars_CarId] FOREIGN KEY ([CarId]) REFERENCES [Cars] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [DetailTypes] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(450) NOT NULL,
        [CarDetailId] int NULL,
        CONSTRAINT [PK_DetailTypes] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_DetailTypes_CarDetail_CarDetailId] FOREIGN KEY ([CarDetailId]) REFERENCES [CarDetail] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [CarEvent] (
        [CarEventId] int NOT NULL IDENTITY,
        [CarId] int NOT NULL,
        [EventId] int NOT NULL,
        CONSTRAINT [PK_CarEvent] PRIMARY KEY ([CarEventId]),
        CONSTRAINT [FK_CarEvent_Cars_CarId] FOREIGN KEY ([CarId]) REFERENCES [Cars] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [CarEventDetail] (
        [CarEventDetailId] int NOT NULL IDENTITY,
        [CarEventId] int NOT NULL,
        [Note] nvarchar(max) NOT NULL,
        [CarDetailId] int NULL,
        CONSTRAINT [PK_CarEventDetail] PRIMARY KEY ([CarEventDetailId]),
        CONSTRAINT [FK_CarEventDetail_CarDetail_CarDetailId] FOREIGN KEY ([CarDetailId]) REFERENCES [CarDetail] ([Id]),
        CONSTRAINT [FK_CarEventDetail_CarEvent_CarEventId] FOREIGN KEY ([CarEventId]) REFERENCES [CarEvent] ([CarEventId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [Detail] (
        [Id] int NOT NULL IDENTITY,
        [DetailTypeId] int NOT NULL,
        [Value] nvarchar(max) NOT NULL,
        [ApplicationUserId] nvarchar(450) NULL,
        [Discriminator] nvarchar(max) NOT NULL,
        [Text] nvarchar(max) NULL,
        [UserId] nvarchar(max) NULL,
        [UserEventId] int NULL,
        [UserEventDetailId] int NULL,
        [Note] nvarchar(max) NULL,
        CONSTRAINT [PK_Detail] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Detail_ApplicationUser_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [ApplicationUser] ([Id]),
        CONSTRAINT [FK_Detail_DetailTypes_DetailTypeId] FOREIGN KEY ([DetailTypeId]) REFERENCES [DetailTypes] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [UserDetail] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [UserEventsId] int NOT NULL,
        [DriverStatsId] int NULL,
        [TimelineId] int NULL,
        [DetailId] int NULL,
        CONSTRAINT [PK_UserDetail] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_UserDetail_ApplicationUser_UserId] FOREIGN KEY ([UserId]) REFERENCES [ApplicationUser] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_UserDetail_Detail_DetailId] FOREIGN KEY ([DetailId]) REFERENCES [Detail] ([Id]),
        CONSTRAINT [FK_UserDetail_DriverStats_DriverStatsId] FOREIGN KEY ([DriverStatsId]) REFERENCES [DriverStats] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [Tickets] (
        [Id] int NOT NULL IDENTITY,
        [Title] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NOT NULL,
        [UserDetailId] int NOT NULL,
        [CreatorId] nvarchar(450) NOT NULL,
        [AssigneeId] nvarchar(450) NOT NULL,
        [CreatedAt] datetime2 NOT NULL,
        [UpdatedAt] datetime2 NULL,
        [ClosedAt] datetime2 NULL,
        [Status] nvarchar(max) NOT NULL,
        [Severity] nvarchar(max) NOT NULL,
        [Priority] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Tickets] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Tickets_ApplicationUser_AssigneeId] FOREIGN KEY ([AssigneeId]) REFERENCES [ApplicationUser] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Tickets_ApplicationUser_CreatorId] FOREIGN KEY ([CreatorId]) REFERENCES [ApplicationUser] ([Id]),
        CONSTRAINT [FK_Tickets_UserDetail_UserDetailId] FOREIGN KEY ([UserDetailId]) REFERENCES [UserDetail] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [Timeline] (
        [Id] int NOT NULL IDENTITY,
        [StartDate] datetime2 NOT NULL,
        [EndDate] datetime2 NOT NULL,
        [UserDetailId] int NOT NULL,
        CONSTRAINT [PK_Timeline] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Timeline_UserDetail_UserDetailId] FOREIGN KEY ([UserDetailId]) REFERENCES [UserDetail] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [TicketAttachment] (
        [Id] int NOT NULL IDENTITY,
        [TicketId] int NOT NULL,
        [FilePath] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_TicketAttachment] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_TicketAttachment_Tickets_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [Tickets] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [TicketComment] (
        [Id] int NOT NULL IDENTITY,
        [TicketId] int NOT NULL,
        [Content] nvarchar(max) NOT NULL,
        [AuthorId] nvarchar(450) NOT NULL,
        [CreatedAt] datetime2 NOT NULL,
        CONSTRAINT [PK_TicketComment] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_TicketComment_ApplicationUser_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [ApplicationUser] ([Id]),
        CONSTRAINT [FK_TicketComment_Tickets_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [Tickets] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [TicketHistory] (
        [Id] int NOT NULL IDENTITY,
        [TicketId] int NOT NULL,
        [Change] nvarchar(max) NOT NULL,
        [ChangedAt] datetime2 NOT NULL,
        [ChangedById] nvarchar(max) NOT NULL,
        [OwnerId] nvarchar(450) NOT NULL,
        [UserDetailId] int NOT NULL,
        CONSTRAINT [PK_TicketHistory] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_TicketHistory_ApplicationUser_OwnerId] FOREIGN KEY ([OwnerId]) REFERENCES [ApplicationUser] ([Id]),
        CONSTRAINT [FK_TicketHistory_Tickets_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [Tickets] ([Id]),
        CONSTRAINT [FK_TicketHistory_UserDetail_UserDetailId] FOREIGN KEY ([UserDetailId]) REFERENCES [UserDetail] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [TicketTag] (
        [Id] int NOT NULL IDENTITY,
        [TicketId] int NOT NULL,
        [Tag] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_TicketTag] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_TicketTag_Tickets_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [Tickets] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [Events] (
        [Id] int NOT NULL IDENTITY,
        [CarId] int NOT NULL,
        [EventTypeId] int NOT NULL,
        [UserId] nvarchar(450) NULL,
        [Date] datetime2 NOT NULL,
        [CategoryId] int NOT NULL,
        [StartTime] datetime2 NULL,
        [EndTime] datetime2 NULL,
        [Type] nvarchar(max) NULL,
        [TeamTimelineId] int NULL,
        [TimelineId] int NULL,
        CONSTRAINT [PK_Events] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Events_ApplicationUser_UserId] FOREIGN KEY ([UserId]) REFERENCES [ApplicationUser] ([Id]),
        CONSTRAINT [FK_Events_Cars_CarId] FOREIGN KEY ([CarId]) REFERENCES [Cars] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Events_Category_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Category] ([CategoryId]) ON DELETE CASCADE,
        CONSTRAINT [FK_Events_EventTypes_EventTypeId] FOREIGN KEY ([EventTypeId]) REFERENCES [EventTypes] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Events_TeamTimeline_TeamTimelineId] FOREIGN KEY ([TeamTimelineId]) REFERENCES [TeamTimeline] ([Id]),
        CONSTRAINT [FK_Events_Timeline_TimelineId] FOREIGN KEY ([TimelineId]) REFERENCES [Timeline] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [UserEvents] (
        [Id] int NOT NULL IDENTITY,
        [StartTime] datetime2 NULL,
        [EndTime] datetime2 NULL,
        [UserId] nvarchar(450) NOT NULL,
        [EventId] int NOT NULL,
        [UserDetailId] int NOT NULL,
        [UserEventDetailId] int NOT NULL,
        CONSTRAINT [PK_UserEvents] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_UserEvents_ApplicationUser_UserId] FOREIGN KEY ([UserId]) REFERENCES [ApplicationUser] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_UserEvents_Events_EventId] FOREIGN KEY ([EventId]) REFERENCES [Events] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_UserEvents_UserDetail_UserDetailId] FOREIGN KEY ([UserDetailId]) REFERENCES [UserDetail] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [UserEventDetail] (
        [Id] int NOT NULL IDENTITY,
        [CarId] int NULL,
        [UserId] nvarchar(450) NOT NULL,
        [ApplicationUserId] nvarchar(450) NOT NULL,
        [UserEventId] int NOT NULL,
        [UserEventDetailGrandularId] int NOT NULL,
        [TextId] int NOT NULL,
        [DateAdded] datetime2 NOT NULL,
        [DetailId] int NULL,
        [EventId] int NULL,
        CONSTRAINT [PK_UserEventDetail] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_UserEventDetail_ApplicationUser_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [ApplicationUser] ([Id]),
        CONSTRAINT [FK_UserEventDetail_ApplicationUser_UserId] FOREIGN KEY ([UserId]) REFERENCES [ApplicationUser] ([Id]),
        CONSTRAINT [FK_UserEventDetail_Cars_CarId] FOREIGN KEY ([CarId]) REFERENCES [Cars] ([Id]),
        CONSTRAINT [FK_UserEventDetail_Detail_DetailId] FOREIGN KEY ([DetailId]) REFERENCES [Detail] ([Id]),
        CONSTRAINT [FK_UserEventDetail_Events_EventId] FOREIGN KEY ([EventId]) REFERENCES [Events] ([Id]),
        CONSTRAINT [FK_UserEventDetail_UserEvents_UserEventId] FOREIGN KEY ([UserEventId]) REFERENCES [UserEvents] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE TABLE [UserEventDetailText] (
        [Id] int NOT NULL IDENTITY,
        [Text] nvarchar(max) NOT NULL,
        [UserEventDetailId] int NOT NULL,
        CONSTRAINT [PK_UserEventDetailText] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_UserEventDetailText_UserEventDetail_UserEventDetailId] FOREIGN KEY ([UserEventDetailId]) REFERENCES [UserEventDetail] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'String') AND [object_id] = OBJECT_ID(N'[Blanks]'))
        SET IDENTITY_INSERT [Blanks] ON;
    EXEC(N'INSERT INTO [Blanks] ([Id], [Name], [String])
    VALUES (1, N''Item 1'', N''This is item 1 data'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name', N'String') AND [object_id] = OBJECT_ID(N'[Blanks]'))
        SET IDENTITY_INSERT [Blanks] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CarDetailId', N'Name') AND [object_id] = OBJECT_ID(N'[DetailTypes]'))
        SET IDENTITY_INSERT [DetailTypes] ON;
    EXEC(N'INSERT INTO [DetailTypes] ([Id], [CarDetailId], [Name])
    VALUES (1, NULL, N''Ticket''),
    (2, NULL, N''Car''),
    (3, NULL, N''UserCarEvent''),
    (4, NULL, N''Shop''),
    (5, NULL, N''Highlight''),
    (6, NULL, N''Improvement''),
    (7, NULL, N''Critique'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CarDetailId', N'Name') AND [object_id] = OBJECT_ID(N'[DetailTypes]'))
        SET IDENTITY_INSERT [DetailTypes] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[EventTypes]'))
        SET IDENTITY_INSERT [EventTypes] ON;
    EXEC(N'INSERT INTO [EventTypes] ([Id], [Name])
    VALUES (1, N''Comission''),
    (2, N''Decomission''),
    (3, N''TicketSubmission''),
    (4, N''ErrorIdentification''),
    (5, N''TestDrive''),
    (6, N''ShopConfiguration''),
    (7, N''PreparedForDrive''),
    (8, N''TagAssigned''),
    (9, N''TagUnAssigned''),
    (10, N''LoggerInstall''),
    (11, N''LoggerUnInstall''),
    (12, N''MainDriveEvent''),
    (13, N''RoutineDrive'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[EventTypes]'))
        SET IDENTITY_INSERT [EventTypes] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Message', N'Time') AND [object_id] = OBJECT_ID(N'[MasterLogs]'))
        SET IDENTITY_INSERT [MasterLogs] ON;
    EXEC(N'INSERT INTO [MasterLogs] ([Id], [Message], [Time])
    VALUES (1, N''App Birth.'', ''2023-07-26T07:43:53.7701090-05:00''),
    (2, N''Hello from The past.'', ''2023-07-26T07:43:53.7701158-05:00'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Message', N'Time') AND [object_id] = OBJECT_ID(N'[MasterLogs]'))
        SET IDENTITY_INSERT [MasterLogs] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Sources]'))
        SET IDENTITY_INSERT [Sources] ON;
    EXEC(N'INSERT INTO [Sources] ([Id], [Name])
    VALUES (1, N''MarketBorrow''),
    (2, N''Purchased''),
    (3, N''Owned'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Sources]'))
        SET IDENTITY_INSERT [Sources] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Statuses]'))
        SET IDENTITY_INSERT [Statuses] ON;
    EXEC(N'INSERT INTO [Statuses] ([Id], [Name])
    VALUES (1, N''Available''),
    (2, N''NotAvailable''),
    (3, N''AwaitingAction'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Statuses]'))
        SET IDENTITY_INSERT [Statuses] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Team]'))
        SET IDENTITY_INSERT [Team] ON;
    EXEC(N'INSERT INTO [Team] ([Id], [Name])
    VALUES (1, N''Unassigned''),
    (2, N''Adas''),
    (3, N''Telematics'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Name') AND [object_id] = OBJECT_ID(N'[Team]'))
        SET IDENTITY_INSERT [Team] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DefaultPriority', N'Name') AND [object_id] = OBJECT_ID(N'[TicketCategory]'))
        SET IDENTITY_INSERT [TicketCategory] ON;
    EXEC(N'INSERT INTO [TicketCategory] ([Id], [DefaultPriority], [Name])
    VALUES (1, 1, N''Voca1''),
    (2, 2, N''Voca2''),
    (3, 3, N''Voca3'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DefaultPriority', N'Name') AND [object_id] = OBJECT_ID(N'[TicketCategory]'))
        SET IDENTITY_INSERT [TicketCategory] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_ApplicationUser_TeamId] ON [ApplicationUser] ([TeamId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_Car2s_CarStaticDetailId] ON [Car2s] ([CarStaticDetailId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_CarDetail_CarEventId] ON [CarDetail] ([CarEventId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_CarDetail_CarId] ON [CarDetail] ([CarId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_CarDetail_DetailId] ON [CarDetail] ([DetailId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_CarEvent_CarId] ON [CarEvent] ([CarId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_CarEvent_EventId] ON [CarEvent] ([EventId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_CarEventDetail_CarDetailId] ON [CarEventDetail] ([CarDetailId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_CarEventDetail_CarEventId] ON [CarEventDetail] ([CarEventId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_Cars_SoftwareId] ON [Cars] ([SoftwareId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_Cars_SourceId] ON [Cars] ([SourceId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [IX_CarStaticDetails_CarId] ON [CarStaticDetails] ([CarId]) WHERE [CarId] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_CarStatuses_CarId] ON [CarStatuses] ([CarId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_CarStatuses_StatusId] ON [CarStatuses] ([StatusId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_Detail_ApplicationUserId] ON [Detail] ([ApplicationUserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_Detail_DetailTypeId] ON [Detail] ([DetailTypeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_Detail_UserEventDetailId] ON [Detail] ([UserEventDetailId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_DetailTypes_CarDetailId] ON [DetailTypes] ([CarDetailId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE UNIQUE INDEX [IX_DetailTypes_Name] ON [DetailTypes] ([Name]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_Events_CarId] ON [Events] ([CarId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_Events_CategoryId] ON [Events] ([CategoryId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_Events_EventTypeId] ON [Events] ([EventTypeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_Events_TeamTimelineId] ON [Events] ([TeamTimelineId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_Events_TimelineId] ON [Events] ([TimelineId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_Events_UserId] ON [Events] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE UNIQUE INDEX [IX_EventTypes_Name] ON [EventTypes] ([Name]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_Loggers_Car2Id] ON [Loggers] ([Car2Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_Loggers_CarId] ON [Loggers] ([CarId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE UNIQUE INDEX [IX_RoleEventMappings_RoleId] ON [RoleEventMappings] ([RoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE UNIQUE INDEX [IX_Sources_Name] ON [Sources] ([Name]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE UNIQUE INDEX [IX_TeamTimeline_TeamId] ON [TeamTimeline] ([TeamId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_TicketAttachment_TicketId] ON [TicketAttachment] ([TicketId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_TicketComment_AuthorId] ON [TicketComment] ([AuthorId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_TicketComment_TicketId] ON [TicketComment] ([TicketId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_TicketHistory_OwnerId] ON [TicketHistory] ([OwnerId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_TicketHistory_TicketId] ON [TicketHistory] ([TicketId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_TicketHistory_UserDetailId] ON [TicketHistory] ([UserDetailId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_Tickets_AssigneeId] ON [Tickets] ([AssigneeId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_Tickets_CreatorId] ON [Tickets] ([CreatorId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_Tickets_UserDetailId] ON [Tickets] ([UserDetailId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_TicketTag_TicketId] ON [TicketTag] ([TicketId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_Timeline_UserDetailId] ON [Timeline] ([UserDetailId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_UserDetail_DetailId] ON [UserDetail] ([DetailId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [IX_UserDetail_DriverStatsId] ON [UserDetail] ([DriverStatsId]) WHERE [DriverStatsId] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE UNIQUE INDEX [IX_UserDetail_UserId] ON [UserDetail] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_UserEventDetail_ApplicationUserId] ON [UserEventDetail] ([ApplicationUserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_UserEventDetail_CarId] ON [UserEventDetail] ([CarId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_UserEventDetail_DetailId] ON [UserEventDetail] ([DetailId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_UserEventDetail_EventId] ON [UserEventDetail] ([EventId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_UserEventDetail_UserEventId] ON [UserEventDetail] ([UserEventId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_UserEventDetail_UserId] ON [UserEventDetail] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_UserEventDetailText_UserEventDetailId] ON [UserEventDetailText] ([UserEventDetailId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_UserEvents_EventId] ON [UserEvents] ([EventId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_UserEvents_UserDetailId] ON [UserEvents] ([UserDetailId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    CREATE INDEX [IX_UserEvents_UserId] ON [UserEvents] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    ALTER TABLE [CarDetail] ADD CONSTRAINT [FK_CarDetail_CarEvent_CarEventId] FOREIGN KEY ([CarEventId]) REFERENCES [CarEvent] ([CarEventId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    ALTER TABLE [CarDetail] ADD CONSTRAINT [FK_CarDetail_Detail_DetailId] FOREIGN KEY ([DetailId]) REFERENCES [Detail] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    ALTER TABLE [CarEvent] ADD CONSTRAINT [FK_CarEvent_Events_EventId] FOREIGN KEY ([EventId]) REFERENCES [Events] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    ALTER TABLE [Detail] ADD CONSTRAINT [FK_Detail_UserEventDetail_UserEventDetailId] FOREIGN KEY ([UserEventDetailId]) REFERENCES [UserEventDetail] ([Id]) ON DELETE CASCADE;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726124354_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230726124354_InitialCreate', N'7.0.9');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230801010605_ApplicationUserOptionalTeam')
BEGIN
    ALTER TABLE [ApplicationUser] DROP CONSTRAINT [FK_ApplicationUser_Team_TeamId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230801010605_ApplicationUserOptionalTeam')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ApplicationUser]') AND [c].[name] = N'TeamId');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [ApplicationUser] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [ApplicationUser] ALTER COLUMN [TeamId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230801010605_ApplicationUserOptionalTeam')
BEGIN
    EXEC(N'UPDATE [MasterLogs] SET [Time] = ''2023-07-31T20:06:04.8440382-05:00''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230801010605_ApplicationUserOptionalTeam')
BEGIN
    EXEC(N'UPDATE [MasterLogs] SET [Time] = ''2023-07-31T20:06:04.8440443-05:00''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230801010605_ApplicationUserOptionalTeam')
BEGIN
    ALTER TABLE [ApplicationUser] ADD CONSTRAINT [FK_ApplicationUser_Team_TeamId] FOREIGN KEY ([TeamId]) REFERENCES [Team] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230801010605_ApplicationUserOptionalTeam')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230801010605_ApplicationUserOptionalTeam', N'7.0.9');
END;
GO

COMMIT;
GO

