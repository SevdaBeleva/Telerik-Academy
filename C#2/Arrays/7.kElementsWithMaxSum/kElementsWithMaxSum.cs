using System;
using System.Diagnostics;


class MaxSumOfElemen
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int maxSum = 0;
        int length = 0;

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            length++;
            if (sum > maxSum && length == k)
            {
                maxSum = sum;
            }
            if (length == k)
            {
                i = (i + 1) - k;
                length = 0;
                sum = 0;
            }
        }
        Console.WriteLine(maxSum);
    }
}
