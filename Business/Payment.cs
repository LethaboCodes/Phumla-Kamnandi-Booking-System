using Phumla_Kamandi_Booking_System.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamandi_Booking_System.Business
{
    public class Payment
    {
        #region Attributes

        private Booking booking;
        private double paymentAmount;
        private DateTime paymentDate;
        private string Card;
       
        #endregion

        #region Properties
        public string CreditCard
        {
            get; set;
        }

        public  Booking GetBooking
        {

            get { return booking; }
            set { booking = value;}
        }


        public double PaymentAmount
        {
            get { return paymentAmount; }
            set { paymentAmount = value; }
        }

        public DateTime PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }

       
        #endregion

        #region Constructors
        public Payment() 
        {
            this.booking = new Booking();
            this.paymentAmount = 0;
            this.paymentDate = DateTime.Now;
            Card = "";
        
        }

        public Payment(Booking booking, double paymentAmount,DateTime date, string card)
        {
           
            this.booking =booking;
            this.paymentAmount = paymentAmount;
            this.paymentDate=date;
            this.Card=card;
            
            
        }
        #endregion

        #region Methods
        

        public void ProcessPayment()
        {
            double local = 0.0;
            if (paymentAmount > 0)
            {
               local = Booking_Form.booking.TotalAmount;
               local -= PaymentAmount;
            }
            
        }

        public override string ToString()
        {
            return $"{booking.BookingID}\t\t{PaymentAmount:C}\t\t{PaymentDate.Date.ToString("yyyy-MM-dd")}";
        }
        #endregion
    }
}

