using System;
using System.Linq;

class Program
{
    static string ReverseSentence(string sentence)
    {
        sentence.Trim();
        string[] array = sentence.Split(' ');
        Array.Reverse(array);
        return string.Join(" ", array);
    }
    static void Main(string[] args)
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";
        Console.WriteLine(ReverseSentence(sentence));
        
    }
}

