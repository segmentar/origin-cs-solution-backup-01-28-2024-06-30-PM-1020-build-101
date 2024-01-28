using Core;

namespace Core
{
    using System;

    public partial class Bootxportableoperation
    {
        public static void GroupConvert(Expressionxportable value_EXPRESSIONXPORTABLE, String[] array_STRING)
        {
            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = (array_STRING.Length < 1).Equals(true);

            shouldReturnCheck = isEqualCheck is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            CategoryConvert(value_EXPRESSIONXPORTABLE, array_STRING);

            return;
        }
    }
}
