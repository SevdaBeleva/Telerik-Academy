using System;
using System.Text;
using System.Text.RegularExpressions;
class ExtractSentences
{
    static void Main(string[] args)
    {
        string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day.We will move out of it in 5 days.";
        string[] arrayText = text.Split('.');

        string word = "In";
        Regex check = new Regex (@"\b" + word + @"\b", RegexOptions.IgnoreCase);
        foreach (string sentence in arrayText)
        {
            Match searched = check.Match(sentence);
            if (searched.Success)
            {
                Console.WriteLine(sentence);
            }
        }
    }   
}
