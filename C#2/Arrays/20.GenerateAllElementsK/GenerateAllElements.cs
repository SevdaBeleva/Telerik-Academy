using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.GenerateAllElementsK
{
    class GenerateAllElements
    {
        static void Input(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + 1 + (i == array.Length - 1 ? "\n" : " "));
            }
        }

        static void GenerateCombinations(int[] array, bool[] used, int i)
        {
            if (i == array.Length)
            {
                Input(array);
                return;
            }

            for (int j = 0; j < array.Length; j++)
            {
                if (used[j]) continue;
                {
                    array[i] = j;
                    used[j] = true;
                    GenerateCombinations(array, used, i + 1);
                    used[j] = false;
                }
            }
        }

        static void Main()
        {
            int[] array = new int[int.Parse(Console.ReadLine())];

            bool[] used = new bool[array.Length];
            GenerateCombinations(array, used, 0);
        }
    }
}
