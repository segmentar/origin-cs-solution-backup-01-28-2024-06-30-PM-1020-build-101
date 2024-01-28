using Core;

namespace Core
{
    using System;

    [Bootxportableisc]
    public partial struct Bootxportablestringsafe
    {
        public String Value;

        public String ValueSafe;

        [Bootxportableism]
        public static Bootxportablestringsafe ForgeDefault(String value_STRING)
        {
            Bootxportablestringsafe safeResult = default;

            String value, valueSafe;

            value = value_STRING;

            valueSafe = Bootxportablesafe.GroupString(value_STRING);

            Bootxportablestringsafe safe;

            safe = new Bootxportablestringsafe();

            safe.Value = value;

            safe.ValueSafe = valueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
