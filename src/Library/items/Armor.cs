namespace RoleplayGame.Items
{
    /// <summary>
    /// Armadura. Provee defensa.
    /// </summary>
    public class Armor : IDefenseItem
    {
        /// <summary>
        /// El poder de defensa que tiene
        /// </summary>
        /// <value></value>
        public int DefensePower 
        {
            get
            {
                return 15;
            }
        }

        public override string ToString()
        {
            return "Armor";
        }
    }
}