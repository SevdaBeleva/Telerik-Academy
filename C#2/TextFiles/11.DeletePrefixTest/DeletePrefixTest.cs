using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _11.DeletePrefixTest
{
    class DeletePrefixTest
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("prefix.txt");
            StreamWriter writer = new StreamWriter("result prefix.txt");
            string line;
            using (reader)
            {
                using (writer)
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
                    }
                }
            }
        }
    }
}
