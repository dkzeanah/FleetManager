CREATE TABLE [dbo].[Status] (
    [StatusID]   INT           NOT NULL,
    [StatusName] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK__Status__C8EE2043906DCC08] PRIMARY KEY CLUSTERED ([StatusID] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [UQ_StatusName]
    ON [dbo].[Status]([StatusName] ASC);

