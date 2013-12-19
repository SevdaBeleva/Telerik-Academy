using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder();
            str.Append("get index");
            str.AppendLine();
            str.Append("first line");
            str.AppendLine();
            str.Append("something else"); 

            Console.WriteLine(str.Substring(7, 9));
           
            

        }
    }
}
