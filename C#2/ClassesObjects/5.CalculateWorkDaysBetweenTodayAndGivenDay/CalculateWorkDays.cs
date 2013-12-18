using System;
class Program
{
        static void Main()
        {
            DayOfWeek Saturday = DayOfWeek.Saturday;
            DayOfWeek Sunday = DayOfWeek.Sunday;
 
            DateTime[] Holidays = {
                                     DateTime.Parse("12/25/2013"),
                                     DateTime.Parse("12/24/2013"),
                                     DateTime.Parse("12/23/2013")
                                  };
 
            DateTime startDay = DateTime.Parse("01/01/2013");
            DateTime today = DateTime.Today;
 
            int count = 0;
   
            DateTime increase = startDay;

            while (increase < today)
            {
                if (increase.DayOfWeek != Saturday || increase.DayOfWeek != Sunday)
                {
                    count++;
                }
               foreach (var holiday in Holidays)
                {
                    if (increase == holiday)
                    {
                        count--;
                    }
                }
               increase = increase.AddDays(1);  
            }
            Console.WriteLine(count);
         }
}
    

