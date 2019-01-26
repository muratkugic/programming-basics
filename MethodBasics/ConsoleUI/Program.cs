using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        // Simple program to Welcome user, ask for users name and greet user by name provided.
        // Basics and understanding of Methods, return keyword and parameters. 

        static void Main(string[] args)
        {
            WelcomeMessage();

            var firstName = GetUserInfo("Enter your first name: ");

            GreetUser(firstName);



            Console.ReadLine();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Method Basics.");
        }

        private static string GetUserInfo(string message)
        {
            Console.Write(message);
            var output = Console.ReadLine();

            return output;
        } 

        private static void GreetUser(string name)
        {
            Console.WriteLine($"Hello { name }!");
        }
    }
}
