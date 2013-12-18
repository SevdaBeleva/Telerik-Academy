using System;


class CompareCharArraysLexicographically
{
    static void Main(string[] args)
    {
        string arr1 = Console.ReadLine();
        string arr2 = Console.ReadLine();
        char[] array1 = arr1.ToCharArray();
        char[] array2 = arr2.ToCharArray();
        bool equal = true;
        int minLength = Math.Min(array1.Length, array2.Length);
        if (array1.Length != array2.Length)
        {
            return;
        }
        for (int i = 0; i < minLength; i++)
        {
            if (array1[i] != array2[i])
            { 
                equal=false;
                Console.WriteLine(equal);
                return;
            }
            
        }
    }
}

