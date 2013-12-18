using System;
using System.Text;
class Program
{
    static int CountSubstrings(string text, string substring)
    {
        text = text.ToLower();
        int index = text.IndexOf(substring);
        int result = 0;
        int count = 0;
        while (index != -1)
        {
           // Console.WriteLine("{0} found at index: {1}", substring, index); // We can use this line to find each index
            index = text.IndexOf(substring, index + 1);
            count++;      
        }
        Console.WriteLine("Substring \"{0}\" is appears {1} times", substring, count);
        return result;
    }

    static void Main(string[] args)
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. " + "\n" + 
        "So we are drinking all the day. We will move out of it in 5 days.";
        string substring = "in";
        int result = CountSubstrings(text, substring);
       


    }
}

