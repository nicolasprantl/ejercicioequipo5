using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class WizardTest
    {
        [Test]
        public void TestWizardCreationHealth()
        {
            Wizard wizard = new Wizard("test");
            int expected = 80;
            Assert.AreEqual(expected, wizard.Health);
        }
        [Test]
        public void TestWizardCreationItem()
        {
            Wizard wizard = new Wizard("test");
            IItem magic = null;
            foreach (IItem item in wizard.Items)
            {
                if (item is Magic)
                {
                    magic = item;
                }
            }
            Assert.AreEqual(magic,wizard.Items[0]);
        }
    }
}