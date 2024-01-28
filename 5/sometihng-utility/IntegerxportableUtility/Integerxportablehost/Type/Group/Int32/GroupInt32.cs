using Core;

namespace Core
{
    using System;

    public partial class Integerxportablehost
    {
        public static Int32 GroupInt32(Integerxportable value_INTEGERXPORTABLE)
        {
            Int32 integerResult = default;

            var list = Integerxportablemagic.IntegerxportablemagicArrayListDispenser(Integerxportablemagic.IntegerxportablemagicLinkedListCastDispenser<Object>(value_INTEGERXPORTABLE.DigitLinkedListObject));

            var result = Convert.ToInt32(0);

            do
            {
                var reflect = (Char)(list[0] as Object);

                Boolean boolean;

                boolean = true;

                boolean = boolean && Object.Equals(list.Count, 1) is true;

                boolean = boolean && Object.Equals(Integerxportableascii.EntityZero, (Int32)reflect) is true;

                Boolean isEqualCheck, shouldBreakCheck;

                isEqualCheck = boolean is false;

                shouldBreakCheck = isEqualCheck is false;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                var next = result + 1;

                var convert = Convert.ToInt32(next);

                result = convert;

                Integerxportabledecrement.Decrement(value_INTEGERXPORTABLE);

                continue;
                
            } while (true);

            integerResult = result;

            return integerResult;
        }
    }
}
