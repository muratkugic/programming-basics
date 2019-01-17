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
            Console.WriteLine("Check if a number is odd or even\n");

            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"Number { num } is even.");
            }
            else
            {
                Console.WriteLine($"Number { num } is odd.");
            }



            Console.ReadLine();
        }
    }
}
