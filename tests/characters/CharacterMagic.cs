using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;

namespace RoleplayGame.Library.Test
{
    public class CharacterMgicTest
    {
        [Test]
        public void TestCharacterDefense()
        {
            string nombre = "elfo";
            Elf elf = new Elf(nombre);
            Magic magic = new Magic();
            Robes robes = new Robes();
            elf.AddItem(magic);
            int expected = (magic.DefensePower + robes.DefensePower);
            Assert.AreEqual(expected, elf.DefensePower);
        }
        [Test]
        public void TestCharacterPower()
        {
            string nombre = "elfo";
            Elf elf = new Elf(nombre);
            Magic magic = new Magic();
            elf.AddItem(magic);
            int expected = (magic.AttackPower);
            Assert.AreEqual(expected, elf.AttackPower);
        }
        [Test]
        public void TestCharacterSacarMagic()
        {
            string nombre = "elfo";
            Elf elf = new Elf(nombre);
            Magic magic = new Magic();
            elf.AddItem(magic);
            elf.RemoveItem(magic);
            int expected = (0);
            Assert.AreEqual(expected, elf.AttackPower);
        }
        
    }
}