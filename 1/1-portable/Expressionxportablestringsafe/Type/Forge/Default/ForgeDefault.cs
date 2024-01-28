using Core;

namespace Core
{
    using System;

    public partial struct Expressionxportablestringsafe
    {
        public static Expressionxportablestringsafe ForgeDefault(String value_STRING)
        {
            Expressionxportablestringsafe safeResult = default;

            String value, valueSafe;

            value = value_STRING;

            valueSafe = Expressionxportablesafe.ForgeString(value_STRING);

            Expressionxportablestringsafe safe;

            safe = new Expressionxportablestringsafe();

            safe.Value = value;

            safe.ValueSafe = valueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
