using System;

namespace Lesson_006_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's draw a rectangle!");
            int length, hight, i, j;
            string temp, star = "*";
            bool valueChecked;

            // get operand1
            do
            {
                Console.Write("Enter length (integer value in range 2..100): ");
                temp = Console.ReadLine();
                valueChecked = int.TryParse(temp, out length) && (length >= 2 && length <= 100); ;
                if (!valueChecked)
                {
                    Console.WriteLine("{0} is not an integer number or not in range 2..100! Please try again!", temp);
                }
            }

            while (!valueChecked);
            do
            {
                Console.Write("Enter hight (integer value in range 2..100): ");
                temp = Console.ReadLine();
                valueChecked = int.TryParse(temp, out hight) && (hight >= 2 && hight <= 100);
                if (!valueChecked)
                {
                    Console.WriteLine("{0} is not an integer number or not in range 2..100! Please try again!", temp);
                }
            }
            while (!valueChecked);
            for (i = 0; i < hight; i++)
            {
                if (i == 0 || i == hight - 1)
                {
                    Console.WriteLine(star.PadRight(length, '*'));
                }
                else
                {
                    Console.WriteLine(star.PadRight(length-1, ' ')+"*");
                }
            }

            Console.WriteLine("\nAnother one!");

            for (i = 0; i < hight; i++)
            {
                for (j = 0; j < length; j++)
                { 
                    Console.Write(star);
                }
                Console.Write("\n");
            }
        }
    }
}
