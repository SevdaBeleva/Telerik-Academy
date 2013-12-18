using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        string first = "03.03.2004";
        string second = "27.02.2006";

        DateTime firstDate = DateTime.ParseExact(first, "d.M.yyyy", CultureInfo.InvariantCulture);
        DateTime secondDate = DateTime.ParseExact(second, "d.M.yyyy", CultureInfo.InvariantCulture);

        TimeSpan result = secondDate - firstDate;
        int days = Math.Abs((int)result.TotalDays);
        Console.WriteLine(days);
    }
}

