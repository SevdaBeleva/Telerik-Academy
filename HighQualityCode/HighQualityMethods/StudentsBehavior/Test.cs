using System;
using System.Threading;

namespace StudentsBehavior
{
    public class Test
    {
        public static void Main()
        {
            Console.WriteLine(Methods.CalcTriangleArea(3, 4, 5));
            Console.WriteLine(Methods.NumberToText(5));
            Console.WriteLine(Methods.FindMax(5, -1, 3, 2, 14, 2, 3));

            Methods.FormatFToNumber(1.3);
            Methods.FormatPercentToNumber(0.75);
            Methods.FormatRToNumber(2.30);

            bool horizontal, vertical;
            Console.WriteLine(Methods.CalcDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter","Ivanov", "17.03.1992" );
            Student stella = new Student("Stella", "Markova", "03.11.1993");
            
            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, Methods.IsOlderThan(peter.BirthDate, stella.BirthDate));
        }
    }
}
