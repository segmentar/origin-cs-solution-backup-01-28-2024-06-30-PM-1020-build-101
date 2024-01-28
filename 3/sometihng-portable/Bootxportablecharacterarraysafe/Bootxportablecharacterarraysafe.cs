using Core;

namespace Core
{
    using System;

    [Bootxportableisc]
    public partial struct Bootxportablecharacterarraysafe
    {
        public Char[] Value;

        public Char[] ValueSafe;

        [Bootxportableism]
        public static Bootxportablecharacterarraysafe ForgeDefault(Char[] array_CHARACTER)
        {
            Bootxportablecharacterarraysafe safeResult = default;

            Char[] value, valueSafe;

            value = array_CHARACTER;

            valueSafe = Bootxportablesafe.GroupCharacterArray(array_CHARACTER);

            Bootxportablecharacterarraysafe safe;

            safe = new Bootxportablecharacterarraysafe();

            safe.Value = value;

            safe.ValueSafe = valueSafe;

            safeResult = safe;

            return safeResult;
        }
    }
}
