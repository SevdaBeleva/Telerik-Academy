using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CompareTwoArrays
{
    class CompareTwoArrays
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[m];


            if (firstArray.Length != secondArray.Length)
            {
                Console.WriteLine("Arrays have different Length");
                return;
            }
            else
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    firstArray[i] = int.Parse(Console.ReadLine());
                    secondArray[i] = int.Parse(Console.ReadLine());
                    if (firstArray[i] != secondArray[i])
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }
        }
    }
}
