CREATE TABLE [dbo].[CarStatus] (
    [CarID]      INT      NOT NULL,
    [StatusID]   INT      NOT NULL,
    [StatusTime] DATETIME NULL,
    CONSTRAINT [FK__CarStatus__Statu__4A8310C6] FOREIGN KEY ([StatusID]) REFERENCES [dbo].[Status] ([StatusID])
);


GO
CREATE NONCLUSTERED INDEX [IX_CarStatus_CarID]
    ON [dbo].[CarStatus]([CarID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_CarStatus_StatusID]
    ON [dbo].[CarStatus]([StatusID] ASC);

