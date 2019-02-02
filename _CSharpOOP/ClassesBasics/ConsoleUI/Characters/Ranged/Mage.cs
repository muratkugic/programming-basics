using ConsoleUI.Equipment.Armor;
using ConsoleUI.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Characters.Ranged
{
    public class Mage
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;
        private string name;
        private Cloth armor;
        private Staff weapon;

        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if (value >= 1)
                {
                    abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Not valid, value should be >=1");
                }
            }
        }

        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                if (value >= 1)
                {
                    healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Not valid, value should be >=1");
                }
            }
        }

        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value >= 1)
                {
                    level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Not valid, value should be >=1");
                }
            }
        }

        public Cloth Armor { get; set; }
        public Staff Weapon { get; set; }

        public void IceLance()
        {

        }
    }
}
