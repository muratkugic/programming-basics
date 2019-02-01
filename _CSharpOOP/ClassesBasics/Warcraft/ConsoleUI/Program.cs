using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleUI.Characters.Spellcaster;
using ConsoleUI.Characters.Melee;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var war1 = new Warrior();
            var war2 = new Warrior("Dude2", 99);
            var war3 = new Warrior("Dude3", 88, 12);

            var kn1 = new Knight();
            var kn2 = new Knight("Dude2", 66);
            var kn3 = new Knight(111, 85, "MainDuder");
        }
    }
}
