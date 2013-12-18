using System;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceLetters
{
    static void Main(string[] args)
    {
        string input = "aaaaabbbbbcdddeeeedssaahhhhwwwwqqqqqpppppppp";
        Console.WriteLine(Regex.Replace(input, @"(\w)\1+", "$1"));
    }  
}
