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
            SwitchNumbers(24, 12);

            Console.ReadLine();
        }

        private static void SwitchNumbers(int num1, int num2)
        {
            Console.WriteLine("Before the switch!");
            Console.WriteLine($"Num1: { num1 } Num2: { num2 }");

            var temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After the switch!");
            Console.WriteLine($"Num1: { num1 } Num2: { num2 }");
        }
    }
}
