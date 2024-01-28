using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableremoteout
    {
        public static Object GroupSByte(Byte[] Remote_ARRAY)
        {
            Object objectResult = default;

            var convert = Convert.ToSByte(Remote_ARRAY[0]);

            var result = convert;

            objectResult = result;

            return objectResult;
        }
    }
}
