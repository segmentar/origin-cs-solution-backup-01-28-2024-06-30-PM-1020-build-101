using Core;

namespace Core
{
    using System;

    public partial class Integerxportable
    {
        public static Integerxportable IntegerxportableMakeDefaultSurface(Char[] Digit_ARRAY, Boolean answer_SIGN_is)
        {
            Integerxportable integerxResult = default;

            integerxResult = IntegerxportableMakeDefault(Digit_ARRAY, answer_SIGN_is, IntegerxportablePolicy.IntegerxportableDebugPolicy);

            return integerxResult;
        }
    }
}
