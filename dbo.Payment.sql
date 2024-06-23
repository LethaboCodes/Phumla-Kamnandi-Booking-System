CREATE TABLE [dbo].[Payment] (
    [Amount]      MONEY         NOT NULL,
    [BookingID]   NVARCHAR (50) NOT NULL,
    [PaymentDate] DATE          NOT NULL,
    [CreditCardNumber] NVARCHAR(10) NOT NULL, 
    FOREIGN KEY ([BookingID]) REFERENCES [dbo].[Booking] ([BookingID])
);

