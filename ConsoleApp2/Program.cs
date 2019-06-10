using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Add(10, 20));
            Console.WriteLine(AddStrings("one", "two"));
        }

        static int Add(int x, int y, int z = 0)
        {
            return x + y + z;
        }

        static string AddStrings(string x, string y)
        {
            return x + y;
        }
    }
}