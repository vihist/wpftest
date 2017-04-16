using System;
using System.Collections.Generic;

namespace WpfApplication2.test
{
    internal class EventGenerater
    {
        internal List<Event> Generate()
        {
            Event eventObj = new EventTest();
            List<Event> eventList = new List<Event>();

            eventList.Add(eventObj);

            return eventList;
        }
    }
}