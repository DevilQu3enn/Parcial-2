using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialScripting2.Class
{
    public class Armor
    {
        private string name;
        private int defensePoints, durability;
        EquipableCharacterType equipableCharacter;

        public string Name { get => name; 
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Null Name in Character.");
                else
                    name = value;
            }
        }
        public int DefensePoints { get => defensePoints;
            set
            {
                if (value <= 0 || value > 99)
                    defensePoints = Math.Clamp(value, 1, 99);
                else
                    defensePoints = value;
            }
        }
        
        public int Durability { get => durability; 
            set
            {
                if (value < 0)
                    durability = Math.Clamp(value, 0, 99);
                else
                    durability = value;
            }
        }

        public EquipableCharacterType EquipableCharacter { get => equipableCharacter; }

        public Armor(string name, int defensePoints, int durability, EquipableCharacterType equipableCharacter)
        {
            Name = name;
            DefensePoints = defensePoints;

            if (durability < 1)
                Durability = 1;
            else
                Durability = durability;

            this.equipableCharacter = equipableCharacter;
        }
    }
}
