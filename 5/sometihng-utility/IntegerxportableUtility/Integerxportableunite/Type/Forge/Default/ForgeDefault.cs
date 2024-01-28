using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial struct Integerxportableunite
    {
        public static Integerxportableunite ForgeDefault(Integerxportable PreDecimal__VALUE, Integerxportable SubDecimal__VALUE)
        {
            Integerxportableunite integerxportableuniteResult = default;

            var deflect = new IEnumerable[2];

            deflect[0] = new ArrayList(Integerxportablemagic.IntegerxportablemagicLinkedListCastDispenser<Object>(PreDecimal__VALUE.DigitLinkedListObject)).ToArray();

            deflect[0] = Integerxportable.IntegerxportableUnwrapdigitSetSurface((Object[])deflect[0]);

            deflect[1] = new ArrayList(Integerxportablemagic.IntegerxportablemagicLinkedListCastDispenser<Object>(SubDecimal__VALUE.DigitLinkedListObject)).ToArray();

            deflect[1] = Integerxportable.IntegerxportableUnwrapdigitSetSurface((Object[])deflect[1]);

            Integerxportableunite integerxportableunite;

            integerxportableunite = new Integerxportableunite();

            integerxportableunite.IsSign = PreDecimal__VALUE.IsSign;

            integerxportableunite.PreDecimalDigitArray = (Char[])deflect[0];

            integerxportableunite.SubDecimalDigitArray = (Char[])deflect[1];

            integerxportableuniteResult = integerxportableunite;

            return integerxportableuniteResult;
        }
    }
}
