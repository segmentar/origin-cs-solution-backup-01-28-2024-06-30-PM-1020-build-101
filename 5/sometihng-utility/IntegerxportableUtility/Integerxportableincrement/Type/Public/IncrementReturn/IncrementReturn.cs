using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Integerxportableincrement
    {
        public static void IncrementReturn(Boolean answer_DECIMAL_is, Boolean answer_HEXADECIMAL_is)
        {
            var character = Integerxportable.Character();

            var value = default(Char);

            if (answer_DECIMAL_is is true)
            {
                value = IncrementBase(character);
            }
            else
                "false".ToString();

            if (answer_HEXADECIMAL_is is true)
            {
                //value = DecrementBaseHexadecimal(character);
            }
            else
                "false".ToString();;

            var array = new ArrayList(Integerxportable.DigitLinkedList).ToArray(typeof(Char));

            var reflect = (Char[])(array as Array);

            var volume = Integerxportable.ForgeVolume(reflect, true);

            var node = Interop.InteropLinkedListNodeCastDispenser<Object>(Integerxportable.Node());

            node.Value = value;

            Integerxportable.PositionStack = (Stack)volume;

            return;
        }
    }
}
