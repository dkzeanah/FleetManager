CREATE TABLE [dbo].[ApplicationUserDetail] (
    [UserId]            NVARCHAR (450) NOT NULL,
    [UserEventDetailId] INT            IDENTITY (1, 1) NOT NULL,
    [EventId]           INT            NOT NULL,
    [Notes]             NVARCHAR (MAX) NULL,
    [MilesDriven]       INT            NULL,
    [TicketsSubmitted]  INT            NULL,
    [EventsSubmitted]   INT            NULL,
    CONSTRAINT [PK_ApplicationUserDetail] PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [FK_ApplicationUserDetail_ApplicationUser_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[ApplicationUser] ([Id])
);

