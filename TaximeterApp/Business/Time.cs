using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaximeterApp.Business
{
    public class Time
    {
        int hour;
        int minute;

        public Time()
        {
            this.hour = 0;
            this.minute = 0;
        }
        public Time(int hour, int minute)
        {
            this.Hour = hour;
            this.Minute = minute;
        }

        public int Hour { get => hour; set => hour = value; }
        public int Minute { get => minute; set => minute = value; }

        public string duration()
        {
            return this.hour + " hrs " + this.minute + " mins";
        }
    }
}
