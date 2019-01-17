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

            while (userInput.ToLower() != "q")
            {
                Console.Write("Ener your name (press 'q' to quit): ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "q")
                {
                    Console.WriteLine("You pressed 'q' and the program terminated!");
                    break;
                }
                else if (userInput.ToLower() == "murat")
                {
                    Console.WriteLine($"{ userInput } created this program!");
                }
                else
                {
                    Console.WriteLine($"Greetings { userInput }! Hope you enjoyed your stay!");
                }
            }










            Console.ReadLine();
        }
    }
}
