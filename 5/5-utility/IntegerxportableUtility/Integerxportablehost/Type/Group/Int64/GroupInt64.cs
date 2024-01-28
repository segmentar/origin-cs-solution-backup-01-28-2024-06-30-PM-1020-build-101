using Core;

namespace Core
{
    using System;

    public partial class Integerxportablehost
    {
        public static Int64 GroupInt64(Integerxportable value_INTEGERX)
        {
            Int64 integerResult = default;

            var list = Interop.InteropArrayListConstructDispenser(Interop.InteropLinkedListCastDispenser(value_INTEGERX.DigitLinkedListObject));

            var result = Convert.ToInt64(0);

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

                var convert = Convert.ToInt64(next);

                result = convert;

                Integerxdecrement.Decrement(value_INTEGERX);

                continue;
                
            } while (true);

            integerResult = result;

            return integerResult;
        }
    }
}
