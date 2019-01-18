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
            var names = new List<string>
            {
                "Bob",
                "Tim",
                "Sue",
                "Jim"
            };

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            Console.WriteLine("Sorting list:");
            names.Sort();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            Console.WriteLine("IndexOf:");
            var index = names.IndexOf("Sue");
            
            Console.WriteLine($"Name: { names[index] } Index: { index }");

            Console.WriteLine();

            Console.WriteLine("Adding/Removing to/from list:");

            names.Add("Rex");
            names.Remove("Jim");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }











            Console.ReadLine();
        }
    }
}
