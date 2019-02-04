using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = "";

            while (command.ToLower() != "exit")
            {
                Console.Clear();
                Console.WriteLine("Welcome to a basic calculator written in C#!");
                command = GetUserInput("Choose command: '+', '-', '/', '*' or 'exit': ");

                switch (command.ToLower())
                {
                    case "+":
                        Addition();
                        break;
                    case "-":
                        Subtraction();
                        break;
                    case "*":
                        Multiplication();
                        break;
                    case "/":
                        Division();
                        break;
                }
            }



            Console.ReadLine();
        }

        private static string GetUserInput(string message)
        {
            Console.Write(message);
            var output = Console.ReadLine();

            return output;
        }

        private static void Addition()
        {
            Console.WriteLine("You chose addition!");
            Console.WriteLine();
            var x = Convert.ToInt32(GetUserInput("Enter first number: "));
            var y = Convert.ToInt32(GetUserInput("Enter second number: "));
            Console.WriteLine($"Result: { x + y }");

            Console.ReadLine();
        }

        private static void Subtraction()
        {
            Console.WriteLine("You chose subtraction!");
            Console.WriteLine();
            var x = Convert.ToInt32(GetUserInput("Enter first number: "));
            var y = Convert.ToInt32(GetUserInput("Enter second number: "));
            Console.WriteLine($"Result: { x - y }");

            Console.ReadLine();
        }

        private static void Multiplication()
        {
            Console.WriteLine("You chose multiplication!");
            Console.WriteLine();
            var x = Convert.ToDouble(GetUserInput("Enter first number: "));
            var y = Convert.ToDouble(GetUserInput("Enter second number: "));
            Console.WriteLine($"Result: { x * y }");

            Console.ReadLine();
        }

        private static void Division()
        {
            Console.WriteLine("You chose division!");
            Console.WriteLine();
            var x = Convert.ToDouble(GetUserInput("Enter first number: "));
            var y = Convert.ToDouble(GetUserInput("Enter second number: "));
            if (y == 0)
            {
                Console.WriteLine("No division with 0!");
            }
            else
            {
                Console.WriteLine($"Result: { x / y }");
            }

            Console.ReadLine();
        }
    }
}
