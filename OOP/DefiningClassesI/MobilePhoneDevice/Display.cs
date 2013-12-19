using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
   public class Display   // 1-st task
    {
        private double size;
        private NumberOfColors color;

        public Display(NumberOfColors color, double size)  // 2-nd task
        {
            this.color = color;
            this.size = size;
        }

        public double Size     // 5-th task - Use properties to encapsulate the data fields
        {
            get { return this.size; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException ("Size should not be a negative number!");
                }
                this.size = value;
            }
        }

        public NumberOfColors Color      // 5-th task - Use properties to encapsulate the data fields
        {
            get { return this.color; }
            set
            {
                if (value != color)
                {
                    throw new ArgumentException("You must choose one of the colors: black, white, red, grey, green, pink, violete or blue!");
                }
                this.color = value;   
            }
        }
    }
}
