CREATE TABLE [dbo].[CarStaticDetails] (
    [CarID]             INT           NOT NULL,
    [CarStaticDetailId] INT           NOT NULL,
    [Tag]               NVARCHAR (50) NOT NULL,
    [Finas]             NVARCHAR (50) NOT NULL,
    [VinLast4]          NVARCHAR (50) NOT NULL,
    [HarnessStatus]     NVARCHAR (50) NULL,
    [FullVin]           NVARCHAR (50) NULL,
    [SoftwareVersion]   NVARCHAR (50) NULL,
    [ADAS]              NVARCHAR (50) NULL,
    CONSTRAINT [PK__CarStaticDetai__68A0340EDCEEBCE1] PRIMARY KEY CLUSTERED ([CarID] ASC),
    CONSTRAINT [FK__CarStaticDetail__CarID__55009F39] FOREIGN KEY ([CarID]) REFERENCES [dbo].[Car] ([CarId])
);

