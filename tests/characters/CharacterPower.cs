using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;

namespace RoleplayGame.Library.Test
{
    public class CharacterPowerTest
    {
        [Test]
        public void TestCharacterPower()
        {
            string nombre = "elfo";
            Elf elf = new Elf(nombre);
            Magic magic = new Magic();
            elf.AddItem(magic);
            int expected = (magic.AttackPower + elf.AttackPower);
            Assert.AreEqual(expected, gauntlet.AttackPower);
        }
    }
}