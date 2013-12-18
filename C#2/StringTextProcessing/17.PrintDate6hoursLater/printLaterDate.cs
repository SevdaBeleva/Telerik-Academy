using System;
using System.Text;
using System.Globalization;

class printLaterDate
{
    static void Main(string[] args)
    {
        string input = "03.02.2013 01:00:00";
        DateTime dateTime = DateTime.ParseExact(input, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        dateTime = dateTime.AddHours(6.5);
        Console.WriteLine("{0} {1}", dateTime.ToString("dddd", new CultureInfo("bg-BG")), dateTime);
    }    
}
