using System;
using System.Text;
class Program
{
    static string ReverseText(string text)
    {
        StringBuilder reverse = new StringBuilder();
        for (int i = text.Length - 1; i >= 0;  i--)
        {
            reverse.Append(text[i]);
        }

        return reverse.ToString();
    }
    static void Main(string[] args)
    {
        string text = "This is a reversed string!";
        Console.WriteLine(text + "\n");

        string reversed = ReverseText(text);
        Console.WriteLine(reversed + "\n");
    }
}
