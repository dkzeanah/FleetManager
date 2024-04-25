CREATE TABLE [dbo].[ApplicationUser] (
    [Id]                   NVARCHAR (450)     NOT NULL,
    [UserName]             NVARCHAR (MAX)     NULL,
    [NormalizedUserName]   NVARCHAR (MAX)     NULL,
    [Email]                NVARCHAR (MAX)     NULL,
    [NormalizedEmail]      NVARCHAR (MAX)     NULL,
    [EmailConfirmed]       BIT                NOT NULL,
    [PasswordHash]         NVARCHAR (MAX)     NULL,
    [SecurityStamp]        NVARCHAR (MAX)     NULL,
    [ConcurrencyStamp]     NVARCHAR (MAX)     NULL,
    [PhoneNumber]          NVARCHAR (MAX)     NULL,
    [PhoneNumberConfirmed] BIT                NOT NULL,
    [TwoFactorEnabled]     BIT                NOT NULL,
    [LockoutEnd]           DATETIMEOFFSET (7) NULL,
    [LockoutEnabled]       BIT                NOT NULL,
    [AccessFailedCount]    INT                NOT NULL,
    [FriendlyName]         NVARCHAR (MAX)     DEFAULT (N'') NOT NULL,
    [FirstName]            NVARCHAR (MAX)     NULL,
    [LastName]             NVARCHAR (MAX)     NULL,
    CONSTRAINT [PK_ApplicationUser] PRIMARY KEY CLUSTERED ([Id] ASC)
);

