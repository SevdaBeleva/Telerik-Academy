using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.RemoveItem(3);
            list.InsertItem(1, 5);
            GenericList<int>[] array = new GenericList<int> { 2, 4, 1, 56, 23 };



            for (int i = 0; i < list.Count; i++)
            {
                int element = list[i];
                Console.WriteLine(element);
            }
        }
    }
}
