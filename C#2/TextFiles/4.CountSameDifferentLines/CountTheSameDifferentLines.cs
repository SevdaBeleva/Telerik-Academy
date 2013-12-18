using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int countSame = 0;
        int countDifferent = 0;
        
        string [] files = {"first.txt", "second.txt"};
        string line1;
        string line2;

        StreamReader firstFile = new StreamReader(files[0]);
        StreamReader secondFile = new StreamReader(files[1]);
        using (firstFile)
        {
            using (secondFile)
            {
                while ((line1 = firstFile.ReadLine()) != null && (line2 = secondFile.ReadLine()) != null)
                {
                    if (line1.Contains(line2))
                    {
                        countSame++;
                    }
                    else if (!line1.Contains(line2))
                    {
                        countDifferent++;
                    }
                }
                Console.WriteLine("The number of same lines is {0}", countSame);
                Console.WriteLine("The number of different lines is {0}", countDifferent);
            }      
        }
    }
    
}
