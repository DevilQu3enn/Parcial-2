global using NUnit.Framework;

namespace ParcialScripting2
{
    public class Tests
    {
        GameByTurns game;

        [SetUp]
        public void Setup()
        {
            game = new GameByTurns();
           
        }

        [TestCase]
        public void TestA()
        {
            float maxHealthP, currentHealthP, baseAttackP, baseDefenseP, attackPoints, attackDurability, defensePoints, defenseDurability;
            
            maxHealthP = game.player1.MaxHealthP;
            currentHealthP= game.player1.CurrentHealthP;
            baseAttackP= game.player1.BaseAttackP;
            baseDefenseP= game.player1.BaseDefenseP;
            attackPoints = game.player1.Weapon.AttackPoints;
            attackDurability = game.player1.Weapon.Durability;
            defensePoints = game.player1.Armor.DefensePoints;
            defenseDurability = game.player1.Armor.Durability;

            Assert.LessOrEqual(0, maxHealthP);
            Assert.LessOrEqual(0, currentHealthP);
            Assert.LessOrEqual(0, baseAttackP);
            Assert.LessOrEqual(0, baseDefenseP);

        }

        [TestCase]
        public void TestB()
        {
            
        }
    }
}