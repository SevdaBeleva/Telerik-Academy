using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    public class Call     // task 8 - Create a class Call to hold a call performed through a GSM. 
                   // It should contain date, time, dialed phone number and duration (in seconds).

    {
        string date;
        string time;
        public string dialedPhone;
        public ulong duration;

        public Call(string date, string time, string dialedPhone, ulong duration)
        {
            this.date = date;
            this.time = time;
            this.dialedPhone = dialedPhone;
            this.duration = duration;

        }

        public string Date
        {
            get { return this.date; }
            set { date = value; }
        }

        public string Time
        {
            get { return this.time; }
            set { time = value; }
        }

        public string DialedPhone
        {
            get { return this.dialedPhone; }
            set { dialedPhone = value; }
        }

        public ulong Duration
        {
            get { return this.duration; }
            set { duration = value; }
        }

        public override string ToString()     // Display information about calls
        {
            return string.Format("Details -- date: {0} time: {1} dialedPhone: {2} duration: {3}", 
                this.date, this.time, this.dialedPhone, this.duration);
        }

        
    }
}
