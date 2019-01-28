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
            // Loads basic information about the chatbot
            LoadChatBotInfo();

            var userChoice = GetInfoFromConsole("Enter choice or 'q' to quit: ");

            // Checks the users choice and calls the appropriate method
            CheckUserChoice(userChoice);

            Console.ReadLine();
        }

        private static void LoadChatBotInfo()
        {
            Console.Write("********************************************\n");
            Console.WriteLine("Welcome to a basic chatbot. \n\nHow to play:\n\nChoose a number corrsponding " +
                "the 'menu' choice\nyou wish to try and follow the instructions.\n" +
                "Press 'q' to quit.");
            Console.WriteLine("********************************************\n");

            Console.WriteLine("Choices:");
            Console.WriteLine("1. Convert celsius to farenheit");
            Console.WriteLine("2. Word multiplying");
            Console.WriteLine("3. Total sum and average");

            Console.WriteLine();
        }

        private static string GetInfoFromConsole(string message)
        {
            Console.Write(message);
            var output = Console.ReadLine();

            return output;
        }

        private static void CheckUserChoice(string input)
        {
            bool isValidNumber = double.TryParse(input, out double choice);

            if (isValidNumber == false)
            {
                if (input == "q")
                {
                    Console.WriteLine("Thanks for playing! Hope to see you soon again.");
                    return;
                }
            }
            else if (choice == 1)
            {
                CelsiusToFarenheit();
            }
            else if (choice == 2)
            {
                WordMultiplier();
            }
            else if (choice == 3)
            {
                SumAndAverage();
            }
            else
            {
                Console.WriteLine("I do not recognize your choice, please restart the program and try again.");
            }


        }

        private static void CelsiusToFarenheit()
        {
            Console.WriteLine();
            double tempC = Convert.ToDouble(GetInfoFromConsole("Enter degrees in celsius and I will convert it to farenheit: "));

            double tempF = (tempC * 9) / 5 + 32;

            Console.WriteLine($"{ tempC } degrees celsius is { tempF } degrees farenheit!");
        }

        private static void WordMultiplier()
        {
            Console.WriteLine();
            string favoriteWord = GetInfoFromConsole("Enter your favorite word: ");

            int multiplier = Convert.ToInt32(GetInfoFromConsole("Enter a number to multiply the word with and print it to the console: "));

            Console.WriteLine($"Your favorite word is '{ favoriteWord }' and you want to repeat it { multiplier } times.");

            for (int i = 1; i <= multiplier; i++)
            {
                Console.WriteLine($"{i}: { favoriteWord }");
            }
        }

        private static void SumAndAverage()
        {
            Console.WriteLine();
            var numbers = new List<int>();

            var addMoreNumbers = "";

            do
            {
                Console.Write("Enter a number: ");
                var userInput = Convert.ToInt32(Console.ReadLine());

                numbers.Add(userInput);

                Console.Write("To add more numbers press 'y', to stop press 'n': ");
                addMoreNumbers = Console.ReadLine();

            } while (addMoreNumbers.ToLower() == "y");

            Console.WriteLine();
            Console.WriteLine($"The total sum of your numbers is: { numbers.Sum() }");

            Console.WriteLine($"The average of your numbers is: { numbers.Average() }");
        }
    }
}
