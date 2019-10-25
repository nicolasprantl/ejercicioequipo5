using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class ElfTest
    {
        Elf elf;
        //🥉3. La creación de un Elf le asigna vida 120
        [Test]
        public void TestAsignarVida()
        {
            elf = new Elf("El elfo");

            int expectedHelth = 120;
            Assert.AreEqual(expectedHelth, elf.Health);
        }
        //🥉3. La creación de un Elf le asigna un item Robes.
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
        //🥉6. Cuando un character tiene vida 0, su propiedad isDead es verdadera;
        // de lo contrario es falsa.
        [Test]
        public void TestVidaCeroIsDeathFalse()
        {
            elf = new Elf("El elfo");
            elf.ReceiveAttack(130);

            bool expected = true;
            Assert.AreEqual(expected, elf.IsDead);
        }
        //🥈12. Al crear un personaje y asignarle dos items de 
        //defensa, el poder de defensa la suma de los poderes de ataque de ambos.
        [Test]
        public void TestPoderDefensa()
        {
            elf = new Elf("El elfo");
            Magic magic = new Magic();
            elf.AddItem(magic);

            int expectedDefensePower = 0;
            foreach (IItem item in elf.Items)
            {
                if(item is IDefenseItem)
                {
                    if(item is Robes)
                    {
                        expectedDefensePower = expectedDefensePower + ((Robes)item).DefensePower;
                    }
                    if(item is Magic)
                    {
                        expectedDefensePower = expectedDefensePower + ((Magic)item).DefensePower;
                    }
                    if(item is MagicStick)
                    {
                        expectedDefensePower = expectedDefensePower + ((MagicStick)item).DefensePower;
                    }
                    if(item is Armor)
                    {
                        expectedDefensePower = expectedDefensePower + ((Armor)item).DefensePower;
                    }
                }
            }            
            Assert.AreEqual(expectedDefensePower, elf.DefensePower);
        }
        //🥈16. Cuando un personaje recibe un ataque y 
        //su defensa es mayor al ataque, su vida no se modifica.
        [Test]
        public void TestVidaNoModificada()
        {
            Elf elfo = new Elf("El elfo");
            int expected = elfo.Health;

            elfo.ReceiveAttack(elfo.DefensePower - 1);

            
            Assert.AreEqual(expected, elfo.Health);
        }

    }
}