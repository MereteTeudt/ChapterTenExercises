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

        public void SetTime(int hour, int minute, int second)
        {
            SecondsFromMidnight = (hour * 3600) + (minute * 60) + second;
        }
        public int SecondsFromMidnight
        {
            get
            {
                return secondsFromMidnight;
            }
            set
            {
                if (value < 0 || value > 86400)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(SecondsFromMidnight)} must be 0-86400");
                }
                secondsFromMidnight = value;
            }
        }
        public string ToUniversalString()
        {
            TimeSpan t = TimeSpan.FromSeconds(SecondsFromMidnight);
            return t.ToString(@"hh\:mm\:ss");
        }

        public override string ToString()
        {
            string time;
            if(secondsFromMidnight > 43200)
            {
                int pmTime = SecondsFromMidnight - 43200;
                TimeSpan t = TimeSpan.FromSeconds(pmTime);
                time = t.ToString(@"hh\:mm\:ss") + "pm";
            }
            else
            {
                TimeSpan t = TimeSpan.FromSeconds(SecondsFromMidnight);
                time = t.ToString(@"hh\:mm\:ss") + "am";
            }
            return time;
        }
    }
}
