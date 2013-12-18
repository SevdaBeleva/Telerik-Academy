using System;
namespace _6.ReturnIndexIfItsBiggerOr_1
{
    class Program
    {
        static void ReturnIndex (int[] array )
        {
            int index = -1;
            for (int i = 1; i < array.Length-1; i++)
            {    
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    index = i; 
                } 
            }
            Console.WriteLine(index);   
        }
        static void Main(string[] args)
        {

            int[] array = { 12, 12312, 12, 12, 12, 12, 12 };
            ReturnIndex(array);
        }
    }
}
