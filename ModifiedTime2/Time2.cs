using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifiedTime2
{
    class Time2
    {
        private int secondsFromMidnight;
        public Time2(int hour = 0, int minute = 0, int second = 0)
        {
            SetTime(hour, minute, second);
        }
        public Time2(Time2 time)
            : this(time.secondsFromMidnight) { }
        public void SetTime(int hour, int minute, int second)
        {
            SecondsFromMidnight = hour * 3600 + minute * 60 + second;
        }
        public int SecondsFromMidnight
        {
            get
            {
                return secondsFromMidnight;
            }
            set
            {
                secondsFromMidnight = value;
            }
        }
    }
}
