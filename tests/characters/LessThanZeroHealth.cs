using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class LessThanZeroHealth
    {
        [Test]
        public void LessThanZeroHealthTest()
        {
            Wizard wizard = new Wizard("test");
            wizard.ReceiveAttack(100000);
            Assert.AreEqual(0, wizard.Health);
        }
    }
}