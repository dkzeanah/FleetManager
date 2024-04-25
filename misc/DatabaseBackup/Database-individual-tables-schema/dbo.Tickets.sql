CREATE TABLE [dbo].[Tickets] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (MAX) NOT NULL,
    [Description] NVARCHAR (MAX) NOT NULL,
    [CreatorId]   NVARCHAR (450) NOT NULL,
    [AssigneeId]  NVARCHAR (450) NOT NULL,
    [CreatedAt]   DATETIME2 (7)  NOT NULL,
    [UpdatedAt]   DATETIME2 (7)  NULL,
    [ClosedAt]    DATETIME2 (7)  NULL,
    [Status]      NVARCHAR (MAX) NOT NULL,
    [Severity]    NVARCHAR (MAX) NOT NULL,
    [Priority]    NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Tickets_ApplicationUser_AssigneeId] FOREIGN KEY ([AssigneeId]) REFERENCES [dbo].[ApplicationUser] ([Id]),
    CONSTRAINT [FK_Tickets_ApplicationUser_CreatorId] FOREIGN KEY ([CreatorId]) REFERENCES [dbo].[ApplicationUser] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Tickets_AssigneeId]
    ON [dbo].[Tickets]([AssigneeId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Tickets_CreatorId]
    ON [dbo].[Tickets]([CreatorId] ASC);

