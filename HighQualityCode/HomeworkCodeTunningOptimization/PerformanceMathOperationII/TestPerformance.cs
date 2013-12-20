using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceMathOperationII
{
  public class TestPerformance
    {
        //Create a watch so we can measure the execution time of the functions
        public static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        static void Main(string[] args)
        {
            //Regions are used to organize the block code of the same operations with different var types. 
            //I've decided to use regions instead of classes because the output will be displayed on the console
            //at the same time and we can observe and compare the results easy.
            //Using classes and separated methods will influence code's readability.

            //Click + to expand region
            //Click - to collapse region

            //Test operation Math.Sqrt with different type of variables
            #region
            
            Console.Write("Math.sqrt float operation:   ");
            DisplayExecutionTime(() =>
            {
                float a = 5f;
                Math.Sqrt(a);
            });

            Console.Write("Math.sqrt double operation:  ");
            DisplayExecutionTime(() =>
            {
                double a = 5d;
                Math.Sqrt(a);
            });

            Console.Write("Math.sqrt decimal operation: ");
            DisplayExecutionTime(() =>
            {
                decimal a = 5m;
                Math.Sqrt((double)a);
            });
            #endregion

            Console.WriteLine("----------------------------------------------------");

            //Test operation Natural logarithm with different type of variables
            #region
            
            Console.Write("Natural logarithm float operation:   ");
            DisplayExecutionTime(() =>
            {
                float a = 5f;
                Math.Log(a);
            });

            Console.Write("Natural logarithm double operation:  ");
            DisplayExecutionTime(() =>
            {
                double a = 5d;
                Math.Log(a);
            });

            Console.Write("Natural logarithm decimal operation: ");
            DisplayExecutionTime(() =>
            {
                decimal a = 5m;
                Math.Log((double)a);
            });
            #endregion

            Console.WriteLine("----------------------------------------------------");

            //Test operation Natural logarithm with different type of variables
            #region

            Console.Write("Sinus float operation:   ");
            DisplayExecutionTime(() =>
            {
                float a = 5f;
                Math.Sin(a);
            });

            Console.Write("Sinus double operation:  ");
            DisplayExecutionTime(() =>
            {
                double a = 5d;
                Math.Sin(a);
            });

            Console.Write("Sinus decimal operation: ");
            DisplayExecutionTime(() =>
            {
                decimal a = 5m;
                Math.Sin((double)a);
            });
            #endregion
        }
    }
}
