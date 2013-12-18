using System;
namespace _12.CreateArrayOfAlphabet
{
    class CreateArrayOfAlphabet
    {
        static void Main(string[] args)
        {
            char[] array = new char[26];
            string word = (Console.ReadLine());

            for (int i = 1; i < 26; i++)
            {
                array[i] = Convert.ToChar('a' + i);
            }

            for (int j = 0; j < word.Length; j++)
            {
                Console.WriteLine( "{0} - {1}",word[j], word[j] - 'a');
            }                              
        }
    }
}
