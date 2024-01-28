using Core;

namespace Core
{
    using System;

    public partial class Integerxportableapi
    {
        public static Integerxportable Decrement(Integerxportable integerx)
        {
            Integerxportable integerxResult = default;

            integerxResult = Integerxportabledecrement.DecrementControl(integerx);

            return integerxResult;
        }
    }
}
