using System;
using System.Text;
class CheckForCorrectBrackets
{
    static void Main(string[] args)
    {

        string text = ")(2+3)/2(";
        Console.WriteLine("Is correct expression: {0}", text);
        char[] textChar = text.ToCharArray();

        int brackets = 0;
        bool isCorrect = true;
        for (int i = 0; i < textChar.Length; i++)
        {
            if (textChar[i] == '(')
            {
                brackets++;
            }
            else if (textChar[i] == ')')
            {
                brackets--;
            }
            if (brackets < 0)
            {
               break;
            }
        }
        if (brackets == 0)
        {
            Console.WriteLine(isCorrect);
        }
        else
        {
            Console.WriteLine(isCorrect = false);
        }
    }   
}
