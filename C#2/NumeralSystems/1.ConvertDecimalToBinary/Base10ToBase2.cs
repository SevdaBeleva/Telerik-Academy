using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ConvertDecimalToBinary
{
    class Base10ToBase2
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                list.Add(number % 2);
                number = number / 2;
            }
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
            }


        }
    }
}
