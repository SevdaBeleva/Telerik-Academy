using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Anacci
{
    static void Main(string[] args)
    {
        string  first = Console.ReadLine().ToUpper();
        string second = Console.ReadLine().ToUpper();
        byte lines = byte.Parse(Console.ReadLine());

        int firstToInt = first[0];
        int secondToInt = second[0];
        int summator = 64;

        firstToInt = firstToInt - summator;
        secondToInt = secondToInt - summator;

        Console.WriteLine((char)(firstToInt + summator));
        int fib = secondToInt+ firstToInt;
        if (fib > 26)
        {
            fib = fib % 26;
        }
            
        if (lines > 1)
        {
            Console.WriteLine("{0}{1}", (char)(secondToInt + summator), (char)(fib + summator));
            firstToInt = secondToInt;
            secondToInt = fib;
            for (int i = 2; i < lines; i++)
            {
                fib = firstToInt + secondToInt;
                if (fib > 26)
                {
                    fib = fib % 26;
                }
                firstToInt = secondToInt;
                secondToInt = fib;
                fib = firstToInt + secondToInt;
                if (fib > 26)
                {
                    fib = fib % 26;
                }
                firstToInt = secondToInt;
                secondToInt = fib;
                Console.Write((char)(firstToInt + summator));
                Console.Write(new String(' ', i - 1));
                Console.Write((char)(secondToInt + summator));

                Console.WriteLine();
            }
        }
    }
}

