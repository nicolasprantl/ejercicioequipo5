using System.Collections.Generic;

namespace RoleplayGame.Items
{

    // @see https://www.amazon.co.uk/Supmaker-Infinity-Gauntlet-Avengers-Halloween/dp/B07Q249RF7

    /// <summary>
    /// Guante de Poder. Provee ataque que se incrementa con las gemas.
    /// </summary>
    public class Gauntlet : IAttackItem
    {
        /// <summary>
        /// Las gemas que posee el guante. Le agregan poder de ataque.
        /// </summary>
        /// <typeparam name="Gem"></typeparam>
        /// <returns></returns>
        private List<Gem> gems = new List<Gem>();

        public List<Gem> Gems { get; }

        public void AddGem(Gem gem)
        {
            this.gems.Add(gem);
        }

        public void RemoveGem(Gem gem)
        {
            this.gems.Remove(gem);
        }

        /// <summary>
        /// El poder de ataque que tiene
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 1 + (30 * this.gems.Count);
            }
        }

        public override string ToString()
        {
            return $"Gountlet with {this.gems.Count} gems";
        }
    }
}