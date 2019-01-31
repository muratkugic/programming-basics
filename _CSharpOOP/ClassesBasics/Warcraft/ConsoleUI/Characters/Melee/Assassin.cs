using ConsoleUI.Equipment.Armors;
using ConsoleUI.Equipment.Weapons.Sword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Characters.Melee
{
    public class Assassin
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private LightLeatherVest bodyArmor;
        private Sword weapon;

        public int AbilityPoints
        {
            get { return abilityPoints; }
            set
            {
                if (value >= 0 && value <= 15)
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
                if (value >= 1)
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

        public LightLeatherVest BodyArmor
        {
            get { return bodyArmor; }
            set { bodyArmor = value; }
        }

        public Sword Weapon
        {
            get { return weapon; }
            set { weapon = value; }
        }

        public Assassin()
        {

        }


        public void Raze()
        {

        }

        public void BleedToDeath()
        {

        }

        public void Survival()
        {

        }
    }
}
