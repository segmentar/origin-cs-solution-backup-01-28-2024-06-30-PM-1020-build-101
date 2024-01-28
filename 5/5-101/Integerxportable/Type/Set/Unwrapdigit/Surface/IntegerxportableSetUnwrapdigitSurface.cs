using Core;

namespace Core
{
    using System;

    public partial class Integerxportable
    {
        public static Char[] IntegerxportableUnwrapdigitSetSurface(Object[] array_OBJECT)
        {
            Char[] arrayResult = default;

            var list = IntegerxportableUnwrapdigitSet(array_OBJECT);

            var array = new Char[list.Count];

            list.CopyTo(array, IntegerxportablePolicy.IntegerxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
