using NUnit.Framework;
using RoleplayGame.Characters;
using RoleplayGame.Encounters;

//🥈14. Cuando un personaje recibe un ataque, su vida disminuye según poder de ataque - defensa del personaje.

namespace RoleplayGame.Library.Test
{
    public class RecibeAtaque
    {
        [Test]
        
        public void ExchangeEncounterTest(Character sender, Character receiver)
        {
            Troll troll = new Troll("Troll");
            Wizard wizard = new Wizard("Wizard");

            ExchangeEncounter exchangeEncounter = new ExchangeEncounter(troll,wizard);

            Assert.AreEqual(null, troll.Items);


        }
    }
}