using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phumla_Kamandi_Booking_System.Business;
using Phumla_Kamandi_Booking_System.Data;


namespace Phumla_Kamandi_Booking_System.Business
{
    public class PaymentController
    {
        private PaymentDB paymentDB;
        private Collection <Payment> paymentCollection;

        public PaymentController()
        {
            paymentDB = new PaymentDB();
            paymentCollection = new Collection <Payment>();
            paymentCollection = paymentDB.AllPayments;
        }
        public Collection<Payment> Payments { get { return paymentCollection; } }
        public void DataMaintenance(Payment payment)
        {
           paymentDB.DataSetChange(payment);
            paymentCollection.Add(payment);
            
        }
        public bool FinalizeChanges(Payment payment)
        {

            return paymentDB.UpdateDataSource(payment);
        }

      /*  public static string GenerateFinancialReport()
        {
           

            // Calculate the total earnings
            double totalEarnings = paymentCollection.Sum(payment => payment.PaymentAmount);

            // Create a report
            StringBuilder report = new StringBuilder();
            report.AppendLine("Financial Report");
            report.AppendLine("-----------------");
            report.AppendLine("Payment Date\tAmount");

            foreach (Payment payment in paymentCollection)
            {
                report.AppendLine(payment.ToString());
            }

            report.AppendLine("-----------------");
            report.AppendLine($"Total Earnings: {totalEarnings:C}");

            return report.ToString();
        }*/
    }
}
