using Core;

namespace Core
{
    using System;

    [Bootxportableisc]
    public partial struct Bootxportablecharactersafe
    {
        public Char Value;

        public Char ValueSafe;

        [Bootxportableism]
        public static Bootxportablecharactersafe ForgeDefault(Char value_CHARACTER)
        {
            Bootxportablecharactersafe safeResult = default;

            Char value, valueSafe;

            value = value_CHARACTER;

            valueSafe = Bootxportablesafe.GroupCharacter(value_CHARACTER);

            Bootxportablecharactersafe safe;

            safe = new Bootxportablecharactersafe();

            safe.Value = value;

            safe.ValueSafe = valueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
