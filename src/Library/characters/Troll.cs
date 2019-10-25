using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Troll
    /// </summary>
    public class Troll: Character
    {
        public Troll(string name)
            : base(name)
        {
            this.Health = 150;
            this.AddItem(new Stick());
            this.AddItem(new Armor());
        }
    }
}