using Core;

namespace Core
{
    using System;

    public partial class Integerxportable
    {
        public static Object[] IntegerxportableWrapdigitSetSurface(Char[] Digit_ARRAY)
        {
            Object[] arrayResult = default;

            var list = IntegerxportableWrapdigitSet(Digit_ARRAY);

            var array = new Object[list.Count];

            list.CopyTo(array, IntegerxportablePolicy.IntegerxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
