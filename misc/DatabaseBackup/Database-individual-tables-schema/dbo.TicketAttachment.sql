CREATE TABLE [dbo].[TicketAttachment] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [TicketId] INT            NOT NULL,
    [FilePath] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_TicketAttachment] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TicketAttachment_Tickets_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [dbo].[Tickets] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_TicketAttachment_TicketId]
    ON [dbo].[TicketAttachment]([TicketId] ASC);

