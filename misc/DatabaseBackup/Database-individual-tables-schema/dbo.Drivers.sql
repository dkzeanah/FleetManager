CREATE TABLE [dbo].[Drivers] (
    [DriverId]     INT             IDENTITY (1, 1) NOT NULL,
    [DrivingHours] DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Drivers] PRIMARY KEY CLUSTERED ([DriverId] ASC)
);

