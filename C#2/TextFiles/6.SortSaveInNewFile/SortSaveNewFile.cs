using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class SortSaveNewFile
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        string line;

        StreamReader firstFile = new StreamReader("first.txt");
        StreamWriter sortedFile = new StreamWriter("sorted.txt");
        using (firstFile)
        {
            while ((line = firstFile.ReadLine()) != null)
            {
                list.Add(line);
            }
            list.Sort();
            using (sortedFile)
            {
                foreach (string ln in list)
                {
                    sortedFile.WriteLine(ln);
                }     
            }      
        }
    }
}
        
