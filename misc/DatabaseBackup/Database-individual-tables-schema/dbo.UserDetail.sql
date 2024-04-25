CREATE TABLE [dbo].[UserDetail] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [UserId]            NVARCHAR (MAX) NOT NULL,
    [DetailId]          INT            NOT NULL,
    [ApplicationUserId] NVARCHAR (450) NULL,
    CONSTRAINT [PK_UserDetail] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_UserDetail_ApplicationUser_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [dbo].[ApplicationUser] ([Id]),
    CONSTRAINT [FK_UserDetail_Detail_DetailId] FOREIGN KEY ([DetailId]) REFERENCES [dbo].[Detail] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_UserDetail_ApplicationUserId]
    ON [dbo].[UserDetail]([ApplicationUserId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_UserDetail_DetailId]
    ON [dbo].[UserDetail]([DetailId] ASC);

