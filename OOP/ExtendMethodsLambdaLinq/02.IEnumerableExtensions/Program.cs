﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(list.GetSum());
            Console.WriteLine(list.GetAverage());
            Console.WriteLine(list.GetMin());
            Console.WriteLine(list.GetMax());
        }
    }
}
