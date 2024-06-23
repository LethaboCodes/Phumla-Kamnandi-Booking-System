using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla_Kamandi_Booking_System.Presentation;

namespace Phumla_Kamandi_Booking_System
{
    internal static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Menu_Form form = new Menu_Form();
            Application.Run(form);
        }
    }
}
