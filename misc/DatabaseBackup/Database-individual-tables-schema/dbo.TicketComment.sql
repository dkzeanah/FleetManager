CREATE TABLE [dbo].[TicketComment] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [TicketId]  INT            NOT NULL,
    [Content]   NVARCHAR (MAX) NOT NULL,
    [AuthorId]  NVARCHAR (450) NOT NULL,
    [CreatedAt] DATETIME2 (7)  NOT NULL,
    CONSTRAINT [PK_TicketComment] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TicketComment_ApplicationUser_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [dbo].[ApplicationUser] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_TicketComment_Tickets_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [dbo].[Tickets] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_TicketComment_AuthorId]
    ON [dbo].[TicketComment]([AuthorId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_TicketComment_TicketId]
    ON [dbo].[TicketComment]([TicketId] ASC);

