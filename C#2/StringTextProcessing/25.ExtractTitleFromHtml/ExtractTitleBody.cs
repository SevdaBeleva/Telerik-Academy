using System;
using System.Text.RegularExpressions;

class Program
    {
        static void Main(string[] args)
        {
            string input = "<html><head><title>News</title></head><body><p><a href=http://academy.telerik.com>Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";
            MatchCollection matchProtocolAndSiteName = Regex.Matches(input, @"(?<=^|>)[^><]+?(?=<|$)");
            foreach (var phrase in matchProtocolAndSiteName)
            {
                Console.WriteLine(phrase);
            }
        }
    }

