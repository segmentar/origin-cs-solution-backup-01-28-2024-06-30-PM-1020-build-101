using Core;

namespace Core
{
    using System;

    public partial class Expressionxportableremoteout
    {
        public static Object GroupUInt16(Byte[] Remote_ARRAY)
        {
            Object objectResult = default;

            var result = BitConverter.ToUInt16(Remote_ARRAY, ExpressionxportablePolicy.ExpressionxportableIndexPolicy);

            objectResult = result;

            return objectResult;
        }
    }
}
