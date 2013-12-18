using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MathExpression
{
    static void Main(string[] args)
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());

        decimal result = ((decimal)((double)Math.Pow((double)n, 2) + (1 / (double)(m * p)) + 1337) / 
            (decimal)((double)n - 128.523123123 * (double)p)) + (decimal)Math.Sin((int)(m % 180));
       // decimal roundedResult = Decimal.Round(result, 6);
        Console.WriteLine("{0:F6}", result);    
    }
}