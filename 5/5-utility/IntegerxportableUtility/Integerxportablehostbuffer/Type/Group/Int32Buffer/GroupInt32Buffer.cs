using Core;

namespace Core
{
    using System;

    public partial class Integerxportablehostbuffer
    {
        public static Byte[] GroupInt32Buffer(Integerxportable value_INTEGERXPORTABLE)
        {
            Byte[] arrayResult = default;

            var result = Integerxportablehost.GroupInt32(value_INTEGERXPORTABLE);

            BitConverter.GetBytes(result);

            return arrayResult;
        }
    }
}
