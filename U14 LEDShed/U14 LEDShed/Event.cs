﻿using System;
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
        public string sPhoneNumber;
        public string sEventDetails;
        public DateTime dEventStart;
        public DateTime dEventEnd;
        public string sEventLocation;
        public string sStockNeeded;
        public double dDays;
        public List<string> slEventItems = new List<string>();
        public void DatesElapsed()
        {
            double numberOfDays = Math.Ceiling((dEventEnd - dEventStart).TotalDays);
            dDays= int.Parse(numberOfDays.ToString()) + 1;
        }
    }
}
