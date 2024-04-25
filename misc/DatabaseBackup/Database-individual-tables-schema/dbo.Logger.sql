CREATE TABLE [dbo].[Logger] (
    [LoggerID]   INT           IDENTITY (1, 1) NOT NULL,
    [CarID]      INT           NOT NULL,
    [TypeLogger] NVARCHAR (50) NOT NULL,
    [NumLoggers] INT           NOT NULL,
    CONSTRAINT [PK__Logger__0ABCCA66A1861B17] PRIMARY KEY CLUSTERED ([LoggerID] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_Logger_CarID]
    ON [dbo].[Logger]([CarID] ASC);

