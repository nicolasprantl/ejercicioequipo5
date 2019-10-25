using System;

namespace RoleplayGame.Items
{
    /// <summary>
    /// Indicar que cierto item no fue encontrado en un exchange.
    /// </summary>
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException(IItem item)
            : base($"Item not found: {item.ToString()}")
        {
        }
    }
}