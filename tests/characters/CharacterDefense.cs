using NUnit.Framework;
using RoleplayGame.Items;
using RoleplayGame.Characters;

namespace RoleplayGame.Library.Test
{
    public class CharacterDefenseTest
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
    }
}