using System;
using System.Text;
class Program
{
    static string Encrypt(string text, string key)
    {
        StringBuilder encryptedText = new StringBuilder(text.Length);
        for (int i = 0; i < text.Length; i++)
        {
            encryptedText.Append((char)(text[i] ^ key[i % key.Length]));
        }
        return encryptedText.ToString();
    }

    static string Decrypt(string text, string key)
    {
        return Encrypt(text, key);
    }

    static void Main(string[] args)
    {
        string  text = "Norman was an American novelist, journalist, essayist, playwright, film maker, actor and political candidate.Norman was born to a well-known Jewish family in Long Branch, New Jersey";
        string key = "Norman";
        Console.WriteLine(Encrypt(text, key));
        Console.WriteLine(Decrypt(Encrypt(text, key), key));
    }   
}
