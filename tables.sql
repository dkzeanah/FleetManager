
USE [aspnet-BlazorApp1-DB]



CREATE TABLE [dbo].[ApplicationUser](
	[Id] [nvarchar](450) NOT NULL,
	[FriendlyName] [nvarchar](max) NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[UserName] [nvarchar](max) NULL,
	[NormalizedUserName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[NormalizedEmail] [nvarchar](max) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[ApplicationUserDetailId] [int] NOT NULL,
 CONSTRAINT [PK_ApplicationUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[ApplicationUserDetail](
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_ApplicationUserDetail] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[Car](
	[CarId] [int] IDENTITY(1,1) NOT NULL,
	[Make] [nvarchar](max) NULL,
	[Model] [nvarchar](max) NULL,
	[Year] [int] NULL,
	[TeleGeneration] [nvarchar](max) NULL,
	[Miles] [int] NULL,
	[Location] [nvarchar](max) NULL,
	[SourceId] [int] NULL,
	[UserId] [nvarchar](max) NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

CREATE TABLE [dbo].[CarStaticDetails](
	[CarStaticDetailId] [int] IDENTITY(1,1) NOT NULL,
	[CarId] [int] NOT NULL,
	[Tag] [nvarchar](max) NOT NULL,
	[Finas] [nvarchar](max) NOT NULL,
	[VinLast4] [nvarchar](max) NOT NULL,
	[HarnessStatus] [nvarchar](max) NULL,
	[FullVin] [nvarchar](max) NULL,
	[SoftwareVersion] [nvarchar](max) NULL,
	[Adas] [nvarchar](max) NULL,
 CONSTRAINT [PK_CarStaticDetails] PRIMARY KEY CLUSTERED 
(
	[CarStaticDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[CarDetail](
	[CarDetailId] [int] IDENTITY(1,1) NOT NULL,
	[Make] [nvarchar](max) NOT NULL,
	[Model] [nvarchar](max) NOT NULL,
	[Year] [nvarchar](max) NOT NULL,
	[Color] [nvarchar](max) NOT NULL,
	[Vin] [nvarchar](max) NOT NULL,
	[CarId] [int] NOT NULL,
	[DetailId] [int] NULL,
 CONSTRAINT [PK_CarDetail] PRIMARY KEY CLUSTERED 
(
	[CarDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[CarEvent](
	[CarEventId] [int] IDENTITY(1,1) NOT NULL,
	[CarId] [int] NOT NULL,
	[EventId] [int] NOT NULL,
 CONSTRAINT [PK_CarEvent] PRIMARY KEY CLUSTERED 
(
	[CarEventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[CarEventDetail](
	[CarEventDetailId] [int] IDENTITY(1,1) NOT NULL,
	[CarEventId] [int] NOT NULL,
	[Note] [nvarchar](max) NOT NULL,
	[CarDetailId] [int] NULL,
 CONSTRAINT [PK_CarEventDetail] PRIMARY KEY CLUSTERED 
(
	[CarEventDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]





CREATE TABLE [dbo].[CarStatus](
	[CarID] [int] NOT NULL,
	[StatusID] [int] NOT NULL,
	[StatusTime] [datetime] NULL
) ON [PRIMARY]



CREATE TABLE [dbo].[Catery](
	[CateryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[DefaultPriority] [int] NOT NULL,
 CONSTRAINT [PK_Catery] PRIMARY KEY CLUSTERED 
(
	[CateryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[Detail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DetailTypeId] [int] NOT NULL,
	[Value] [nvarchar](max) NOT NULL,
	[ApplicationUserId] [nvarchar](450) NULL,
	[Discriminator] [nvarchar](max) NOT NULL,
	[UserId] [nvarchar](max) NULL,
	[UserEventId] [int] NULL,
	[UserEventDetailId] [int] NULL,
	[Note] [nvarchar](max) NULL,
 CONSTRAINT [PK_Detail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[DetailType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[CarDetailId] [int] NULL,
 CONSTRAINT [PK_DetailType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[ErrorLog](
	[ErrorID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[ErrorDetails] [nvarchar](255) NULL,
	[ErrorPriority] [int] NULL,
	[ErrorNotes] [nvarchar](255) NULL,
 CONSTRAINT [PK__ErrorLog__358565CA8BB277F2] PRIMARY KEY CLUSTERED 
(
	[ErrorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[Event](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CarId] [int] NOT NULL,
	[EventTypeId] [int] NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[StartTime] [datetime] NULL,
	[EndTime] [datetime] NULL,
	[Date] [datetime] NOT NULL,
	[Type] [nvarchar](max) NULL,
	[Tag] [nvarchar](max) NULL,
	[Catery] [int] NOT NULL,
 CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[EventDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DetailId] [int] NOT NULL,
	[EventId] [int] NOT NULL,
	[DateAdded] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_EventDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[EventType](
	[EventTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Id] [int] NOT NULL,
	[EventId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__EventTyp__A9216B1F734774DB] PRIMARY KEY CLUSTERED 
(
	[EventTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[Logger](
	[LoggerID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[TypeLogger] [nvarchar](50) NOT NULL,
	[NumLoggers] [int] NOT NULL,
 CONSTRAINT [PK__Logger__0ABCCA66A1861B17] PRIMARY KEY CLUSTERED 
(
	[LoggerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[RoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](max) NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_RoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[RoleEventMappings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Role] [nvarchar](450) NULL,
	[DefaultEventTypeId] [int] NOT NULL,
 CONSTRAINT [PK_RoleEventMappings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[Roles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[NormalizedName] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[Source](
	[SourceID] [int] IDENTITY(1,1) NOT NULL,
	[SourceName] [nvarchar](50) NULL,
 CONSTRAINT [PK__Source__16E019F99EE16562] PRIMARY KEY CLUSTERED 
(
	[SourceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[Status](
	[StatusID] [int] NOT NULL,
	[StatusName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Status__C8EE2043906DCC08] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[TicketAttachment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TicketId] [int] NOT NULL,
	[FilePath] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TicketAttachment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[TicketComment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TicketId] [int] NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[AuthorId] [nvarchar](450) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_TicketComment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[TicketHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TicketId] [int] NOT NULL,
	[Change] [nvarchar](max) NOT NULL,
	[ChangedAt] [datetime2](7) NOT NULL,
	[ChangedById] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_TicketHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[Tickets](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[CreatorId] [nvarchar](450) NOT NULL,
	[AssigneeId] [nvarchar](450) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[UpdatedAt] [datetime2](7) NULL,
	[ClosedAt] [datetime2](7) NULL,
	[Status] [nvarchar](max) NOT NULL,
	[Severity] [nvarchar](max) NOT NULL,
	[Priority] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[TicketTag](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TicketId] [int] NOT NULL,
	[Tag] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TicketTag] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[UserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](max) NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[UserDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](max) NOT NULL,
	[DetailId] [int] NOT NULL,
	[ApplicationUserId] [nvarchar](450) NULL,
 CONSTRAINT [PK_UserDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[UserEvents](
	[UserEventId] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NOT NULL,
	[UserId] [nvarchar](450) NULL,
 CONSTRAINT [PK_UserEvents] PRIMARY KEY CLUSTERED 
(
	[UserEventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[UserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[UserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[UserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[BlankModels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_BlankModels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[CarStatus_New](
	[StatusID] [int] NOT NULL,
	[StatusName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__CarStatu__C8EE2043D8294AF0] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[Drivers](
	[DriverId] [int] IDENTITY(1,1) NOT NULL,
	[DrivingHours] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Drivers] PRIMARY KEY CLUSTERED 
(
	[DriverId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[Issues](
	[IssueId] [int] IDENTITY(1,1) NOT NULL,
	[Summary] [nvarchar](max) NOT NULL,
	[Status] [nvarchar](max) NOT NULL,
	[Priority] [nvarchar](max) NOT NULL,
	[AssignedTo] [nvarchar](max) NOT NULL,
	[System] [nvarchar](max) NOT NULL,
	[ModifiedBy] [nvarchar](max) NOT NULL,
	[ModifiedAt] [nvarchar](max) NOT NULL,
	[ModifiedByUser] [nvarchar](max) NOT NULL,
	[SubmittedBy] [nvarchar](max) NOT NULL,
	[SubmittedAt] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Issues] PRIMARY KEY CLUSTERED 
(
	[IssueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]



CREATE TABLE [dbo].[Log](
	[LogID] [int] IDENTITY(1,1) NOT NULL,
	[LogMessage] [nvarchar](255) NOT NULL,
	[LogTime] [datetime] NULL,
 CONSTRAINT [PK__Log__5E5499A88878D432] PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



CREATE TABLE [dbo].[Software](
	[SoftwareID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[HeadUnit] [nvarchar](50) NOT NULL,
	[SoftwareVersion] [nvarchar](50) NOT NULL,
	[NextSoftwareVersion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Software__25EDB8DCFDCE01A5] PRIMARY KEY CLUSTERED 
(
	[SoftwareID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



INSERT [dbo].[ApplicationUser] ([Id], [FriendlyName], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [ApplicationUserDetailId]) VALUES (N'ebc0a619-8758-43c0-bbc5-7fd9e8cd6d79', N'Donovan Zeanah', NULL, NULL, N'd@d.com', N'D@D.COM', N'd@d.com', N'D@D.COM', 1, N'AQAAAAIAAYagAAAAEKJoP3glAhdQ813NBF1cdLH8/stoFhMgcJV0uTvf1RejbWtvWzos+64nEnwcYpMSxQ==', N'T3DVYXPVW7MXQ2HSATFAVIMFUWT25OEP', N'dfd1d160-9eae-457f-a735-af6f36e5c9c4', NULL, 0, 0, NULL, 1, 0, 0)

INSERT [dbo].[AspNetRoles] ([Id]) VALUES (N'1899d6f0-e6df-4bfb-a598-b67053170ef5')

INSERT [dbo].[AspNetRoles] ([Id]) VALUES (N'341c7c93-fe97-4e65-911b-a09ef77c8120')

INSERT [dbo].[AspNetRoles] ([Id]) VALUES (N'76c994a7-75e1-4b2d-a8a0-0b8f88efd8a8')

INSERT [dbo].[AspNetRoles] ([Id]) VALUES (N'862220e1-8f02-41c6-a5af-92ca24c5a689')

INSERT [dbo].[AspNetRoles] ([Id]) VALUES (N'd7123fbf-e969-435f-9ee5-7b272cfd5204')




INSERT [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1899d6f0-e6df-4bfb-a598-b67053170ef5', N'Organizer', N'ORGANIZER', NULL)

INSERT [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'341c7c93-fe97-4e65-911b-a09ef77c8120', N'Contact', N'CONTACT', NULL)

INSERT [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'76c994a7-75e1-4b2d-a8a0-0b8f88efd8a8', N'Technician', N'TECHNICIAN', NULL)

INSERT [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'862220e1-8f02-41c6-a5af-92ca24c5a689', N'Admin', N'ADMIN', NULL)

INSERT [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'd7123fbf-e969-435f-9ee5-7b272cfd5204', N'Driver', N'DRIVER', NULL)

INSERT [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (N'ebc0a619-8758-43c0-bbc5-7fd9e8cd6d79', N'862220e1-8f02-41c6-a5af-92ca24c5a689')



/****** Object:  Index [IX_CarDetail_CarId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_CarDetail_CarId] ON [dbo].[CarDetail]
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_CarDetail_DetailId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_CarDetail_DetailId] ON [dbo].[CarDetail]
(
	[DetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_CarEvent_CarId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_CarEvent_CarId] ON [dbo].[CarEvent]
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_CarEvent_EventId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_CarEvent_EventId] ON [dbo].[CarEvent]
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_CarEventDetail_CarDetailId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_CarEventDetail_CarDetailId] ON [dbo].[CarEventDetail]
(
	[CarDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_CarEventDetail_CarEventId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_CarEventDetail_CarEventId] ON [dbo].[CarEventDetail]
(
	[CarEventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_CarStaticDetails_CarId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_CarStaticDetails_CarId] ON [dbo].[CarStaticDetails]
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_CarStatus_CarID]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_CarStatus_CarID] ON [dbo].[CarStatus]
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_CarStatus_StatusID]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_CarStatus_StatusID] ON [dbo].[CarStatus]
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

SET ANSI_PADDING ON

/****** Object:  Index [IX_Detail_ApplicationUserId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_Detail_ApplicationUserId] ON [dbo].[Detail]
(
	[ApplicationUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_Detail_DetailTypeId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_Detail_DetailTypeId] ON [dbo].[Detail]
(
	[DetailTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_Detail_UserEventDetailId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_Detail_UserEventDetailId] ON [dbo].[Detail]
(
	[UserEventDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_DetailType_CarDetailId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_DetailType_CarDetailId] ON [dbo].[DetailType]
(
	[CarDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IDX_ErrorLog_CarID]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IDX_ErrorLog_CarID] ON [dbo].[ErrorLog]
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_EventDetail_DetailId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_EventDetail_DetailId] ON [dbo].[EventDetail]
(
	[DetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_EventDetail_EventId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_EventDetail_EventId] ON [dbo].[EventDetail]
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_Logger_CarID]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_Logger_CarID] ON [dbo].[Logger]
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

SET ANSI_PADDING ON

/****** Object:  Index [IX_RoleEventMappings_Role]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_RoleEventMappings_Role] ON [dbo].[RoleEventMappings]
(
	[Role] ASC
)
WHERE ([Role] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

SET ANSI_PADDING ON

/****** Object:  Index [UQ_StatusName]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_StatusName] ON [dbo].[Status]
(
	[StatusName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_TicketAttachment_TicketId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_TicketAttachment_TicketId] ON [dbo].[TicketAttachment]
(
	[TicketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

SET ANSI_PADDING ON

/****** Object:  Index [IX_TicketComment_AuthorId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_TicketComment_AuthorId] ON [dbo].[TicketComment]
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_TicketComment_TicketId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_TicketComment_TicketId] ON [dbo].[TicketComment]
(
	[TicketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

SET ANSI_PADDING ON

/****** Object:  Index [IX_TicketHistory_ChangedById]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_TicketHistory_ChangedById] ON [dbo].[TicketHistory]
(
	[ChangedById] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_TicketHistory_TicketId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_TicketHistory_TicketId] ON [dbo].[TicketHistory]
(
	[TicketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

SET ANSI_PADDING ON

/****** Object:  Index [IX_Tickets_AssigneeId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_Tickets_AssigneeId] ON [dbo].[Tickets]
(
	[AssigneeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

SET ANSI_PADDING ON

/****** Object:  Index [IX_Tickets_CreatorId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_Tickets_CreatorId] ON [dbo].[Tickets]
(
	[CreatorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_TicketTag_TicketId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_TicketTag_TicketId] ON [dbo].[TicketTag]
(
	[TicketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

SET ANSI_PADDING ON

/****** Object:  Index [IX_UserDetail_ApplicationUserId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserDetail_ApplicationUserId] ON [dbo].[UserDetail]
(
	[ApplicationUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_UserDetail_DetailId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserDetail_DetailId] ON [dbo].[UserDetail]
(
	[DetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IX_UserEvents_EventId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserEvents_EventId] ON [dbo].[UserEvents]
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

SET ANSI_PADDING ON

/****** Object:  Index [IX_UserEvents_UserId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserEvents_UserId] ON [dbo].[UserEvents]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

/****** Object:  Index [IDX_Software_CarID]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IDX_Software_CarID] ON [dbo].[Software]
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

ALTER TABLE [dbo].[ApplicationUser] ADD  DEFAULT ((0)) FOR [ApplicationUserDetailId]

ALTER TABLE [dbo].[Event] ADD  DEFAULT ((0)) FOR [Catery]

ALTER TABLE [dbo].[Log] ADD  DEFAULT (getdate()) FOR [LogTime]

ALTER TABLE [dbo].[ApplicationUserDetail]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationUserDetail_ApplicationUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
ON DELETE CASCADE

ALTER TABLE [dbo].[ApplicationUserDetail] CHECK CONSTRAINT [FK_ApplicationUserDetail_ApplicationUser_UserId]

ALTER TABLE [dbo].[AspNetRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoles_Roles_Id] FOREIGN KEY([Id])
REFERENCES [dbo].[Roles] ([Id])

ALTER TABLE [dbo].[AspNetRoles] CHECK CONSTRAINT [FK_AspNetRoles_Roles_Id]

ALTER TABLE [dbo].[CarDetail]  WITH CHECK ADD  CONSTRAINT [FK_CarDetail_Cars_CarId] FOREIGN KEY([CarId])
REFERENCES [dbo].[Car] ([CarId])
ON DELETE CASCADE

ALTER TABLE [dbo].[CarDetail] CHECK CONSTRAINT [FK_CarDetail_Cars_CarId]

ALTER TABLE [dbo].[CarDetail]  WITH CHECK ADD  CONSTRAINT [FK_CarDetail_Detail_DetailId] FOREIGN KEY([DetailId])
REFERENCES [dbo].[Detail] ([Id])

ALTER TABLE [dbo].[CarDetail] CHECK CONSTRAINT [FK_CarDetail_Detail_DetailId]

ALTER TABLE [dbo].[CarEvent]  WITH CHECK ADD  CONSTRAINT [FK_CarEvent_Cars_CarId] FOREIGN KEY([CarId])
REFERENCES [dbo].[Car] ([CarId])
ON DELETE CASCADE

ALTER TABLE [dbo].[CarEvent] CHECK CONSTRAINT [FK_CarEvent_Cars_CarId]

ALTER TABLE [dbo].[CarEventDetail]  WITH CHECK ADD  CONSTRAINT [FK_CarEventDetail_CarDetail_CarDetailId] FOREIGN KEY([CarDetailId])
REFERENCES [dbo].[CarDetail] ([CarDetailId])

ALTER TABLE [dbo].[CarEventDetail] CHECK CONSTRAINT [FK_CarEventDetail_CarDetail_CarDetailId]

ALTER TABLE [dbo].[CarEventDetail]  WITH CHECK ADD  CONSTRAINT [FK_CarEventDetail_CarEvent_CarEventId] FOREIGN KEY([CarEventId])
REFERENCES [dbo].[CarEvent] ([CarEventId])
ON DELETE CASCADE

ALTER TABLE [dbo].[CarEventDetail] CHECK CONSTRAINT [FK_CarEventDetail_CarEvent_CarEventId]

ALTER TABLE [dbo].[CarStaticDetails]  WITH CHECK ADD  CONSTRAINT [FK_CarStaticDetails_Cars_CarId] FOREIGN KEY([CarId])
REFERENCES [dbo].[Car] ([CarId])

ALTER TABLE [dbo].[CarStaticDetails] CHECK CONSTRAINT [FK_CarStaticDetails_Cars_CarId]

ALTER TABLE [dbo].[CarStatus]  WITH CHECK ADD  CONSTRAINT [FK__CarStatus__CarID__498EEC8D] FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([CarId])

ALTER TABLE [dbo].[CarStatus] CHECK CONSTRAINT [FK__CarStatus__CarID__498EEC8D]

ALTER TABLE [dbo].[CarStatus]  WITH CHECK ADD  CONSTRAINT [FK__CarStatus__Statu__4A8310C6] FOREIGN KEY([StatusID])
REFERENCES [dbo].[Status] ([StatusID])

ALTER TABLE [dbo].[CarStatus] CHECK CONSTRAINT [FK__CarStatus__Statu__4A8310C6]

ALTER TABLE [dbo].[Detail]  WITH CHECK ADD  CONSTRAINT [FK_Detail_ApplicationUser_ApplicationUserId] FOREIGN KEY([ApplicationUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])

ALTER TABLE [dbo].[Detail] CHECK CONSTRAINT [FK_Detail_ApplicationUser_ApplicationUserId]

ALTER TABLE [dbo].[Detail]  WITH CHECK ADD  CONSTRAINT [FK_Detail_DetailType_DetailTypeId] FOREIGN KEY([DetailTypeId])
REFERENCES [dbo].[DetailType] ([Id])
ON DELETE CASCADE

ALTER TABLE [dbo].[Detail] CHECK CONSTRAINT [FK_Detail_DetailType_DetailTypeId]

ALTER TABLE [dbo].[Detail]  WITH CHECK ADD  CONSTRAINT [FK_Detail_UserEvents_UserEventDetailId] FOREIGN KEY([UserEventDetailId])
REFERENCES [dbo].[UserEvents] ([UserEventId])
ON DELETE CASCADE

ALTER TABLE [dbo].[Detail] CHECK CONSTRAINT [FK_Detail_UserEvents_UserEventDetailId]

ALTER TABLE [dbo].[DetailType]  WITH CHECK ADD  CONSTRAINT [FK_DetailType_CarDetail_CarDetailId] FOREIGN KEY([CarDetailId])
REFERENCES [dbo].[CarDetail] ([CarDetailId])

ALTER TABLE [dbo].[DetailType] CHECK CONSTRAINT [FK_DetailType_CarDetail_CarDetailId]

ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_ApplicationUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[ApplicationUser] ([Id])

ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_ApplicationUser_UserId]

ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_Car_CarId] FOREIGN KEY([CarId])
REFERENCES [dbo].[Car] ([CarId])

ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_Car_CarId]

ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_EventType_EventTypeId] FOREIGN KEY([EventTypeId])
REFERENCES [dbo].[EventType] ([EventTypeID])

ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_EventType_EventTypeId]

ALTER TABLE [dbo].[EventDetail]  WITH CHECK ADD  CONSTRAINT [FK_EventDetail_Detail_DetailId] FOREIGN KEY([DetailId])
REFERENCES [dbo].[Detail] ([Id])

ALTER TABLE [dbo].[EventDetail] CHECK CONSTRAINT [FK_EventDetail_Detail_DetailId]

ALTER TABLE [dbo].[Logger]  WITH CHECK ADD  CONSTRAINT [FK__Logger__CarID__5224328E] FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([CarId])

ALTER TABLE [dbo].[Logger] CHECK CONSTRAINT [FK__Logger__CarID__5224328E]

ALTER TABLE [dbo].[TicketAttachment]  WITH CHECK ADD  CONSTRAINT [FK_TicketAttachment_Tickets_TicketId] FOREIGN KEY([TicketId])
REFERENCES [dbo].[Tickets] ([Id])
ON DELETE CASCADE

ALTER TABLE [dbo].[TicketAttachment] CHECK CONSTRAINT [FK_TicketAttachment_Tickets_TicketId]

ALTER TABLE [dbo].[TicketComment]  WITH CHECK ADD  CONSTRAINT [FK_TicketComment_ApplicationUser_AuthorId] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[ApplicationUser] ([Id])
ON DELETE CASCADE

ALTER TABLE [dbo].[TicketComment] CHECK CONSTRAINT [FK_TicketComment_ApplicationUser_AuthorId]

ALTER TABLE [dbo].[TicketComment]  WITH CHECK ADD  CONSTRAINT [FK_TicketComment_Tickets_TicketId] FOREIGN KEY([TicketId])
REFERENCES [dbo].[Tickets] ([Id])
ON DELETE CASCADE

ALTER TABLE [dbo].[TicketComment] CHECK CONSTRAINT [FK_TicketComment_Tickets_TicketId]

ALTER TABLE [dbo].[TicketHistory]  WITH CHECK ADD  CONSTRAINT [FK_TicketHistory_ApplicationUser_ChangedById] FOREIGN KEY([ChangedById])
REFERENCES [dbo].[ApplicationUser] ([Id])
ON DELETE CASCADE

ALTER TABLE [dbo].[TicketHistory] CHECK CONSTRAINT [FK_TicketHistory_ApplicationUser_ChangedById]

ALTER TABLE [dbo].[TicketHistory]  WITH CHECK ADD  CONSTRAINT [FK_TicketHistory_Tickets_TicketId] FOREIGN KEY([TicketId])
REFERENCES [dbo].[Tickets] ([Id])
ON DELETE CASCADE

ALTER TABLE [dbo].[TicketHistory] CHECK CONSTRAINT [FK_TicketHistory_Tickets_TicketId]

ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_ApplicationUser_AssigneeId] FOREIGN KEY([AssigneeId])
REFERENCES [dbo].[ApplicationUser] ([Id])

ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_ApplicationUser_AssigneeId]

ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_ApplicationUser_CreatorId] FOREIGN KEY([CreatorId])
REFERENCES [dbo].[ApplicationUser] ([Id])

ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_ApplicationUser_CreatorId]

ALTER TABLE [dbo].[TicketTag]  WITH CHECK ADD  CONSTRAINT [FK_TicketTag_Tickets_TicketId] FOREIGN KEY([TicketId])
REFERENCES [dbo].[Tickets] ([Id])
ON DELETE CASCADE

ALTER TABLE [dbo].[TicketTag] CHECK CONSTRAINT [FK_TicketTag_Tickets_TicketId]

ALTER TABLE [dbo].[UserDetail]  WITH CHECK ADD  CONSTRAINT [FK_UserDetail_ApplicationUser_ApplicationUserId] FOREIGN KEY([ApplicationUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])

ALTER TABLE [dbo].[UserDetail] CHECK CONSTRAINT [FK_UserDetail_ApplicationUser_ApplicationUserId]

ALTER TABLE [dbo].[UserDetail]  WITH CHECK ADD  CONSTRAINT [FK_UserDetail_Detail_DetailId] FOREIGN KEY([DetailId])
REFERENCES [dbo].[Detail] ([Id])
ON DELETE CASCADE

ALTER TABLE [dbo].[UserDetail] CHECK CONSTRAINT [FK_UserDetail_Detail_DetailId]

ALTER TABLE [dbo].[UserEvents]  WITH CHECK ADD  CONSTRAINT [FK_UserEvents_ApplicationUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[ApplicationUser] ([Id])

ALTER TABLE [dbo].[UserEvents] CHECK CONSTRAINT [FK_UserEvents_ApplicationUser_UserId]

USE [master]

ALTER DATABASE [aspnet-BlazorApp1-DB] SET  READ_WRITE 

