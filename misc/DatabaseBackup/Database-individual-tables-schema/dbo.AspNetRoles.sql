CREATE TABLE [dbo].[AspNetRoles] (
    [Id]               NVARCHAR (450) NOT NULL,
    [Name]             NVARCHAR (MAX) NULL,
    [NormalizedName]   NVARCHAR (MAX) NULL,
    [ConcurrencyStamp] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_AspNetRoles_Roles_Id] FOREIGN KEY ([Id]) REFERENCES [dbo].[Roles] ([Id]) ON DELETE CASCADE
);

