using System;
class PrintListAlphabetical
{
    static void Main(string[] args)
    {
        string input = "apple, beer, amstel, check, fair, baby, telerik, friends, technology";
        string[] array = input.Split(' ', ',');
        Array.Sort(array);
        foreach(string word in array)
        Console.WriteLine(word);
    }   
}
