CREATE TABLE [dbo].[CarDetail] (
    [CarDetailId] INT            IDENTITY (1, 1) NOT NULL,
    [CarId]       INT            NULL,
    [Color]       NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    [DetailId]    INT            NULL,
    [Make]        NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    [Model]       NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    [Vin]         NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    [Year]        NVARCHAR (MAX) DEFAULT (N'') NOT NULL,
    CONSTRAINT [PK_CarDetail] PRIMARY KEY CLUSTERED ([CarDetailId] ASC),
    CONSTRAINT [FK_CarDetail_Car_CarId] FOREIGN KEY ([CarId]) REFERENCES [dbo].[Car] ([CarId]) ON DELETE CASCADE,
    CONSTRAINT [FK_CarDetail_Detail_DetailId] FOREIGN KEY ([DetailId]) REFERENCES [dbo].[Detail] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_CarDetail_CarId]
    ON [dbo].[CarDetail]([CarId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CarDetail_DetailId]
    ON [dbo].[CarDetail]([DetailId] ASC);

