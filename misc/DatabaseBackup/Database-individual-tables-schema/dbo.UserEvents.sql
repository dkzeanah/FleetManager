CREATE TABLE [dbo].[UserEvents] (
    [UserEventId] INT            IDENTITY (1, 1) NOT NULL,
    [UserId]      NVARCHAR (450) NULL,
    [EventId]     INT            NOT NULL,
    CONSTRAINT [PK_UserEvents] PRIMARY KEY CLUSTERED ([UserEventId] ASC),
    CONSTRAINT [FK_UserEvents_Event_EventId] FOREIGN KEY ([EventId]) REFERENCES [dbo].[Event] ([EventID]),
    CONSTRAINT [FK_UserEvents_ApplicationUser_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[ApplicationUser] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_UserEvents_EventId]
    ON [dbo].[UserEvents]([EventId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_UserEvents_UserId]
    ON [dbo].[UserEvents]([UserId] ASC);

