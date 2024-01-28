using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Integerxportablehost
    {
        public static IList<Object> IntegerxportablehostObjectSet(Integerxportable value_INTEGERXPORTABLE)
        {
            ICollection<Object> collectionResult = default;

            collectionResult = new Collection<Object>();

            var list = Integerxportablemagic.IntegerxportablemagicLinkedListCastDispenser<Object>(value_INTEGERXPORTABLE.DigitLinkedListObject);

            var array = Integerxportablemagic.IntegerxportablemagicArrayListDispenser(list).ToArray();

            do
            {
                var reflect = (Char)(array[0] as Object);

                Boolean boolean;

                boolean = true;

                boolean = boolean && Object.Equals(list.Count, 1) is true;

                boolean = boolean && Object.Equals(Integerxportableascii.EntityZero, (Int32)reflect) is true;

                Boolean isEqualCheck, shouldBreakCheck;

                isEqualCheck = boolean is false;

                shouldBreakCheck = isEqualCheck is false;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                Object objectValue;

                objectValue = new Object();

                collectionResult.Add(objectValue);

                Integerxportabledecrement.Decrement(value_INTEGERXPORTABLE);

                continue;

            } while (true);

            return new List<Object>(collectionResult);
        }
    }
}
