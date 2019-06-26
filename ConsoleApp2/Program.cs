using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Lib.Add(10, 20));
            Console.WriteLine(Lib.AddStrings("one", "two"));
            Console.WriteLine(Lib.AddStrings("three", "four"));
        }
    }

    public class Lib
    {
        public static int Add(int x, int y, int z = 0)
        {
            return x + y + z;
        }

        public static string AddStrings(string x, string y)
        {
            return x + y;
        }
        
    }
}