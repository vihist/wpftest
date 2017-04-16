using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2.test
{
    class Date
    {
        public Date()
        {
            _year = 1;
            _month = 1;
            _day = 1;
        }

        public void Increase()
        {
            if (_day == 30)
            {
                if (_month == 12)
                {
                    _year++;
                    _month = 1;
                }
                else
                {
                    _month++;
                }
                _day = 1;
            }
            else
            {
                _day++;
            }
        }

        public int year
        {
            get
            {
                return _year;
            }
        }

        public int month
        {
            get
            {
                return _month;
            }
        }

        public int day
        {
            get
            {
                return _day;
            }
        }

        private int _year;
        private int _month;
        private int _day;
    }
}
