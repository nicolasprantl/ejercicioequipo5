namespace RoleplayGame.Items
{
    /// <summary>
    /// Vara
    /// </summary>
    public class Stick : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 3;
            }
        }

        public override string ToString()
        {
            return "Stick";
        }
    }
}