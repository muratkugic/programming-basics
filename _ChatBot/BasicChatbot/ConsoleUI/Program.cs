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
            Console.WriteLine("********************************************\n");
            Console.WriteLine("Welcome to a basic chatbot. Choose an option\nby entering" +
                " a number from the 'menu'.\n\nHow to play:\nChoose a number corrsponding " +
                "the 'menu' choice\nyou wish to try and follow the instructions.\n" +
                "Press 'q' to quit.");
            Console.WriteLine("********************************************\n");

            Console.WriteLine("Choices:");
            Console.WriteLine("1. Convert celsius to farenheit");
            Console.WriteLine("2. Word multiplying");
            Console.WriteLine("3. Total sum and average");

            Console.WriteLine();

            Console.Write("Enter your choice or press 'q' to quit: ");
            string input = Console.ReadLine();

            bool isValidNumber = double.TryParse(input, out double choice);

            if (isValidNumber == false)
            {
                if (input == "q")
                {
                    Console.WriteLine("Thanks for playing! Hope to see you soon again.");
                    Console.ReadLine(); // This line is for me to check that the logic works.  
                    return;
                }
            }
            else if (choice == 1)
            {
                Console.WriteLine();
                Console.WriteLine($"You entered choice '{ choice }'");
                Console.Write("Enter degrees in celsius and I will convert it to farenheit: ");
                double tempC = Convert.ToDouble(Console.ReadLine());

                double tempF = (tempC * 9) / 5 + 32;

                Console.WriteLine($"{ tempC } degrees celsius is { tempF } degrees farenheit!");
            }
            else if (choice == 2)
            {
                Console.WriteLine();
                Console.WriteLine($"You entered choice '{ choice }'");
                Console.Write("Enter your favorite word: ");
                string favoriteWord = Console.ReadLine();

                Console.Write("Enter a number to multiply the word with and print it to the console: ");
                int multiply = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Your favorite word is { favoriteWord } and you want to repeat it { multiply } times.");

                for (int i = 1; i <= multiply; i++)
                {
                    Console.WriteLine($"{i}: { favoriteWord }");
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine();
                Console.WriteLine($"You entered choice '{ choice }'");

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

            






            Console.ReadLine();
        }
    }
}
