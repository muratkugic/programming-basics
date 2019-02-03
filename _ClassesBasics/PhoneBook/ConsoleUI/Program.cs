using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        public static List<Person> People = new List<Person>();

        static void Main(string[] args)
        {
            var command = "";

            while (command != "exit")
            {
                Console.WriteLine("Available commands: 'add', 'list' or 'exit'.");
                Console.WriteLine("Enter command: ");
                command = Console.ReadLine();

                switch (command)
                {
                    case "add":
                        AddPeople();
                        break;
                    case "list":
                        ListPeople();
                        break;
                }
            }


            Console.ReadLine();
        }

        public static void AddPeople()
        {
            var person = new Person();

            Console.WriteLine("Enter first name: ");
            person.FirstName = Console.ReadLine();

            Console.WriteLine("Enter last name: ");
            person.LastName = Console.ReadLine();

            Console.WriteLine("Enter phone number: ");
            person.PhoneNumber = Console.ReadLine();

            People.Add(person);
        }

        public static void PrintPeople(Person person)
        {
            Console.WriteLine($"First Name: { person.FirstName }");
            Console.WriteLine($"Last Name: { person.LastName }");
            Console.WriteLine($"Phone Number: { person.PhoneNumber }");
            Console.WriteLine("---------------------------------");
        }

        public static void ListPeople()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                foreach (var person in People)
                {
                    PrintPeople(person);
                }
            }
        }
    }
}
