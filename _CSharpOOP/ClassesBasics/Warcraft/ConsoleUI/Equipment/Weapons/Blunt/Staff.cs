using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Equipment.Weapons.Staff
{
    public class Staff
    {
        public int damage;

        public int Damage
        {
            get { return damage; }
            set
            {
                if (value >= 1)
                {
                    damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Invalid value. Must be a positive number.");
                }
            }
        }

        public void Empower()
        {

        }
    }
}
