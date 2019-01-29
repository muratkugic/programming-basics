using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        // This is my third try on FizzBuzz and my best effort yet.
        // Especially compared to my first try (in the same folder).
        // This method makes makes it so user can decide all values. 

        static void Main(string[] args)
        {
            LoadFizzBuzz();


            Console.ReadLine();
        }

        private static void FizzBuzz(int startNum, int stopNum, int mod1, int mod2, string fizz, string buzz)
        {
            for (int i = startNum; i <= stopNum; i++)
            {
                if (i % mod1 == 0 && i % mod2 == 0)
                {
                    Console.WriteLine(fizz + buzz);
                }
                else if (i % mod1 == 0)
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

        private static int GetIntFromConsole(string message)
        {
            Console.Write(message);
            var output = Convert.ToInt32(Console.ReadLine());

            return output;
        }

        private static string GetStringFromConsole(string message)
        {
            Console.Write(message);
            var output = Console.ReadLine();

            return output;
        }

        private static void LoadFizzBuzz()
        {
            var startNum = GetIntFromConsole("Enter startNum: ");
            var stopNum = GetIntFromConsole("Enter stopNum: ");
            var mod1 = GetIntFromConsole("Enter mod1: ");
            var mod2 = GetIntFromConsole("Enter mod2: ");

            var firstWord = GetStringFromConsole("Enter word (e.g. 'Fizz'): ");
            var secondWord = GetStringFromConsole("Enter word (e.g. 'Buzz'): ");

            FizzBuzz(startNum, stopNum, mod1, mod2, firstWord, secondWord);
        }
    }
}