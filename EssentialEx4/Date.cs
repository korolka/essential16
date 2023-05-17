using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialEx4
{
    internal class Date
    {
        private DateTime dateTime;

        public Date(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public DateTime DateTime
        {
            get { return dateTime; }
        }

        public static TimeSpan operator -(Date dateTime1, Date dateTime2)
        {
            TimeSpan dateTime3 = dateTime1.DateTime - dateTime2.DateTime;
            return dateTime3;
        }

        public static DateTime operator +(Date dateTime, double plusDays)
        {
            DateTime result = dateTime.DateTime.AddDays(plusDays);
            return result;
        }
    }
}
