CREATE TABLE [dbo].[EventDetail] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [DetailId]  INT           NOT NULL,
    [EventId]   INT           NOT NULL,
    [DateAdded] DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_EventDetail] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_EventDetail_Detail_DetailId] FOREIGN KEY ([DetailId]) REFERENCES [dbo].[Detail] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_EventDetail_Event_EventId] FOREIGN KEY ([EventId]) REFERENCES [dbo].[Event] ([EventID]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_EventDetail_DetailId]
    ON [dbo].[EventDetail]([DetailId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_EventDetail_EventId]
    ON [dbo].[EventDetail]([EventId] ASC);

