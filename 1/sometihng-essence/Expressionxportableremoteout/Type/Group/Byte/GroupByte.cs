using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableremoteout
    {
        public static Object GroupByte(Byte[] Remote_ARRAY)
        {
            Object objectResult = default;

            var convert = Convert.ToByte(Remote_ARRAY[0]);

            var result = convert;

            objectResult = result;

            return objectResult;
        }
    }
}
