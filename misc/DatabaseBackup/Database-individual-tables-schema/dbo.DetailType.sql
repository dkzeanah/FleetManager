CREATE TABLE [dbo].[DetailType] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [CarDetailId] INT            NULL,
    CONSTRAINT [PK_DetailType] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_DetailType_CarDetail_CarDetailId] FOREIGN KEY ([CarDetailId]) REFERENCES [dbo].[CarDetail] ([CarDetailId])
);


GO
CREATE NONCLUSTERED INDEX [IX_DetailType_CarDetailId]
    ON [dbo].[DetailType]([CarDetailId] ASC);

