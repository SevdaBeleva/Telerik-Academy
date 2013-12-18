using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class ReadTextPrintOddLines
    {
        static void Main(string[] args)
        {
            
            StreamReader reader = new StreamReader("test.txt", Encoding.GetEncoding("windows-1251"));
            using (reader)
            {
                int count = 1;
                for (string fileContent; (fileContent = reader.ReadLine()) != null; count++)
                {
                    if (count % 2 == 1)
                    {
                        Console.WriteLine(fileContent);
                    }
                }
            }
            

        }
    }

