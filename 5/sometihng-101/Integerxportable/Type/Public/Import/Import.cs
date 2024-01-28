using Core;

namespace Core
{
    using System;

    public partial class Integerxportable
    {
        public static void Import(Integerxportable value_INTEGERX)
        {
            DigitLinkedList = Integerxportablemagic.IntegerxportablemagicLinkedListCastDispenser<Object>(value_INTEGERX.DigitLinkedListObject);

            PositionStack = Integerxportablemagic.IntegerxportablemagicStackCastDispenser<Object>(value_INTEGERX.PositionStackObject);

            return;
        }
    }
}
