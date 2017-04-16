using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2.test
{
    class EventTest : Event
    {
        public EventTest()
        {
            desc = "this is test event";
            optionDescList.Add("TEST A");
            optionDescList.Add("TEST B");
        }
    }
}
