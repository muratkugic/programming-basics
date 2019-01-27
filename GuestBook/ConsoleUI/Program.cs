using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ask for users family name
//add names to a list
//ask for users party count
//add users count to total count
//print out names
//print out total count

namespace ConsoleUI
{
    class Program
    {
        private static List<string> userParties = new List<string>();
        private static int totalGuests = 0;

        static void Main(string[] args)
        {
            LoadGuests();

            PrintGuests();

            PrintGuestCount();

            Console.ReadLine();
        }

        private static void LoadGuests()
        {
            var moreGuestsComing = "";

            do
            {
                userParties.Add(GetUserInfo("Enter family name: "));

                totalGuests += GetPartyCount("Enter number of people in the party: ");

                Console.Write("To add more press 'y' or to quit press 'n': ");
                moreGuestsComing = Console.ReadLine();
            } while (moreGuestsComing.ToLower() == "y");
        }

        private static void PrintGuests()
        {
            Console.WriteLine();
            Console.WriteLine("Guests:");
            foreach (var name in userParties)
            {
                Console.WriteLine(name);
            }
        }

        private static void PrintGuestCount()
        {
            Console.WriteLine();
            Console.WriteLine($"Total guest count: { totalGuests }");
        }

        private static string GetUserInfo(string message)
        {
            Console.Write(message);
            var output = Console.ReadLine();

            return output;
        }

        private static int GetPartyCount(string message)
        {
            Console.Write(message);
            var output = Convert.ToInt32(Console.ReadLine());

            return output;
        }
    }
}
