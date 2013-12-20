using System;
using System.Collections.Generic;
using System.Text;

public class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null || arr.Length <= 0)
        {
            throw new ArgumentNullException("Array is null or empty!");
        }
        if (startIndex < 0)
        {
            throw new ArgumentException("Start index must be 0 or positive number!");
        }
        if (count < 0)
        {
            throw new ArgumentException("Count must be 0 or positive number!");
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }
        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (String.IsNullOrEmpty(str))
        {
            throw  new ArgumentNullException("string must not be null or empty!");
        }
        if (count > str.Length)
        {
            throw new ArgumentOutOfRangeException("Count number must be smaller than stirng's length!");
        }
        if (count < 0)
        {
            throw  new ArgumentOutOfRangeException("Count must be a positive number!");
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }
        return result.ToString();
    }

    public static bool CheckPrime(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Number must a positive number!");
        }

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        { 
            if (number % divisor == 0)
            {
                return false;
            }       
        }
        return true;
    }

    static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));
        Console.WriteLine(ExtractEnding("Hi", 1));

        try
        {
            Console.WriteLine(CheckPrime(23));
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Check prime number must be a positive value!");
        }

        try
        {
            Console.WriteLine(CheckPrime(33));      
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Check prime number must be a positive value!");
        }

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
