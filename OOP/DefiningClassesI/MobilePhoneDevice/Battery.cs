using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
   public class Battery  // 1-st task
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        BatteryType type;  // 3-rd task

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType type) // 2-nd task
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.type = type;
        }

        public string Model  // 5-th task - Use properties to encapsulate the data fields
        {
            get { return this.model; }
            set
            {
                if (value != model || value == null)    // Ensure all fields hold correct data at any given time
                {
                    throw new ArgumentException("Invalid argument: Model field should not be empty!");
                }
                this.model = value;
            }
        }

        public double HoursIdle   // 5-th task - Use properties to encapsulate the data fields
        {
            get { return this.hoursIdle; }
            set
            {
                if (value <= 0)   // Ensure all fields hold correct data at any given time
                {
                    throw new ArgumentException("Invalid argument: HoursIdle should not be a negative number!");
                }

                this.hoursIdle = value;
            }
        }

        public double HoursTalk    // 5-th task - Use properties to encapsulate the data fields
        {
            get { return this.hoursTalk; }
            set
            {
                if (value <= 0)     // Ensure all fields hold correct data at any given time
                {
                    throw new ArgumentException("Invalid argument: HoursIdle should not be a negative number!");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType Type
        {
            get { return this.type; }
            set
            {
                if (value != type)    // Ensure all fields hold correct data at any given time
                {
                    throw new ArgumentException("Invalid argument: Type must be of type BatteryType (Li-Ion, NiMH, NiCd, …) !");
                }

                this.type = value;     
            }
        }   
    }
}
