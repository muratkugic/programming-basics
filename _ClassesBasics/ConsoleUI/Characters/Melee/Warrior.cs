using ConsoleUI.Equipment.Armor;
using ConsoleUI.Equipment.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Characters.Melee
{
    public class Warrior
    {
        private int abilityPoints;
        private int healthPoints;
        private int level;
        private string name;
        private Chainlink armor;
        private Sword weapon;

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

        public Chainlink Armor { get; set; }
        public Sword Weapon { get; set; }

        public Warrior()
            : this("ConstName1", 2)
        {

        }

        public Warrior(string name, int level)
            : this(name, level, 40)
        {
        }

        public Warrior(string name, int level, int healthPoints)
        {
            Name = name;
            Level = level;
            HealthPoints = healthPoints;
            AbilityPoints = 16;
            Armor = new Chainlink();
            Weapon = new Sword();
        }

        public void Execute()
        {

        }
    }
}
