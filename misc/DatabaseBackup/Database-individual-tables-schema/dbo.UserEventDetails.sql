CREATE TABLE [dbo].[UserEventDetails] (
    [UserEventDetailId] INT            IDENTITY (1, 1) NOT NULL,
    [UserId]            NVARCHAR (MAX) NULL,
    [Notes]             NVARCHAR (MAX) NULL,
    [ApplicationUserId] NVARCHAR (450) NULL,
    [UserEventId]       INT            NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_UserEventDetails_ApplicationUserId]
    ON [dbo].[UserEventDetails]([ApplicationUserId] ASC);

