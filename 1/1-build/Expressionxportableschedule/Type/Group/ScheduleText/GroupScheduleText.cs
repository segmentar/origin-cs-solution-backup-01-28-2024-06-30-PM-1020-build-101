using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableschedule
    {
        public static void GroupScheduleText(Expressionxportable value_EXPRESSIONXPORTABLE, String value_STRING)
        {
            var split = value_STRING.Split(Expressionxportableradical.EntityNewLineSeparator, StringSplitOptions.None);

            var aoth = split.Length;

            var zee = (aoth + 1);

            var array = new String[zee];

            split.CopyTo(array, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            array[aoth] = String.Empty;

            GroupScheduleLine(value_EXPRESSIONXPORTABLE, array);

            return;
        }
    }
}
