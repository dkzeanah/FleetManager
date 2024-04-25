CREATE TABLE [dbo].[CarEvent] (
    [CarEventId] INT IDENTITY (1, 1) NOT NULL,
    [CarId]      INT NOT NULL,
    [EventId]    INT NOT NULL,
    CONSTRAINT [PK_CarEvent] PRIMARY KEY CLUSTERED ([CarEventId] ASC),
    CONSTRAINT [FK_CarEvent_Car_CarId] FOREIGN KEY ([CarId]) REFERENCES [dbo].[Car] ([CarId]) ON DELETE CASCADE,
    CONSTRAINT [FK_CarEvent_Event_EventId] FOREIGN KEY ([EventId]) REFERENCES [dbo].[Event] ([EventID]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_CarEvent_CarId]
    ON [dbo].[CarEvent]([CarId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CarEvent_EventId]
    ON [dbo].[CarEvent]([EventId] ASC);

