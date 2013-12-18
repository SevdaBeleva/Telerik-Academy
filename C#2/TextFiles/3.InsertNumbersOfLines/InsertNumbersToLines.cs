using System;
using System.IO;

class InsertNumbersToLines
{
    static void Main(string[] args)
    {
        int count = 1;
        string line;
        using (StreamReader reader = new StreamReader("DxDiag.txt"))
        {
            using (StreamWriter writer = new StreamWriter("DxDiagNew.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(String.Format("{0} {1}", count, line));
                    count++;
                }
            }
        }
    }
}


    
