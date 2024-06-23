using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla_Kamandi_Booking_System.Business;

namespace Phumla_Kamandi_Booking_System.Presentation
{
    public partial class Financial_Report_Form : Form
    {
        private Menu_Form menu_form;
        private PaymentController paymentController;
        public Financial_Report_Form()
        {
            InitializeComponent();
            paymentController = new PaymentController();
            
        }

        private void financial_report_back_button_Click(object sender, EventArgs e)
        {
            menu_form = new Menu_Form();
            menu_form.Show();
            this.Close();
        }

        private void Financial_Report_Form_Load(object sender, EventArgs e)
        {
            // financial_report_textbox.AppendText(Environment.NewLine + PaymentController.GenerateFinancialReport());

            // Calculate the total earnings
            double totalEarnings = paymentController.Payments.Sum(payment => payment.PaymentAmount);

            // Create a report
            
            financial_report_textbox.AppendText(Environment.NewLine + "-------------------------------------------------------------------------------------------------------------------");
            financial_report_textbox.AppendText(Environment.NewLine + "BookingID \t\t Amount \t\t Payment Date");

            foreach (Payment payment in paymentController.Payments)
            {
                financial_report_textbox.AppendText(Environment.NewLine + payment.ToString());
            }

            financial_report_textbox.AppendText(Environment.NewLine + "-------------------------------------------------------------------------------------------------------------------");
            financial_report_textbox.AppendText(Environment.NewLine + $"Total Earnings: {totalEarnings:C}");
        }
    }
}
