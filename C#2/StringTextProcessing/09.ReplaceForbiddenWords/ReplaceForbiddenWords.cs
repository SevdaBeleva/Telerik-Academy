using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

class ReplaceForbiddenWords
{
    static void Main(string[] arg)
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string words = "PHP, CLR, Microsoft";
        Console.WriteLine(Regex.Replace(text, words.Replace(", ", "|") , t => new String('*', t.Length)));
    }

}
