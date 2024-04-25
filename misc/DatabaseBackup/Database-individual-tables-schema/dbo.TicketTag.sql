CREATE TABLE [dbo].[TicketTag] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [TicketId] INT            NOT NULL,
    [Tag]      NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_TicketTag] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TicketTag_Tickets_TicketId] FOREIGN KEY ([TicketId]) REFERENCES [dbo].[Tickets] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_TicketTag_TicketId]
    ON [dbo].[TicketTag]([TicketId] ASC);

