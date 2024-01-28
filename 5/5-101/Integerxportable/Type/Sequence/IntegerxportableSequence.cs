using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class IntegerxportableSequence
    {
        public Integerxportable Result { get; set; } = default;

        public IntegerxportableSequence(Char[] Digit_ARRAY, Boolean answer_SIGN_is, Boolean answer_DEBUG_is)
        {
            Debug(Digit_ARRAY, answer_DEBUG_is);

            var deflect = new IEnumerable[1];

            deflect[0] = Integerxportable.IntegerxportableWrapdigitSetSurface(Digit_ARRAY);

            var inflect = new Object[2];

            inflect[0] = Integerxportablemagic.IntegerxportablemagicLinkedListDispenser<Object>((Object[])deflect[0]);

            inflect[1] = Integerxportable.ForgeVolume(Digit_ARRAY, true);
            
            Integerxportable integerx;

            integerx = new Integerxportable(inflect[0], inflect[1], default(Integerxportable),  answer_SIGN_is, answer_DEBUG_is);

            this.Result = integerx;

            return;
        }

        ~IntegerxportableSequence()
        {
            return;
        }
    }
}
