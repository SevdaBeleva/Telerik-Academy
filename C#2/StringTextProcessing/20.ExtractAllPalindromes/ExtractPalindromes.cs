using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
class Program
{
    static bool IsPalindrome(string input)
    {
        for (int i = 0; i < input.Length / 2; i++)
        {
            if (input[i] != input[input.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        string input = "just some text ABBA, using System lamal, exe.";

        foreach (Match item in Regex.Matches(input, @"\w+"))
        {
            if (IsPalindrome(item.Value))
            {
                Console.WriteLine(item);
            }
        }

        foreach (Match item in Regex.Matches(input, @"\b(?<N>.)+.?(?<-N>\k<N>)+(?(N)(?!))\b"))
        {
            Console.WriteLine(item);
        }
    }
    
}
