using ConsoleUI.Characters.Melee;
using ConsoleUI.Characters.Ranged;
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
            var war1 = new Warrior();
            var war2 = new Warrior("Bob", 22);
            var war3 = new Warrior("ThirdDude", 66, 800);

            var mag1 = new Mage();
            var mag2 = new Mage("Jaina", 99);
            var mag3 = new Mage("Bloodmage Thanos", 120, 999);



            Console.ReadLine();
        }
    }
}
