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
            string[] names = new string[] { "Bob", "Sue", "Tim" };

            Console.Write("To get a name, pick a number between 1 and 3: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());


            if (userChoice == 1)
            {
                Console.WriteLine($"You pressed { userChoice } and the name corresponding name is { names[0] }!");
            }
            else if (userChoice == 2)
            {
                Console.WriteLine($"You pressed { userChoice } and the name corresponding name is { names[1] }!");
            }
            else if (userChoice == 3)
            {
                Console.WriteLine($"You pressed { userChoice } and the name corresponding name is { names[2] }!");
            }

            





            Console.ReadLine();
        }
    }
}
