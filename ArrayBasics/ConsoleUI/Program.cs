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
            int[] myArray = new int[] { 3, 5, 7, 9, 11};

            Console.WriteLine($"My array length is { myArray.Length }.");

            foreach (var item in myArray)
            {
                Console.WriteLine($"Array item: { item }");
            }

            Console.WriteLine();
            Console.WriteLine();

            // Copy an array to another

            string[] firstNames = new string[] { "Bob", "Sue", "Tim", "Jack", "Rob" };

            string[] copyOfFirstNames = new string[firstNames.Length];


            firstNames.CopyTo(copyOfFirstNames, 0);

            foreach (var item in copyOfFirstNames)
            {
                Console.WriteLine(item);
            }








            Console.ReadLine();
        }
    }
}
