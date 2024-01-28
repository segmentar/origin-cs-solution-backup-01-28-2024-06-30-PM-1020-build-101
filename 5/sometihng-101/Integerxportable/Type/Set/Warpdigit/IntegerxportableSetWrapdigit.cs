using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Integerxportable
    {
        public static IList<Object> IntegerxportableWrapdigitSet(Char[] Digit_ARRAY)
        {
            ICollection<Object> collectionResult = default;

            collectionResult = new Collection<Object>();

            foreach (Char Digit_VALUE in Digit_ARRAY)
            {
                collectionResult.Add(Digit_VALUE);

                continue;
            }

            return new List<Object>(collectionResult);
        }
    }
}
