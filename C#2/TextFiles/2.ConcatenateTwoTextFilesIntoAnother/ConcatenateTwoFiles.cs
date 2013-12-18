using System;
using System.IO;

class ConcatenateTwoFiles
    {
        static void ConcatenateFiles(string files, StreamWriter concatenatedFile )
        {

            using (StreamReader reader = new StreamReader(files))
            {
                for (string line; (line = reader.ReadLine()) != null; )
                {
                    concatenatedFile.WriteLine(line);
                }
                
            }
        }
 
        static void Main(string[] args)
        {
           string [] files = {"Program.cs", "Program.cs"};
           using (StreamWriter writer = new StreamWriter("ConcatenatedTestTest1.txt"))
           {
               foreach (string file in files)
               {
                   ConcatenateFiles(file, writer);
                   Console.WriteLine(file);
               }
           }
        
        }
    }
