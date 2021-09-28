using System;

namespace Lesson_005
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 256;
            int mask = 0x01;
            // Task 0.1
            Console.WriteLine("Task 0.1");
            bool result = i != 0 && (i & (i - 1)) == 0;
            if (result)
            {
                Console.WriteLine($"Number {i} is a power of 2!");
            }
            else
            {
                Console.WriteLine($"Number {i} is not a power of 2!");
            }

            // Task 0.2
            Console.WriteLine("Task 0.2");
            bool var1 = true, var2 = false;
            Console.WriteLine($"Variable1 = {var1}, Variable2 = {var2}", var1.ToString(), var2.ToString());
            result = var1 || var2;
            Console.WriteLine($"result = var1 || var2 = {result}");
            result = !(!var1 && !var2);
            Console.WriteLine($"result2 = !(!var1 && !var2) = {result}");

            // Task 2
            Console.WriteLine("Task 2");
            result = (i & mask) == 0;
            if (result)
            {
                Console.WriteLine($"Number {i} is even!");
            }
            else
            {
                Console.WriteLine($"Number {i} is odd!");
            }

            // Task 3
            Console.WriteLine("Task 3");
            int x = 5, y = 10, z = 15;
            Console.WriteLine($"At the beggining: x={x}, y={y}, z={z}");
            x += y >> x++ * z;
            Console.WriteLine("x += y >> x++ * z");
            Console.WriteLine($"Now: x={x}, y={y}, z={z}");
            z = ++x & y * 5;
            Console.WriteLine("z = ++x & y * 5");
            Console.WriteLine($"Now: x={x}, y={y}, z={z}");
            y /= x + 5 | z;
            Console.WriteLine("y /= x + 5 | z;");
            Console.WriteLine($"Now: x={x}, y={y}, z={z}");
            z = x++ & y * 5;
            Console.WriteLine("z = x++ & y * 5;");
            Console.WriteLine($"Now: x={x}, y={y}, z={z}");
            x = y << x++ ^ z;
            Console.WriteLine("x = y << x++ ^ z;");
            Console.WriteLine($"Now: x={x}, y={y}, z={z}");

            // Task 3
            Console.WriteLine("Task 4");
            double salary = 5000.0, totalSalary;
            int bonus, years = 17;

            if (years < 5)
            {
                bonus = 10;
            }
            else if (years >= 5 && years < 10)
            {
                bonus = 15;
            }
            else if (years >= 10 && years < 15)
            {
                bonus = 25;
            }
            else if (years >= 15 && years < 20)
            {
                bonus = 35;
            }
            else if (years >= 20 && years < 25)
            {
                bonus = 45;
            }
            else 
            {
                bonus = 50;
            }

            totalSalary = salary + salary * bonus / 100;
            Console.WriteLine($"Employee has been working for {years} years. His/her bonus is {bonus}%. Normal salary is {salary}. Total salary with bonus is {totalSalary}");
        }
    }
}
