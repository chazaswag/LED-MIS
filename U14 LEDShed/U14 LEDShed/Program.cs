using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U14_LEDShed
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Control control = new Control();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(control));

            Event e1 = new Event();
            e1.sEventName = "Test Name";
            e1.sCompanyName = "Test Company Name";
            e1.sEventDetails = "its probably an event of sorts";
            e1.sEventLocation = "some location";
            e1.dEventStart = DateTime.Parse("Jun 1, 2023");
            e1.dEventEnd = DateTime.Parse("Jun 3, 2023");
            e1.sEmail = "test@email.com";
            e1.sPhoneNumber = "073333333333";
            e1.slEventItems.Add("Rope");
            e1.slItemAmount.Add("10");
            e1.slItemCost.Add("25.50");
            e1.slEventItems.Add("Vans");
            e1.slItemAmount.Add("20");
            e1.slItemCost.Add("2.50");
            control.eventsList.Add(e1);
        }
    }
}
