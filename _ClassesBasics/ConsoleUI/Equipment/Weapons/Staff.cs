using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Equipment.Weapons
{
    public class Staff
    {
        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 0)
                {
                    damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage value should be a positive number");
                }
            }
        }

        public Staff()
        {

        }

        public void Empower()
        {

        }
    }
}
