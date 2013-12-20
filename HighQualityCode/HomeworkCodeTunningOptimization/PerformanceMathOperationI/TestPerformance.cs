using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceOperationVariable
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

            //Test operation Sum with different type of variables
            #region
            Console.Write("Sum int operation:      ");
            DisplayExecutionTime(() =>
            {
                int a = 5;
                int b = 7;
                int result = a + b;
            });

            Console.Write("Sum long operation:     ");
            DisplayExecutionTime(() =>
            {
                long a = 5;
                long b = 7;
                long result = a + b;
            });

            Console.Write("Sum float operation:    ");
            DisplayExecutionTime(() =>
            {
                float a = 5f;
                float b = 7f;
                float result = a + b;
            });

            Console.Write("Sum double operation:   ");
            DisplayExecutionTime(() =>
            {
                double a = 5d;
                double b = 7d;
                double result = a + b;
            });

            Console.Write("Sum decimal operation:  ");
            DisplayExecutionTime(() =>
            {
                decimal a = 5m;
                decimal b = 7m;
                decimal result = a + b;
            });
            #endregion

            Console.WriteLine("----------------------------------------------------");

            //Test operation Substract with different type of variables
            #region
            Console.Write("Substract int operation:     ");
            DisplayExecutionTime(() =>
            {
                int a = 5;
                int b = 7;
                int result = b - a;
            });

            Console.Write("Substract long operation:    "); 
            DisplayExecutionTime(() =>
            {
                long a = 5;
                long b = 7;
                long result = b - a;
            });

            Console.Write("Substract float operation:   ");
            DisplayExecutionTime(() =>
            {
                float a = 5f;
                float b = 7f;
                float result = b - a;
            });

            Console.Write("Substract double operation:  ");
            DisplayExecutionTime(() =>
            {
                double a = 5d;
                double b = 7d;
                double result = b - a;
            });

            Console.Write("Substract decimal operation: ");
            DisplayExecutionTime(() =>
            {
                decimal a = 5m;
                decimal b = 7m;
                decimal result = b - a;
            });
            #endregion

            Console.WriteLine("----------------------------------------------------");

            //Test operation Increment with different type of variables
            #region
            Console.Write("Increment int operation:     ");
            DisplayExecutionTime(() =>
            {
                int a = 5;
                a++;
            });

            Console.Write("Increment long operation:    ");
            DisplayExecutionTime(() =>
            {
                long a = 5;
                a++;
            });

            Console.Write("Increment float operation:   ");
            DisplayExecutionTime(() =>
            {
                float a = 5f;
                a++;
            });

            Console.Write("Increment double operation:  ");
            DisplayExecutionTime(() =>
            {
                double a = 5d;
                a++;
            });

            Console.Write("Increment decimal operation: ");
            DisplayExecutionTime(() =>
            {
                decimal a = 5m;
                a++;
            });
            #endregion

            Console.WriteLine("----------------------------------------------------");

            //Test operation Multiply with different type of variables
            #region
            Console.Write("Multiply int operation:      ");
            DisplayExecutionTime(() =>
            {
                int a = 5;
                int b = 7;
                int result = a * b;
            });

            Console.Write("Multiply long operation:     ");
            DisplayExecutionTime(() =>
            {
                long a = 5;
                long b = 7;
                long result = a * b;
            });

            Console.Write("Multiply float operation:    ");
            DisplayExecutionTime(() =>
            {
                float a = 5f;
                float b = 7f;
                float result = a * b;
            });

            Console.Write("Multiply double operation:   ");
            DisplayExecutionTime(() =>
            {
                double a = 5d;
                double b = 7d;
                double result = a * b;
            });

            Console.Write("Multiply decimal operation:  ");
            DisplayExecutionTime(() =>
            {
                decimal a = 5m;
                decimal b = 7m;
                decimal result = a * b;
            });
            #endregion

            Console.WriteLine("----------------------------------------------------");

            //Test operation Divide with different type of variables
            #region
            Console.Write("Divide int operation:        ");
            DisplayExecutionTime(() =>
            {
                int a = 5;
                int b = 7;
                int result = b / a;
            });

            Console.Write("Divide long operation:       ");
            DisplayExecutionTime(() =>
            {
                long a = 5;
                long b = 7;
                long result = b / a;
            });

            Console.Write("Divide float operation:      ");
            DisplayExecutionTime(() =>
            {
                float a = 5f;
                float b = 7f;
                float result = b / a;
            });

            Console.Write("Divide double operation:     ");
            DisplayExecutionTime(() =>
            {
                double a = 5d;
                double b = 7d;
                double result = b / a;
            });

            Console.Write("Divide decimal operation:    ");
            DisplayExecutionTime(() =>
            {
                decimal a = 5m;
                decimal b = 7m;
                decimal result = b / a;
            });
            #endregion

            Console.WriteLine();
        }
    }
}
