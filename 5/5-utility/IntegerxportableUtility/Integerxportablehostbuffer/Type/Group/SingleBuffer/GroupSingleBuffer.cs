using Core;

namespace Core
{
    using System;

    public partial class Integerxportablehostbuffer
    {
        public static Byte[] GroupSingleBuffer(Integerxportable value_INTEGERXPORTABLE)
        {
            Byte[] arrayResult = default;

            var result = Integerxportablehost.GroupSingle(value_INTEGERXPORTABLE);

            BitConverter.GetBytes(result);

            return arrayResult;
        }
    }
}
