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
            // My first attempt on FizzBuzz without looking at tutorials

            int start = 1;
            int end = 100;

            string fizz = "Fizz";
            string buzz = "Buzz";

            for (int i = start; i <= end; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(fizz + buzz);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(fizz);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(buzz);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }





            Console.ReadLine();
        }
    }
}
