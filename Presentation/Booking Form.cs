using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla_Kamandi_Booking_System.Data;
using Phumla_Kamandi_Booking_System.Business;
using System.Runtime.InteropServices.ComTypes;

namespace Phumla_Kamandi_Booking_System.Presentation
{
    public partial class Booking_Form : Form
    {
        protected Room room;
        public static Booking booking;
        private DateTime startDate;
        private DateTime endDate;
        private RoomController roomController;
        private Guest_Form guestForm;
        private Menu_Form menu_form;

        public Booking_Form()
        {
            InitializeComponent();
            roomController = new RoomController();

        }

        private void booking_form_check_in_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            startDate = booking_form_check_in_dateTimePicker.Value.Date;
        }

        private void booking_form_check_out_dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            endDate = booking_form_check_out_dateTimePicker1.Value.Date;
        }

        private void booking_form_submit_button_Click(object sender, EventArgs e)
        {
            room = roomController.IsRoomAvailable(startDate, endDate);

            if (room != null)
            {                
                booking = new Booking();
                booking.BookingID = Booking.GenerateBookingID();
                booking.CheckOutDate = endDate;
                booking.CheckInDate = startDate;
                booking.Room = room;
                int days = (endDate.Date.Subtract(startDate.Date)).Days;
                double price = RoomController.GetRoomPrice(startDate) * days;
                booking.TotalAmount = price;
                booking.Deposit = price * 0.1;
                string message = $"Room Number: {room.RoomNumber}\nPrice: {price:C}\nDeposit: {booking.Deposit}"; // {price:C} formats the price as currency
                string caption = "Room Availability";
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    guestForm = new Guest_Form();
                    guestForm.Show();
                    Hide();
                }

                }
                else { 
                MessageBox.Show("No Rooms avialble for the selected dates. Select new dates"); 
            }
                    
        }

        private void booking_form_back_button_Click(object sender, EventArgs e)
        {
            menu_form = new Menu_Form();
            menu_form.Show();
            this.Close();

        }

        private void Booking_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
