using Core;

namespace Core
{
    using System;

    public partial class Integerxportableadd
    {
        public static Integerxportable Add(Integerxportable value_INTEGERX, Integerxportable Integerx_VALUE)
        {
            Integerxportable integerxResult = default;

            var list = Integerxportablemagic.IntegerxportablemagicLinkedListCastDispenser<Object>(Integerx_VALUE.DigitLinkedListObject);

            do
            {
                var reflect = (Char)(list.First.Value as Object);

                Boolean boolean;

                boolean = true;

                boolean = boolean && Object.Equals(list.Count, 1) is true;

                boolean = boolean && Object.Equals(Integerxportableascii.EntityZero, (Int32)reflect) is true;

                Boolean isEqualCheck, shouldBreakCheck;

                isEqualCheck = boolean is true;

                shouldBreakCheck = isEqualCheck is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                Integerxportabledecrement.Decrement(value_INTEGERX);

                Integerxportabledecrement.Decrement(Integerx_VALUE);

                continue;

            } while (true);

            var result = value_INTEGERX;

            integerxResult = result;

            return integerxResult;
        }
    }
}
