using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    public class GSM  // 1-st task. Define classes
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private List<Call> callHistory;

        private static string iPhone4S =  "revolution";       //  6-th task - Add a static field and a property
                                                              //    IPhone4S in the GSM class to hold the information about iPhone 4S.

        public GSM (string model, string manufacturer, decimal price, string owner ) // 2-nd task.Define constructor for classes
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.callHistory = new List<Call>();
        }

        public override string ToString()  // 4-th task. Write a method in the GSM class for displaying all information about it
        {
            return string.Format("model: {0}, manufacturer: {1}, price: {2}, owner: {3} ",
                this.model, this.manufacturer, this.price, this.owner) ;
        }

        public string Model    // 5-th task - Use properties to encapsulate the data fields
        {
            get { return this.model; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Model should be a 5 digit number");
                }
                this.model = value;
            }
        }

        public string Manufacturer    // 5-th task - Use properties to encapsulate the data fields
        {
            get { return this.manufacturer; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Enter a manufacturer!");
                }
                this.manufacturer = value;
            }
        }

        public decimal Price       // 5-th task - Use properties to encapsulate the data fields
        {
            get { return this.price; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price should not be 0 or negative number");
                }
                this.price = value;
            }
        }

        public string Owner     // 5-th task - Use properties to encapsulate the data fields
        {
            get { return this.owner; }
            set
            {
                if (value != owner)
                {
                    throw new ArgumentException("You must enter an owner");
                }
                this.owner = value;
            }
        }

        public static string IPhone4S         // 6-th task - Add a static field and a property
                                             //    IPhone4S in the GSM class to hold the information about iPhone 4S.
        {
            get { return iPhone4S; }
            set { iPhone4S = value; }
        }


        public List<Call> CallHistory      // task 9 - Add a property CallHistory in the GSM class 
                                           //  to hold a list of the performed calls.
        {
            get { return callHistory; }
            set { callHistory = value; }
        }

        public void DeleteCall(Call call)  // task 10 - Add method in the GSM class for deleting 
                                                                   // calls from the calls history.

        {
            callHistory.Remove(call);   
        }

        public void DeleteAllCalls(List<Call> callHistory)     // task 10 - Add methods in the GSM class for deleting 
                                                               //  all calls from the calls history.

        {
            callHistory.Clear();
        }

        public void AddCall(Call call)  // task 10 - Add methods in the GSM class for adding
                                                                // calls from the calls history. 

        {
            callHistory.Add(call);
        }

        public decimal CalculateTotalPrice(decimal price)      // task 11 - Add a method that calculates the total price 
                                                               // of the calls in the call history. 
        {
            decimal totalPrice = 0;
            ulong minutesAll = 0;
            for (int i = 0; i < callHistory.Count; i++ )
            {
                minutesAll = minutesAll + callHistory[i].Duration;      
            }
            totalPrice = price * (minutesAll / 60);
            return totalPrice;
        }
        
    }
}
