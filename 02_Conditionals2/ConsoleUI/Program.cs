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
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age <= 16)
            {
                Console.WriteLine("Junior: 4.99$");
            }
            else if (age > 16 && age <= 64 )
            {
                Console.WriteLine("Adult: 14.99$");
            }
            else
            {
                Console.WriteLine("Senior: 9.99$");
            }







            Console.ReadLine();
        }
    }
}
