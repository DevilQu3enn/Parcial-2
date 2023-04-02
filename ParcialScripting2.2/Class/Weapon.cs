using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialScripting2.Class
{
    public class Weapon
    {
        private string name;
        private int attackPoints, durability;
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

        public int AttackPoints { get => attackPoints; 
            set
            {
                if (value <= 0 || value > 99)
                    attackPoints = Math.Clamp(value, 1, 99);
                else
                    attackPoints = value;
            }
        }

        public int Durability
        {
            get => durability;
            set
            {
                if (value < 0)
                    durability = Math.Clamp(value, 0, 99);
                else
                    durability = value;
            }
        }

        public EquipableCharacterType EquipableCharacter { get => equipableCharacter; }

        public Weapon(string name, int attackPoints, int durability, EquipableCharacterType equipableCharacter)
        {
            Name = name;
            AttackPoints = attackPoints;

            if (durability < 1)
                Durability = 1;
            else
                Durability = durability;

            this.equipableCharacter = equipableCharacter;
        }
    }
}
