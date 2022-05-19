using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day05
{
    class HiringDate 
    {
        int day;
        int month;
        int year;

       
        public int Day
        {
            set { day = value; }
            get { return day; }
        }
        public int Month
        {
            set { month = value; }
            get { return month; }
        }

        public int Year
        {
            set { year = value; }
            get { return year; }
        }

        


        public override string ToString()
        {
            return $"({day} /  { month }  /  {year})";
        }
       
    }
}
