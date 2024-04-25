CREATE TABLE [dbo].[Event] (
    [EventID]           INT            IDENTITY (1, 1) NOT NULL,
    [CarID]             INT            NOT NULL,
    [UserID]            NVARCHAR (450) NOT NULL,
    [EventTypeID]       INT            NOT NULL,
    [StartTime]         DATETIME       NULL,
    [EndTime]           DATETIME       NULL,
    [PlaceholderUserId] NVARCHAR (450) NULL,
    [UserEventDetailId] INT            DEFAULT ((0)) NOT NULL,
    [CategoryId]        INT            NULL,
    [Date]              DATETIME2 (7)  DEFAULT ('0001-01-01T00:00:00.0000000') NOT NULL,
    [Type]              NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    CONSTRAINT [PK__Event__7944C870D4DB1DAC] PRIMARY KEY CLUSTERED ([EventID] ASC),
    CONSTRAINT [FK_Event_Category_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([CategoryId]) ON DELETE CASCADE,
    CONSTRAINT [FK_Event_ApplicationUser_UserID] FOREIGN KEY ([UserID]) REFERENCES [dbo].[ApplicationUser] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK__Event__EventType__1CBC4616] FOREIGN KEY ([EventTypeID]) REFERENCES [dbo].[EventType] ([EventTypeID])
);


GO
CREATE NONCLUSTERED INDEX [IDX_Event_CarID]
    ON [dbo].[Event]([CarID] ASC);


GO
CREATE NONCLUSTERED INDEX [IDX_Event_EventTypeID]
    ON [dbo].[Event]([EventTypeID] ASC);


GO
CREATE NONCLUSTERED INDEX [IDX_Event_UserID]
    ON [dbo].[Event]([UserID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Event_PlaceholderUserId]
    ON [dbo].[Event]([PlaceholderUserId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Event_CategoryId]
    ON [dbo].[Event]([CategoryId] ASC);

