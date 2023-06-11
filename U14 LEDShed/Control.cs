using System;
using System.Collections.Generic;

namespace U14_LEDShed
{
    [Serializable]
    public class Control
    {
        public List<Event> eventsList = new List<Event>();
        public List<Freelancer> freelancerList = new List<Freelancer>();
        public List<Stock> stockList = new List<Stock>();
        public List<EventCost> costList = new List<EventCost>();
    }
}
