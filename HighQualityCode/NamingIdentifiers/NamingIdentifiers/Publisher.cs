using System;

public class Publisher
{
    private const int MaxCount = 6;
    public class ConsolePublisher
    {
        public void PrintValue(bool variable)
        {
            string result = variable.ToString();
            Console.WriteLine(result);
        }
    }

    public static void Main(string[] args)
    {
        ConsolePublisher publisher = new ConsolePublisher();
        publisher.PrintValue(true);
    }
}

