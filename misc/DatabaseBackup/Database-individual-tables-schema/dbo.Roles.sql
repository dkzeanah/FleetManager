CREATE TABLE [dbo].[Roles] (
    [Id]               NVARCHAR (450) NOT NULL,
    [Name]             NVARCHAR (MAX) NULL,
    [NormalizedName]   NVARCHAR (MAX) NULL,
    [ConcurrencyStamp] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED ([Id] ASC)
);

