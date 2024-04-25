CREATE TABLE [dbo].[CarEventDetail] (
    [CarEventDetailId] INT            IDENTITY (1, 1) NOT NULL,
    [CarEventId]       INT            NOT NULL,
    [Note]             NVARCHAR (MAX) NOT NULL,
    [CarDetailId]      INT            NULL,
    CONSTRAINT [PK_CarEventDetail] PRIMARY KEY CLUSTERED ([CarEventDetailId] ASC),
    CONSTRAINT [FK_CarEventDetail_CarDetail_CarDetailId] FOREIGN KEY ([CarDetailId]) REFERENCES [dbo].[CarDetail] ([CarDetailId]),
    CONSTRAINT [FK_CarEventDetail_CarEvent_CarEventId] FOREIGN KEY ([CarEventId]) REFERENCES [dbo].[CarEvent] ([CarEventId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_CarEventDetail_CarDetailId]
    ON [dbo].[CarEventDetail]([CarDetailId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CarEventDetail_CarEventId]
    ON [dbo].[CarEventDetail]([CarEventId] ASC);

