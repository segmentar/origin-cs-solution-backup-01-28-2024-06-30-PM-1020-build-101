using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Integerxportable
    {
        public static IList<Char> IntegerxportableUnwrapdigitSet(Object[] array_OBJECT)
        {
            ICollection<Char> collectionResult = default;

            collectionResult = new Collection<Char>();

            foreach (Object value_OBJECT in array_OBJECT)
            {
                var reflect = (Char)(value_OBJECT as Object);

                collectionResult.Add(reflect);

                continue;
            }

            return new List<Char>(collectionResult);
        }
    }
}
