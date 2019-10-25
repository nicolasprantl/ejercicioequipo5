using System;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Tipos de personajes
    /// </summary>
    public enum CharacterType
    {
        Elf = 1,
        Wizard = 2,
        Troll = 3
    }

    public class InvalidCharacterTypeException: Exception 
    {
        public InvalidCharacterTypeException(string type)
            : base($"Invalid character type ${type}")
        {
            // intencionalmente en blanco
        }
    }

    /// <summary>
    /// Crea objetos de tipo Personaje
    /// </summary>
    public class CharacterFactory
    {
        /// <summary>
        /// Crea un personaje dado un tipo de personaje y un nombre
        /// </summary>
        public static Character GetCharacter(CharacterType type, string name)
        {
            switch (type)
            {
                case CharacterType.Elf: return new Elf(name);
                case CharacterType.Wizard: return new Wizard(name);
                case CharacterType.Troll: return new Troll(name);

                default: throw new InvalidCharacterTypeException(type.ToString());
            }
        }
    }
}