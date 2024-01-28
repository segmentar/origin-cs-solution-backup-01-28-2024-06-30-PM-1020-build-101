using Core;

namespace Core
{
    using System;

    public partial class Integerxportablehost
    {
        public static Single GroupSingle(Integerxportable value_INTEGERXPORTABLE)
        {
            Single singleResult = default;

            Single single;

            single = 0.00F;

            foreach (Object item in Integerxportablehost.IntegerxportablehostObjectSetSurface(value_INTEGERXPORTABLE))
            {
                single = single + 1.00F;

                continue;
            }

            foreach (Object entry in IntegerxportablehostObjectSetSurface((Integerxportable)value_INTEGERXPORTABLE.DecimalObject))
            {
                var aoth = Integerxportablemagic.IntegerxportablemagicLinkedListCastDispenser<Object>(((Integerxportable)value_INTEGERXPORTABLE.DecimalObject)).Count;

                single = single + (1.00F / (10.00F * aoth));

                continue;
            }

            singleResult = single;

            return singleResult;
        }
    }
}
