using Core;

namespace Core
{
    using System;

    public partial class Integerxportableincrement
    {
        public static Integerxportable IncrementControl(Integerxportable value_INTEGERX)
        {
            Integerxportable integerxResult = default;

            if (value_INTEGERX.IsSign)
            {
                Integerxdecrement.Decrement(value_INTEGERX);
            }
            else
            {
                Increment(value_INTEGERX);
            }

            integerxResult = value_INTEGERX;

            return integerxResult;
        }
    }
}
