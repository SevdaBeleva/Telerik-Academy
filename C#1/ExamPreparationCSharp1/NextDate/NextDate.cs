using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NextDate
{
    static void Main(string[] args)
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());

        string date = month.ToString() +'.' + day.ToString() +  '.' + year.ToString();
        DateTime wantedDate = Convert.ToDateTime(date).AddDays(1);        
        Console.WriteLine("{0}.{1}.{2}", wantedDate.Day, wantedDate.Month, wantedDate.Year);
    }
}

