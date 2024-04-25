//Configuring complex types.
//As of EF Core 5.0, the concept of a "complex type" has been replaced with Owned Entity Types. Please refer to the point about owned types below.
//Configuring composite primary keys.
//This is when you want multiple properties to act together as the primary key for your entity.
//code:
        modelBuilder.Entity<Car>()
            .HasKey(c => new { c.CarId, c.Model });  // CarId and Model together form the primary key

//Configuring relationships fully.
//One-to-One relationships. This could be between Car and CarDetail entities, where each Car has one CarDetail and each CarDetail belongs to one Car.
//code:
        modelBuilder.Entity<Car>()
            .HasOne(c => c.CarDetail)
            .WithOne(cd => cd.Car)
            .HasForeignKey<CarDetail>(cd => cd.CarId);  // assumes CarDetail has CarId FK

//Many-to-Many relationships. Here, let's say a Car can have multiple Features, and a Feature can be part of multiple Cars. This became simpler with EF Core 5.0 and later.
//code:
        modelBuilder.Entity<Car>()
            .HasMany(c => c.Features)
            .WithMany(f => f.Cars);

//Configuring cascade delete behavior.
//This sets up what should happen to related entities when a parent entity is deleted. Let's say we want to delete a Car, and we want all associated Wheels to be deleted as well.
//code:
        modelBuilder.Entity<Car>()
            .HasMany(c => c.Wheels)
            .WithOne(w => w.Car)
            .OnDelete(DeleteBehavior.Cascade);  // When a Car is deleted, its Wheels are deleted too

//To-Table mapping.
//This specifies a different table name for a model. By default, EF Core uses the pluralized model name as the table name.
//code:
modelBuilder.Entity<Car>().ToTable("Automobiles");  // Maps Car entities to the "Automobiles" table

//Configuring entity type inheritance.
//This is when you have a class hierarchy and want to map that to your database. Let's say you have Car and Truck as subclasses of Vehicle.
//code:
        modelBuilder.Entity<Vehicle>()
            .HasDiscriminator<string>("VehicleType")  // Column to distinguish between Car and Truck
            .HasValue<Car>("Car")
            .HasValue<Truck>("Truck");

//Configuring value conversions and comparers.
//This is when you want to convert a value between how it's represented in your model and how it's stored in the database. Let's say you have a Color enum that you want to store as a string.
//code:
        modelBuilder.Entity<Car>()
            .Property(c => c.Color)
            .HasConversion(
                v => v.ToString(),  // Convert from Color to string
                v => (Color)Enum.Parse(typeof(Color), v)  // Convert from string to Color
            );

//Configuring owned types.
//These are complex types that are treated as entities but don't have their own identity. Let's say a Car owns one Engine type.
//code:
        modelBuilder.Entity<Car>()
            .OwnsOne(c => c.Engine);
    
//Configuring query filters.
//This applies a filter to all queries for a particular entity type. Let's say you want to exclude Car entities that are marked as deleted.
//code:
        modelBuilder.Entity<Car>()
            .HasQueryFilter(c => !c.IsDeleted);  // Exclude Cars 















INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (2, N'180', N'X294-01019', N'0131', N'1', N'4JGGM2BB6PA000131', N'E316.5', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (3, N'181', N'X167-04607', N'7779', N'0', N'4JGFF8HB5NA357779', N'E900.4', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (4, N'182', N'X296-01198', N'3435', N'0', N'4JGDM2DB4RA003435', NULL, N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (5, N'183', N'X167-06625', N'4776', N'0', N'4JGFF8FE9RA844776', N'E329.5', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (6, N'184', N'X294-01471', N'0790', N'0', N'4JGGM1CB8RA000790', N'E330.6', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (7, N'185', N'Z296-01209', N'3388', N'0', N'4JGDX5FB2RA003388', N'E330.6', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (8, N'186', N'X296-01210', N'3437', N'0', N'4JGDM4EB5RA003437', N'E330.6', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (9, N'187', N'X167-06656', N'4775', N'0', N'4JGFF5KE1RA844775', N'E444.3', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (10, N'188', N'X294-01457', N'1590', N'0', N'4JGGM5DB8RA001590', N'E444.3', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (11, N'189', N'X296-00421', N'0351', N'0', N'4JGDM4EB6PA000351', N'E329.5', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (12, N'190', N'X296-00395', N'0205', N'0', N'4JGDM2DB9PA000205', N'E329.4', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (13, N'191', N'X167-06686', N'4774', N'0', N'4JGFF8HB1RA844774', N'E330.6', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (14, N'192', N'X294-01532', N'0792', N'0', N'4JGGM2BB2RA000792', N'E330.6', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (15, N'193', N'X296-00702', N'0194', N'0', N'4JGDM2EB1PU000194', N'E330.6', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (16, N'195', N'V167-06463', N'9370', N'0', N'4JGFB4GB3RA809370', N'E444.4', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (17, N'196', N'Z296-01192', N'3386', N'0', N'4JGDX5FB9RA003386', N'E444.4', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (18, N'197', N'C167-06461', N'9371', N'0', N'4JGFD8KB4RA809371', N'E330.5', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (19, N'198', N'V167-06567', N'3660', N'0', N'4JGFB4GB1PA883660', N'E330.6', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (20, N'199', N'X294-01456', N'1588', N'0', N'4JGGM5DBXRA001588', N'E330.6', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (21, N'288', N'X296-00848', N'0701', N'0', N'4JGDM4EB7PA000701', NULL, N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (22, N'638', N'V297-02377', N'9834', N'0', N'W1KCG4EB4PA019834', N'E330.6', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (23, N'651', N'W206-01531', N'0041', N'0', N'W1KAF4GB9NR000041', N'E51.5', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (24, N'652', N'V297-01008', N'0823', N'0', N'W1KCG4EB7NA000823', N'E330.6', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (25, N'653', N'A118-01377', N'8913', N'0', N'W1K5J5EB8RN368913', N'E330.6', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (26, N'654', N'V297-01062', N'3265', N'0', N'W1KCG2EB8NA003265', NULL, N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (27, N'655', N'V223-05154', N'0096', N'0', N'W1K6G8CB9RA200096', N'E330.6', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (28, N'657', N'X254-02459', N'1221', N'0', N'W1NKM4GB3PF001221', NULL, N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (29, N'658', N'V295-01073', N'0498', N'0', N'W1KEG2BB5NF000498', N'E329.6', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (30, N'659', N'V295-01074', N'0499', N'0', N'W1KEG2BB7NF000499', N'E329.1', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (31, N'660', N'Z223-05153', N'3259', N'0', N'W1K6X7GB9RA203259', N'E330.6', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (32, N'661', N'N295-01333', N'5779', N'0', N'W1KEG5DB3PF005779', N'E329.6', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (33, N'662', N'X243-01749', N'7408', N'0', N'W1N9M1DB3RN027408', N'E905.2', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (34, N'663', N'V223-04879', N'9432', N'0', N'W1K6G8CB5PA159432', N'E330.6', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (35, N'664', N'V297-01298', N'0411', N'0', N'W1KCG4EB6NA000411', NULL, N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (36, N'665', N'A238-02435', N'5712', N'0', N'W1K1K6BB7PF185712', N'E905.2', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (37, N'666', N'W214-01098', N'0650', N'0', N'W1KLF4HB7RA000650', N'E51.5', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (38, N'668', N'X294-00461', N'0386', N'0', N'4JGGM1CB5PA000386', N'E329.5', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (39, N'669', N'X296-00322', N'0031', N'0', N'4JGDM2DB2PA000031', N'E316.5', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (40, N'670', N'V295-00503', N'0620', N'0', N'W1KEG2BB5PF000620', N'E330.5', N'0')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (42, N'TTTT-45', N'xv25-xxxx', N'TT44', N'1', N'xxxxxxxxxxxxx', N'1', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (43, N'TTTT-45', N'xv25-xxxx', N'TT44', N'1', N'xxxxxxxxxxxxx', N'1', N'1')
INSERT INTO [dbo].[CarStaticDetail] ([CarID], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [ADAS]) VALUES (, N'TTTT-49', N'xv25-x457', N'TT49', N'1', N'xxxxxx4465xxx', N'54.5', N'1')




CREATE TABLE [ApplicationUser] (
    [Id] nvarchar(450) NOT NULL,
    [FriendlyName] nvarchar(max) NULL,
    [ApplicationUserDetailId] int NOT NULL,
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


CREATE TABLE [BlankModels] (
    [Id] int NOT NULL IDENTITY,
    CONSTRAINT [PK_BlankModels] PRIMARY KEY ([Id])
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


CREATE TABLE [RoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(max) NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_RoleClaims] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [RoleEventMappings] (
    [Id] int NOT NULL IDENTITY,
    [Role] nvarchar(450) NULL,
    [DefaultEventTypeId] int NOT NULL,
    CONSTRAINT [PK_RoleEventMappings] PRIMARY KEY ([Id])
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
    CONSTRAINT [FK_Tickets_ApplicationUser_AssigneeId] FOREIGN KEY ([AssigneeId]) REFERENCES [ApplicationUser] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Tickets_ApplicationUser_CreatorId] FOREIGN KEY ([CreatorId]) REFERENCES [ApplicationUser] ([Id]) ON DELETE CASCADE
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
    CONSTRAINT [FK_CarStaticDetails_Cars_CarId] FOREIGN KEY ([CarId]) REFERENCES [Cars] ([CarId]) ON DELETE CASCADE
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


CREATE TABLE [Event] (
    [EventId] int NOT NULL IDENTITY,
    [CarId] int NOT NULL,
    [EventTypeId] int NOT NULL,
    [UserId] nvarchar(450) NOT NULL,
    [Date] datetime NOT NULL,
    [StartTime] datetime NULL,
    [EndTime] datetime NULL,
    [Type] nvarchar(max) NULL,
    [Category] float NOT NULL,
    CONSTRAINT [PK__Event__7944C870D4DB1DAC] PRIMARY KEY ([EventId]),
    CONSTRAINT [FK_Event_ApplicationUser_UserId] FOREIGN KEY ([UserId]) REFERENCES [ApplicationUser] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK__Event__EventType__1CBC4616] FOREIGN KEY ([EventTypeId]) REFERENCES [EventType] ([EventTypeID])
);
GO


CREATE TABLE [AspNetRoles] (
    [Id] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetRoles_Roles_Id] FOREIGN KEY ([Id]) REFERENCES [Roles] ([Id]) ON DELETE CASCADE
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


CREATE TABLE [CarEvent] (
    [CarEventId] int NOT NULL IDENTITY,
    [CarId] int NOT NULL,
    [EventId] int NOT NULL,
    CONSTRAINT [PK_CarEvent] PRIMARY KEY ([CarEventId]),
    CONSTRAINT [FK_CarEvent_Cars_CarId] FOREIGN KEY ([CarId]) REFERENCES [Cars] ([CarId]) ON DELETE CASCADE,
    CONSTRAINT [FK_CarEvent_Event_EventId] FOREIGN KEY ([EventId]) REFERENCES [Event] ([EventId]) ON DELETE CASCADE
);
GO


CREATE TABLE [UserEvents] (
    [UserEventId] int NOT NULL IDENTITY,
    [EventId] int NOT NULL,
    [UserId] nvarchar(450) NULL,
    CONSTRAINT [PK_UserEvents] PRIMARY KEY ([UserEventId]),
    CONSTRAINT [FK_UserEvents_ApplicationUser_UserId] FOREIGN KEY ([UserId]) REFERENCES [ApplicationUser] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_UserEvents_Event_EventId] FOREIGN KEY ([EventId]) REFERENCES [Event] ([EventId]) ON DELETE CASCADE
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
    CONSTRAINT [FK_EventDetail_Detail_DetailId] FOREIGN KEY ([DetailId]) REFERENCES [Detail] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_EventDetail_Event_EventId] FOREIGN KEY ([EventId]) REFERENCES [Event] ([EventId]) ON DELETE CASCADE
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


CREATE INDEX [IdX_Event_CarId] ON [Event] ([CarId]);
GO


CREATE INDEX [IdX_Event_EventTypeId] ON [Event] ([EventTypeId]);
GO


CREATE INDEX [IdX_Event_UserId] ON [Event] ([UserId]);
GO


CREATE INDEX [IX_EventDetail_DetailId] ON [EventDetail] ([DetailId]);
GO


CREATE INDEX [IX_EventDetail_EventId] ON [EventDetail] ([EventId]);
GO


CREATE INDEX [IX_Logger_CarID] ON [Logger] ([CarID]);
GO


CREATE UNIQUE INDEX [IX_RoleEventMappings_Role] ON [RoleEventMappings] ([Role]) WHERE [Role] IS NOT NULL;
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