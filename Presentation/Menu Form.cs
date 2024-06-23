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
    public partial class Menu_Form : Form
    {
        private Booking_Form booking_form;
        private Booking_Listing_Form listing_form;
        private BookingController booking_controller;
        private Occupancy_Report_Form occupancy_report_form;
        private Financial_Report_Form financial_report_form;

        public Menu_Form()
        {
            InitializeComponent();
            booking_controller = new BookingController();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void make_booking_button_Click(object sender, EventArgs e)
        {
            booking_form = new Booking_Form();
            booking_form.Show();
            this.Hide();
        }

        private void Menu_Form_Load(object sender, EventArgs e)
        {

        }

        private void list_bookings_button_Click(object sender, EventArgs e)
        {
            listing_form = new Booking_Listing_Form(booking_controller);
            listing_form.Show();
            this.Hide();
        }

        private void financial_report_button_Click(object sender, EventArgs e)
        {
            financial_report_form = new Financial_Report_Form();
            financial_report_form.Show();
            this.Hide();
        }

        private void occupancy_report_button_Click(object sender, EventArgs e)
        {
            occupancy_report_form = new Occupancy_Report_Form();
            occupancy_report_form.Show();
            this.Hide();
        }
    }
}
