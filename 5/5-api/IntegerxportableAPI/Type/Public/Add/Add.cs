using Core;

namespace Core
{
    using System;

    public partial class Integerxportableapi
    {
        public static Integerxportable Add(Integerxportable left, Integerxportable right)
        {
            Integerxportable integerxResult = default;

            integerxResult = Integerxadd.Add(left, right);

            return integerxResult;
        }
    }
}
