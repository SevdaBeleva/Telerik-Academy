using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hold64BitValues
{
    // task 5  Define a class BitArray64 to hold 64 bit values inside an ulong value. 
    //Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

   public class BitArray64 : IEnumerable<int>
    {
       private int[] array = new int[64];
       private ulong number;

       public BitArray64(ulong number)   // Create constructror for class BitArray64
        {
            this.number = number;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)(number % 2);
                number = number / 2;
            }
        }
       public ulong Number      // define a property for number field
       {
           get { return this.number; }
           private set 
           {
               this.number = value;
           }
       }

       public IEnumerator<int> GetEnumerator()     // use enumerator to implement foreach loop
       {
           for (int i = array.Length-1; i >=0; i--)
           {
               yield return this.array[i];
           }
       }

       System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() //  generic version
       {
           return this.GetEnumerator();

       }

       public override bool Equals(object obj)
       {
           BitArray64 array = obj as BitArray64;

           if (Object.Equals(this.number, array.number))
           {
               return true;
           }
           return false;
       }

       // override System.Pbject: GetHashCode
       public override int GetHashCode()
       {
           return this.number.GetHashCode() ^ this.array.GetHashCode();
       }

       // override System.Pbject: operator ==
       public static bool operator == (BitArray64 array1, BitArray64 array2)
       {
           return BitArray64.Equals(array1, array2);
       }

       // override System.Pbject: operator !=
       public static bool operator !=(BitArray64 array1, BitArray64 array2)
       {
           return !(BitArray64.Equals(array1, array2));
       }
       
    }
    
    
}
