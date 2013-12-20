using System;
using System.Globalization;
using System.Threading;


namespace StudentsBehavior
{
    public class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive!");
            }

            //Calculate semiparameter (s)
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            return area;
        }

        public static string NumberToText(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("number must be in the range 0-9");
            }
        }

        public static int FindMax(params int[] array)
        {
            
            if (array == null )
            {
                throw new ArgumentNullException();
            }

            if (array.Length == 0)
            {
                throw new ArgumentException("no elements in the array");
            }

            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }

        //Change method PrintAsNumber into 3 separated methods
        public static void FormatFToNumber(object number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        public static void FormatPercentToNumber(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        public static void FormatRToNumber(object number)
        {
            Console.WriteLine("{0,8}", number);
        }

        public static double CalcDistance(double x1, double y1, double x2, double y2, out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (y1 == y2);
            isVertical = (x1 == x2);
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

            return distance;
        }
    }
}



