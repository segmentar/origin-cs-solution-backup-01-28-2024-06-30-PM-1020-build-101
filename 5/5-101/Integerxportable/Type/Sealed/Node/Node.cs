using Core;

namespace Core
{
    using System;

    public partial class Integerxportable
    {
        public static Object Node()
        {
            Object objectResult = default;

            var stack = Integerxportablemagic.IntegerxportablemagicStackDispenser<Object>(PositionStack);

            var list = DigitLinkedList;

            var current = list.First;

            while (true)
            {
                Boolean boolean;

                boolean = false;

                boolean = boolean || Object.Equals(stack.Count, 0) is true;

                Boolean isEqualCheck, shouldBreakCheck;

                isEqualCheck = boolean is true;

                shouldBreakCheck = isEqualCheck is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                stack.Pop();

                current = current.Next;

                continue;
            }

            var result = current;

            objectResult = result;

            return objectResult;
        }
    }
}
