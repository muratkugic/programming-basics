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
            Console.Write("How old are you: ");
            string ageText = Console.ReadLine();

            bool isValidAge = int.TryParse(ageText, out int age);

            if (isValidAge)
            {
                if (age >= 21)
                {
                    Console.WriteLine("You can enter.");
                }
                else
                {
                    Console.WriteLine($"Try in { 21 - age } year/s again.");
                }
            }
            else
            {
                Console.WriteLine($"Format '{ ageText }' unknown, please use whole numbers.");
            }





            Console.ReadLine();
        }
    }
}
