CREATE TABLE [dbo].[Software] (
    [SoftwareID]          INT           IDENTITY (1, 1) NOT NULL,
    [CarID]               INT           NOT NULL,
    [HeadUnit]            NVARCHAR (50) NOT NULL,
    [SoftwareVersion]     NVARCHAR (50) NOT NULL,
    [NextSoftwareVersion] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK__Software__25EDB8DCFDCE01A5] PRIMARY KEY CLUSTERED ([SoftwareID] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IDX_Software_CarID]
    ON [dbo].[Software]([CarID] ASC);

