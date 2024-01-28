using Core;

namespace Core
{
    using System;

    public partial class Integerxportable
    {
        public static void Export(Integerxportable value_INTEGERX)
        {
            value_INTEGERX.DigitLinkedListObject = DigitLinkedList;

            value_INTEGERX.PositionStackObject = PositionStack;

            return;
        }
    }
}
