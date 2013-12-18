using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class TribonacciTriangle
{
    static void Main(string[] args)
    {
        BigInteger n1 = int.Parse(Console.ReadLine());
        BigInteger n2 = int.Parse(Console.ReadLine());
        BigInteger n3 = int.Parse(Console.ReadLine());
        int lines = int.Parse(Console.ReadLine());
        if (lines >= 2 && lines <= 20)
        {
            Console.WriteLine(n1);
            Console.WriteLine("{0} {1}", n2, n3);
            for (int i = 2; i < lines; i++)
            {
                BigInteger fib = 0;
                for (int j = 0; j < i + 1; j++)
                {
                    fib = n3 + n2 + n1;
                    n1 = n2;
                    n2 = n3;
                    n3 = fib;
                    Console.Write("{0} ", fib);
                }
                Console.WriteLine();
            }
        }     
    }
}

