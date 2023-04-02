using ParcialScripting2.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum CharacterTypes { Human = 1, Beast = 2, Hybrid = 3 }
public enum EquipableCharacterType { Human = 1, Beast = 2, Hybrid = 3, Any = 4 }

public class Character
{
   

    private string name;
    private int maxHealthP, currentHealthP, baseAttackP, baseDefenseP;
    private Weapon weapon;
    private Armor armor;
    CharacterTypes characterType;
    private bool haveWeapon = false, haveArmor = false;

    public string Name { get => name;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("Null Name in Character.");
            else
                name = value.ToUpper();
        }
    }
    public int MaxHealthP { get => maxHealthP;
        set 
        {
            if (value <= 0)
                maxHealthP = Math.Clamp(value, 1, 99);
            else
                maxHealthP = value;
        }
    } 
    public int CurrentHealthP { get => currentHealthP; 
        set
        {
            if (value < 0)
                currentHealthP = Math.Clamp(value, 0, maxHealthP);
            else
                currentHealthP = value;
        }
    }
    public int BaseAttackP { get => baseAttackP; 
        set
        {
            if (value <= 0)
                baseAttackP = 2;
            else
                baseAttackP = value;
        }
    }
    public int BaseDefenseP { get => baseDefenseP; 
        set
        {
            if (value <= 0)
                baseDefenseP = 2;
            else
                baseDefenseP = value;
        }
    }
    public Weapon Weapon { get => weapon; 
        set
        {
            if (weapon == null)
                throw new Exception("Null weapon in Character.");
            else
            {
                if ((int)characterType != (int)value.EquipableCharacter)
                    return;
                else if (4 != (int)value.EquipableCharacter)
                    weapon = value;
                else if ((int)characterType == (int)value.EquipableCharacter)
                    weapon = value;
            }
        }
    }
    public Armor Armor { get => armor; 
        set
        {
            if (armor == null)
                throw new Exception("Null armor in Character.");
            else
            {
                if ((int)characterType != (int)value.EquipableCharacter )
                    return;
                else if (4 != (int)value.EquipableCharacter)
                    armor = value;
                else if ((int)characterType == (int)value.EquipableCharacter)
                    armor = value;
            }
        }
    }

    public CharacterTypes CharacterType { get => characterType; }

    public Character(string name, int maxHealthP, int baseAttackP, int baseDefenseP, Weapon weapon, Armor armor, CharacterTypes characterType)
    {
        Name = name;
        MaxHealthP = maxHealthP;
        BaseAttackP = baseAttackP;
        BaseDefenseP = baseDefenseP;
        CurrentHealthP = MaxHealthP;
        Weapon = weapon;
        Armor = armor;
        this.characterType = characterType;
        haveArmor = true;
        haveWeapon = true;
    }

    public void Attack(Character character)
    {
        if (weapon.Durability != 0)
        {
            character.Damage(baseAttackP + weapon.AttackPoints);
            Weapon.Durability--;
        }
        else
        {
            character.Damage(baseAttackP);
        }
        
    }

    public void Damage(int damage)
    {
        if (damage >= 0 && damage < 2)
        {
            CurrentHealthP -= 1;
        }
        else
        {
            if (armor.Durability != 0)
            {
                armor.Durability -= damage / 2;
            }
            else
            {
                CurrentHealthP -= damage;
            }
        }
    }

    public void ItsArmored()
    {
        if (armor.Durability == 0)
        {
            haveArmor = false;
        }
        else
        {
            haveArmor = true;
        }
    }

    public void ItsArmed()
    {
        if (armor.Durability == 0)
        {
            haveWeapon = false;
        }
        else
        {
            haveWeapon = true;
        }
    }

}



