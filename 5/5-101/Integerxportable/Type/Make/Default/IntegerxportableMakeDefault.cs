using Core;

namespace Core
{
    using System;

    public partial class Integerxportable
    {
        public static Integerxportable IntegerxportableMakeDefault(Char[] Digit_ARRAY, Boolean answer_SIGN_is, Boolean answer_DEBUG_is)
        {
            Integerxportable integerxResult = default;

            var result = new IntegerxportableSequence(Digit_ARRAY, answer_SIGN_is, answer_DEBUG_is).Result;

            Integerxportablemagic.IntegerxportablemagicArrayListCastDispenser(IntegerxportablePolicy.IntegerxportableArrayListObject).Add(result);

            integerxResult = result;

            return integerxResult;
        }
    }
}
