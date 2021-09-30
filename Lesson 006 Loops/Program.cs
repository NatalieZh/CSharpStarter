using System;


namespace Lesson_006_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            char selectedTask;
            ConsoleKeyInfo choice;
            bool finish;
            do
            {
                Console.Clear();
                Console.WriteLine("This lesson consists of 5 tasks. Pess a number to select a task (Esc for exit): ");
                Console.WriteLine("0 - task 0 ");
                Console.WriteLine("2 - task 2 ");
                Console.WriteLine("3 - task 3 ");
                Console.WriteLine("4 - task 4 ");
                Console.WriteLine("5 - task 5 ");
                Console.WriteLine("Press Esc to exit");

                Console.Write("Do your choice: ");

                choice = Console.ReadKey();
                if (choice.Key == ConsoleKey.Escape)
                {
                    finish = true;
                }
                else
                {
                    selectedTask = choice.KeyChar;
                    finish = false;
                    switch (selectedTask)
                    {
                        case '0':
                            Task0();
                            break;
                        case '2':
                            Task2();
                            break;
                        default:
                            //Console.WriteLine($"\n There isn't task '{selectedTask}'! Please try again!");
                            break;

                    }
                }




            }
            while (!finish);

        }

        static private int ReadNumber()
        {
            int number;
            string temp;
            bool valueChecked;

            do
            {
                Console.Write("Enter number (integer value): ");
                temp = Console.ReadLine();
                valueChecked = int.TryParse(temp, out number);
                if (!valueChecked)
                {
                    Console.WriteLine($"{temp} is not an integer number! Please try again!", temp);
                }
            }
            while (!valueChecked);
            return number;
        }

        static void Task0()
        {
            Console.Clear();
            int i, j;
            Console.WriteLine("Let's draw a rectangle!");
            int length, hight;
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
                    Console.WriteLine(star.PadRight(length - 1, ' ') + "*");
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

        static void Task2()
        {
            Console.Clear();
            int a, b, i;
            double sum = 0;
            string numbers = string.Empty;
            // let's not check that a<b
            a = ReadNumber();
            b = ReadNumber();

            //sum of all numbers step 1 without boundaries
            for (i = a+1; i < b; i++)
            {
                sum += i;
                numbers += i + ",";
            }
            Console.WriteLine($"\nSum of all numbers (without boundaries) between {a} and {b} is {sum} ({numbers.Trim(',')})");
            Console.ReadKey(true);
            //sum of all numbers step 1 with boundaries
            sum = 0;
            numbers = string.Empty;
            for (i = a; i <= b; i++)
            {
                sum += i;
                numbers += i + ",";
            }
            Console.WriteLine($"\nSum of all numbers (with boundaries) between {a} and {b} is {sum} ({numbers.Trim(',')})");
            Console.ReadKey(true);

            //all odd numbers step 1 with boundaries
            numbers = string.Empty;
            for (i = a; i <= b; i++)
            {
                if (i % 2 == 1)
                { 
                    numbers += i + ",";
                }
            }
            Console.WriteLine($"\nAll odd numbers (with boundaries) between {a} and {b} are ({numbers.Trim(',')})");
            Console.ReadKey(true);
        }
    }


}
