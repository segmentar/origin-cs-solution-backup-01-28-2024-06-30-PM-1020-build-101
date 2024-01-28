using Core;

namespace Core
{
    using System;

    public partial class Bootxportablesafe
    {
        public static Char GroupCharacter(Char value_CHARACTER)
        {
            Char characterResult = default;

            Char character;

            if (Char.IsControl(value_CHARACTER))
            {
                character = (Char)Bootxportableascii.EntityWhitespace;
            }
            else
            {
                character = value_CHARACTER;  
            }

            characterResult = character;

            return characterResult;
        }
    }
}
