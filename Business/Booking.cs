using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Phumla_Kamandi_Booking_System.Data;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;


namespace Phumla_Kamandi_Booking_System.Business
{

    public class Booking
    {
        #region Attributes

        private string bookingID;
        private Guest guest;
        private Room room;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private double TotalDue;
        private double deposit;
        
        private List<Payment> payments;

        #endregion

        #region Properties
        public string BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }
        public double Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }
        public Guest Guest
        {
            get { return guest; }
            set { guest = value; }
        }

        public Room Room
        {
            get { return room; }
            set { room = value; }
        }

        public DateTime CheckInDate
        {
            get { return checkInDate; }
            set { checkInDate = value; }
        }

        public DateTime CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }

        public double TotalAmount
        {
            get { return TotalDue; }
            set { TotalDue = value; }
        }

       

        
        public List<Payment> Payments
        {
            get { return payments; }
        }
        #endregion

        #region Constructors
        public Booking()
        {
            bookingID = GenerateBookingID(); ;
            guest = new Guest();
            room = new Room();
            checkInDate = DateTime.Now;
            checkOutDate = DateTime.Now;
            TotalDue = 0.0; 
            payments = new List<Payment>();
        }

        public Booking(string bookingID, Guest guest, Room room, DateTime checkInDate, DateTime checkOutDate)
        {
            this.bookingID = bookingID;
            this.guest = guest;
            this.room = room;
            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            TotalDue = 550.0;
           
            payments = new List<Payment>();
        }

       
        #endregion

        #region Methods
       

        
        public static string GenerateBookingID()
        {
            
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var reservationRef = new StringBuilder(10);
            for (int i = 0; i < 10; i++)
            {
                reservationRef.Append(chars[random.Next(chars.Length)]);
            }
            return reservationRef.ToString();
        }

        public override string ToString()
        {
            return $"Booking ID: {bookingID}\r\n" +
                   $"Guest Name: {guest.Name}\r\n" +
                   $"Guest Last Name: {guest.LastName}\r\n" +
                   $"Guest Name: {guest.ID}\r\n" +
                   $"Guest Phone: {guest.Telephone}\r\n" +
                   $"Room: {room.RoomNumber}\r\n" + // Assuming Room has a property like RoomNumber
                   $"Check-In Date: {checkInDate.ToShortDateString()}\r\n" +
                   $"Check-Out Date: {checkOutDate.ToShortDateString()}\r\n" +
                   $"Total Amount: {TotalDue:C}\r\n" + // Format as currency
                   $"Deposit: {deposit:C}\r\n" + // Format as currency
                   $"Payments: {string.Join("\r\n", payments.Select(p => p.ToString()))}"; // Assuming Payment has a ToString method// Assuming Payment has a ToString method
        }

        #endregion

      
    }
}

