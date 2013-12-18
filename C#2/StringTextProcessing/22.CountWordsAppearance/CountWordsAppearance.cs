using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string input = "this is some text, just for this task";
        var dictionary = new Dictionary <string, int>();

        foreach (Match word in Regex.Matches(input, @"\w+"))
        {
            dictionary[word.Value] = dictionary.ContainsKey(word.Value) ? dictionary[word.Value] + 1 : 1;
        }

        foreach (var letter in dictionary)
        {
            Console.WriteLine("{0}: {1}", letter.Key, letter.Value);
        }
    }
}
