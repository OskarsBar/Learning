using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdevums5
{
    class Date
    {
        private int _day;
        private int _month;
        private int _year;

        public Date(int day,int month,int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }
        public int Day
        {
            get
            {
                return _day;
            }
            set
            {
                _day = value;
            }
        }
        public int Month
        {
            get
            {
                return _month;
            }
            set
            {
                _month = value;
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                _year = value;
            }
        }
        public void DisplayDate()
        {
            Console.WriteLine("{0}/{1}/{2}", _day, _month, _year);
        } 
    }
}
