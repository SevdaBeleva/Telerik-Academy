using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDevice
{
    class GSMTest       //  7-th task - Write a class GSMTest to test the GSM class
    {
        static void Main(string[] args)
        {
            // Instances of the GSM class
            GSM nokia = new GSM("63-10", "nokia", 350, "pesho");
            GSM sony = new GSM("0000", "sony", 180, "gosho");      // task 12 -- Create an instance of the GSM class
            GSM samsung = new GSM("0000", "samsung", 200, "tosho");

            GSM[] array = new GSM[] { nokia, sony, samsung };    //  7---- Create an array of few instances of the GSM class
            foreach (GSM gsm in array)
            {

                Console.WriteLine(gsm.ToString());              // 7--- Display the information about the GSMs in the array
            }

            Console.WriteLine(GSM.IPhone4S);                    // 7--- Display the information about the static property IPhone4S


            Call call = new Call("21/02/12","13:00","0877611817",78949);   // Create an instance of class Call
            Call call1 = new Call("02/02/13","13:45","0877611817",789);    // Create an instance of class Call
            Call call2 = new Call("03/03/13","15:00","0877611817",134444);  // Create an instance of class Call
            sony.AddCall(call);                // task 12 - Add few calls
            sony.AddCall(call1);               // task 12 - Add few calls
            sony.AddCall(call2);               // task 12 - Add few calls

            foreach (Call calls in sony.CallHistory)    // use foreach loop to display information about the calls
            {
                Console.WriteLine(calls.ToString());
            }

            Console.WriteLine("Total price: " + sony.CalculateTotalPrice(0.37m));   // task 12 Assuming that the price per minute is 0.37 
                                                                  // calculate and print the total price of the calls in the history

            Call  longestCall = new Call (" "," "," ",0);        // Find the longest call
            for (int i = 0; i < sony.CallHistory.Count; i++)
            {
                
                if (longestCall.duration < sony.CallHistory[i].Duration)
                { 
                    longestCall = sony.CallHistory[i];
                    
                }
            }
            sony.DeleteCall(longestCall);           // Remove the longest call
            Console.WriteLine("Total price after clearing the longest call is: "
                + sony.CalculateTotalPrice(0.37m)); // calculate again the total price again


            sony.DeleteAllCalls(sony.CallHistory);  // task 12 -- Finally clear the call history and print it.
            Console.WriteLine("Print call history after clearing it: ");
            foreach (Call calls in sony.CallHistory)    
            {
                Console.WriteLine(calls.ToString());
            }
        }      
    }
}

