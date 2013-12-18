using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("file.txt");
        StreamWriter writer = new StreamWriter("file1.txt");
        string line;
        using (reader)
        {
                line = reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.Replace("start", "finish"));
                }
            
        }
    }
}

