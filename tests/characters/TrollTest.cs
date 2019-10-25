using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Items;

namespace RoleplayGame.Library.Test
{
    public class TrollTest
    {
        [Test]
        public void TestTroll()
        {
            Troll troll = new Troll("Troll");
            
            Stick expectedStick = new Stick();
            Armor expectedArmor = new Armor();
            Stick stick = null;
            Armor armor = null;
            
            foreach(IItem item in troll.Items)
            {
                if(item is Stick)
                {
                    stick = (Stick)item;
                    expectedStick = (Stick)item;
                }
            }

            foreach(IItem item in troll.Items)
            {
                if(item is Armor)
                {
                    armor = (Armor)item;
                    expectedArmor = (Armor)item;
                }
            }
            Assert.AreEqual(expectedArmor, armor);
            
        }
    }
}