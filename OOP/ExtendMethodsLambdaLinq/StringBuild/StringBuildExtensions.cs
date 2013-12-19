using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuild
{

    // task 1: Implement an extension method Substring(int index, int length) for the class StringBuilder that returns 
    // new StringBuilder and has the same functionality as Substring in the class String.
 
   public static class StringBuildExtension
    {
       public static string Substring (this StringBuilder stringBuilder, int index, int length)
       {
           return stringBuilder.ToString(index, length);
       }
    }
}
