using Core;

namespace Core
{
    using System;

    public partial class Expressionxportablesafe
    {
        public static String ForgeString(String value_STRING)
        {
            String stringResult = default;

            var data = value_STRING.ToCharArray();

            var value = ForgeCharacterArray(data);

            var result = new String(value);

            stringResult = result;

            return stringResult;
        }
    }
}
