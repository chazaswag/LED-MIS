using System;
using System.Windows.Forms;

namespace U14_LEDShed
{
    [Serializable]
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Control control = new Control();

            Freelancer f1 = new Freelancer();
            f1.sName = "James Normfolk";
            f1.sDailyRate = "125";
            f1.sAddress = "somewhere";
            control.freelancerList.Add(f1);

            Freelancer f2 = new Freelancer();
            f2.sName = "Lily Allanson";
            f2.sDailyRate = "135";
            f2.sAddress = "somewhere else";
            control.freelancerList.Add(f2);

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
            e1.dTotalcost = 305;
            control.eventsList.Add(e1);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(control));


        }
    }
}
