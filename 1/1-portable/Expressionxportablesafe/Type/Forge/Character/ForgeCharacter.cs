using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablesafe
    {
        public static Char ForgeCharacter(Char value_CHARACTER)
        {
            Char characterResult = default;

            Char character;

            if (Char.IsControl(value_CHARACTER))
            {
                character = (Char)Expressionxportableascii.EntityWhitespace;
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
