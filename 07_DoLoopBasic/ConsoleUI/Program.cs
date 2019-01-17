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
            string userInput = "";

            do
            {
                Console.Write("Enter your name (type 'exit' to quit): ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("You typed 'exit' and the program terminated.");
                    break;
                }
                else if (userInput.ToLower() == "murat")
                {
                    Console.WriteLine($"The creator of this program is { userInput }!");
                }
                else
                {
                    Console.WriteLine($"Hello { userInput }, glad you stoped by.");
                }

            } while (userInput.ToLower() != "exit");









            Console.ReadLine();
        }
    }
}
