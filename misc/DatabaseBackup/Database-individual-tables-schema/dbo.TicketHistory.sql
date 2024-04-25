CREATE TABLE [dbo].[TicketHistory] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [TicketId]    INT            NOT NULL,
    [Change]      NVARCHAR (MAX) NOT NULL,
    [ChangedAt]   DATETIME2 (7)  NOT NULL,
    [ChangedById] NVARCHAR (450) NOT NULL,
    CONSTRAINT [PK_TicketHistory] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TicketHistory_ApplicationUser_ChangedById] FOREIGN KEY ([ChangedById]) REFERENCES [dbo].[ApplicationUser] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_TicketHistory_Tickets_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [dbo].[Tickets] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_TicketHistory_ChangedById]
    ON [dbo].[TicketHistory]([ChangedById] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_TicketHistory_TicketId]
    ON [dbo].[TicketHistory]([TicketId] ASC);

