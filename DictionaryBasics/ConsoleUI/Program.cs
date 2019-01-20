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
            // Create emplyee dictionary with employee ID as key and employee name as value.
            // Ask for user inut "ID" and display employee name to Console.

            Dictionary<int, string> employees = new Dictionary<int, string>
            {
                [1] = "Sue",
                [2] = "Bob",
                [3] = "Jim",
                [4] = "Tim"
            };

            // printing out Dict keys and values

            foreach (var key in employees.Keys)
            {
                Console.WriteLine($"Key: { key }");
            }

            Console.WriteLine();

            foreach (var value in employees.Values)
            {
                Console.WriteLine($"Value: { value }");
            }

            Console.WriteLine();

            Console.Write("Enter employee ID: ");
            var userInput = Console.ReadLine();

            bool isValidId = int.TryParse(userInput, out int id);

            if (isValidId)
            {
                if (id == 1)
                {
                    Console.WriteLine($"You enterd '{ userInput }' and the name is: { employees[1] }."); 
                }
                else if (id == 2)
                {
                    Console.WriteLine($"You enterd '{ userInput }' and the name is: { employees[2] }.");
                }
                else if (id == 3)
                {
                    Console.WriteLine($"You enterd '{ userInput }' and the name is: { employees[3] }.");
                }
                else if (id == 4)
                {
                    Console.WriteLine($"You enterd '{ userInput }' and the name is: { employees[4] }.");
                }
                else
                {
                    Console.WriteLine($"'{ id }' is not present in the dictionary.");
                    Console.WriteLine($"The dictionary lenght is: { employees.Count }");
                }
            }
            else
            {
                Console.WriteLine($"'{ userInput }' is not a valid employee ID!");
            }

            











            Console.ReadLine();
        }
    }
}
