using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.Equipment.Armors
{
    public class ClothRobe
    {
        public int armorPoints;

        public int ArmorPoints
        {
            get { return armorPoints; }
            set
            {
                if (value >= 1)
                {
                    armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Invalid value. Must be a positive number.");
                }
            }
        }
    }
}
