using Core;

namespace Core
{
    using System;

    public partial class Integerxportable
    {
        public static Char Character()
        {
            Char characterResult = default;

            var inflect = new Object[2];

            inflect[0] = Node();

            var reflect = Integerxportablemagic.IntegerxportablemagicLinkedListNodeCastDispenser<Object>(inflect[0]);

            inflect[1] = reflect.Value;

            Char character;

            character = (Char)inflect[1];

            characterResult = character;

            return characterResult;
        }
    }
}
