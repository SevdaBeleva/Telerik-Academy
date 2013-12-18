using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FindSequenceOfMaxSum
{
    class FindSequenceOfMaxSum
    {
        static void Main(string[] args)
        {

            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int currentSum = array[0];
            int maxSum = array[0];
            int sequence = 1;
            int currentSequence = 1;
            int startIndex = 0; 
            int endIndex = 0;
            //Kadane's algorithm
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] + maxSum > array[i])
                {
                    maxSum = array[i] + maxSum;
                    currentSequence++;
                }

                else
                {
                    maxSum = array[i];
                    endIndex = i;
                    currentSequence = 1;
                }
                if (maxSum > currentSum)
                {
                    currentSum = maxSum;
                    sequence = currentSequence;
                    startIndex = endIndex;
                }
            }
            
            int sumSequence = 0;
            Console.Write("sequence: ");
            for (int i = startIndex; i < startIndex + sequence; i++) // print sequence
            {
               sumSequence =  sumSequence + array[i]; // Find the sum of the sequence
               Console.Write(array[i] + " ");
                
            }
            Console.WriteLine("\nsum of sequence: "+ sumSequence);  
        }
    }
}
