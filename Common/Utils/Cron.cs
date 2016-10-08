using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade.Amp.Common.Utils
{
    public class Cron
    {
        public class Digit
        {
            public string english { get; set; }
            public bool every { get; set; }
            public int gcd { get; set; }
            public int[] values { get; set; }
        }

        private string[] daysOfWeek = {"sun", "mon", "tue", "wed", "thu", "fri", "sat"};
        private string[] longDaysOfWeek = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
        private string[] monthNames = {"jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec"};
        private string[] longMonthNames = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
        private int StarValue = -1;

        public string human { get; set; }
        public Digit min { get; set; }
        public Digit hour { get; set; }
        public Digit dom { get; set; }
        public Digit mon { get; set; }
        public Digit dow { get; set; }

        public Cron(string vixie)
        {

        }
    }
}
