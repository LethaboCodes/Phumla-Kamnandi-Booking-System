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
    public partial class Details_Confirmation_Form : Form
    {
        private Menu_Form menu_form;

        public Details_Confirmation_Form()
        {
            InitializeComponent();
        }

        private void Details_Confirmation_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void details_confirmation_form_cancel_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking cancelled.");
            menu_form = new Menu_Form();
            menu_form.Show();
            this.Close();
        }

        private void details_confirmation_form_confirmation_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking complete.");
            menu_form = new Menu_Form();
            menu_form.Show();
            this.Close();
        }
    }
}
