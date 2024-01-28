using Core;

namespace Core
{
    using System;

    public partial class Integerxportable
    {
        public static Object ForgeVolume(Char[] Digit_ARRAY, Boolean answer_DECREMENT_should)
        {
            Object objectResult = default;

            var stack = Integerxportablemagic.IntegerxportablemagicStackDispenser<Object>(new Object[0]);

            foreach (Char Digit_VALUE in Digit_ARRAY)
            {
                Object objectValue;

                objectValue = new Object();

                stack.Push(objectValue);

                continue;
            }

            var decrement = true;

            decrement = decrement && answer_DECREMENT_should is true;

            decrement = decrement && Object.Equals(stack.Count, 0) is false;

            Boolean shouldDecrementCheck;

            shouldDecrementCheck = decrement is true;

            if (shouldDecrementCheck is true)
            {
                stack.Pop();
            }
            else
                "false".ToString();

            var result = stack;

            objectResult = result;

            return objectResult;
        }
    }
}
