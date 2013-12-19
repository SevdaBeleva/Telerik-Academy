using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hold64BitValues
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray64 array = new BitArray64(10);  // create the first array

            foreach (var bit in array)
            {
                Console.Write(bit);
            }

            BitArray64 newArray = new BitArray64(10); // create new to compare it with the first one

            Console.WriteLine(array.Equals(newArray)); // Check Equals
            Console.WriteLine(BitArray64.Equals(array, newArray)); // Check ==
            Console.WriteLine(!BitArray64.Equals(array, newArray));  // Check !=
            Console.WriteLine(array.GetHashCode());     // Check GetHashCode
            Console.WriteLine(newArray.GetHashCode());   // Check GetHashCode
        }
    }
}
