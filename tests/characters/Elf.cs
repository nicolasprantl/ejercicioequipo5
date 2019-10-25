using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class ElfTest
    {
        Elf elf;
        [Test]
        public void TestAsignarVida()
        {
            elf = new Elf("El elfo");

            int expectedHelth = 120;
            Assert.AreEqual(expectedHelth, elf.Health);
        }

        [Test]
        public void TestAsignarRobes()
        {
            elf = new Elf("El elfo");

            Robes expectedRobes = new Robes();
            Robes robes = null;
            foreach (IItem item in elf.Items)
            {
                if(item is Robes)
                {
                    robes = (Robes)item;
                    expectedRobes = (Robes)item;
                }
            }
            Assert.AreEqual(expectedRobes, robes);
        }
    }
}