CREATE TABLE [dbo].[ErrorLog] (
    [ErrorID]       INT            IDENTITY (1, 1) NOT NULL,
    [CarID]         INT            NOT NULL,
    [ErrorDetails]  NVARCHAR (255) NULL,
    [ErrorPriority] INT            NULL,
    [ErrorNotes]    NVARCHAR (255) NULL,
    CONSTRAINT [PK__ErrorLog__358565CA8BB277F2] PRIMARY KEY CLUSTERED ([ErrorID] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IDX_ErrorLog_CarID]
    ON [dbo].[ErrorLog]([CarID] ASC);

