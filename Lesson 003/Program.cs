using System;

namespace Lesson_003
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            int x = 10, y = 12, z = 3;
            Console.WriteLine("Task 1");
            Console.WriteLine("At the beggining: x={0}, y={1}, z={2}", x, y, z);
            x += y - x++ * z; 

            Console.WriteLine("x += y - x++ * z");
            Console.WriteLine("x=" + x);
            Console.WriteLine("Now: x={0}, y={1}, z={2}", x, y, z);
            z = --x - y * 5;
            Console.WriteLine("z = --x - y * 5");
            Console.WriteLine("z=" + z);
            Console.WriteLine("Now: x={0}, y={1}, z={2}", x, y, z);
             y /= x + 5 % z;
            Console.WriteLine("y /= x + 5 % z");
            Console.WriteLine("y=" + y);
            Console.WriteLine("Now: x={0}, y={1}, z={2}", x, y, z);
            z = x++ + y * 5;
            Console.WriteLine("z = x++ + y * 5");
            Console.WriteLine("z=" + z);
            Console.WriteLine("Now: x={0}, y={1}, z={2}", x, y, z);
            x = y - x++ * z;
            Console.WriteLine("x = y - x++ * z");
            Console.WriteLine("x=" + x);
            Console.WriteLine("Now: x={0}, y={1}, z={2}", x, y, z);

            Console.WriteLine("Please, press a key to see next task...");
            Console.ReadKey();
            #endregion

            #region Task2
            Console.WriteLine("\nTask 2");
            int a = 100, b = 111, c = 333;
            decimal avarageDecimal = (decimal)(a + b + c) / 3;
            double avarageDouble = (double)(a + b + c) / 3;
            Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);
            Console.WriteLine("Avarage (double) of a, b and c is {0}", avarageDouble);
            Console.WriteLine("Avarage (decimal) of a, b and c is {0}", avarageDecimal);
            Console.ReadKey();
            #endregion

            #region Task3
            Console.WriteLine("\nTask 3");
            double pi = 3.141592653, r = 1.5;
            double circleArea = pi * Math.Pow(r, 2);
            Console.WriteLine("Area of a circle with radius r={0} equals to {1}", r, circleArea);
            Console.ReadKey();
            #endregion

            #region Task4
            Console.WriteLine("\nTask 4");
            r = 12;
            double h = 17.5;
            double cylinderVolume = pi * Math.Pow(r, 2) * h;
            Console.WriteLine("Volume of a cylinder with radius r={0} and hight h={1} equals to {2}", r, h, cylinderVolume);
            double cylinderSurfaceArea = 2 * pi * r * (r + h );
            Console.WriteLine("Surface area of a cylinder with radius r={0} and hight h={1} equals to {2}", r, h, cylinderSurfaceArea);
            Console.ReadKey();
            #endregion
        }
    }
}
