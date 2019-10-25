using NUnit.Framework;
using RoleplayGame.Characters;

//🥈14. Cuando un personaje recibe un ataque, su vida disminuye según poder de ataque - defensa del personaje.

namespace RoleplayGame.Library.Test
{
    public class AttackTest
    {
        [Test]
        
        public void RecibeAtaqueTest()
        {
            Troll troll = new Troll("Troll");

            //ReciveAttack es el poder de ataque que pide la letra
            
            troll.ReceiveAttack(100);
            
            
            int excpectedAttack = 65;
            Assert.AreEqual(excpectedAttack, troll.Health);
        }
    }
}