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
            //Add names to a roster until there are no more names.
            //Print out the names and the count to the console.

            var nameRoster = new List<string>();

            var moreNames = "";

            do
            {
                Console.Write("Enter name: ");
                var name = Console.ReadLine();

                nameRoster.Add(name);

                Console.Write("To add more names type 'y', to stop type 'n': ");
                moreNames = Console.ReadLine();
            } while (moreNames.ToLower() == "y");

            Console.WriteLine();

            Console.WriteLine($"Count of names on the list: { nameRoster.Count }");

            Console.WriteLine();

            foreach (var name in nameRoster)
            {
                Console.WriteLine(name);
            }








            Console.ReadLine();
        }
    }
}
