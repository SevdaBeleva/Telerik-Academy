using System;
namespace _1.Hello
{
    class Hello
    {
        static void Hello1(string name)
        {
            Console.WriteLine("Hello, " + name);
        }
        static void Main()
        {
            string name = Console.ReadLine();
            Hello1(name);
        }
    }
}
