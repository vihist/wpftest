using System;
using System.Collections.Generic;
using System.Windows;

namespace WpfApplication2.test
{
    internal class EventBox
    {
        private Event @event;

        public EventBox(Event @event)
        {
            this.@event = @event;
            m_ListTigger = new List<Event>();
        }

        internal void Do()
        {
            EventDialog eventDlg = new EventDialog(@event.Desc, @event.OptionDescList);
            eventDlg.ShowDialog();
        }

        internal IEnumerable<Event> GetTiggerEvent()
        {
            return m_ListTigger;
        }

        private List<Event> m_ListTigger;
    }
}