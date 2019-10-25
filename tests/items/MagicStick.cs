using NUnit.Framework;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class MagicStickTest
    {
        [Test]
        public void TestMagicStickAttack()
        {
            MagicStick magicstick = new MagicStick();
            Magic magic = new Magic();
            Stick stick = new Stick();
            int expected = (magic.AttackPower+stick.AttackPower*3);
            Assert.AreEqual(expected, magicstick.AttackPower);
        }
        [Test]
        public void TestMagicStickDeffense()
        {
            MagicStick magicstick = new MagicStick();
            Magic magic = new Magic();
            int expected = (magic.DefensePower);
            Assert.AreEqual(expected, magicstick.DefensePower);
        }
    }
}