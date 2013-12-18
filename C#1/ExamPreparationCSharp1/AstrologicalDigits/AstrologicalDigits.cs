using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AstrologicalDigits
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();
        int wantedNumber = 0;

        do
        {
            for (int i = 0; i < number.Length; i++)
            {
                if ((number[i] == '.' || number[i] == '-'))
                {
                    i++;
                }

                wantedNumber += int.Parse(number[i].ToString());
            }

            if (wantedNumber < 10)
            { 
                break;
            }
            number = wantedNumber.ToString();
            wantedNumber = 0;
        }
        while (wantedNumber < 10) ;
        Console.WriteLine(wantedNumber);
    }
}

