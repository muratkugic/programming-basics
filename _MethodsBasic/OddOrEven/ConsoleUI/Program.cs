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
            var userNumber = GetUserInfo("Enter a whole number: ");

            OddOrEven(userNumber);


            Console.ReadLine();
        }

        private static void OddOrEven(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine($"{ x } is an even number.");
            }
            else
            {
                Console.WriteLine($"{ x } is an odd number.");
            }
        }

        private static int GetUserInfo(string message)
        {
            Console.Write(message);
            var output = Convert.ToInt32(Console.ReadLine());

            return output;
        }
    }
}
