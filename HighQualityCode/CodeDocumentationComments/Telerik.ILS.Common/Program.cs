using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringExtensions;

namespace Telerik.ILS.Common
{
   public class Program
    {
        static void Main(string[] args)
        {
            // Test some string extesnsions
            string bottom = "123baby123";
            Console.WriteLine(bottom.ToInteger());
            Console.WriteLine(bottom.ToShort());
            Console.WriteLine(bottom.ToBoolean());
            Console.WriteLine(bottom.ToMd5Hash());
            Console.WriteLine(bottom.CapitalizeFirstLetter());
            
        }
    }
}
