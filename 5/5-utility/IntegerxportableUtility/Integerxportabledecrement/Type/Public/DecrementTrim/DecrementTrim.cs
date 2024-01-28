using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Integerxportabledecrement
    {
        public static void DecrementTrim()
        {
            try
            {
                var deflect = new IEnumerable[3];

                deflect[0] = new ArrayList(Integerxportable.DigitLinkedList).ToArray(typeof(Object));

                var reflect = (Object[])(deflect[0] as Array);

                var value = String.Empty;

                foreach (Object objectValue in reflect)
                {
                    value = String.Concat(value, (Char)objectValue);

                    continue;
                }

                var result = value.TrimStart((Char)Integerxportableascii.EntityZero);

                var difference = (value.Length - result.Length);

                deflect[1] = result.ToCharArray();

                deflect[2] = new Object[((Char[])deflect[1]).Length];

                var indexer = 0;

                foreach (Char character in (Char[])deflect[1])
                {
                    ((Object[])deflect[2])[indexer] = character;

                    indexer = indexer + 1;

                    continue;
                }

                Integerxportable.DigitLinkedList = new LinkedList<Object>((Object[])deflect[2]);

                while (true)
                {
                    Boolean isEqualCheck, shouldBreakCheck;

                    isEqualCheck = Object.Equals(difference, 0) is true;

                    shouldBreakCheck = isEqualCheck is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    Object objectValue;

                    objectValue = new Object();

                    Integerxportable.PositionStack.Push(objectValue);

                    difference = difference - 1;

                    continue;
                }

            } catch (Exception exception)
            {
                Integerxportablerender.RenderError($"{IntegerxportableCode.RenderPath.Core_Integerxportable_Fatal}", new Integerxportablefatal.DecrementTrim().Initialize(new String[0], exception));
            }

            return;
        }
    }
}
