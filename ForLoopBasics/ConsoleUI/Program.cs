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
            // Ask user for a comma seperated list of first names (no spaces).
            // Split the string into a string array and loop through the array saying hello to every person

            Console.Write("Enter a comma seperated list of names (no spaces): ");
            var input = Console.ReadLine();

            var firstNames = input.Split(',');

            for (int i = 0; i < firstNames.Length; i++)
            {
                Console.WriteLine($"Hello { firstNames[i] }!");
            }







            Console.ReadLine();
        }
    }
}
