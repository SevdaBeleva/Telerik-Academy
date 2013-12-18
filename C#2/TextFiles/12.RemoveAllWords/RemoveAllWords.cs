using System;
using System.IO;
using System.Text.RegularExpressions;

class RemoveAllWords
    {
        static void Main(string[] args)
        {

            try
            {
                string words = @"\b(" + String.Join("|", File.ReadAllLines("words.txt")) + @")\b";

                using (StreamReader input = new StreamReader("anotherWords.txt"))
                using (StreamWriter output = new StreamWriter("result.txt"))
                    for (string line; (line = input.ReadLine()) != null; )
                        output.WriteLine(Regex.Replace(line, words, String.Empty));
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
    }
}

