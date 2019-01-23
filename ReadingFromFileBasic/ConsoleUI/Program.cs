using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading from file and displaying the total line count.

            var file = File.ReadLines(@"C:\GitRepos\programming-basics\ReadingFromFileBasic\ConsoleUI\bin\Debug\HarryPotter.txt");

            foreach (var line in file)
            {
                Console.WriteLine(line);
            }

            var lines = file.ToList();


            Console.WriteLine();

            Console.WriteLine($"Line count (including whitespace): { lines.Count }");








            Console.ReadLine();
        }
    }
}
