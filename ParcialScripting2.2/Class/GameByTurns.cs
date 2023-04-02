using ParcialScripting2.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Turns { Player1, Player2 }

public class GameByTurns
{
    private Turns turn;
    public Character player1;
    public Character player2;

    public GameByTurns()
    {
        Weapon weapon1 = new Weapon("Samehada", 10, 20, EquipableCharacterType.Hybrid);
        Armor armor1 = new Armor("Armadura Barbara", 20, 30, EquipableCharacterType.Hybrid);
        player1 = new Character("Kisame", 50, 4, 5, weapon1, armor1, CharacterTypes.Hybrid);

        Weapon weapon2 = new Weapon("Chipote Chillon", 15, 20, EquipableCharacterType.Human);
        Armor armor2 = new Armor("Doji de Goku", 30, 25, EquipableCharacterType.Human);
        player2 = new Character("Chabelo", 30, 10, 5, weapon2, armor2, CharacterTypes.Human);


    }

    public void Game()
    {
        switch(turn)
        {
            case Turns.Player1:
                break; 
            case Turns.Player2:
                break;
        }
    }
}

