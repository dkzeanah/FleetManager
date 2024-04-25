USE [master]
GO
/****** Object:  Database [aspnet-BlazorApp1-DB]    Script Date: 7/24/2023 8:25:05 PM ******/
CREATE DATABASE [aspnet-BlazorApp1-DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'aspnet-BlazorApp1-DB', FILENAME = N'C:\Users\zeanahD\aspnet-BlazorApp1-DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'aspnet-BlazorApp1-DB_log', FILENAME = N'C:\Users\zeanahD\aspnet-BlazorApp1-DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [aspnet-BlazorApp1-DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET  MULTI_USER 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET QUERY_STORE = OFF
GO
USE [aspnet-BlazorApp1-DB]
GO
/****** Object:  Table [dbo].[ApplicationUser]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[ApplicationUserDetail]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationUserDetail](
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_ApplicationUserDetail] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Car]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[CarDetail]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[CarEvent]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarEvent](
	[CarEventId] [int] IDENTITY(1,1) NOT NULL,
	[CarId] [int] NOT NULL,
	[EventId] [int] NOT NULL,
 CONSTRAINT [PK_CarEvent] PRIMARY KEY CLUSTERED 
(
	[CarEventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarEventDetail]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[CarStaticDetails]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[CarStatus]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarStatus](
	[CarID] [int] NOT NULL,
	[StatusID] [int] NOT NULL,
	[StatusTime] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[DefaultPriority] [int] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detail]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[DetailType]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetailType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[CarDetailId] [int] NULL,
 CONSTRAINT [PK_DetailType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ErrorLog]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[Event]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
 CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventDetail]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[EventType]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[Logger]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[RoleClaims]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[RoleEventMappings]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleEventMappings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Role] [nvarchar](450) NULL,
	[DefaultEventTypeId] [int] NOT NULL,
 CONSTRAINT [PK_RoleEventMappings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[Source]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Source](
	[SourceID] [int] IDENTITY(1,1) NOT NULL,
	[SourceName] [nvarchar](50) NULL,
 CONSTRAINT [PK__Source__16E019F99EE16562] PRIMARY KEY CLUSTERED 
(
	[SourceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[StatusID] [int] NOT NULL,
	[StatusName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Status__C8EE2043906DCC08] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TicketAttachment]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TicketAttachment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TicketId] [int] NOT NULL,
	[FilePath] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TicketAttachment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TicketComment]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[TicketHistory]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[TicketTag]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TicketTag](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TicketId] [int] NOT NULL,
	[Tag] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TicketTag] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserClaims]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[UserDetail]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[UserEvents]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserEvents](
	[UserEventId] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NOT NULL,
	[UserId] [nvarchar](450) NULL,
 CONSTRAINT [PK_UserEvents] PRIMARY KEY CLUSTERED 
(
	[UserEventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLogins]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTokens]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BlankModels]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BlankModels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_BlankModels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarStatus_New]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarStatus_New](
	[StatusID] [int] NOT NULL,
	[StatusName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__CarStatu__C8EE2043D8294AF0] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Drivers]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Drivers](
	[DriverId] [int] IDENTITY(1,1) NOT NULL,
	[DrivingHours] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Drivers] PRIMARY KEY CLUSTERED 
(
	[DriverId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Issues]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[Log]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Log](
	[LogID] [int] IDENTITY(1,1) NOT NULL,
	[LogMessage] [nvarchar](255) NOT NULL,
	[LogTime] [datetime] NULL,
 CONSTRAINT [PK__Log__5E5499A88878D432] PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Software]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[Temp_ErrorLog]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Temp_ErrorLog](
	[ErrorID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[ErrorDetails] [nvarchar](255) NULL,
	[ErrorPriority] [int] NULL,
	[ErrorNotes] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Temp_Event]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Temp_Event](
	[EventID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[EventTypeID] [int] NOT NULL,
	[StartTime] [datetime] NOT NULL,
	[EndTime] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Temp_Logger]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Temp_Logger](
	[LoggerID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[TypeLogger] [nvarchar](50) NOT NULL,
	[NumLoggers] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Temp_Repair]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Temp_Repair](
	[RepairID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[TechnicianID] [int] NOT NULL,
	[RepairDetails] [nvarchar](255) NOT NULL,
	[RepairStart] [datetime] NOT NULL,
	[RepairEnd] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Temp_Software]    Script Date: 7/24/2023 8:25:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Temp_Software](
	[SoftwareID] [int] IDENTITY(1,1) NOT NULL,
	[CarID] [int] NOT NULL,
	[HeadUnit] [nvarchar](50) NOT NULL,
	[SoftwareVersion] [nvarchar](50) NOT NULL,
	[NextSoftwareVersion] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[ApplicationUser] ([Id], [FriendlyName], [FirstName], [LastName], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [ApplicationUserDetailId]) VALUES (N'ebc0a619-8758-43c0-bbc5-7fd9e8cd6d79', N'Donovan Zeanah', NULL, NULL, N'd@d.com', N'D@D.COM', N'd@d.com', N'D@D.COM', 1, N'AQAAAAIAAYagAAAAEKJoP3glAhdQ813NBF1cdLH8/stoFhMgcJV0uTvf1RejbWtvWzos+64nEnwcYpMSxQ==', N'T3DVYXPVW7MXQ2HSATFAVIMFUWT25OEP', N'dfd1d160-9eae-457f-a735-af6f36e5c9c4', NULL, 0, 0, NULL, 1, 0, 0)
GO
INSERT [dbo].[AspNetRoles] ([Id]) VALUES (N'1899d6f0-e6df-4bfb-a598-b67053170ef5')
GO
INSERT [dbo].[AspNetRoles] ([Id]) VALUES (N'341c7c93-fe97-4e65-911b-a09ef77c8120')
GO
INSERT [dbo].[AspNetRoles] ([Id]) VALUES (N'76c994a7-75e1-4b2d-a8a0-0b8f88efd8a8')
GO
INSERT [dbo].[AspNetRoles] ([Id]) VALUES (N'862220e1-8f02-41c6-a5af-92ca24c5a689')
GO
INSERT [dbo].[AspNetRoles] ([Id]) VALUES (N'd7123fbf-e969-435f-9ee5-7b272cfd5204')
GO
SET IDENTITY_INSERT [dbo].[Car] ON 
GO
INSERT [dbo].[Car] ([CarId], [Make], [Model], [Year], [TeleGeneration], [Miles], [Location], [SourceId], [UserId]) VALUES (1, N'ttest', N'ttest', 2025, N'gen20', 400, N'tuscaloosa', NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Car] OFF
GO
SET IDENTITY_INSERT [dbo].[CarStaticDetails] ON 
GO
INSERT [dbo].[CarStaticDetails] ([CarStaticDetailId], [CarId], [Tag], [Finas], [VinLast4], [HarnessStatus], [FullVin], [SoftwareVersion], [Adas]) VALUES (1, 1, N'tfer', N'4965-fdsa', N'gjt', N'1', N'trewertre', N'e232', N'1')
GO
SET IDENTITY_INSERT [dbo].[CarStaticDetails] OFF
GO
INSERT [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'1899d6f0-e6df-4bfb-a598-b67053170ef5', N'Organizer', N'ORGANIZER', NULL)
GO
INSERT [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'341c7c93-fe97-4e65-911b-a09ef77c8120', N'Contact', N'CONTACT', NULL)
GO
INSERT [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'76c994a7-75e1-4b2d-a8a0-0b8f88efd8a8', N'Technician', N'TECHNICIAN', NULL)
GO
INSERT [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'862220e1-8f02-41c6-a5af-92ca24c5a689', N'Admin', N'ADMIN', NULL)
GO
INSERT [dbo].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'd7123fbf-e969-435f-9ee5-7b272cfd5204', N'Driver', N'DRIVER', NULL)
GO
INSERT [dbo].[UserRoles] ([UserId], [RoleId]) VALUES (N'ebc0a619-8758-43c0-bbc5-7fd9e8cd6d79', N'862220e1-8f02-41c6-a5af-92ca24c5a689')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230705192853_InitialCreate', N'7.0.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230706132207_ApplicationUser', N'7.0.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230706142508_renameCarsTableToCarUpdatedSnapshotManually', N'7.0.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230707120723_RoleMappingAttempted', N'7.0.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230707122628_EventAllowNullables', N'7.0.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230707123748_IDRenamesToId', N'7.0.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230707124949_DropEventTable', N'7.0.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230707132000_EventRecreation', N'7.0.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230707140936_EventModelUpdateTagFieldNoTypeCategoryIdAdded', N'7.0.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230707144456_GoodMeasureIDToIdApplicationDbContext', N'7.0.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230707153702_OnModelCreatingUpdate', N'7.0.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230707154855_EventReSync', N'7.0.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230712170633_refactoringsofCaretc', N'7.0.8')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230712203521_updating', N'7.0.8')
GO
/****** Object:  Index [IX_CarDetail_CarId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_CarDetail_CarId] ON [dbo].[CarDetail]
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CarDetail_DetailId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_CarDetail_DetailId] ON [dbo].[CarDetail]
(
	[DetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CarEvent_CarId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_CarEvent_CarId] ON [dbo].[CarEvent]
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CarEvent_EventId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_CarEvent_EventId] ON [dbo].[CarEvent]
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CarEventDetail_CarDetailId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_CarEventDetail_CarDetailId] ON [dbo].[CarEventDetail]
(
	[CarDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CarEventDetail_CarEventId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_CarEventDetail_CarEventId] ON [dbo].[CarEventDetail]
(
	[CarEventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CarStaticDetails_CarId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_CarStaticDetails_CarId] ON [dbo].[CarStaticDetails]
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CarStatus_CarID]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_CarStatus_CarID] ON [dbo].[CarStatus]
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CarStatus_StatusID]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_CarStatus_StatusID] ON [dbo].[CarStatus]
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Detail_ApplicationUserId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_Detail_ApplicationUserId] ON [dbo].[Detail]
(
	[ApplicationUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Detail_DetailTypeId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_Detail_DetailTypeId] ON [dbo].[Detail]
(
	[DetailTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Detail_UserEventDetailId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_Detail_UserEventDetailId] ON [dbo].[Detail]
(
	[UserEventDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DetailType_CarDetailId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_DetailType_CarDetailId] ON [dbo].[DetailType]
(
	[CarDetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_ErrorLog_CarID]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IDX_ErrorLog_CarID] ON [dbo].[ErrorLog]
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_EventDetail_DetailId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_EventDetail_DetailId] ON [dbo].[EventDetail]
(
	[DetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_EventDetail_EventId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_EventDetail_EventId] ON [dbo].[EventDetail]
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Logger_CarID]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_Logger_CarID] ON [dbo].[Logger]
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RoleEventMappings_Role]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_RoleEventMappings_Role] ON [dbo].[RoleEventMappings]
(
	[Role] ASC
)
WHERE ([Role] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_StatusName]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_StatusName] ON [dbo].[Status]
(
	[StatusName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TicketAttachment_TicketId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_TicketAttachment_TicketId] ON [dbo].[TicketAttachment]
(
	[TicketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_TicketComment_AuthorId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_TicketComment_AuthorId] ON [dbo].[TicketComment]
(
	[AuthorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TicketComment_TicketId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_TicketComment_TicketId] ON [dbo].[TicketComment]
(
	[TicketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_TicketHistory_ChangedById]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_TicketHistory_ChangedById] ON [dbo].[TicketHistory]
(
	[ChangedById] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TicketHistory_TicketId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_TicketHistory_TicketId] ON [dbo].[TicketHistory]
(
	[TicketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Tickets_AssigneeId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_Tickets_AssigneeId] ON [dbo].[Tickets]
(
	[AssigneeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Tickets_CreatorId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_Tickets_CreatorId] ON [dbo].[Tickets]
(
	[CreatorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TicketTag_TicketId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_TicketTag_TicketId] ON [dbo].[TicketTag]
(
	[TicketId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserDetail_ApplicationUserId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserDetail_ApplicationUserId] ON [dbo].[UserDetail]
(
	[ApplicationUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserDetail_DetailId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserDetail_DetailId] ON [dbo].[UserDetail]
(
	[DetailId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserEvents_EventId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserEvents_EventId] ON [dbo].[UserEvents]
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserEvents_UserId]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IX_UserEvents_UserId] ON [dbo].[UserEvents]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_Software_CarID]    Script Date: 7/24/2023 8:25:06 PM ******/
CREATE NONCLUSTERED INDEX [IDX_Software_CarID] ON [dbo].[Software]
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ApplicationUser] ADD  DEFAULT ((0)) FOR [ApplicationUserDetailId]
GO
ALTER TABLE [dbo].[Event] ADD  DEFAULT ((0)) FOR [Category]
GO
ALTER TABLE [dbo].[Log] ADD  DEFAULT (getdate()) FOR [LogTime]
GO
ALTER TABLE [dbo].[ApplicationUserDetail]  WITH CHECK ADD  CONSTRAINT [FK_ApplicationUserDetail_ApplicationUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ApplicationUserDetail] CHECK CONSTRAINT [FK_ApplicationUserDetail_ApplicationUser_UserId]
GO
ALTER TABLE [dbo].[AspNetRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoles_Roles_Id] FOREIGN KEY([Id])
REFERENCES [dbo].[Roles] ([Id])
GO
ALTER TABLE [dbo].[AspNetRoles] CHECK CONSTRAINT [FK_AspNetRoles_Roles_Id]
GO
ALTER TABLE [dbo].[CarDetail]  WITH CHECK ADD  CONSTRAINT [FK_CarDetail_Cars_CarId] FOREIGN KEY([CarId])
REFERENCES [dbo].[Car] ([CarId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CarDetail] CHECK CONSTRAINT [FK_CarDetail_Cars_CarId]
GO
ALTER TABLE [dbo].[CarDetail]  WITH CHECK ADD  CONSTRAINT [FK_CarDetail_Detail_DetailId] FOREIGN KEY([DetailId])
REFERENCES [dbo].[Detail] ([Id])
GO
ALTER TABLE [dbo].[CarDetail] CHECK CONSTRAINT [FK_CarDetail_Detail_DetailId]
GO
ALTER TABLE [dbo].[CarEvent]  WITH CHECK ADD  CONSTRAINT [FK_CarEvent_Cars_CarId] FOREIGN KEY([CarId])
REFERENCES [dbo].[Car] ([CarId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CarEvent] CHECK CONSTRAINT [FK_CarEvent_Cars_CarId]
GO
ALTER TABLE [dbo].[CarEventDetail]  WITH CHECK ADD  CONSTRAINT [FK_CarEventDetail_CarDetail_CarDetailId] FOREIGN KEY([CarDetailId])
REFERENCES [dbo].[CarDetail] ([CarDetailId])
GO
ALTER TABLE [dbo].[CarEventDetail] CHECK CONSTRAINT [FK_CarEventDetail_CarDetail_CarDetailId]
GO
ALTER TABLE [dbo].[CarEventDetail]  WITH CHECK ADD  CONSTRAINT [FK_CarEventDetail_CarEvent_CarEventId] FOREIGN KEY([CarEventId])
REFERENCES [dbo].[CarEvent] ([CarEventId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CarEventDetail] CHECK CONSTRAINT [FK_CarEventDetail_CarEvent_CarEventId]
GO
ALTER TABLE [dbo].[CarStaticDetails]  WITH CHECK ADD  CONSTRAINT [FK_CarStaticDetails_Cars_CarId] FOREIGN KEY([CarId])
REFERENCES [dbo].[Car] ([CarId])
GO
ALTER TABLE [dbo].[CarStaticDetails] CHECK CONSTRAINT [FK_CarStaticDetails_Cars_CarId]
GO
ALTER TABLE [dbo].[CarStatus]  WITH CHECK ADD  CONSTRAINT [FK__CarStatus__CarID__498EEC8D] FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([CarId])
GO
ALTER TABLE [dbo].[CarStatus] CHECK CONSTRAINT [FK__CarStatus__CarID__498EEC8D]
GO
ALTER TABLE [dbo].[CarStatus]  WITH CHECK ADD  CONSTRAINT [FK__CarStatus__Statu__4A8310C6] FOREIGN KEY([StatusID])
REFERENCES [dbo].[Status] ([StatusID])
GO
ALTER TABLE [dbo].[CarStatus] CHECK CONSTRAINT [FK__CarStatus__Statu__4A8310C6]
GO
ALTER TABLE [dbo].[Detail]  WITH CHECK ADD  CONSTRAINT [FK_Detail_ApplicationUser_ApplicationUserId] FOREIGN KEY([ApplicationUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Detail] CHECK CONSTRAINT [FK_Detail_ApplicationUser_ApplicationUserId]
GO
ALTER TABLE [dbo].[Detail]  WITH CHECK ADD  CONSTRAINT [FK_Detail_DetailType_DetailTypeId] FOREIGN KEY([DetailTypeId])
REFERENCES [dbo].[DetailType] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Detail] CHECK CONSTRAINT [FK_Detail_DetailType_DetailTypeId]
GO
ALTER TABLE [dbo].[Detail]  WITH CHECK ADD  CONSTRAINT [FK_Detail_UserEvents_UserEventDetailId] FOREIGN KEY([UserEventDetailId])
REFERENCES [dbo].[UserEvents] ([UserEventId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Detail] CHECK CONSTRAINT [FK_Detail_UserEvents_UserEventDetailId]
GO
ALTER TABLE [dbo].[DetailType]  WITH CHECK ADD  CONSTRAINT [FK_DetailType_CarDetail_CarDetailId] FOREIGN KEY([CarDetailId])
REFERENCES [dbo].[CarDetail] ([CarDetailId])
GO
ALTER TABLE [dbo].[DetailType] CHECK CONSTRAINT [FK_DetailType_CarDetail_CarDetailId]
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_ApplicationUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_ApplicationUser_UserId]
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_Car_CarId] FOREIGN KEY([CarId])
REFERENCES [dbo].[Car] ([CarId])
GO
ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_Car_CarId]
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_EventType_EventTypeId] FOREIGN KEY([EventTypeId])
REFERENCES [dbo].[EventType] ([EventTypeID])
GO
ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_EventType_EventTypeId]
GO
ALTER TABLE [dbo].[EventDetail]  WITH CHECK ADD  CONSTRAINT [FK_EventDetail_Detail_DetailId] FOREIGN KEY([DetailId])
REFERENCES [dbo].[Detail] ([Id])
GO
ALTER TABLE [dbo].[EventDetail] CHECK CONSTRAINT [FK_EventDetail_Detail_DetailId]
GO
ALTER TABLE [dbo].[Logger]  WITH CHECK ADD  CONSTRAINT [FK__Logger__CarID__5224328E] FOREIGN KEY([CarID])
REFERENCES [dbo].[Car] ([CarId])
GO
ALTER TABLE [dbo].[Logger] CHECK CONSTRAINT [FK__Logger__CarID__5224328E]
GO
ALTER TABLE [dbo].[TicketAttachment]  WITH CHECK ADD  CONSTRAINT [FK_TicketAttachment_Tickets_TicketId] FOREIGN KEY([TicketId])
REFERENCES [dbo].[Tickets] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TicketAttachment] CHECK CONSTRAINT [FK_TicketAttachment_Tickets_TicketId]
GO
ALTER TABLE [dbo].[TicketComment]  WITH CHECK ADD  CONSTRAINT [FK_TicketComment_ApplicationUser_AuthorId] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[ApplicationUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TicketComment] CHECK CONSTRAINT [FK_TicketComment_ApplicationUser_AuthorId]
GO
ALTER TABLE [dbo].[TicketComment]  WITH CHECK ADD  CONSTRAINT [FK_TicketComment_Tickets_TicketId] FOREIGN KEY([TicketId])
REFERENCES [dbo].[Tickets] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TicketComment] CHECK CONSTRAINT [FK_TicketComment_Tickets_TicketId]
GO
ALTER TABLE [dbo].[TicketHistory]  WITH CHECK ADD  CONSTRAINT [FK_TicketHistory_ApplicationUser_ChangedById] FOREIGN KEY([ChangedById])
REFERENCES [dbo].[ApplicationUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TicketHistory] CHECK CONSTRAINT [FK_TicketHistory_ApplicationUser_ChangedById]
GO
ALTER TABLE [dbo].[TicketHistory]  WITH CHECK ADD  CONSTRAINT [FK_TicketHistory_Tickets_TicketId] FOREIGN KEY([TicketId])
REFERENCES [dbo].[Tickets] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TicketHistory] CHECK CONSTRAINT [FK_TicketHistory_Tickets_TicketId]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_ApplicationUser_AssigneeId] FOREIGN KEY([AssigneeId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_ApplicationUser_AssigneeId]
GO
ALTER TABLE [dbo].[Tickets]  WITH CHECK ADD  CONSTRAINT [FK_Tickets_ApplicationUser_CreatorId] FOREIGN KEY([CreatorId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[Tickets] CHECK CONSTRAINT [FK_Tickets_ApplicationUser_CreatorId]
GO
ALTER TABLE [dbo].[TicketTag]  WITH CHECK ADD  CONSTRAINT [FK_TicketTag_Tickets_TicketId] FOREIGN KEY([TicketId])
REFERENCES [dbo].[Tickets] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TicketTag] CHECK CONSTRAINT [FK_TicketTag_Tickets_TicketId]
GO
ALTER TABLE [dbo].[UserDetail]  WITH CHECK ADD  CONSTRAINT [FK_UserDetail_ApplicationUser_ApplicationUserId] FOREIGN KEY([ApplicationUserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[UserDetail] CHECK CONSTRAINT [FK_UserDetail_ApplicationUser_ApplicationUserId]
GO
ALTER TABLE [dbo].[UserDetail]  WITH CHECK ADD  CONSTRAINT [FK_UserDetail_Detail_DetailId] FOREIGN KEY([DetailId])
REFERENCES [dbo].[Detail] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserDetail] CHECK CONSTRAINT [FK_UserDetail_Detail_DetailId]
GO
ALTER TABLE [dbo].[UserEvents]  WITH CHECK ADD  CONSTRAINT [FK_UserEvents_ApplicationUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[ApplicationUser] ([Id])
GO
ALTER TABLE [dbo].[UserEvents] CHECK CONSTRAINT [FK_UserEvents_ApplicationUser_UserId]
GO
USE [master]
GO
ALTER DATABASE [aspnet-BlazorApp1-DB] SET  READ_WRITE 
GO
