using ConsoleUI.Equipment.Armors;
using ConsoleUI.Equipment.Weapons.Axe;
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
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private Chainlink bodyArmor;
        private Axe weapon;

        public int AbilityPoints
        {
            get { return abilityPoints; }
            set
            {
                if (value >= 1 && value <= 15)
                {
                    abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Invalid value: 0-15!");
                }
            }
        }

        public int HealthPoints
        {
            get { return healthPoints; }
            set
            {
                if (value <= 0)
                {
                    healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Invalid value: > 0!");
                }
            }
        }

        public int Level
        {
            get { return level; }
            set
            {
                if (value >= 1)
                {
                    level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Invalid value: > 0!");
                }
            }
        }

        public string Faction
        {
            get { return faction; }
            set
            {
                if (value == "Melee")
                {
                    faction = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Invalid value. Must be Melee or Spellcaster.");
                }
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Chainlink BodyArmor
        {
            get { return bodyArmor; }
            set { bodyArmor = value; }
        }

        public Axe Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public Warrior()
            : this("WarriorLord", 1)
        {

        }

        public Warrior(string name, int level)
            : this(name, level, 100)
        {

        }

        public Warrior(string name, int level, int healthpoints)
        {
            Name = name;
            Level = level;
            HealthPoints = healthPoints;
            Faction = "Melee";
            AbilityPoints = 15;
            Weapon = new Axe();
            BodyArmor = new Chainlink();
        }


        public void Strike()
        {

        }

        public void Execute()
        {

        }

        public void SkinHarden()
        {

        }
    }
}
