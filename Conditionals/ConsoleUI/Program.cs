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
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            if (firstName.ToLower() == "murat" && lastName.ToLower() == "kugic")
            {
                Console.WriteLine($"Greetings { firstName }!");
            }
            else if (firstName.ToLower() == "stefan" && lastName.ToLower() == "isgren" || lastName.ToLower() == "isen")
            {
                Console.WriteLine($"Howdy Mr. { lastName }!");
            }
            else
            {
                Console.WriteLine($"Hello stranger: [{ firstName } { lastName }]");
            }







            Console.ReadLine();
        }
    }
}
