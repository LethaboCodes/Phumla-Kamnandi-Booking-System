using Phumla_Kamandi_Booking_System.Data;
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
    public partial class Booking_Confirmation_Form : Form
    {
        private BookingController _controller;
        private Menu_Form menu_form;
        public Booking_Confirmation_Form()
        {
            
            InitializeComponent();
            _controller = new BookingController();
        }

        private void Booking_Confirmation_Form_Load(object sender, EventArgs e)
        {

            booking_confirmation_form_textbox.AppendText(Environment.NewLine + Booking_Form.booking.ToString());

        }

        private void details_confirmation_form_confirmation_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking Complete");
            _controller.DataMaintenance(Booking_Form.booking,BookingDB.DBOperation.Add);
            _controller.FinalizeChanges(Booking_Form.booking);
            menu_form = new Menu_Form();
            menu_form.Show();
            this.Hide();

        }

        private void details_confirmation_form_back_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking Cancelled.");
            menu_form = new Menu_Form();
            menu_form.Show();
            this.Close();
        }

        private void booking_confirmation_form_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
