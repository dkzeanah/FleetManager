CREATE TABLE [dbo].[Car] (
    [Make]           NVARCHAR (50)  NULL,
    [Model]          NVARCHAR (50)  NULL,
    [Year]           INT            NULL,
    [TeleGeneration] NVARCHAR (50)  NULL,
    [Miles]          INT            NULL,
    [Location]       NVARCHAR (255) NULL,
    [SourceID]       INT            NULL,
    [UserId]         NVARCHAR (MAX) NULL,
    [CarId]          INT            IDENTITY (1, 1) NOT NULL,
    CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED ([CarId] ASC)
);

