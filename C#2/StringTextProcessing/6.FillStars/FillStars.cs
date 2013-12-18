using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string text = "We are looking for";
        char symbol = '*';
        Console.WriteLine(text.PadRight(20, symbol));
    }
    
}
