using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

  class ReplaceWholeWord
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("file.txt");
            StreamWriter writer = new StreamWriter("file1.txt");
            string line;
            using (reader)
            {
                using (writer)
                {
                    line = reader.ReadLine();
                    while ((line = reader.ReadLine()) != null)
                    {
                        
                        writer.WriteLine(line =Regex.Replace(line, @"\bstart\b", "finish"));
                    }
                   
                }
            }
        }
    }

