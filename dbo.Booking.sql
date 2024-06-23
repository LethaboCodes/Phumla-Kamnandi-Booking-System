CREATE TABLE [dbo].[Booking] (
    [BookingID] TEXT        NOT NULL,
    [CheckIn]   DATE       NULL,
    [CheckOut]  NCHAR (30) NULL,
    [TotalDue]  NCHAR (30) NULL,
    [GuestID]   INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([BookingID] ASC),
    FOREIGN KEY ([GuestID]) REFERENCES [dbo].[Guest] ([GuestID])
);

