using Core;

namespace Core
{
    using System;

    public partial class Integerxportableapi
    {
        public static Integerxportable Subtract(Integerxportable left, Integerxportable right)
        {
            Integerxportable integerxResult = default;

            integerxResult = Integerxsubtract.Subtract(left, right);

            return integerxResult;
        }
    }
}
