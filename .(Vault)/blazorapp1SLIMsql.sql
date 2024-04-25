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

CREATE TABLE [dbo].[ApplicationUserDetail](
	[UserId] [nvarchar](450) NOT NULL,


CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,

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
 
CREATE TABLE [dbo].[CarDetail](
	[CarDetailId] [int] IDENTITY(1,1) NOT NULL,
	[Make] [nvarchar](max) NOT NULL,
	[Model] [nvarchar](max) NOT NULL,
	[Year] [nvarchar](max) NOT NULL,
	[Color] [nvarchar](max) NOT NULL,
	[Vin] [nvarchar](max) NOT NULL,
	[CarId] [int] NOT NULL,
	[DetailId] [int] NULL,
 
--CREATE TABLE [dbo].[CarEvent](
	[CarEventId] [int] IDENTITY(1,1) NOT NULL,
	[CarId] [int] NOT NULL,
	[EventId] [int] NOT NULL,
 
--CREATE TABLE [dbo].[CarEventDetail](
	[CarEventDetailId] [int] IDENTITY(1,1) NOT NULL,
	[CarEventId] [int] NOT NULL,
	[Note] [nvarchar](max) NOT NULL,
	[CarDetailId] [int] NULL,

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
 
CREATE TABLE [dbo].[CarStatus](
	[CarID] [int] NOT NULL,
	[StatusID] [int] NOT NULL,
	[StatusTime] [datetime] NULL


CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[DefaultPriority] [int] NOT NULL,
 
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
 
CREATE TABLE [dbo].[DetailType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[CarDetailId] [int] NULL,
 
CREATE TABLE [dbo].[ErrorLog](
	[ErrorID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[ErrorDetails] [nvarchar](255) NULL,
	[ErrorPriority] [int] NULL,
	[ErrorNotes] [nvarchar](255) NULL,

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
	[Category] [int] NOT NULL,
 

CREATE TABLE [dbo].[EventDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DetailId] [int] NOT NULL,
	[EventId] [int] NOT NULL,
	[DateAdded] [datetime2](7) NOT NULL,
 
CREATE TABLE [dbo].[EventType](
	[EventTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Id] [int] NOT NULL,
	[EventId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 
CREATE TABLE [dbo].[Logger](
	[LoggerID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[TypeLogger] [nvarchar](50) NOT NULL,
	[NumLoggers] [int] NOT NULL,
 CONSTRAINT [PK__Logger__0ABCCA66A1861B17] PRIMARY KEY CLUSTERED 

CREATE TABLE [dbo].[RoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](max) NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 
CREATE TABLE [dbo].[RoleEventMappings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Role] [nvarchar](450) NULL,
	[DefaultEventTypeId] [int] NOT NULL,
 
CREATE TABLE [dbo].[Roles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[NormalizedName] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 
CREATE TABLE [dbo].[Source](
	[SourceID] [int] IDENTITY(1,1) NOT NULL,
	[SourceName] [nvarchar](50) NULL,
 
CREATE TABLE [dbo].[Status](
	[StatusID] [int] NOT NULL,
	[StatusName] [nvarchar](50) NOT NULL,
 
CREATE TABLE [dbo].[TicketAttachment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TicketId] [int] NOT NULL,
	[FilePath] [nvarchar](max) NOT NULL,
 
CREATE TABLE [dbo].[TicketComment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TicketId] [int] NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[AuthorId] [nvarchar](450) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
 
CREATE TABLE [dbo].[TicketHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TicketId] [int] NOT NULL,
	[Change] [nvarchar](max) NOT NULL,
	[ChangedAt] [datetime2](7) NOT NULL,
	[ChangedById] [nvarchar](450) NOT NULL,
 
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

CREATE TABLE [dbo].[TicketTag](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TicketId] [int] NOT NULL,
	[Tag] [nvarchar](max) NOT NULL,
 
CREATE TABLE [dbo].[UserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](max) NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,

CREATE TABLE [dbo].[UserDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](max) NOT NULL,
	[DetailId] [int] NOT NULL,
	[ApplicationUserId] [nvarchar](450) NULL,
 
CREATE TABLE [dbo].[UserEvents](
	[UserEventId] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NOT NULL,
	[UserId] [nvarchar](450) NULL,
 
CREATE TABLE [dbo].[UserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](max) NULL,
 
CREATE TABLE [dbo].[UserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 
CREATE TABLE [dbo].[UserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,

CREATE TABLE [dbo].[BlankModels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
 
CREATE TABLE [dbo].[CarStatus_New](
	[StatusID] [int] NOT NULL,
	[StatusName] [nvarchar](50) NOT NULL,
 
CREATE TABLE [dbo].[Drivers](
	[DriverId] [int] IDENTITY(1,1) NOT NULL,
	[DrivingHours] [decimal](18, 2) NOT NULL,
 
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
 
CREATE TABLE [dbo].[Log](
	[LogID] [int] IDENTITY(1,1) NOT NULL,
	[LogMessage] [nvarchar](255) NOT NULL,
	[LogTime] [datetime] NULL,
 
CREATE TABLE [dbo].[Software](
	[SoftwareID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[HeadUnit] [nvarchar](50) NOT NULL,
	[SoftwareVersion] [nvarchar](50) NOT NULL,
	[NextSoftwareVersion] [nvarchar](50) NOT NULL,

CREATE TABLE [dbo].[Temp_ErrorLog](
	[ErrorID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[ErrorDetails] [nvarchar](255) NULL,
	[ErrorPriority] [int] NULL,
	[ErrorNotes] [nvarchar](255) NULL

CREATE TABLE [dbo].[Temp_Event](
	[EventID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[EventTypeID] [int] NOT NULL,
	[StartTime] [datetime] NOT NULL,
	[EndTime] [datetime] NOT NULL

CREATE TABLE [dbo].[Temp_Logger](
	[LoggerID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[TypeLogger] [nvarchar](50) NOT NULL,
	[NumLoggers] [int] NOT NULL

CREATE TABLE [dbo].[Temp_Repair](
	[RepairID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[TechnicianID] [int] NOT NULL,
	[RepairDetails] [nvarchar](255) NOT NULL,
	[RepairStart] [datetime] NOT NULL,
	[RepairEnd] [datetime] NOT NULL

CREATE TABLE [dbo].[Temp_Software](
	[SoftwareID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[HeadUnit] [nvarchar](50) NOT NULL,
	[SoftwareVersion] [nvarchar](50) NOT NULL,
	[NextSoftwareVersion] [nvarchar](50) NOT NULL

CREATE NONCLUSTERED INDEX [IX_CarDetail_CarId] ON [dbo].[CarDetail]
CREATE NONCLUSTERED INDEX [IX_CarDetail_DetailId] ON [dbo].[CarDetail]
CREATE NONCLUSTERED INDEX [IX_CarEvent_CarId] ON [dbo].[CarEvent]
CREATE NONCLUSTERED INDEX [IX_CarEvent_EventId] ON [dbo].[CarEvent]
CREATE NONCLUSTERED INDEX [IX_CarEventDetail_CarDetailId] ON [dbo].[CarEventDetail]
CREATE NONCLUSTERED INDEX [IX_CarEventDetail_CarEventId] ON [dbo].[CarEventDetail]
CREATE NONCLUSTERED INDEX [IX_CarStatus_CarID] ON [dbo].[CarStatus]
CREATE NONCLUSTERED INDEX [IX_CarStatus_StatusID] ON [dbo].[CarStatus]
CREATE NONCLUSTERED INDEX [IX_Detail_ApplicationUserId] ON [dbo].[Detail]
CREATE NONCLUSTERED INDEX [IX_Detail_DetailTypeId] ON [dbo].[Detail]
CREATE NONCLUSTERED INDEX [IX_Detail_UserEventDetailId] ON [dbo].[Detail]
CREATE NONCLUSTERED INDEX [IX_DetailType_CarDetailId] ON [dbo].[DetailType]
CREATE NONCLUSTERED INDEX [IDX_ErrorLog_CarID] ON [dbo].[ErrorLog]
CREATE NONCLUSTERED INDEX [IX_EventDetail_DetailId] ON [dbo].[EventDetail]
CREATE NONCLUSTERED INDEX [IX_EventDetail_EventId] ON [dbo].[EventDetail]
CREATE NONCLUSTERED INDEX [IX_Logger_CarID] ON [dbo].[Logger]
CREATE NONCLUSTERED INDEX [IX_TicketAttachment_TicketId] ON [dbo].[TicketAttachment]
CREATE NONCLUSTERED INDEX [IX_TicketComment_AuthorId] ON [dbo].[TicketComment]
CREATE NONCLUSTERED INDEX [IX_TicketComment_TicketId] ON [dbo].[TicketComment]
CREATE NONCLUSTERED INDEX [IX_TicketHistory_ChangedById] ON [dbo].[TicketHistory]
CREATE NONCLUSTERED INDEX [IX_TicketHistory_TicketId] ON [dbo].[TicketHistory]
CREATE NONCLUSTERED INDEX [IX_Tickets_AssigneeId] ON [dbo].[Tickets]
CREATE NONCLUSTERED INDEX [IX_Tickets_CreatorId] ON [dbo].[Tickets]
CREATE NONCLUSTERED INDEX [IX_TicketTag_TicketId] ON [dbo].[TicketTag]
CREATE NONCLUSTERED INDEX [IX_UserDetail_ApplicationUserId] ON [dbo].[UserDetail]
CREATE NONCLUSTERED INDEX [IX_UserDetail_DetailId] ON [dbo].[UserDetail]
CREATE NONCLUSTERED INDEX [IX_UserEvents_EventId] ON [dbo].[UserEvents]
CREATE NONCLUSTERED INDEX [IX_UserEvents_UserId] ON [dbo].[UserEvents]
CREATE NONCLUSTERED INDEX [IDX_Software_CarID] ON [dbo].[Software]
CREATE UNIQUE NONCLUSTERED INDEX [IX_RoleEventMappings_Role] ON [dbo].[RoleEventMappings]
CREATE UNIQUE NONCLUSTERED INDEX [UQ_StatusName] ON [dbo].[Status]
ALTER TABLE [dbo].[ApplicationUser] ADD  DEFAULT ((0)) FOR [ApplicationUserDetailId]
ALTER TABLE [dbo].[Event] ADD  DEFAULT ((0)) FOR [Category]
ALTER TABLE [dbo].[Log] ADD  DEFAULT (getdate()) FOR [LogTime]
ALTER TABLE [dbo].[ApplicationUserDetail]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationUserDetail_ApplicationUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[ApplicationUser] ([Id]