using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class CountLetterAppearance
    {
        static void Main()
        {
            string input = "this is some text. just for this task";
            int[] values = new int['z' - 'a' + 1];

            foreach (char c in input.ToLower())
            {
                if ('a' <= c && c <= 'z')
                {
                    values[c - 'a']++;
                }
            }

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] != 0)
                {
                    Console.WriteLine("{0}: {1}", (char)(i + 'a'), values[i]);
                }
            }
        }
    }

