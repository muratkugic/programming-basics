using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        // This is my second try on FizzBuzz and I am happy with this solution.
        // Especially compared to my first try (in the same folder 'programming-basics'.
        // This method makes it easy to change start and stop values as well as the words to be displayed,
        // as well as the modulus numbers. I made this without looking it up and am really pleased with the result. 

        static void Main(string[] args)
        {
            FizzBuzz(1, 100, 3, 5, "Fizz", "Buzz", "FizzBuzz");


            Console.ReadLine();
        }

        private static void FizzBuzz(int startNum, int stopNum, int mod, int mod2, string fizz, string buzz, string fizzBuzz)
        {
            for (int i = startNum; i <= stopNum; i++)
            {
                if (i % mod == 0 && i % mod2 == 0)
                {
                    Console.WriteLine(fizzBuzz);
                }
                else if (i % mod == 0)
                {
                    Console.WriteLine(fizz);
                }
                else if (i % mod2 == 0)
                {
                    Console.WriteLine(buzz);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
