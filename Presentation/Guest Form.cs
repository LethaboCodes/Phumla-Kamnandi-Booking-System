using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Phumla_Kamandi_Booking_System.Business;
using Phumla_Kamandi_Booking_System.Data;


namespace Phumla_Kamandi_Booking_System.Presentation
{
    public partial class Guest_Form : Form

    {
        protected Guest guest;
        private GuestController guestController;
        private Booking_Form booking_form;
        private Payment_Form payment_Form;


        public Guest_Form()
        {
            InitializeComponent();
            guestController = new GuestController();
        }

        private void ClearAll()
        {
            first_name_textbox.Text = "";
            last_name_textbox.Text = "";
            id_textbox.Text = "";
            phone_textbox.Text = "";
        }
        private void PopulateGuest()
        {
            if (ValidateBookingFields() )
            {
                guest = new Guest();
                //if(id_textbox.Text.)
                guest.ID = id_textbox.Text;
                guest.Name = first_name_textbox.Text;
                guest.Telephone = phone_textbox.Text;
                guest.LastName = last_name_textbox.Text;
                guest.GuestID = Guest.GenerateGuestID(first_name_textbox.Text, last_name_textbox.Text);

            }
        }

        private bool ValidateBookingFields()
        {
            // Check if all fields are filled
            if (string.IsNullOrWhiteSpace(id_textbox.Text) ||
                string.IsNullOrWhiteSpace(first_name_textbox.Text) ||
                string.IsNullOrWhiteSpace(last_name_textbox.Text)) 

            {  

                
                return false;
            }

            return true; // All fields are filled
        }
        private bool IsAllDigits()
        {
            return id_textbox.Text.All(char.IsDigit);
        }



        private void Guest_Form_Load(object sender, EventArgs e)
        {

        }

        private void guest_form_submit_button_Click(object sender, EventArgs e)
        {
            
            PopulateGuest();
            Booking_Form.booking.Guest = guest;
            if (guestController.Find(guest.GuestID) == null)
            {
                guestController.DataMaintenance(guest);
                guestController.FinalizeChanges(guest);
                MessageBox.Show("New Guest successfully added.");
            }
            ClearAll();            

            payment_Form = new Payment_Form();
            payment_Form.Show();
            this.Hide();
        }

        private void guest_form_back_button_Click(object sender, EventArgs e)
        {
            booking_form = new Booking_Form();
            booking_form.Show();
            this.Close();

        }



        #region Integrity Coontrols

        #endregion



        private void first_name_textbox_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void first_name_textbox_Enter(object sender, EventArgs e)
        {

        }

        private void first_name_textbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(first_name_textbox.Text))
            {
                first_name_textbox.Text = "Enter a valid name (no digits)";
                first_name_textbox.ForeColor = SystemColors.GrayText;
            }
            else
            {
                // Check if the input contains any digits
                if (first_name_textbox.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Name cannot contain digits. Please enter a valid name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    first_name_textbox.Text = "";
                    first_name_textbox.Focus();
                }
            }

        }

        private void last_name_textbox_Enter(object sender, EventArgs e)
        {

        }

        private void last_name_textbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(last_name_textbox.Text))
            {
                last_name_textbox.Text = "Enter a valid last name (no digits)";
                last_name_textbox.ForeColor = SystemColors.GrayText;
            }
            else
            {
                // Check if the input contains any digits
                if (last_name_textbox.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Last name cannot contain digits. Please enter a valid last name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    last_name_textbox.Text = "";
                    last_name_textbox.Focus();
                }
            }
        }

        private void id_textbox_Enter(object sender, EventArgs e)
        {
            if (id_textbox.Text == "Enter a valid ID e.g. 13 digit number")
            {
                id_textbox.Text = "";
                id_textbox.ForeColor = SystemColors.WindowText; // Restore the default text color
            }

        }

        private void id_textbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(id_textbox.Text))
            {
                id_textbox.Text = "Enter a valid ID e.g. 13 digit number";
                id_textbox.ForeColor = SystemColors.GrayText; // Change the text color to gray
            }
            else
            {
                // Check if the input is a 13-digit number
                if (id_textbox.Text.Length != 13 || !id_textbox.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Please enter a valid 13-digit number as the ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    id_textbox.Text = ""; // Clear the textbox
                    id_textbox.Focus(); // Set focus back to the textbox
                }
            }

        }
    }

}
