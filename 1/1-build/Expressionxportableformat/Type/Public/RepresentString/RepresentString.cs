using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableformat
    {
        public static String RepresentString(Expressionxportable value_EXPRESSIONXPORTABLE, Int32 Layer_VALUE)
        {
            String stringResult = default;

            var inflect = new Object[3];

            inflect[0] = new String((Char)Expressionxportableascii.EntityArrowRight, Layer_VALUE);

            Boolean isDefaultContagentCheck;

            isDefaultContagentCheck = (value_EXPRESSIONXPORTABLE.ObjectIdentity == default) is true;

            if (isDefaultContagentCheck)
            {
                inflect[1] = String.Empty;
            }
            else
            {
                var concat = String.Concat(' ', $"{{{value_EXPRESSIONXPORTABLE.ObjectIdentity.GetType()}}}");

                inflect[1] = concat;
            }

            var result = String.Empty;

            result = result + (String)inflect[0];

            result = result + ((Expressionxportablestringsafe)value_EXPRESSIONXPORTABLE.StringIdentity).ValueSafe;

            result = result + (String)inflect[1];

            result = result + (Char)Expressionxportableascii.EntityLineFeed;

            foreach (Expressionxportable expressionxportable in Expressionxportablemagic.ExpressionxportablemagicArrayListCastDispenser(value_EXPRESSIONXPORTABLE.LayerArrayListObject))
            {
                var zee = (Layer_VALUE + 1);

                var value = RepresentString(expressionxportable, zee);

                result = result + value;

                continue;
            }

            stringResult = result;

            return stringResult;
        }
    }
}
