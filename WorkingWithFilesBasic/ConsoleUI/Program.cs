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
            // Write user input to file with datetime for every entry.
            // Save to custom location on PC.

            var firstNames = new List<string>();
            var continueInput = "";

            do
            {
                Console.Write("Enter first name: ");
                var userInput = Console.ReadLine();

                firstNames.Add("Date added: " + DateTime.Now.ToString());
                firstNames.Add("Name: " + userInput);

                Console.Write("Do you want to add another name? 'y' or 'n': ");
                continueInput = Console.ReadLine();
                
            } while (continueInput.ToLower() == "y");

            File.AppendAllLines(@"C:\Users\Murat\Desktop\File.txt", firstNames);

            // Goal was to learn to write to a file, add date and time of entry and of course the
            // entry itself. Going forward I must look into how to do this better and re-write
            // everything once I learn methods. I am happy that the code does what I want it to.





            Console.ReadLine();
        }
    }
}
