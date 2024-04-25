CREATE TABLE [dbo].[EventType] (
    [EventTypeID]  INT           IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (50) NOT NULL,
    [EventId]      INT           DEFAULT ((0)) NOT NULL,
    [OtherEventId] INT           DEFAULT ((0)) NOT NULL,
    [Id]           INT           DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK__EventTyp__A9216B1F734774DB] PRIMARY KEY CLUSTERED ([EventTypeID] ASC),
    CONSTRAINT [uc_EventTypeName] UNIQUE NONCLUSTERED ([Name] ASC)
);

