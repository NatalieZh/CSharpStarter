using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pi = 3.141592653m;
            decimal e = 2.7182818284590452m;

            Console.WriteLine("Task 2");
            Console.WriteLine("pi:" + pi);
            Console.WriteLine("e:" + e);
            Console.WriteLine("Please, press a key to see next task...");
            Console.ReadKey(true);

            Console.WriteLine("Task 3");
            Console.WriteLine("\nMy string 1");
            Console.WriteLine("\tMy string 2");
            Console.WriteLine("\aMy string 3");
            Console.ReadKey(true);
        }
    }
}
