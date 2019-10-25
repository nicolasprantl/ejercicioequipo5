namespace RoleplayGame.Items
{
    /// <summary>
    /// Tipos de elementos
    /// </summary>
    public enum ItemType
    {
        Armor = 1, 
        Gauntlet = 2, 
        Magic = 3, 
        MagicStick = 4, 
        Robes = 5, 
        Stick = 6
    }

    /// <summary>
    /// Creador de elementos. 
    /// </summary>
    public class ItemFactory
    {
        /// <summary>
        /// Permite crear elementos dado un tipo de elemento.
        /// </summary>
        /// <param name="type">El tipo de elemento</param>
        /// <returns>El elemento</returns>
        public static IItem GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.Armor: return new Armor();
                case ItemType.Gauntlet: return new Gauntlet();
                case ItemType.Magic: return new Magic();
                case ItemType.MagicStick: return new MagicStick();
                case ItemType.Robes: return new Robes();
                case ItemType.Stick: return new Stick();
                
                default: return null;
            }
        }
    }
}