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
            // Ask user for their first name. Continue asking until there are no more users.
            // Add names to a list of string and loop through the list greeting every
            // user "Hello <name>!".

            var firstName = new List<string>();
            var continueAsking = "";

            do
            {
                Console.Write("Enter your first name: ");
                var userInput = Console.ReadLine();

                Console.Write("Do you want to add anther name? Type 'yes' or 'no' to quit: ");
                continueAsking = Console.ReadLine();

                firstName.Add(userInput);
            } while (continueAsking.ToLower() == "yes");

            foreach (var name in firstName)
            {
                Console.WriteLine($"Hello { name }!");
            }









            Console.ReadLine();
        }
    }
}
