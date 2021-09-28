using System;
using System.Text.Encodings;

namespace Lesson_004
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp;

            #region Task0
            // it doesn't work on my Windows without setting encoding
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            System.Console.InputEncoding = System.Text.Encoding.Unicode;

            string word;
            Console.WriteLine("Task 0.");
            Console.WriteLine("Переводчик содержит 10 слов о погоде. Русский->английский.");

            do
            {
                Console.Write("\nВведите слово: ");
                word = Console.ReadLine();
                switch(word)
                {
                    case "погода":
                        Console.WriteLine("weather");
                        break;
                    case "дождь":
                        Console.WriteLine("rain");
                        break;
                    case "ветер":
                        Console.WriteLine("wind");
                        break;
                    case "ясно":
                        Console.WriteLine("bright");
                        break;
                    case "град":
                        Console.WriteLine("hail");
                        break;
                    case "молния":
                        Console.WriteLine("lightning");
                        break;
                    case "гроза":
                        Console.WriteLine("thunderstorm");
                        break;
                    case "снег":
                        Console.WriteLine("snow");
                        break;
                    case "гололед":
                        Console.WriteLine("ice");
                        break;
                    case "пасмурно":
                        Console.WriteLine("cloudy");
                        break;
                    default:
                        Console.WriteLine("Слова '{0}' нет в словаре.", word);
                        break;            
                }
                Console.Write("New word - press any key, Exit - press Esc...");
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape) ;
            #endregion

            #region Task2
            Console.WriteLine("\n ----------------------------------------------------------");
            Console.WriteLine("\n Task 2.");
            Console.WriteLine("Program can do basic math operations with 2 numbers.\n");
            double operand1, operand2;
            double? result;
            bool operandChecked;
            string sign;
            do 
            {
                // get operand1
                do 
                {
                    Console.Write("\nEnter operand1: ");
                    temp = Console.ReadLine();
                    operandChecked = double.TryParse(temp, out operand1);
                    if (!operandChecked)
                    {
                        Console.WriteLine("{0} is not a number! Please try again!", temp);
                    }
                }
                while (!operandChecked);
                //get operand2
                do
                {
                    Console.Write("Enter operand2: ");
                    temp = Console.ReadLine();
                    operandChecked = double.TryParse(temp, out operand2);
                    if (!operandChecked)
                    {
                        Console.WriteLine("{0} is not a number! Please try again!", temp);
                    }
                }
                while (!operandChecked);
                //get sighn
                do
                {
                    result = null;
                    Console.Write("Enter one of simple math operations (+,-,*,/): ");
                    sign = Console.ReadLine();
                    switch (sign)
                    {
                        case "+":
                            result = operand1 + operand2;
                            break;
                        case "-":
                            result = operand1 - operand2;
                            break;
                        case "*":
                            result = operand1 * operand2;
                            break;
                        case "/":
                            if (operand2 == 0)
                            {
                                result = double.NaN;
                                Console.WriteLine("Devide by 0 is not possible!");
                            }
                            else
                            {
                                result = operand1 / operand2;
                            }
                            break;
                        default:
                            Console.WriteLine("Unknown operation '{0}'.", sign);
                            break;
                    }

                }
                while (!result.HasValue);

                Console.WriteLine("Result: {0} {1} {2} = {3}.", operand1, sign, operand2, result.Value);
                Console.Write("New calculation - press any key, Exit - press Esc...");
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            #endregion

            #region Task3
            Console.WriteLine("\n\nTask 3.");
            Console.WriteLine("Check if number in a range.");
            double number;

            do
            {
                do
                {
                    Console.Write("\nEnter a number from 0 to 100: ");
                    temp = Console.ReadLine();
                    operandChecked = double.TryParse(temp, out number);
                    if (!operandChecked)
                    {
                        Console.WriteLine("{0} is not a number! Please try again: ", temp);
                    }
                }
                while (!operandChecked);

                if (number >= 0 && number <= 14)
                {
                    Console.WriteLine($"Nunmer {number} is in range [0,14].");
                }
                else if (number >= 15 && number <= 35)
                {
                    Console.WriteLine($"Nunmer {number} is in range [15,35].");
                }
                else if (number >= 36 && number <= 50)
                {
                    Console.WriteLine($"Nunmer {number} is in range [36,50].");
                }
                else if (number >= 51 && number <= 100)
                {
                    Console.WriteLine($"Nunmer {number} is in range [50,100].");
                }
                else
                {
                    Console.WriteLine($"Nunmer {number} is less than 0 or gteater than 100.");
                }
                Console.Write("New number - press any key, Exit - press Esc...");
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            #endregion
        }
    }
}
