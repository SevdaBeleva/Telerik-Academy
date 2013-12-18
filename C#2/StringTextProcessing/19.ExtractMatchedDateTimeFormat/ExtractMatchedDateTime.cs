using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string input = "this is just some text 23.12.2013 this is just some text";

        DateTime date;
        foreach (Match item in Regex.Matches(input, @"\b\d{2}.\d{2}.\d{4}\b"))
        {
            if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }
    }   
}
