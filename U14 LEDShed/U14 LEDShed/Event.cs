using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U14_LEDShed
{
    public class Event
    {
        public string sEventName;
        public string sEmail;
        public int iPhoneNumber;
        public string sEventDetails;
        public DateTime dEventStart;
        public DateTime dEventEnd;
        public string sEventLocation;
        public string sStockNeeded;

        public int DatesElapsed()
        {
            double numberOfDays = Math.Ceiling((dEventEnd - dEventStart).TotalDays);
            int days = int.Parse(numberOfDays.ToString());
            return days;
        }

        internal void ShowDialog()
        {
        }
    }
}
