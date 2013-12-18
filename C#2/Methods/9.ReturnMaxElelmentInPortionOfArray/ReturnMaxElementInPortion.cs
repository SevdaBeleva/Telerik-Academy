using System;
namespace _9.ReturnMaxElelmentInPortionOfArray
{
    class ReturnMaxElementInPortion
    {
        
        static int ReturnMaxElementInPortion1(int[] array, int position)
        {
            int maxNumber = position;
            for (int i = position; i < array.Length; i++)
            {
                if (maxNumber < array[i])
                {
                    maxNumber = array[i];
                }
            }
            Console.WriteLine(maxNumber);
            return maxNumber;
        }
        
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 2, 23, 12, 4, 5, 67, 890};
            ReturnMaxElementInPortion1(array, 3);
        }
    }
}
