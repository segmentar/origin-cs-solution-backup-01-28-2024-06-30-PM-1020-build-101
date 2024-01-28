using Core;

namespace Core
{
    using System;

    public partial class Integerxportablehost
    {
        public static Object[] IntegerxportablehostObjectSetSurface(Integerxportable value_INTEGERXPORTABLE)
        {
            Object[] arrayResult = default;

            var list = IntegerxportablehostObjectSet(value_INTEGERXPORTABLE);

            var array = new Object[list.Count];

            list.CopyTo(arrayResult, IntegerxportablePolicy.IntegerxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
