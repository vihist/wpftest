using System;
using System.Collections.Generic;

namespace WpfApplication2.test
{
    class Event
    {
        public Event()
        {
            optionDescList = new List<string>();
        }

        public string Desc
        {
            get
            {
                return desc;
            }
        }

        public List<string> OptionDescList
        {
            get
            {
                return optionDescList;
            }
        }

        protected string desc;
        protected List<string> optionDescList;
    }
}