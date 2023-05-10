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
        public string sCompanyName;
        public string sEmail;
        public string sPhoneNumber;
        public string sEventDetails;
        public DateTime dEventStart;
        public DateTime dEventEnd;
        public string sEventLocation;
        public double dDays;
        public double dTotalcost;
        public List<string> slEventItems = new List<string>();
        public List<string> slItemAmount = new List<string>();
        public List<string> slItemCost = new List<string>();
        public void DatesElapsed()
        {
            double numberOfDays = Math.Ceiling((dEventEnd - dEventStart).TotalDays);
            dDays= int.Parse(numberOfDays.ToString()) + 1;
        }
    }
}
