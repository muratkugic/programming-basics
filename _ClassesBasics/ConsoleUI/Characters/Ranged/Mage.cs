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
                if (value >= 0)
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

        public string Name { get; set; }
        public Cloth Armor { get; set; }
        public Staff Weapon { get; set; }

        public Mage()
            : this("ConstName1", 2)
        {

        }

        public Mage(string name, int level)
            : this(name, level, 40)
        {
            Name = name;
            Level = level;
        }

        public Mage(string name, int level, int healthPoints)
        {
            Name = name;
            Level = level;
            HealthPoints = healthPoints;
            AbilityPoints = abilityPoints;
            Armor = new Cloth();
            Weapon = new Staff();
        }

        public void IceLance()
        {

        }
    }
}
