using Phumla_Kamandi_Booking_System.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamandi_Booking_System.Presentation
{
    public partial class Occupancy_Report_Form : Form
    {
        private Menu_Form menu_form;
        private BookingController bookingController;

        public Occupancy_Report_Form()
        {
            
            InitializeComponent();
            bookingController = new BookingController();
        }


        public void GenerateOccupancyReport(DateTime startDate, DateTime endDate)
        {
            
            occupancy_report_textbox.AppendText(Environment.NewLine + $"Date Range: {startDate.ToShortDateString()} - {endDate.ToShortDateString()}");
            occupancy_report_textbox.AppendText(Environment.NewLine + "-------------------------------------------------------------------------------------------------------------------------------");
            occupancy_report_textbox.AppendText(Environment.NewLine + "Room Number\t\tGuest Name\t\tBooking Period");

            foreach (Booking booking in bookingController.AllBookings)
            {
                if (booking.CheckInDate <= endDate && booking.CheckOutDate >= startDate)
                {
                    // Room is occupied during the specified date range
                    string guestName = $"{booking.Guest.Name} {booking.Guest.LastName}";
                    string bookingPeriod = $"{booking.CheckInDate.ToShortDateString()} - {booking.CheckOutDate.ToShortDateString()}";
                    occupancy_report_textbox.AppendText(Environment.NewLine + $"{booking.Room.RoomNumber}\t\t\t{guestName}\t\t{bookingPeriod}");
                }
            }

            
        }


        private void Reports_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu_form = new Menu_Form();
            menu_form.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void occupancy_report_generate_button_Click(object sender, EventArgs e)
        {
            GenerateOccupancyReport(occupancy_start_datetimepicker.Value, occupancy_end_datetimepicker.Value);
            
        }

        private void _occupancyenddatelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
