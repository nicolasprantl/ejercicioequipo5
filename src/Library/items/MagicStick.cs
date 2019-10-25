namespace RoleplayGame.Items
{
    /// <summary>
    /// Vara mágica
    /// </summary>
    public class MagicStick: IAttackItem, IDefenseItem
    {
        private Magic magic = new Magic();

        private Stick stick = new Stick();

        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return magic.AttackPower + stick.AttackPower * 3;
            }
        }

        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return magic.DefensePower;
            }
        }

        public override string ToString()
        {
            return "Magic Stick";
        }
    }
}