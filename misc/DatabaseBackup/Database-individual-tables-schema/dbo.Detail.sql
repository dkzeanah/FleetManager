CREATE TABLE [dbo].[Detail] (
    [Id3]               INT            NULL,
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [DetailTypeId]      INT            NULL,
    [UserEventDetailId] INT            NULL,
    [ApplicationUserId] NVARCHAR (450) NULL,
    CONSTRAINT [PK_Detail] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Detail_ApplicationUser_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [dbo].[ApplicationUser] ([Id]),
    CONSTRAINT [FK_Detail_DetailType_DetailTypeId] FOREIGN KEY ([DetailTypeId]) REFERENCES [dbo].[DetailType] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Detail_UserEvents_UserEventDetailId] FOREIGN KEY ([UserEventDetailId]) REFERENCES [dbo].[UserEvents] ([UserEventId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Detail_DetailTypeId]
    ON [dbo].[Detail]([DetailTypeId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Detail_UserEventDetailId]
    ON [dbo].[Detail]([UserEventDetailId] ASC);

