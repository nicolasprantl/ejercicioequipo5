using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class CharacterTwoAttackItemsTest
    {
        [Test]
        public void TestCharacterTwoAttackItems()
        {
            Troll troll = new Troll("test");
            Magic magic = new Magic();
            troll.AddItem(magic);
            Stick stick = new Stick();
            int expected = magic.AttackPower + stick.AttackPower;
            int actual = troll.AttackPower;
            Assert.AreEqual(actual, expected);
        }
    }
}