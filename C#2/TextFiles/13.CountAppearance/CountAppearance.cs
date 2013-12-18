using System;
using System.IO;
using System.Text.RegularExpressions;

class CountAppearance
    {
        static void Main(string[] args)
        {
            try
            {
                string[] words = File.ReadAllLines("words.txt"); 
                int[] values = new int[words.Length];

                
                StreamReader reader = new StreamReader("test.txt");
                StreamWriter writer = new StreamWriter("result.txt");

                using (reader)
                {
                    for (string line; (line = reader.ReadLine()) != null; )
                    {
                        for (int i = 0; i < words.Length; i++)
                        {
                            values[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;
                        }
                    }
                }

                Array.Sort(values, words);

                using (writer)
                {
                    for (int i = words.Length - 1; i >= 0; i--)
                    {
                        writer.WriteLine("{0} - {1}", words[i], values[i]);
                    }
                }
        }

        catch (FileNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }

            catch (DirectoryNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }

            catch (IOException exception)
        {
            Console.WriteLine(exception.Message);
        }


            catch (UnauthorizedAccessException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}
    

